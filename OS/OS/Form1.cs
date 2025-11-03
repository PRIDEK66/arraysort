using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hide input grids initially
            dgvCPU.Visible = false;
            dgvDisk.Visible = false;

            // Setup CPU DataGridView columns
            dgvCPU.Columns.Clear();
            dgvCPU.ColumnCount = 5;
            dgvCPU.Columns[0].Name = "PID";
            dgvCPU.Columns[0].HeaderText = "Process ID";
            dgvCPU.Columns[1].Name = "Arrival";
            dgvCPU.Columns[1].HeaderText = "Arrival Time";
            dgvCPU.Columns[2].Name = "Burst";
            dgvCPU.Columns[2].HeaderText = "Burst Time";
            dgvCPU.Columns[3].Name = "Priority";
            dgvCPU.Columns[3].HeaderText = "Priority";
            dgvCPU.Columns[3].Visible = false;
            dgvCPU.Columns[4].Name = "Time Quantum";
            dgvCPU.Columns[4].HeaderText = "Time Quantum";
            dgvCPU.Columns[4].Visible = false;

            // Setup Disk DataGridView columns
            dgvDisk.Columns.Clear();
            dgvDisk.ColumnCount = 1;
            dgvDisk.Columns[0].Name = "Track";
            dgvDisk.Columns[0].HeaderText = "Track Number";
            dgvDisk.Columns[0].Width = 150;

            // Populate CPU scheduling options
            cmbCPUScheduling.Items.AddRange(new string[] {
                "First-Come, First-Served (FCFS)",
                "Shortest Job First (Non-preemptive)",
                "Shortest Job First (Preemptive - SRTF)",
                "Priority Scheduling (Non-preemptive)",
                "Priority Scheduling (Preemptive)",
                "Round Robin"
            });
            cmbCPUScheduling.SelectedIndex = 0;

            // Disk algorithms
            cmbDiskAlgo.Items.AddRange(new string[] {
                "First-Come, First-Served (FCFS)",
                "Shortest Seek Time First (SSTF)",
                "SCAN (Elevator)"
            });
            cmbDiskAlgo.SelectedIndex = 0;

            // Default numeric values
            nudNumProcesses.Value = 4;
            nudDiskRequests.Value = 5;
            nudQuantum.Value = 2;

            // Hide quantum controls initially
            lblQuantum.Visible = false;
            nudQuantum.Visible = false;

            // Prepare results grid
            dgvCPUResults.ColumnCount = 8;
            dgvCPUResults.Columns[0].Name = "PID";
            dgvCPUResults.Columns[1].Name = "Arrival";
            dgvCPUResults.Columns[2].Name = "Burst";
            dgvCPUResults.Columns[3].Name = "Start";
            dgvCPUResults.Columns[4].Name = "Completion";
            dgvCPUResults.Columns[5].Name = "Turnaround";
            dgvCPUResults.Columns[6].Name = "Waiting";
            dgvCPUResults.Columns[7].Name = "Response";

            dgvCPUResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region --- CPU Scheduling ---

        private void btnCreateProcesses_Click(object sender, EventArgs e)
        {
            dgvCPU.Visible = true;
            int n = (int)nudNumProcesses.Value;
            dgvCPU.Rows.Clear();

            // Disable adding new rows
            dgvCPU.AllowUserToAddRows = false;

            for (int i = 1; i <= n; i++)
            {
                dgvCPU.Rows.Add("P" + i, 0, 1, 0, 0);
            }
        }

        private void cmbCPUScheduling_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cmbCPUScheduling.SelectedItem?.ToString() ?? "";

            lblQuantum.Visible = false;
            nudQuantum.Visible = false;

            if (dgvCPU.Columns.Count >= 5)
            {
                dgvCPU.Columns["Priority"].Visible = false;
                dgvCPU.Columns["Time Quantum"].Visible = false;
            }

            if (selected.Contains("Round Robin"))
            {
                lblQuantum.Visible = true;
                nudQuantum.Visible = true;
                if (dgvCPU.Columns.Count >= 5)
                    dgvCPU.Columns["Time Quantum"].Visible = true;
            }
            else if (selected.Contains("Priority"))
            {
                if (dgvCPU.Columns.Count >= 5)
                    dgvCPU.Columns["Priority"].Visible = true;
            }
        }

        private void btnRunCPU_Click(object sender, EventArgs e)
        {
            try
            {
                var algorithm = cmbCPUScheduling.SelectedItem?.ToString() ?? "";
                var processes = ReadCPUProcesses();

                if (processes.Count == 0)
                {
                    MessageBox.Show("No processes defined.");
                    return;
                }

                List<GanttEntry> gantt = null;

                if (algorithm.Contains("FCFS"))
                    gantt = RunFCFS(processes);
                else if (algorithm.Contains("Shortest Job") && algorithm.Contains("Non-preemptive"))
                    gantt = RunSJFNonPreemptive(processes);
                else if (algorithm.Contains("SRTF") || (algorithm.Contains("Shortest Job") && algorithm.Contains("Preemptive")))
                    gantt = RunSJFPreemptive(processes);
                else if (algorithm.Contains("Priority") && algorithm.Contains("Non-preemptive"))
                    gantt = RunPriorityNonPreemptive(processes);
                else if (algorithm.Contains("Priority") && algorithm.Contains("Preemptive"))
                    gantt = RunPriorityPreemptive(processes);
                else if (algorithm.Contains("Round Robin"))
                {
                    int quantum = (int)nudQuantum.Value;
                    if (quantum <= 0)
                    {
                        MessageBox.Show("Time quantum must be > 0.");
                        return;
                    }
                    gantt = RunRoundRobin(processes, quantum);
                }
                else
                {
                    MessageBox.Show("Unknown algorithm.");
                    return;
                }

                ComputeAndDisplayCPUResults(processes, gantt);
                pnlGantt.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private List<CPUProcess> ReadCPUProcesses()
        {
            var list = new List<CPUProcess>();
            foreach (DataGridViewRow row in dgvCPU.Rows)
            {
                if (row.IsNewRow) continue;
                string pid = Convert.ToString(row.Cells[0].Value) ?? "";
                int arrival = ToInt(row.Cells[1].Value);
                int burst = ToInt(row.Cells[2].Value);
                int priority = ToInt(row.Cells[3].Value);

                list.Add(new CPUProcess
                {
                    PID = string.IsNullOrWhiteSpace(pid) ? Guid.NewGuid().ToString().Substring(0, 4) : pid,
                    Arrival = Math.Max(0, arrival),
                    Burst = Math.Max(0, burst),
                    Priority = priority,
                    Remaining = Math.Max(0, burst)
                });
            }
            return list.OrderBy(p => p.Arrival).ThenBy(p => p.PID).ToList();
        }

        private int ToInt(object o)
        {
            if (o == null) return 0;
            int v;
            int.TryParse(o.ToString(), out v);
            return v;
        }

        private List<GanttEntry> RunFCFS(List<CPUProcess> procs)
        {
            int time = 0;
            var gantt = new List<GanttEntry>();
            var copy = procs.Select(p => p.Clone()).OrderBy(p => p.Arrival).ThenBy(p => p.PID).ToList();

            foreach (var p in copy)
            {
                // If CPU is idle, jump to process arrival time
                if (time < p.Arrival)
                    time = p.Arrival;

                p.Start = time;
                p.Completion = time + p.Burst;
                gantt.Add(new GanttEntry { PID = p.PID, Start = time, End = time + p.Burst });
                time += p.Burst;
            }

            return gantt;
        }

        private List<GanttEntry> RunSJFNonPreemptive(List<CPUProcess> procs)
        {
            int time = 0;
            var gantt = new List<GanttEntry>();
            var remain = procs.Select(p => p.Clone()).ToList();
            int completed = 0;
            int n = remain.Count;

            while (completed < n)
            {
                // Get all processes that have arrived and not yet completed
                var available = remain.Where(p => p.Arrival <= time && p.Completion == 0)
                                      .OrderBy(p => p.Burst)
                                      .ThenBy(p => p.Arrival)
                                      .ThenBy(p => p.PID)
                                      .ToList();

                if (available.Count == 0)
                {
                    // CPU is idle, jump to next process arrival
                    time++;
                    continue;
                }

                var p = available.First();
                p.Start = time;
                p.Completion = time + p.Burst;
                gantt.Add(new GanttEntry { PID = p.PID, Start = p.Start, End = p.Completion });
                time = p.Completion;
                completed++;
            }

            return gantt;
        }

        private List<GanttEntry> RunSJFPreemptive(List<CPUProcess> procs)
        {
            var list = procs.Select(p => p.Clone()).OrderBy(p => p.Arrival).ToList();
            var segments = new List<GanttEntry>();
            int time = 0;
            int finished = 0;
            int n = list.Count;

            // Track first start time for each process
            var firstStart = new Dictionary<string, int>();

            while (finished < n)
            {
                // Get all processes that have arrived and still have remaining time
                var available = list.Where(p => p.Arrival <= time && p.Remaining > 0)
                                    .OrderBy(p => p.Remaining)
                                    .ThenBy(p => p.Arrival)
                                    .ThenBy(p => p.PID)
                                    .ToList();

                if (available.Count == 0)
                {
                    time++;
                    continue;
                }

                var cur = available.First();

                // Record first start time (for response time calculation)
                if (!firstStart.ContainsKey(cur.PID))
                    firstStart[cur.PID] = time;

                int start = time;
                cur.Remaining -= 1;
                time++;
                int end = time;

                segments.Add(new GanttEntry { PID = cur.PID, Start = start, End = end });

                if (cur.Remaining == 0)
                {
                    cur.Completion = time;
                    finished++;
                }
            }

            return MergeGanttSegments(segments);
        }

        private List<GanttEntry> RunPriorityNonPreemptive(List<CPUProcess> procs)
        {
            int time = 0;
            var gantt = new List<GanttEntry>();
            var remain = procs.Select(p => p.Clone()).ToList();
            int completed = 0;
            int n = remain.Count;

            while (completed < n)
            {
                // Get all processes that have arrived and not yet completed
                // Lower priority number = higher priority
                var available = remain.Where(p => p.Arrival <= time && p.Completion == 0)
                                      .OrderBy(p => p.Priority)
                                      .ThenBy(p => p.Arrival)
                                      .ThenBy(p => p.PID)
                                      .ToList();

                if (available.Count == 0)
                {
                    time++;
                    continue;
                }

                var p = available.First();
                p.Start = time;
                p.Completion = time + p.Burst;
                gantt.Add(new GanttEntry { PID = p.PID, Start = p.Start, End = p.Completion });
                time = p.Completion;
                completed++;
            }

            return gantt;
        }

        private List<GanttEntry> RunPriorityPreemptive(List<CPUProcess> procs)
        {
            var list = procs.Select(p => p.Clone()).OrderBy(p => p.Arrival).ToList();
            var segments = new List<GanttEntry>();
            int time = 0;
            int finished = 0;
            int n = list.Count;

            while (finished < n)
            {
                // Get all processes that have arrived and still have remaining time
                // Lower priority number = higher priority
                var available = list.Where(p => p.Arrival <= time && p.Remaining > 0)
                                    .OrderBy(p => p.Priority)
                                    .ThenBy(p => p.Arrival)
                                    .ThenBy(p => p.PID)
                                    .ToList();

                if (available.Count == 0)
                {
                    time++;
                    continue;
                }

                var cur = available.First();
                int start = time;
                cur.Remaining -= 1;
                time++;
                int end = time;

                segments.Add(new GanttEntry { PID = cur.PID, Start = start, End = end });

                if (cur.Remaining == 0)
                {
                    cur.Completion = time;
                    finished++;
                }
            }

            return MergeGanttSegments(segments);
        }

        private List<GanttEntry> RunRoundRobin(List<CPUProcess> procs, int quantum)
        {
            var list = procs.Select(p => p.Clone()).OrderBy(p => p.Arrival).ToList();
            var segments = new List<GanttEntry>();
            var q = new Queue<CPUProcess>();
            int idx = 0;
            int time = 0;
            var added = new HashSet<string>(); // Track which processes have been added to queue

            while (idx < list.Count || q.Count > 0)
            {
                // Add all newly arrived processes to the queue
                while (idx < list.Count && list[idx].Arrival <= time)
                {
                    if (!added.Contains(list[idx].PID))
                    {
                        q.Enqueue(list[idx]);
                        added.Add(list[idx].PID);
                        idx++;
                    }
                }

                if (q.Count == 0)
                {
                    // CPU is idle, jump to next process arrival
                    if (idx < list.Count)
                    {
                        time = list[idx].Arrival;
                        continue;
                    }
                    break;
                }

                var cur = q.Dequeue();

                // Record first start time
                if (cur.Start == -1)
                    cur.Start = time;

                // Execute for quantum or remaining time, whichever is smaller
                int run = Math.Min(quantum, cur.Remaining);
                segments.Add(new GanttEntry { PID = cur.PID, Start = time, End = time + run });
                time += run;
                cur.Remaining -= run;

                // Add any processes that arrived during execution
                while (idx < list.Count && list[idx].Arrival <= time)
                {
                    if (!added.Contains(list[idx].PID))
                    {
                        q.Enqueue(list[idx]);
                        added.Add(list[idx].PID);
                        idx++;
                    }
                }

                // Re-add current process if it still has remaining time
                if (cur.Remaining > 0)
                    q.Enqueue(cur);
                else
                    cur.Completion = time;
            }

            return MergeGanttSegments(segments);
        }

        private List<GanttEntry> MergeGanttSegments(List<GanttEntry> segments)
        {
            if (segments == null || segments.Count == 0) return new List<GanttEntry>();
            var ordered = segments.OrderBy(s => s.Start).ToList();
            var merged = new List<GanttEntry>();
            var cur = ordered[0];

            for (int i = 1; i < ordered.Count; i++)
            {
                var s = ordered[i];
                if (s.PID == cur.PID && s.Start <= cur.End)
                {
                    cur.End = Math.Max(cur.End, s.End);
                }
                else
                {
                    merged.Add(cur);
                    cur = s;
                }
            }
            merged.Add(cur);
            return merged;
        }

        private void ComputeAndDisplayCPUResults(List<CPUProcess> procs, List<GanttEntry> gantt)
        {
            // Dictionary to store first start and last completion times for each process
            var pidStart = new Dictionary<string, int>();
            var pidCompletion = new Dictionary<string, int>();

            if (gantt != null)
            {
                foreach (var seg in gantt)
                {
                    // Get the first time a process starts
                    if (!pidStart.ContainsKey(seg.PID))
                        pidStart[seg.PID] = seg.Start;

                    // Get the latest end time as completion
                    if (!pidCompletion.ContainsKey(seg.PID) || seg.End > pidCompletion[seg.PID])
                        pidCompletion[seg.PID] = seg.End;
                }
            }

            // Compute all time metrics for each process
            foreach (var p in procs)
            {
                p.Start = pidStart.ContainsKey(p.PID) ? pidStart[p.PID] : -1;
                p.Completion = pidCompletion.ContainsKey(p.PID) ? pidCompletion[p.PID] : 0;
                p.Turnaround = p.Completion > 0 ? p.Completion - p.Arrival : 0;
                p.Waiting = p.Turnaround - p.Burst;

                // ? FIXED: Response Time = Finish Time - Start Time
                if (p.Completion > 0 && p.Start >= 0)
                    p.Response = p.Completion - p.Start;
                else
                    p.Response = 0;
            }

            // Display average results
            txtATAT.Text = procs.Count > 0 ? procs.Average(x => x.Turnaround).ToString("F2") : "0";
            txtAWT.Text = procs.Count > 0 ? procs.Average(x => x.Waiting).ToString("F2") : "0";
            txtART.Text = procs.Count > 0 ? procs.Average(x => x.Response).ToString("F2") : "0";

            // Display individual process results
            dgvCPUResults.Rows.Clear();
            foreach (var p in procs)
            {
                dgvCPUResults.Rows.Add(
                    p.PID,
                    p.Arrival,
                    p.Burst,
                    p.Start,
                    p.Completion,
                    p.Turnaround,
                    p.Waiting,
                    p.Response
                );
            }

            lastGantt = gantt ?? new List<GanttEntry>();
        }


        private List<GanttEntry> lastGantt = new List<GanttEntry>();

        private void pnlGantt_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            if (lastGantt == null || lastGantt.Count == 0) return;

            int min = lastGantt.Min(x => x.Start);
            int max = lastGantt.Max(x => x.End);
            int total = Math.Max(1, max - min);

            int width = pnlGantt.Width - 40;
            int height = pnlGantt.Height - 40;
            int y = 10;
            var font = new Font("Arial", 9);

            g.DrawLine(Pens.Black, 20, y + height / 2, 20 + width, y + height / 2);

            var pidBrush = new Dictionary<string, Brush>();
            foreach (var seg in lastGantt)
            {
                if (!pidBrush.ContainsKey(seg.PID))
                {
                    int h = Math.Abs(seg.PID.GetHashCode()) % 360;
                    Color c = HsvToColor(h, 0.5f, 0.95f);
                    pidBrush[seg.PID] = new SolidBrush(c);
                }
            }

            foreach (var seg in lastGantt)
            {
                float x1 = 20 + (seg.Start - min) * (float)width / total;
                float x2 = 20 + (seg.End - min) * (float)width / total;
                float w = Math.Max(4, x2 - x1);
                var brush = pidBrush[seg.PID];
                g.FillRectangle(brush, x1, y, w, height / 2);
                g.DrawRectangle(Pens.Black, x1, y, w, height / 2);
                g.DrawString(seg.PID, font, Brushes.Black, x1 + 3, y + 3);
                g.DrawString(seg.Start.ToString(), font, Brushes.Black, x1 - 3, y + height / 2 + 2);
                g.DrawString(seg.End.ToString(), font, Brushes.Black, x2 - 3, y + height / 2 + 2);
            }

            foreach (var b in pidBrush.Values) (b as IDisposable)?.Dispose();
        }

        private Color HsvToColor(int h, float s, float v)
        {
            float hf = h / 60f;
            int i = (int)Math.Floor(hf) % 6;
            float f = hf - (float)Math.Floor(hf);
            float p = v * (1 - s);
            float q = v * (1 - f * s);
            float t = v * (1 - (1 - f) * s);
            float r = 0, gg = 0, b = 0;
            switch (i)
            {
                case 0: r = v; gg = t; b = p; break;
                case 1: r = q; gg = v; b = p; break;
                case 2: r = p; gg = v; b = t; break;
                case 3: r = p; gg = q; b = v; break;
                case 4: r = t; gg = p; b = v; break;
                case 5: r = v; gg = p; b = q; break;
            }
            return Color.FromArgb(200, (int)(r * 255), (int)(gg * 255), (int)(b * 255));
        }

        #endregion

        #region --- Disk Scheduling ---

        private void btnCreateDisk_Click(object sender, EventArgs e)
        {
            dgvDisk.Visible = true;
            int n = (int)nudDiskRequests.Value;
            dgvDisk.Rows.Clear();
            for (int i = 1; i <= n; i++)
                dgvDisk.Rows.Add(0);
        }

        private void btnRunDisk_Click(object sender, EventArgs e)
        {
            try
            {
                var algo = cmbDiskAlgo.SelectedItem?.ToString() ?? "";
                var reqs = ReadDiskRequests();
                int head = (int)nudInitialHead.Value;

                if (reqs.Count == 0)
                {
                    MessageBox.Show("No disk requests.");
                    return;
                }

                List<int> order = null;
                if (algo.Contains("FCFS"))
                    order = new List<int>(reqs);
                else if (algo.Contains("SSTF"))
                    order = RunSSTF(reqs, head);
                else if (algo.Contains("SCAN"))
                    order = RunSCAN(reqs, head, (int)nudDiskSize.Value, true);
                else
                {
                    MessageBox.Show("Unknown disk algorithm.");
                    return;
                }

                lstDiskOrder.Items.Clear();
                foreach (var r in order)
                    lstDiskOrder.Items.Add(r);

                txtTotalHead.Text = ComputeTotalMovement(order, head).ToString();
                lastDiskOrder = order;
                pnlDisk.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disk error: " + ex.Message);
            }
        }

        private List<int> ReadDiskRequests()
        {
            var list = new List<int>();
            foreach (DataGridViewRow row in dgvDisk.Rows)
            {
                if (row.IsNewRow) continue;
                list.Add(ToInt(row.Cells[0].Value));
            }
            return list;
        }

        private List<int> RunSSTF(List<int> requests, int head)
        {
            var rem = new List<int>(requests);
            var order = new List<int>();
            int cur = head;
            while (rem.Count > 0)
            {
                int closest = rem.OrderBy(x => Math.Abs(x - cur)).First();
                order.Add(closest);
                rem.Remove(closest);
                cur = closest;
            }
            return order;
        }

        private List<int> RunSCAN(List<int> requests, int head, int diskSize, bool directionUp = true)
        {
            var lower = requests.Where(r => r <= head).OrderByDescending(r => r).ToList();
            var higher = requests.Where(r => r > head).OrderBy(r => r).ToList();
            var order = new List<int>();
            if (directionUp)
            {
                order.AddRange(higher);
                order.AddRange(lower);
            }
            else
            {
                order.AddRange(lower);
                order.AddRange(higher);
            }
            return order;
        }

        private int ComputeTotalMovement(List<int> order, int head)
        {
            int total = 0;
            int cur = head;
            foreach (var r in order)
            {
                total += Math.Abs(cur - r);
                cur = r;
            }
            return total;
        }

        private List<int> lastDiskOrder = new List<int>();

        private void pnlDisk_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            if (lastDiskOrder == null || lastDiskOrder.Count == 0) return;

            int head = (int)nudInitialHead.Value;
            int min = Math.Min(head, lastDiskOrder.Min());
            int max = Math.Max(head, lastDiskOrder.Max());
            int width = pnlDisk.Width - 40;
            int y = pnlDisk.Height / 2;
            var font = new Font("Arial", 9);

            Func<int, float> mapX = (val) =>
            {
                if (max == min) return 20 + width / 2;
                return 20 + (val - min) * (float)width / (max - min);
            };

            int prev = head;
            foreach (var r in lastDiskOrder)
            {
                float x1 = mapX(prev);
                float x2 = mapX(r);
                g.DrawLine(Pens.Black, x1, y, x2, y);
                g.FillEllipse(Brushes.Red, x2 - 4, y - 4, 8, 8);
                g.DrawString(r.ToString(), font, Brushes.Black, x2 - 10, y - 20);
                prev = r;
            }

            float hx = mapX(head);
            g.FillEllipse(Brushes.Green, hx - 6, y + 8, 12, 12);
            g.DrawString("Head: " + head, font, Brushes.Black, hx - 20, y + 22);
        }

        #endregion
    }

    #region --- Helper Classes ---

    public class CPUProcess
    {
        public string PID { get; set; } = "";
        public int Arrival { get; set; } = 0;
        public int Burst { get; set; } = 0;
        public int Priority { get; set; } = 0;
        public int Remaining { get; set; } = 0;
        public int Start { get; set; } = -1;
        public int Completion { get; set; } = 0;
        public int Turnaround { get; set; } = 0;
        public int Waiting { get; set; } = 0;
        public int Response { get; set; } = 0;

        public CPUProcess Clone()
        {
            return new CPUProcess
            {
                PID = this.PID,
                Arrival = this.Arrival,
                Burst = this.Burst,
                Priority = this.Priority,
                Remaining = this.Remaining,
                Start = -1,
                Completion = 0
            };
        }
    }

    public class GanttEntry
    {
        public string PID { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
    }

    #endregion
}