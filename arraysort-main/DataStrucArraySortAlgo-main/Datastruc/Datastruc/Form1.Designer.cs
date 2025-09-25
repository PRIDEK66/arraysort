namespace Datastruc
{
    partial class ArraySort
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblArraySize = new Label();
            lblArrayElements = new Label();
            lblAlgorithms = new Label();
            linklblBubble = new LinkLabel();
            linklblselection = new LinkLabel();
            linklblInsertion = new LinkLabel();
            linklblMerge = new LinkLabel();
            txtArraySize = new TextBox();
            txtElements = new TextBox();
            datagvSorted = new DataGridView();
            btnClr = new Button();
            lblCount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagvSorted).BeginInit();
            SuspendLayout();
            // 
            // lblArraySize
            // 
            lblArraySize.AutoSize = true;
            lblArraySize.Location = new Point(46, 51);
            lblArraySize.Margin = new Padding(4, 0, 4, 0);
            lblArraySize.Name = "lblArraySize";
            lblArraySize.Size = new Size(135, 25);
            lblArraySize.TabIndex = 0;
            lblArraySize.Text = "Enter Array Size";
            lblArraySize.Click += label1_Click;
            // 
            // lblArrayElements
            // 
            lblArrayElements.AutoSize = true;
            lblArrayElements.Location = new Point(46, 90);
            lblArrayElements.Margin = new Padding(4, 0, 4, 0);
            lblArrayElements.Name = "lblArrayElements";
            lblArrayElements.Size = new Size(175, 25);
            lblArrayElements.TabIndex = 1;
            lblArrayElements.Text = "Enter Array Elements";
            lblArrayElements.Click += lblArrayElements_Click;
            // 
            // lblAlgorithms
            // 
            lblAlgorithms.AutoSize = true;
            lblAlgorithms.Location = new Point(209, 174);
            lblAlgorithms.Margin = new Padding(4, 0, 4, 0);
            lblAlgorithms.Name = "lblAlgorithms";
            lblAlgorithms.Size = new Size(232, 25);
            lblAlgorithms.TabIndex = 2;
            lblAlgorithms.Text = "Choose Sorting Algorithms:";
            // 
            // linklblBubble
            // 
            linklblBubble.AutoSize = true;
            linklblBubble.Location = new Point(268, 214);
            linklblBubble.Margin = new Padding(4, 0, 4, 0);
            linklblBubble.Name = "linklblBubble";
            linklblBubble.Size = new Size(126, 25);
            linklblBubble.TabIndex = 3;
            linklblBubble.TabStop = true;
            linklblBubble.Text = "A. Bubble Sort";
            linklblBubble.LinkClicked += linklblBubble_LinkClicked;
            // 
            // linklblselection
            // 
            linklblselection.AutoSize = true;
            linklblselection.Location = new Point(268, 239);
            linklblselection.Margin = new Padding(4, 0, 4, 0);
            linklblselection.Name = "linklblselection";
            linklblselection.Size = new Size(140, 25);
            linklblselection.TabIndex = 4;
            linklblselection.TabStop = true;
            linklblselection.Text = "B. Selection Sort";
            linklblselection.LinkClicked += linklblselection_LinkClicked;
            // 
            // linklblInsertion
            // 
            linklblInsertion.AutoSize = true;
            linklblInsertion.Location = new Point(268, 264);
            linklblInsertion.Margin = new Padding(4, 0, 4, 0);
            linklblInsertion.Name = "linklblInsertion";
            linklblInsertion.Size = new Size(139, 25);
            linklblInsertion.TabIndex = 5;
            linklblInsertion.TabStop = true;
            linklblInsertion.Text = "C. Insertion Sort";
            linklblInsertion.LinkClicked += linklblInsertion_LinkClicked;
            // 
            // linklblMerge
            // 
            linklblMerge.AutoSize = true;
            linklblMerge.Location = new Point(268, 289);
            linklblMerge.Margin = new Padding(4, 0, 4, 0);
            linklblMerge.Name = "linklblMerge";
            linklblMerge.Size = new Size(123, 25);
            linklblMerge.TabIndex = 6;
            linklblMerge.TabStop = true;
            linklblMerge.Text = "D. Merge Sort";
            linklblMerge.LinkClicked += linklblMerge_LinkClicked;
            // 
            // txtArraySize
            // 
            txtArraySize.Location = new Point(240, 48);
            txtArraySize.Margin = new Padding(4);
            txtArraySize.Name = "txtArraySize";
            txtArraySize.Size = new Size(98, 31);
            txtArraySize.TabIndex = 7;
            txtArraySize.TextAlign = HorizontalAlignment.Center;
            txtArraySize.TextChanged += txtArraySize_TextChanged;
            // 
            // txtElements
            // 
            txtElements.Location = new Point(240, 87);
            txtElements.Margin = new Padding(4);
            txtElements.Name = "txtElements";
            txtElements.Size = new Size(328, 31);
            txtElements.TabIndex = 8;
            txtElements.TextChanged += txtElements_TextChanged;
            // 
            // datagvSorted
            // 
            datagvSorted.BackgroundColor = SystemColors.ActiveCaption;
            datagvSorted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagvSorted.GridColor = SystemColors.MenuHighlight;
            datagvSorted.Location = new Point(46, 354);
            datagvSorted.Margin = new Padding(4);
            datagvSorted.Name = "datagvSorted";
            datagvSorted.RowHeadersWidth = 51;
            datagvSorted.Size = new Size(608, 300);
            datagvSorted.TabIndex = 9;
            datagvSorted.CellContentClick += datagvSorted_CellContentClick;
            // 
            // btnClr
            // 
            btnClr.BackColor = Color.SteelBlue;
            btnClr.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClr.ForeColor = SystemColors.ButtonFace;
            btnClr.Location = new Point(537, 673);
            btnClr.Margin = new Padding(4);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(117, 41);
            btnClr.TabIndex = 10;
            btnClr.Text = "Clear";
            btnClr.UseVisualStyleBackColor = false;
            btnClr.Click += btnClr_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(575, 96);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(87, 19);
            lblCount.TabIndex = 11;
            lblCount.Text = "0/arraylength";
            lblCount.Click += lblCount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 122);
            label1.Name = "label1";
            label1.Size = new Size(328, 19);
            label1.TabIndex = 12;
            label1.Text = "Note: Use space or comma to separate the element/s";
            label1.Click += label1_Click_1;
            // 
            // ArraySort
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(696, 792);
            Controls.Add(label1);
            Controls.Add(lblCount);
            Controls.Add(btnClr);
            Controls.Add(datagvSorted);
            Controls.Add(txtElements);
            Controls.Add(txtArraySize);
            Controls.Add(linklblMerge);
            Controls.Add(linklblInsertion);
            Controls.Add(linklblselection);
            Controls.Add(linklblBubble);
            Controls.Add(lblAlgorithms);
            Controls.Add(lblArrayElements);
            Controls.Add(lblArraySize);
            Margin = new Padding(4);
            Name = "ArraySort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArraySort";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagvSorted).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArraySize;
        private Label lblArrayElements;
        private Label lblAlgorithms;
        private LinkLabel linklblBubble;
        private LinkLabel linklblselection;
        private LinkLabel linklblInsertion;
        private LinkLabel linklblMerge;
        private DataGridView datagvSorted;
        public TextBox txtArraySize;
        public TextBox txtElements;
        private Button btnClr;
        private Label lblCount;
        private Label label1;
    }
}
