namespace OS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.TabPage tabDisk;

        // CPU controls
        private System.Windows.Forms.GroupBox grpCPUTop;
        private System.Windows.Forms.Label lblNumProcesses;
        private System.Windows.Forms.NumericUpDown nudNumProcesses;
        private System.Windows.Forms.Button btnCreateProcesses;
        private System.Windows.Forms.DataGridView dgvCPU;
        private System.Windows.Forms.ComboBox cmbCPUScheduling;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.NumericUpDown nudQuantum;
        private System.Windows.Forms.Button btnRunCPU;
        private System.Windows.Forms.Panel pnlGantt;
        private System.Windows.Forms.GroupBox grpCPUResults;
        private System.Windows.Forms.Label lblATAT;
        private System.Windows.Forms.TextBox txtATAT;
        private System.Windows.Forms.Label lblAWT;
        private System.Windows.Forms.TextBox txtAWT;
        private System.Windows.Forms.Label lblART;
        private System.Windows.Forms.TextBox txtART;
        private System.Windows.Forms.DataGridView dgvCPUResults;
        private System.Windows.Forms.Label lblGanttChart;

        // Disk controls
        private System.Windows.Forms.GroupBox grpDiskTop;
        private System.Windows.Forms.Label lblDiskRequests;
        private System.Windows.Forms.NumericUpDown nudDiskRequests;
        private System.Windows.Forms.Button btnCreateDisk;
        private System.Windows.Forms.DataGridView dgvDisk;
        private System.Windows.Forms.Label lblInitialHead;
        private System.Windows.Forms.NumericUpDown nudInitialHead;
        private System.Windows.Forms.Label lblDiskSize;
        private System.Windows.Forms.NumericUpDown nudDiskSize;
        private System.Windows.Forms.ComboBox cmbDiskAlgo;
        private System.Windows.Forms.Button btnRunDisk;
        private System.Windows.Forms.ListBox lstDiskOrder;
        private System.Windows.Forms.Label lblTotalHead;
        private System.Windows.Forms.TextBox txtTotalHead;
        private System.Windows.Forms.Panel pnlDisk;
        private System.Windows.Forms.Label lblProcessingOrder;
        private System.Windows.Forms.Label lblDiskVisual;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.grpCPUResults = new System.Windows.Forms.GroupBox();
            this.dgvCPUResults = new System.Windows.Forms.DataGridView();
            this.lblATAT = new System.Windows.Forms.Label();
            this.txtATAT = new System.Windows.Forms.TextBox();
            this.lblAWT = new System.Windows.Forms.Label();
            this.txtAWT = new System.Windows.Forms.TextBox();
            this.lblART = new System.Windows.Forms.Label();
            this.txtART = new System.Windows.Forms.TextBox();
            this.lblGanttChart = new System.Windows.Forms.Label();
            this.pnlGantt = new System.Windows.Forms.Panel();
            this.btnRunCPU = new System.Windows.Forms.Button();
            this.nudQuantum = new System.Windows.Forms.NumericUpDown();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.cmbCPUScheduling = new System.Windows.Forms.ComboBox();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.grpCPUTop = new System.Windows.Forms.GroupBox();
            this.dgvCPU = new System.Windows.Forms.DataGridView();
            this.btnCreateProcesses = new System.Windows.Forms.Button();
            this.nudNumProcesses = new System.Windows.Forms.NumericUpDown();
            this.lblNumProcesses = new System.Windows.Forms.Label();
            this.tabDisk = new System.Windows.Forms.TabPage();
            this.lblDiskVisual = new System.Windows.Forms.Label();
            this.pnlDisk = new System.Windows.Forms.Panel();
            this.txtTotalHead = new System.Windows.Forms.TextBox();
            this.lblTotalHead = new System.Windows.Forms.Label();
            this.lstDiskOrder = new System.Windows.Forms.ListBox();
            this.lblProcessingOrder = new System.Windows.Forms.Label();
            this.btnRunDisk = new System.Windows.Forms.Button();
            this.cmbDiskAlgo = new System.Windows.Forms.ComboBox();
            this.grpDiskTop = new System.Windows.Forms.GroupBox();
            this.nudDiskSize = new System.Windows.Forms.NumericUpDown();
            this.lblDiskSize = new System.Windows.Forms.Label();
            this.nudInitialHead = new System.Windows.Forms.NumericUpDown();
            this.lblInitialHead = new System.Windows.Forms.Label();
            this.dgvDisk = new System.Windows.Forms.DataGridView();
            this.btnCreateDisk = new System.Windows.Forms.Button();
            this.nudDiskRequests = new System.Windows.Forms.NumericUpDown();
            this.lblDiskRequests = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabCPU.SuspendLayout();
            this.grpCPUResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPUResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).BeginInit();
            this.grpCPUTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumProcesses)).BeginInit();
            this.tabDisk.SuspendLayout();
            this.grpDiskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabCPU);
            this.tabControlMain.Controls.Add(this.tabDisk);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1340, 730);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabCPU
            // 
            this.tabCPU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCPU.Controls.Add(this.grpCPUResults);
            this.tabCPU.Controls.Add(this.lblGanttChart);
            this.tabCPU.Controls.Add(this.pnlGantt);
            this.tabCPU.Controls.Add(this.btnRunCPU);
            this.tabCPU.Controls.Add(this.nudQuantum);
            this.tabCPU.Controls.Add(this.lblQuantum);
            this.tabCPU.Controls.Add(this.cmbCPUScheduling);
            this.tabCPU.Controls.Add(this.lblAlgorithm);
            this.tabCPU.Controls.Add(this.grpCPUTop);
            this.tabCPU.Location = new System.Drawing.Point(4, 32);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(10);
            this.tabCPU.Size = new System.Drawing.Size(1332, 694);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "CPU Scheduling";
            // 
            // grpCPUResults
            // 
            this.grpCPUResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCPUResults.BackColor = System.Drawing.Color.White;
            this.grpCPUResults.Controls.Add(this.dgvCPUResults);
            this.grpCPUResults.Controls.Add(this.lblATAT);
            this.grpCPUResults.Controls.Add(this.txtATAT);
            this.grpCPUResults.Controls.Add(this.lblAWT);
            this.grpCPUResults.Controls.Add(this.txtAWT);
            this.grpCPUResults.Controls.Add(this.lblART);
            this.grpCPUResults.Controls.Add(this.txtART);
            this.grpCPUResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCPUResults.Location = new System.Drawing.Point(860, 13);
            this.grpCPUResults.Name = "grpCPUResults";
            this.grpCPUResults.Size = new System.Drawing.Size(459, 668);
            this.grpCPUResults.TabIndex = 8;
            this.grpCPUResults.TabStop = false;
            this.grpCPUResults.Text = "Results";
            // 
            // dgvCPUResults
            // 
            this.dgvCPUResults.AllowUserToAddRows = false;
            this.dgvCPUResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCPUResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvCPUResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCPUResults.ColumnHeadersHeight = 34;
            this.dgvCPUResults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCPUResults.Location = new System.Drawing.Point(15, 140);
            this.dgvCPUResults.Name = "dgvCPUResults";
            this.dgvCPUResults.ReadOnly = true;
            this.dgvCPUResults.RowHeadersVisible = false;
            this.dgvCPUResults.RowHeadersWidth = 62;
            this.dgvCPUResults.Size = new System.Drawing.Size(370, 515);
            this.dgvCPUResults.TabIndex = 6;
            // 
            // lblATAT
            // 
            this.lblATAT.AutoSize = true;
            this.lblATAT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblATAT.Location = new System.Drawing.Point(15, 35);
            this.lblATAT.Name = "lblATAT";
            this.lblATAT.Size = new System.Drawing.Size(172, 20);
            this.lblATAT.TabIndex = 0;
            this.lblATAT.Text = "Average Turnaround Time:";
            // 
            // txtATAT
            // 
            this.txtATAT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtATAT.Location = new System.Drawing.Point(200, 32);
            this.txtATAT.Name = "txtATAT";
            this.txtATAT.ReadOnly = true;
            this.txtATAT.Size = new System.Drawing.Size(100, 27);
            this.txtATAT.TabIndex = 1;
            this.txtATAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAWT
            // 
            this.lblAWT.AutoSize = true;
            this.lblAWT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAWT.Location = new System.Drawing.Point(15, 70);
            this.lblAWT.Name = "lblAWT";
            this.lblAWT.Size = new System.Drawing.Size(155, 20);
            this.lblAWT.TabIndex = 2;
            this.lblAWT.Text = "Average Waiting Time:";
            // 
            // txtAWT
            // 
            this.txtAWT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAWT.Location = new System.Drawing.Point(200, 67);
            this.txtAWT.Name = "txtAWT";
            this.txtAWT.ReadOnly = true;
            this.txtAWT.Size = new System.Drawing.Size(100, 27);
            this.txtAWT.TabIndex = 3;
            this.txtAWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblART
            // 
            this.lblART.AutoSize = true;
            this.lblART.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblART.Location = new System.Drawing.Point(15, 105);
            this.lblART.Name = "lblART";
            this.lblART.Size = new System.Drawing.Size(167, 20);
            this.lblART.TabIndex = 4;
            this.lblART.Text = "Average Response Time:";
            // 
            // txtART
            // 
            this.txtART.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtART.Location = new System.Drawing.Point(200, 102);
            this.txtART.Name = "txtART";
            this.txtART.ReadOnly = true;
            this.txtART.Size = new System.Drawing.Size(100, 27);
            this.txtART.TabIndex = 5;
            this.txtART.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGanttChart
            // 
            this.lblGanttChart.AutoSize = true;
            this.lblGanttChart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGanttChart.Location = new System.Drawing.Point(13, 313);
            this.lblGanttChart.Name = "lblGanttChart";
            this.lblGanttChart.Size = new System.Drawing.Size(106, 23);
            this.lblGanttChart.TabIndex = 7;
            this.lblGanttChart.Text = "Gantt Chart";
            // 
            // pnlGantt
            // 
            this.pnlGantt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGantt.BackColor = System.Drawing.Color.White;
            this.pnlGantt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGantt.Location = new System.Drawing.Point(13, 339);
            this.pnlGantt.Name = "pnlGantt";
            this.pnlGantt.Size = new System.Drawing.Size(895, 342);
            this.pnlGantt.TabIndex = 6;
            this.pnlGantt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGantt_Paint);
            // 
            // btnRunCPU
            // 
            this.btnRunCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRunCPU.FlatAppearance.BorderSize = 0;
            this.btnRunCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCPU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRunCPU.ForeColor = System.Drawing.Color.White;
            this.btnRunCPU.Location = new System.Drawing.Point(764, 268);
            this.btnRunCPU.Name = "btnRunCPU";
            this.btnRunCPU.Size = new System.Drawing.Size(144, 38);
            this.btnRunCPU.TabIndex = 5;
            this.btnRunCPU.Text = "Run Scheduling";
            this.btnRunCPU.UseVisualStyleBackColor = false;
            this.btnRunCPU.Click += new System.EventHandler(this.btnRunCPU_Click);
            // 
            // nudQuantum
            // 
            this.nudQuantum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQuantum.Location = new System.Drawing.Point(688, 273);
            this.nudQuantum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQuantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantum.Name = "nudQuantum";
            this.nudQuantum.Size = new System.Drawing.Size(70, 30);
            this.nudQuantum.TabIndex = 4;
            this.nudQuantum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudQuantum.Visible = false;
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantum.Location = new System.Drawing.Point(568, 275);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(114, 23);
            this.lblQuantum.TabIndex = 3;
            this.lblQuantum.Text = "Time Quantum:";
            this.lblQuantum.Visible = false;
            // 
            // cmbCPUScheduling
            // 
            this.cmbCPUScheduling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPUScheduling.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCPUScheduling.FormattingEnabled = true;
            this.cmbCPUScheduling.Location = new System.Drawing.Point(102, 271);
            this.cmbCPUScheduling.Name = "cmbCPUScheduling";
            this.cmbCPUScheduling.Size = new System.Drawing.Size(445, 31);
            this.cmbCPUScheduling.TabIndex = 2;
            this.cmbCPUScheduling.SelectedIndexChanged += new System.EventHandler(this.cmbCPUScheduling_SelectedIndexChanged);
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlgorithm.Location = new System.Drawing.Point(13, 274);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(90, 23);
            this.lblAlgorithm.TabIndex = 1;
            this.lblAlgorithm.Text = "Algorithm:";
            // 
            // grpCPUTop
            // 
            this.grpCPUTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCPUTop.BackColor = System.Drawing.Color.White;
            this.grpCPUTop.Controls.Add(this.dgvCPU);
            this.grpCPUTop.Controls.Add(this.btnCreateProcesses);
            this.grpCPUTop.Controls.Add(this.nudNumProcesses);
            this.grpCPUTop.Controls.Add(this.lblNumProcesses);
            this.grpCPUTop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCPUTop.Location = new System.Drawing.Point(13, 13);
            this.grpCPUTop.Name = "grpCPUTop";
            this.grpCPUTop.Size = new System.Drawing.Size(895, 245);
            this.grpCPUTop.TabIndex = 0;
            this.grpCPUTop.TabStop = false;
            this.grpCPUTop.Text = "Process Input";
            // 
            // dgvCPU
            // 
            this.dgvCPU.AllowUserToResizeRows = false;
            this.dgvCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCPU.BackgroundColor = System.Drawing.Color.White;
            this.dgvCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCPU.ColumnHeadersHeight = 34;
            this.dgvCPU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCPU.Location = new System.Drawing.Point(15, 70);
            this.dgvCPU.Name = "dgvCPU";
            this.dgvCPU.RowHeadersVisible = false;
            this.dgvCPU.RowHeadersWidth = 62;
            this.dgvCPU.Size = new System.Drawing.Size(865, 162);
            this.dgvCPU.TabIndex = 3;
            // 
            // btnCreateProcesses
            // 
            this.btnCreateProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnCreateProcesses.FlatAppearance.BorderSize = 0;
            this.btnCreateProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProcesses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreateProcesses.ForeColor = System.Drawing.Color.White;
            this.btnCreateProcesses.Location = new System.Drawing.Point(218, 28);
            this.btnCreateProcesses.Name = "btnCreateProcesses";
            this.btnCreateProcesses.Size = new System.Drawing.Size(120, 34);
            this.btnCreateProcesses.TabIndex = 2;
            this.btnCreateProcesses.Text = "Create Table";
            this.btnCreateProcesses.UseVisualStyleBackColor = false;
            this.btnCreateProcesses.Click += new System.EventHandler(this.btnCreateProcesses_Click);
            // 
            // nudNumProcesses
            // 
            this.nudNumProcesses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudNumProcesses.Location = new System.Drawing.Point(142, 31);
            this.nudNumProcesses.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNumProcesses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumProcesses.Name = "nudNumProcesses";
            this.nudNumProcesses.Size = new System.Drawing.Size(70, 30);
            this.nudNumProcesses.TabIndex = 1;
            this.nudNumProcesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumProcesses.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblNumProcesses
            // 
            this.lblNumProcesses.AutoSize = true;
            this.lblNumProcesses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumProcesses.Location = new System.Drawing.Point(15, 33);
            this.lblNumProcesses.Name = "lblNumProcesses";
            this.lblNumProcesses.Size = new System.Drawing.Size(121, 23);
            this.lblNumProcesses.TabIndex = 0;
            this.lblNumProcesses.Text = "No. Processes:";
            // 
            // tabDisk
            // 
            this.tabDisk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDisk.Controls.Add(this.lblDiskVisual);
            this.tabDisk.Controls.Add(this.pnlDisk);
            this.tabDisk.Controls.Add(this.txtTotalHead);
            this.tabDisk.Controls.Add(this.lblTotalHead);
            this.tabDisk.Controls.Add(this.lstDiskOrder);
            this.tabDisk.Controls.Add(this.lblProcessingOrder);
            this.tabDisk.Controls.Add(this.btnRunDisk);
            this.tabDisk.Controls.Add(this.cmbDiskAlgo);
            this.tabDisk.Controls.Add(this.grpDiskTop);
            this.tabDisk.Location = new System.Drawing.Point(4, 32);
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Padding = new System.Windows.Forms.Padding(10);
            this.tabDisk.Size = new System.Drawing.Size(1332, 694);
            this.tabDisk.TabIndex = 1;
            this.tabDisk.Text = "Disk Scheduling";
            // 
            // lblDiskVisual
            // 
            this.lblDiskVisual.AutoSize = true;
            this.lblDiskVisual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiskVisual.Location = new System.Drawing.Point(13, 437);
            this.lblDiskVisual.Name = "lblDiskVisual";
            this.lblDiskVisual.Size = new System.Drawing.Size(185, 23);
            this.lblDiskVisual.TabIndex = 8;
            this.lblDiskVisual.Text = "Disk Head Movement";
            // 
            // pnlDisk
            // 
            this.pnlDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisk.BackColor = System.Drawing.Color.White;
            this.pnlDisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisk.Location = new System.Drawing.Point(13, 463);
            this.pnlDisk.Name = "pnlDisk";
            this.pnlDisk.Size = new System.Drawing.Size(1306, 218);
            this.pnlDisk.TabIndex = 7;
            this.pnlDisk.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDisk_Paint);
            // 
            // txtTotalHead
            // 
            this.txtTotalHead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalHead.Location = new System.Drawing.Point(207, 393);
            this.txtTotalHead.Name = "txtTotalHead";
            this.txtTotalHead.ReadOnly = true;
            this.txtTotalHead.Size = new System.Drawing.Size(120, 30);
            this.txtTotalHead.TabIndex = 6;
            this.txtTotalHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalHead
            // 
            this.lblTotalHead.AutoSize = true;
            this.lblTotalHead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalHead.Location = new System.Drawing.Point(13, 396);
            this.lblTotalHead.Name = "lblTotalHead";
            this.lblTotalHead.Size = new System.Drawing.Size(188, 23);
            this.lblTotalHead.TabIndex = 5;
            this.lblTotalHead.Text = "Total Head Movement:";
            // 
            // lstDiskOrder
            // 
            this.lstDiskOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstDiskOrder.FormattingEnabled = true;
            this.lstDiskOrder.ItemHeight = 23;
            this.lstDiskOrder.Location = new System.Drawing.Point(360, 252);
            this.lstDiskOrder.Name = "lstDiskOrder";
            this.lstDiskOrder.Size = new System.Drawing.Size(180, 165);
            this.lstDiskOrder.TabIndex = 4;
            // 
            // lblProcessingOrder
            // 
            this.lblProcessingOrder.AutoSize = true;
            this.lblProcessingOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProcessingOrder.Location = new System.Drawing.Point(360, 226);
            this.lblProcessingOrder.Name = "lblProcessingOrder";
            this.lblProcessingOrder.Size = new System.Drawing.Size(149, 23);
            this.lblProcessingOrder.TabIndex = 3;
            this.lblProcessingOrder.Text = "Processing Order";
            // 
            // btnRunDisk
            // 
            this.btnRunDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRunDisk.FlatAppearance.BorderSize = 0;
            this.btnRunDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunDisk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRunDisk.ForeColor = System.Drawing.Color.White;
            this.btnRunDisk.Location = new System.Drawing.Point(13, 274);
            this.btnRunDisk.Name = "btnRunDisk";
            this.btnRunDisk.Size = new System.Drawing.Size(144, 38);
            this.btnRunDisk.TabIndex = 2;
            this.btnRunDisk.Text = "Run Scheduling";
            this.btnRunDisk.UseVisualStyleBackColor = false;
            this.btnRunDisk.Click += new System.EventHandler(this.btnRunDisk_Click);
            // 
            // cmbDiskAlgo
            // 
            this.cmbDiskAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiskAlgo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiskAlgo.FormattingEnabled = true;
            this.cmbDiskAlgo.Location = new System.Drawing.Point(13, 226);
            this.cmbDiskAlgo.Name = "cmbDiskAlgo";
            this.cmbDiskAlgo.Size = new System.Drawing.Size(327, 31);
            this.cmbDiskAlgo.TabIndex = 1;
            // 
            // grpDiskTop
            // 
            this.grpDiskTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDiskTop.BackColor = System.Drawing.Color.White;
            this.grpDiskTop.Controls.Add(this.nudDiskSize);
            this.grpDiskTop.Controls.Add(this.lblDiskSize);
            this.grpDiskTop.Controls.Add(this.nudInitialHead);
            this.grpDiskTop.Controls.Add(this.lblInitialHead);
            this.grpDiskTop.Controls.Add(this.dgvDisk);
            this.grpDiskTop.Controls.Add(this.btnCreateDisk);
            this.grpDiskTop.Controls.Add(this.nudDiskRequests);
            this.grpDiskTop.Controls.Add(this.lblDiskRequests);
            this.grpDiskTop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDiskTop.Location = new System.Drawing.Point(13, 13);
            this.grpDiskTop.Name = "grpDiskTop";
            this.grpDiskTop.Size = new System.Drawing.Size(1306, 200);
            this.grpDiskTop.TabIndex = 0;
            this.grpDiskTop.TabStop = false;
            this.grpDiskTop.Text = "Disk Request Input";
            // 
            // nudDiskSize
            // 
            this.nudDiskSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudDiskSize.Location = new System.Drawing.Point(547, 67);
            this.nudDiskSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDiskSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiskSize.Name = "nudDiskSize";
            this.nudDiskSize.Size = new System.Drawing.Size(90, 30);
            this.nudDiskSize.TabIndex = 7;
            this.nudDiskSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiskSize.Value = new decimal(new int[] {
            199,
            0,
            0,
            0});
            // 
            // lblDiskSize
            // 
            this.lblDiskSize.AutoSize = true;
            this.lblDiskSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiskSize.Location = new System.Drawing.Point(460, 69);
            this.lblDiskSize.Name = "lblDiskSize";
            this.lblDiskSize.Size = new System.Drawing.Size(81, 23);
            this.lblDiskSize.TabIndex = 6;
            this.lblDiskSize.Text = "Disk Size:";
            // 
            // nudInitialHead
            // 
            this.nudInitialHead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudInitialHead.Location = new System.Drawing.Point(547, 31);
            this.nudInitialHead.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInitialHead.Name = "nudInitialHead";
            this.nudInitialHead.Size = new System.Drawing.Size(90, 30);
            this.nudInitialHead.TabIndex = 5;
            this.nudInitialHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInitialHead.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblInitialHead
            // 
            this.lblInitialHead.AutoSize = true;
            this.lblInitialHead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInitialHead.Location = new System.Drawing.Point(400, 33);
            this.lblInitialHead.Name = "lblInitialHead";
            this.lblInitialHead.Size = new System.Drawing.Size(141, 23);
            this.lblInitialHead.TabIndex = 4;
            this.lblInitialHead.Text = "Initial Head Pos.:";
            // 
            // dgvDisk
            // 
            this.dgvDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDisk.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisk.ColumnHeadersHeight = 34;
            this.dgvDisk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDisk.Location = new System.Drawing.Point(15, 103);
            this.dgvDisk.Name = "dgvDisk";
            this.dgvDisk.RowHeadersVisible = false;
            this.dgvDisk.RowHeadersWidth = 62;
            this.dgvDisk.Size = new System.Drawing.Size(200, 85);
            this.dgvDisk.TabIndex = 3;
            // 
            // btnCreateDisk
            // 
            this.btnCreateDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnCreateDisk.FlatAppearance.BorderSize = 0;
            this.btnCreateDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDisk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreateDisk.ForeColor = System.Drawing.Color.White;
            this.btnCreateDisk.Location = new System.Drawing.Point(218, 29);
            this.btnCreateDisk.Name = "btnCreateDisk";
            this.btnCreateDisk.Size = new System.Drawing.Size(120, 34);
            this.btnCreateDisk.TabIndex = 2;
            this.btnCreateDisk.Text = "Create Table";
            this.btnCreateDisk.UseVisualStyleBackColor = false;
            this.btnCreateDisk.Click += new System.EventHandler(this.btnCreateDisk_Click);
            // 
            // nudDiskRequests
            // 
            this.nudDiskRequests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudDiskRequests.Location = new System.Drawing.Point(142, 31);
            this.nudDiskRequests.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDiskRequests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiskRequests.Name = "nudDiskRequests";
            this.nudDiskRequests.Size = new System.Drawing.Size(70, 30);
            this.nudDiskRequests.TabIndex = 1;
            this.nudDiskRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiskRequests.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDiskRequests
            // 
            this.lblDiskRequests.AutoSize = true;
            this.lblDiskRequests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiskRequests.Location = new System.Drawing.Point(15, 33);
            this.lblDiskRequests.Name = "lblDiskRequests";
            this.lblDiskRequests.Size = new System.Drawing.Size(115, 23);
            this.lblDiskRequests.TabIndex = 0;
            this.lblDiskRequests.Text = "No. Requests:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1364, 754);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU & Disk Scheduling Simulator";
            this.tabControlMain.ResumeLayout(false);
            this.tabCPU.ResumeLayout(false);
            this.tabCPU.PerformLayout();
            this.grpCPUResults.ResumeLayout(false);
            this.grpCPUResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPUResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantum)).EndInit();
            this.grpCPUTop.ResumeLayout(false);
            this.grpCPUTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumProcesses)).EndInit();
            this.tabDisk.ResumeLayout(false);
            this.tabDisk.PerformLayout();
            this.grpDiskTop.ResumeLayout(false);
            this.grpDiskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskRequests)).EndInit();
            this.ResumeLayout(false);

        }
    }
}