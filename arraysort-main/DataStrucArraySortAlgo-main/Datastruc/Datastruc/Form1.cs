using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Datastruc
{
    public partial class ArraySort : Form
    {
        public ArraySort()
        {
            InitializeComponent();

            // grid setup
            datagvSorted.AllowUserToAddRows = false;
            datagvSorted.RowHeadersVisible = false;
            datagvSorted.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InitGrid();

            // initialize label count
            lblCount.Text = "0 / 0";
        }

        private void InitGrid()
        {
            datagvSorted.Columns.Clear();
            datagvSorted.Columns.Add("Step", "Step");
            datagvSorted.Columns.Add("Array", "Array State");
            datagvSorted.Rows.Clear();
            datagvSorted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // add row to grid
        private void AddStepToGrid(int stepNum, int[] arr)
        {
            datagvSorted.Rows.Add(stepNum, string.Join(" ", arr));
        }

        // highlight row if array is changed
        private void HighlightChangedRow(int rowIndex)
        {
            if (rowIndex == 0 || rowIndex >= datagvSorted.Rows.Count) return;

            string prev = datagvSorted.Rows[rowIndex - 1].Cells[1].Value?.ToString();
            string curr = datagvSorted.Rows[rowIndex].Cells[1].Value?.ToString();

            if (prev != curr)
            {
                datagvSorted.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                datagvSorted.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        // change color of selected algorithm
        private void HighlightAlgorithm(LinkLabel selected)
        {
            linklblBubble.LinkColor = Color.Blue;
            linklblselection.LinkColor = Color.Blue;
            linklblInsertion.LinkColor = Color.Blue;
            linklblMerge.LinkColor = Color.Blue;

            selected.LinkColor = Color.Red;
        }

        // change string input to int
        private bool TryParseInput(out int[] arr)
        {
            arr = null;

            if (!int.TryParse(txtArraySize.Text.Trim(), out int size) || size <= 0)
            {
                MessageBox.Show("Enter a valid positive integer for array size.",
                                "Invalid size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string text = (txtElements.Text ?? "").Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Enter the array elements (separated by spaces or commas).",
                                "No elements", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var parts = Regex.Split(text, @"[,\s]+").Where(s => s.Length > 0).ToArray();

            // check if fewer
            if (parts.Length < size)
            {
                MessageBox.Show($"You entered {parts.Length} elements but array size is {size}. Enter at least {size} elements.",
                                "Not enough elements", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // check if more
            if (parts.Length > size)
            {
                MessageBox.Show($"You entered {parts.Length} elements but array size is {size}. Please enter exactly {size} elements.",
                                "Too many elements", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(parts[i], out int value))
                {
                    MessageBox.Show($"Invalid number '{parts[i]}' at position {i + 1}.",
                                    "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                arr[i] = value;
            }

            return true;
        }

        // sorting algorithms and steps 

        // bubble sort steps
        private List<int[]> BubbleSortSteps(int[] source)
        {
            var steps = new List<int[]>();
            int[] a = (int[])source.Clone();
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                        steps.Add((int[])a.Clone()); // record after each swap
                    }
                }
            }
            return steps;
        }

        // selection sort steps
        private List<int[]> SelectionSortSteps(int[] source)
        {
            var steps = new List<int[]>();
            int[] a = (int[])source.Clone();
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIdx]) minIdx = j;
                }
                if (minIdx != i)
                {
                    int tmp = a[i];
                    a[i] = a[minIdx];
                    a[minIdx] = tmp;
                    steps.Add((int[])a.Clone());
                }
            }
            return steps;
        }

        // insertion sort steps
        private List<int[]> InsertionSortSteps(int[] source)
        {
            var steps = new List<int[]>();
            int[] a = (int[])source.Clone();
            int n = a.Length;

            for (int i = 1; i < n; i++)
            {
                int key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    steps.Add((int[])a.Clone());
                    j--;
                }
                a[j + 1] = key;
                steps.Add((int[])a.Clone());
            }
            return steps;
        }

        // merge sort steps
        private List<int[]> MergeSortSteps(int[] source)
        {
            var steps = new List<int[]>();
            int[] a = (int[])source.Clone();
            MergeSortRecursive(a, 0, a.Length - 1, steps);
            return steps;
        }

        private void MergeSortRecursive(int[] a, int left, int right, List<int[]> steps)
        {
            if (left >= right) return;
            int mid = (left + right) / 2;
            MergeSortRecursive(a, left, mid, steps);
            MergeSortRecursive(a, mid + 1, right, steps);
            Merge(a, left, mid, right, steps);
        }

        private void Merge(int[] a, int left, int mid, int right, List<int[]> steps)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(a, left, L, 0, n1);
            Array.Copy(a, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j]) a[k++] = L[i++];
                else a[k++] = R[j++];
            }
            while (i < n1) a[k++] = L[i++];
            while (j < n2) a[k++] = R[j++];

            steps.Add((int[])a.Clone());
        }

        // bubble sort
        private void linklblBubble_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HighlightAlgorithm(linklblBubble);

            if (!TryParseInput(out int[] arr)) return;

            InitGrid();
            int stepNumber = 0;
            AddStepToGrid(stepNumber, arr);

            var steps = BubbleSortSteps(arr);
            foreach (var s in steps)
            {
                stepNumber++;
                AddStepToGrid(stepNumber, s);
                HighlightChangedRow(stepNumber);
            }
        }

        //selection sort
        private void linklblselection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HighlightAlgorithm(linklblselection);

            if (!TryParseInput(out int[] arr)) return;

            InitGrid();
            int stepNumber = 0;
            AddStepToGrid(stepNumber, arr);

            var steps = SelectionSortSteps(arr);
            foreach (var s in steps)
            {
                stepNumber++;
                AddStepToGrid(stepNumber, s);
                HighlightChangedRow(stepNumber);
            }
        }

        // insertion sort
        private void linklblInsertion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HighlightAlgorithm(linklblInsertion);

            if (!TryParseInput(out int[] arr)) return;

            InitGrid();
            int stepNumber = 0;
            AddStepToGrid(stepNumber, arr);

            var steps = InsertionSortSteps(arr);
            foreach (var s in steps)
            {
                stepNumber++;
                AddStepToGrid(stepNumber, s);
                HighlightChangedRow(stepNumber);
            }
        }

        // merge sort
        private void linklblMerge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HighlightAlgorithm(linklblMerge);

            if (!TryParseInput(out int[] arr)) return;

            InitGrid();
            int stepNumber = 0;
            AddStepToGrid(stepNumber, arr);

            var steps = MergeSortSteps(arr);
            foreach (var s in steps)
            {
                stepNumber++;
                AddStepToGrid(stepNumber, s);
                HighlightChangedRow(stepNumber);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        // when array size changes
        public void txtArraySize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtArraySize.Text.Trim(), out int size) && size > 0)
            {
                lblCount.Text = $"0 / {size}";
                lblCount.ForeColor = Color.Black;
            }
            else
            {
                lblCount.Text = "0 / 0";
                lblCount.ForeColor = Color.Black;
            }
        }

        // when elements change
        private void txtElements_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtArraySize.Text.Trim(), out int size) || size <= 0)
            {
                lblCount.Text = "0 / 0";
                lblCount.ForeColor = Color.Black;
                return;
            }

            var parts = Regex.Split(txtElements.Text.Trim(), @"[,\s]+")
                             .Where(s => s.Length > 0).ToArray();

            int count = parts.Length;
            lblCount.Text = $"{count} / {size}";

            // live warning
            if (count > size)
            {
                lblCount.ForeColor = Color.Red;
            }
            else
            {
                lblCount.ForeColor = Color.Black;
            }
        }

        private void datagvSorted_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnClr_Click(object sender, EventArgs e)
        {
            //clr txtbox
            txtArraySize.Clear();
            txtElements.Clear();
            InitGrid();

            //reset counter
            lblCount.Text = "0 / arraylength";
            lblCount.ForeColor = Color.Black;

            //reset color
            linklblBubble.LinkColor = Color.Blue;
            linklblselection.LinkColor = Color.Blue;
            linklblInsertion.LinkColor = Color.Blue;
            linklblMerge.LinkColor = Color.Blue;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblArrayElements_Click(object sender, EventArgs e)
        {

        }
    }
}
