namespace Form1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnExit = new Button();
            btnBinary = new Button();
            btnPostfix = new Button();
            btnQueue = new Button();
            btnStack = new Button();
            panelStack = new Panel();
            lblStackTitle = new Label();
            lblStackSizeLabel = new Label();
            txtStackSize = new TextBox();
            btnSetStackSize = new Button();
            lblStackInputEx = new Label();
            txtStackInput = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            btnPeek = new Button();
            btnIsEmpty = new Button();
            btnIsFull = new Button();
            lblStackDisplay = new Label();
            listStack = new ListBox();
            lblStackStatus = new Label();
            panelQueue = new Panel();
            lblQueueTitle = new Label();
            lblQueueSizeLabel = new Label();
            txtQueueSize = new TextBox();
            btnSetQueueSize = new Button();
            lblQueueInputEx = new Label();
            txtQueueInput = new TextBox();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnQueueIsEmpty = new Button();
            btnQueueIsFull = new Button();
            lblQueueDisplay = new Label();
            listQueue = new ListBox();
            lblQueueStatus = new Label();
            panelPostfix = new Panel();
            lblPostfixTitle = new Label();
            lblPostfixExample = new Label();
            lblPostfixInputLabel = new Label();
            txtPostfixInput = new TextBox();
            btnEvaluatePostfix = new Button();
            lblPostfixResult = new Label();
            panelBinary = new Panel();
            lblBinaryTitle = new Label();
            lblBinaryInputEx = new Label();
            txtDecimalInput = new TextBox();
            btnConvertBinary = new Button();
            lblBinarySteps = new Label();
            listBinary = new ListBox();
            lblBinaryResult = new Label();
            panelMenu.SuspendLayout();
            panelStack.SuspendLayout();
            panelQueue.SuspendLayout();
            panelPostfix.SuspendLayout();
            panelBinary.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(45, 45, 45);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnBinary);
            panelMenu.Controls.Add(btnPostfix);
            panelMenu.Controls.Add(btnQueue);
            panelMenu.Controls.Add(btnStack);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 550);
            panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Maroon;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 490);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 60);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnBinary
            // 
            btnBinary.BackColor = Color.FromArgb(60, 60, 60);
            btnBinary.Dock = DockStyle.Top;
            btnBinary.FlatAppearance.BorderSize = 0;
            btnBinary.FlatStyle = FlatStyle.Flat;
            btnBinary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBinary.ForeColor = Color.White;
            btnBinary.Location = new Point(0, 180);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(180, 60);
            btnBinary.TabIndex = 1;
            btnBinary.Text = "Binary Conv";
            btnBinary.UseVisualStyleBackColor = false;
            btnBinary.Click += btnBinary_Click;
            // 
            // btnPostfix
            // 
            btnPostfix.BackColor = Color.FromArgb(60, 60, 60);
            btnPostfix.Dock = DockStyle.Top;
            btnPostfix.FlatAppearance.BorderSize = 0;
            btnPostfix.FlatStyle = FlatStyle.Flat;
            btnPostfix.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPostfix.ForeColor = Color.White;
            btnPostfix.Location = new Point(0, 120);
            btnPostfix.Name = "btnPostfix";
            btnPostfix.Size = new Size(180, 60);
            btnPostfix.TabIndex = 2;
            btnPostfix.Text = "Postfix Eval";
            btnPostfix.UseVisualStyleBackColor = false;
            btnPostfix.Click += btnPostfix_Click;
            // 
            // btnQueue
            // 
            btnQueue.BackColor = Color.FromArgb(60, 60, 60);
            btnQueue.Dock = DockStyle.Top;
            btnQueue.FlatAppearance.BorderSize = 0;
            btnQueue.FlatStyle = FlatStyle.Flat;
            btnQueue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQueue.ForeColor = Color.White;
            btnQueue.Location = new Point(0, 60);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(180, 60);
            btnQueue.TabIndex = 3;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = false;
            btnQueue.Click += btnQueue_Click;
            // 
            // btnStack
            // 
            btnStack.BackColor = Color.FromArgb(60, 60, 60);
            btnStack.Dock = DockStyle.Top;
            btnStack.FlatAppearance.BorderSize = 0;
            btnStack.FlatStyle = FlatStyle.Flat;
            btnStack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStack.ForeColor = Color.White;
            btnStack.Location = new Point(0, 0);
            btnStack.Name = "btnStack";
            btnStack.Size = new Size(180, 60);
            btnStack.TabIndex = 4;
            btnStack.Text = "Stack";
            btnStack.UseVisualStyleBackColor = false;
            btnStack.Click += btnStack_Click;
            // 
            // panelStack
            // 
            panelStack.BackColor = Color.FromArgb(30, 30, 30);
            panelStack.Controls.Add(lblStackTitle);
            panelStack.Controls.Add(lblStackSizeLabel);
            panelStack.Controls.Add(txtStackSize);
            panelStack.Controls.Add(btnSetStackSize);
            panelStack.Controls.Add(lblStackInputEx);
            panelStack.Controls.Add(txtStackInput);
            panelStack.Controls.Add(btnPush);
            panelStack.Controls.Add(btnPop);
            panelStack.Controls.Add(btnPeek);
            panelStack.Controls.Add(btnIsEmpty);
            panelStack.Controls.Add(btnIsFull);
            panelStack.Controls.Add(lblStackDisplay);
            panelStack.Controls.Add(listStack);
            panelStack.Controls.Add(lblStackStatus);
            panelStack.Location = new Point(180, 0);
            panelStack.Name = "panelStack";
            panelStack.Size = new Size(720, 550);
            panelStack.TabIndex = 1;
            // 
            // lblStackTitle
            // 
            lblStackTitle.AutoSize = true;
            lblStackTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStackTitle.Location = new Point(30, 20);
            lblStackTitle.Name = "lblStackTitle";
            lblStackTitle.Size = new Size(283, 38);
            lblStackTitle.TabIndex = 0;
            lblStackTitle.Text = "STACK OPERATIONS";
            // 
            // lblStackSizeLabel
            // 
            lblStackSizeLabel.AutoSize = true;
            lblStackSizeLabel.Location = new Point(30, 70);
            lblStackSizeLabel.Name = "lblStackSizeLabel";
            lblStackSizeLabel.Size = new Size(123, 25);
            lblStackSizeLabel.TabIndex = 1;
            lblStackSizeLabel.Text = "Set Stack Size:";
            // 
            // txtStackSize
            // 
            txtStackSize.Font = new Font("Segoe UI", 10F);
            txtStackSize.Location = new Point(30, 95);
            txtStackSize.Name = "txtStackSize";
            txtStackSize.Size = new Size(100, 34);
            txtStackSize.TabIndex = 2;
            // 
            // btnSetStackSize
            // 
            btnSetStackSize.BackColor = Color.FromArgb(0, 120, 215);
            btnSetStackSize.FlatStyle = FlatStyle.Flat;
            btnSetStackSize.Location = new Point(140, 93);
            btnSetStackSize.Name = "btnSetStackSize";
            btnSetStackSize.Size = new Size(90, 27);
            btnSetStackSize.TabIndex = 3;
            btnSetStackSize.Text = "Set Size";
            btnSetStackSize.UseVisualStyleBackColor = false;
            btnSetStackSize.Click += btnSetStackSize_Click;
            // 
            // lblStackInputEx
            // 
            lblStackInputEx.AutoSize = true;
            lblStackInputEx.Location = new Point(30, 140);
            lblStackInputEx.Name = "lblStackInputEx";
            lblStackInputEx.Size = new Size(126, 25);
            lblStackInputEx.TabIndex = 4;
            lblStackInputEx.Text = "Enter Number:";
            // 
            // txtStackInput
            // 
            txtStackInput.Font = new Font("Segoe UI", 10F);
            txtStackInput.Location = new Point(30, 165);
            txtStackInput.Name = "txtStackInput";
            txtStackInput.Size = new Size(100, 34);
            txtStackInput.TabIndex = 5;
            // 
            // btnPush
            // 
            btnPush.BackColor = Color.FromArgb(0, 150, 80);
            btnPush.FlatStyle = FlatStyle.Flat;
            btnPush.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPush.Location = new Point(140, 163);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(90, 30);
            btnPush.TabIndex = 6;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = false;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.BackColor = Color.FromArgb(200, 80, 80);
            btnPop.FlatStyle = FlatStyle.Flat;
            btnPop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPop.Location = new Point(140, 200);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(90, 30);
            btnPop.TabIndex = 7;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = false;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.BackColor = Color.FromArgb(100, 100, 150);
            btnPeek.FlatStyle = FlatStyle.Flat;
            btnPeek.Location = new Point(140, 237);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(90, 30);
            btnPeek.TabIndex = 8;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = false;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnIsEmpty
            // 
            btnIsEmpty.BackColor = Color.FromArgb(100, 100, 150);
            btnIsEmpty.FlatStyle = FlatStyle.Flat;
            btnIsEmpty.Location = new Point(140, 274);
            btnIsEmpty.Name = "btnIsEmpty";
            btnIsEmpty.Size = new Size(90, 30);
            btnIsEmpty.TabIndex = 9;
            btnIsEmpty.Text = "IsEmpty";
            btnIsEmpty.UseVisualStyleBackColor = false;
            btnIsEmpty.Click += btnIsEmpty_Click;
            // 
            // btnIsFull
            // 
            btnIsFull.BackColor = Color.FromArgb(100, 100, 150);
            btnIsFull.FlatStyle = FlatStyle.Flat;
            btnIsFull.Location = new Point(140, 311);
            btnIsFull.Name = "btnIsFull";
            btnIsFull.Size = new Size(90, 30);
            btnIsFull.TabIndex = 10;
            btnIsFull.Text = "IsFull";
            btnIsFull.UseVisualStyleBackColor = false;
            btnIsFull.Click += btnIsFull_Click;
            // 
            // lblStackDisplay
            // 
            lblStackDisplay.AutoSize = true;
            lblStackDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStackDisplay.Location = new Point(280, 70);
            lblStackDisplay.Name = "lblStackDisplay";
            lblStackDisplay.Size = new Size(286, 25);
            lblStackDisplay.TabIndex = 11;
            lblStackDisplay.Text = "Stack Contents (Top to Bottom):";
            // 
            // listStack
            // 
            listStack.BackColor = Color.FromArgb(50, 50, 50);
            listStack.Font = new Font("Consolas", 10F);
            listStack.ForeColor = Color.White;
            listStack.ItemHeight = 23;
            listStack.Location = new Point(280, 95);
            listStack.Name = "listStack";
            listStack.Size = new Size(220, 280);
            listStack.TabIndex = 12;
            listStack.SelectedIndexChanged += listStack_SelectedIndexChanged;
            // 
            // lblStackStatus
            // 
            lblStackStatus.Font = new Font("Segoe UI", 9F);
            lblStackStatus.ForeColor = Color.FromArgb(100, 200, 255);
            lblStackStatus.Location = new Point(30, 390);
            lblStackStatus.Name = "lblStackStatus";
            lblStackStatus.Size = new Size(500, 50);
            lblStackStatus.TabIndex = 13;
            // 
            // panelQueue
            // 
            panelQueue.BackColor = Color.FromArgb(30, 30, 30);
            panelQueue.Controls.Add(lblQueueTitle);
            panelQueue.Controls.Add(lblQueueSizeLabel);
            panelQueue.Controls.Add(txtQueueSize);
            panelQueue.Controls.Add(btnSetQueueSize);
            panelQueue.Controls.Add(lblQueueInputEx);
            panelQueue.Controls.Add(txtQueueInput);
            panelQueue.Controls.Add(btnEnqueue);
            panelQueue.Controls.Add(btnDequeue);
            panelQueue.Controls.Add(btnQueueIsEmpty);
            panelQueue.Controls.Add(btnQueueIsFull);
            panelQueue.Controls.Add(lblQueueDisplay);
            panelQueue.Controls.Add(listQueue);
            panelQueue.Controls.Add(lblQueueStatus);
            panelQueue.Location = new Point(180, 0);
            panelQueue.Name = "panelQueue";
            panelQueue.Size = new Size(720, 550);
            panelQueue.TabIndex = 2;
            panelQueue.Visible = false;
            // 
            // lblQueueTitle
            // 
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblQueueTitle.Location = new Point(30, 20);
            lblQueueTitle.Name = "lblQueueTitle";
            lblQueueTitle.Size = new Size(289, 38);
            lblQueueTitle.TabIndex = 0;
            lblQueueTitle.Text = "QUEUE OPERATIONS";
            // 
            // lblQueueSizeLabel
            // 
            lblQueueSizeLabel.AutoSize = true;
            lblQueueSizeLabel.Location = new Point(30, 70);
            lblQueueSizeLabel.Name = "lblQueueSizeLabel";
            lblQueueSizeLabel.Size = new Size(134, 25);
            lblQueueSizeLabel.TabIndex = 1;
            lblQueueSizeLabel.Text = "Set Queue Size:";
            // 
            // txtQueueSize
            // 
            txtQueueSize.Font = new Font("Segoe UI", 10F);
            txtQueueSize.Location = new Point(30, 95);
            txtQueueSize.Name = "txtQueueSize";
            txtQueueSize.Size = new Size(100, 34);
            txtQueueSize.TabIndex = 2;
            // 
            // btnSetQueueSize
            // 
            btnSetQueueSize.BackColor = Color.FromArgb(0, 120, 215);
            btnSetQueueSize.FlatStyle = FlatStyle.Flat;
            btnSetQueueSize.Location = new Point(140, 93);
            btnSetQueueSize.Name = "btnSetQueueSize";
            btnSetQueueSize.Size = new Size(90, 27);
            btnSetQueueSize.TabIndex = 3;
            btnSetQueueSize.Text = "Set Size";
            btnSetQueueSize.UseVisualStyleBackColor = false;
            btnSetQueueSize.Click += btnSetQueueSize_Click;
            // 
            // lblQueueInputEx
            // 
            lblQueueInputEx.AutoSize = true;
            lblQueueInputEx.Location = new Point(30, 140);
            lblQueueInputEx.Name = "lblQueueInputEx";
            lblQueueInputEx.Size = new Size(126, 25);
            lblQueueInputEx.TabIndex = 4;
            lblQueueInputEx.Text = "Enter Number:";
            // 
            // txtQueueInput
            // 
            txtQueueInput.Font = new Font("Segoe UI", 10F);
            txtQueueInput.Location = new Point(30, 165);
            txtQueueInput.Name = "txtQueueInput";
            txtQueueInput.Size = new Size(100, 34);
            txtQueueInput.TabIndex = 5;
            // 
            // btnEnqueue
            // 
            btnEnqueue.BackColor = Color.FromArgb(0, 150, 80);
            btnEnqueue.FlatStyle = FlatStyle.Flat;
            btnEnqueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnqueue.Location = new Point(140, 163);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(90, 30);
            btnEnqueue.TabIndex = 6;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = false;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.BackColor = Color.FromArgb(200, 80, 80);
            btnDequeue.FlatStyle = FlatStyle.Flat;
            btnDequeue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDequeue.Location = new Point(140, 200);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(90, 30);
            btnDequeue.TabIndex = 7;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = false;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnQueueIsEmpty
            // 
            btnQueueIsEmpty.BackColor = Color.FromArgb(100, 100, 150);
            btnQueueIsEmpty.FlatStyle = FlatStyle.Flat;
            btnQueueIsEmpty.Location = new Point(140, 237);
            btnQueueIsEmpty.Name = "btnQueueIsEmpty";
            btnQueueIsEmpty.Size = new Size(90, 30);
            btnQueueIsEmpty.TabIndex = 8;
            btnQueueIsEmpty.Text = "IsEmpty";
            btnQueueIsEmpty.UseVisualStyleBackColor = false;
            btnQueueIsEmpty.Click += btnQueueIsEmpty_Click;
            // 
            // btnQueueIsFull
            // 
            btnQueueIsFull.BackColor = Color.FromArgb(100, 100, 150);
            btnQueueIsFull.FlatStyle = FlatStyle.Flat;
            btnQueueIsFull.Location = new Point(140, 274);
            btnQueueIsFull.Name = "btnQueueIsFull";
            btnQueueIsFull.Size = new Size(90, 30);
            btnQueueIsFull.TabIndex = 9;
            btnQueueIsFull.Text = "IsFull";
            btnQueueIsFull.UseVisualStyleBackColor = false;
            btnQueueIsFull.Click += btnQueueIsFull_Click;
            // 
            // lblQueueDisplay
            // 
            lblQueueDisplay.AutoSize = true;
            lblQueueDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQueueDisplay.Location = new Point(280, 70);
            lblQueueDisplay.Name = "lblQueueDisplay";
            lblQueueDisplay.Size = new Size(285, 25);
            lblQueueDisplay.TabIndex = 10;
            lblQueueDisplay.Text = "Queue Contents (Front to Rear):";
            // 
            // listQueue
            // 
            listQueue.BackColor = Color.FromArgb(50, 50, 50);
            listQueue.Font = new Font("Consolas", 10F);
            listQueue.ForeColor = Color.White;
            listQueue.ItemHeight = 23;
            listQueue.Location = new Point(280, 95);
            listQueue.Name = "listQueue";
            listQueue.Size = new Size(220, 280);
            listQueue.TabIndex = 11;
            // 
            // lblQueueStatus
            // 
            lblQueueStatus.Font = new Font("Segoe UI", 9F);
            lblQueueStatus.ForeColor = Color.FromArgb(100, 200, 255);
            lblQueueStatus.Location = new Point(30, 390);
            lblQueueStatus.Name = "lblQueueStatus";
            lblQueueStatus.Size = new Size(500, 50);
            lblQueueStatus.TabIndex = 12;
            // 
            // panelPostfix
            // 
            panelPostfix.BackColor = Color.FromArgb(30, 30, 30);
            panelPostfix.Controls.Add(lblPostfixTitle);
            panelPostfix.Controls.Add(lblPostfixExample);
            panelPostfix.Controls.Add(lblPostfixInputLabel);
            panelPostfix.Controls.Add(txtPostfixInput);
            panelPostfix.Controls.Add(btnEvaluatePostfix);
            panelPostfix.Controls.Add(lblPostfixResult);
            panelPostfix.Location = new Point(180, 0);
            panelPostfix.Name = "panelPostfix";
            panelPostfix.Size = new Size(720, 550);
            panelPostfix.TabIndex = 3;
            panelPostfix.Visible = false;
            // 
            // lblPostfixTitle
            // 
            lblPostfixTitle.AutoSize = true;
            lblPostfixTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPostfixTitle.Location = new Point(220, 80);
            lblPostfixTitle.Name = "lblPostfixTitle";
            lblPostfixTitle.Size = new Size(308, 38);
            lblPostfixTitle.TabIndex = 0;
            lblPostfixTitle.Text = "POSTFIX EVALUATION";
            // 
            // lblPostfixExample
            // 
            lblPostfixExample.AutoSize = true;
            lblPostfixExample.ForeColor = Color.FromArgb(150, 150, 150);
            lblPostfixExample.Location = new Point(220, 130);
            lblPostfixExample.Name = "lblPostfixExample";
            lblPostfixExample.Size = new Size(276, 25);
            lblPostfixExample.TabIndex = 1;
            lblPostfixExample.Text = "Example: 12 3 * 5 +  (Result = 41)";
            // 
            // lblPostfixInputLabel
            // 
            lblPostfixInputLabel.AutoSize = true;
            lblPostfixInputLabel.Location = new Point(220, 170);
            lblPostfixInputLabel.Name = "lblPostfixInputLabel";
            lblPostfixInputLabel.Size = new Size(202, 25);
            lblPostfixInputLabel.TabIndex = 2;
            lblPostfixInputLabel.Text = "Enter Postfix Expression:";
            // 
            // txtPostfixInput
            // 
            txtPostfixInput.Font = new Font("Consolas", 11F);
            txtPostfixInput.Location = new Point(220, 195);
            txtPostfixInput.Name = "txtPostfixInput";
            txtPostfixInput.Size = new Size(320, 33);
            txtPostfixInput.TabIndex = 3;
            // 
            // btnEvaluatePostfix
            // 
            btnEvaluatePostfix.BackColor = Color.FromArgb(0, 120, 215);
            btnEvaluatePostfix.FlatStyle = FlatStyle.Flat;
            btnEvaluatePostfix.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEvaluatePostfix.Location = new Point(300, 235);
            btnEvaluatePostfix.Name = "btnEvaluatePostfix";
            btnEvaluatePostfix.Size = new Size(150, 35);
            btnEvaluatePostfix.TabIndex = 4;
            btnEvaluatePostfix.Text = "Evaluate";
            btnEvaluatePostfix.UseVisualStyleBackColor = false;
            btnEvaluatePostfix.Click += btnEvaluatePostfix_Click;
            // 
            // lblPostfixResult
            // 
            lblPostfixResult.Font = new Font("Segoe UI", 12F);
            lblPostfixResult.ForeColor = Color.FromArgb(100, 255, 100);
            lblPostfixResult.Location = new Point(220, 290);
            lblPostfixResult.Name = "lblPostfixResult";
            lblPostfixResult.Size = new Size(400, 80);
            lblPostfixResult.TabIndex = 5;
            // 
            // panelBinary
            // 
            panelBinary.BackColor = Color.FromArgb(30, 30, 30);
            panelBinary.Controls.Add(lblBinaryTitle);
            panelBinary.Controls.Add(lblBinaryInputEx);
            panelBinary.Controls.Add(txtDecimalInput);
            panelBinary.Controls.Add(btnConvertBinary);
            panelBinary.Controls.Add(lblBinarySteps);
            panelBinary.Controls.Add(listBinary);
            panelBinary.Controls.Add(lblBinaryResult);
            panelBinary.Location = new Point(180, 0);
            panelBinary.Name = "panelBinary";
            panelBinary.Size = new Size(720, 550);
            panelBinary.TabIndex = 4;
            panelBinary.Visible = false;
            // 
            // lblBinaryTitle
            // 
            lblBinaryTitle.AutoSize = true;
            lblBinaryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBinaryTitle.Location = new Point(30, 20);
            lblBinaryTitle.Name = "lblBinaryTitle";
            lblBinaryTitle.Size = new Size(484, 38);
            lblBinaryTitle.TabIndex = 0;
            lblBinaryTitle.Text = "DECIMAL TO BINARY CONVERSION";
            // 
            // lblBinaryInputEx
            // 
            lblBinaryInputEx.AutoSize = true;
            lblBinaryInputEx.Location = new Point(30, 70);
            lblBinaryInputEx.Name = "lblBinaryInputEx";
            lblBinaryInputEx.Size = new Size(194, 25);
            lblBinaryInputEx.TabIndex = 1;
            lblBinaryInputEx.Text = "Enter Decimal Number:";
            // 
            // txtDecimalInput
            // 
            txtDecimalInput.Font = new Font("Segoe UI", 10F);
            txtDecimalInput.Location = new Point(30, 95);
            txtDecimalInput.Name = "txtDecimalInput";
            txtDecimalInput.Size = new Size(130, 34);
            txtDecimalInput.TabIndex = 2;
            // 
            // btnConvertBinary
            // 
            btnConvertBinary.BackColor = Color.FromArgb(0, 120, 215);
            btnConvertBinary.FlatStyle = FlatStyle.Flat;
            btnConvertBinary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvertBinary.Location = new Point(170, 93);
            btnConvertBinary.Name = "btnConvertBinary";
            btnConvertBinary.Size = new Size(110, 28);
            btnConvertBinary.TabIndex = 3;
            btnConvertBinary.Text = "Convert";
            btnConvertBinary.UseVisualStyleBackColor = false;
            btnConvertBinary.Click += btnConvertBinary_Click;
            // 
            // lblBinarySteps
            // 
            lblBinarySteps.AutoSize = true;
            lblBinarySteps.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBinarySteps.Location = new Point(30, 145);
            lblBinarySteps.Name = "lblBinarySteps";
            lblBinarySteps.Size = new Size(163, 25);
            lblBinarySteps.TabIndex = 4;
            lblBinarySteps.Text = "Conversion Steps:";
            // 
            // listBinary
            // 
            listBinary.BackColor = Color.FromArgb(50, 50, 50);
            listBinary.Font = new Font("Consolas", 10F);
            listBinary.ForeColor = Color.White;
            listBinary.ItemHeight = 23;
            listBinary.Location = new Point(30, 170);
            listBinary.Name = "listBinary";
            listBinary.Size = new Size(320, 188);
            listBinary.TabIndex = 5;
            // 
            // lblBinaryResult
            // 
            lblBinaryResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBinaryResult.ForeColor = Color.FromArgb(100, 255, 100);
            lblBinaryResult.Location = new Point(30, 385);
            lblBinaryResult.Name = "lblBinaryResult";
            lblBinaryResult.Size = new Size(550, 50);
            lblBinaryResult.TabIndex = 6;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(900, 550);
            Controls.Add(panelMenu);
            Controls.Add(panelStack);
            Controls.Add(panelQueue);
            Controls.Add(panelPostfix);
            Controls.Add(panelBinary);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stack & Queue Case Study";
            panelMenu.ResumeLayout(false);
            panelStack.ResumeLayout(false);
            panelStack.PerformLayout();
            panelQueue.ResumeLayout(false);
            panelQueue.PerformLayout();
            panelPostfix.ResumeLayout(false);
            panelPostfix.PerformLayout();
            panelBinary.ResumeLayout(false);
            panelBinary.PerformLayout();
            ResumeLayout(false);
        }

        // === UI COMPONENTS ===
        private Panel panelStack, panelQueue, panelPostfix, panelBinary;
        private TextBox txtStackInput, txtStackSize, txtQueueInput, txtQueueSize, txtPostfixInput, txtDecimalInput;
        private ListBox listStack, listQueue, listBinary;
        private Label lblStackStatus, lblQueueStatus, lblPostfixResult, lblBinaryResult;
        private Panel panelMenu;
        private Button btnExit;
        private Button btnBinary;
        private Button btnPostfix;
        private Button btnQueue;
        private Button btnStack;
        private Label lblStackTitle;
        private Label lblStackSizeLabel;
        private Button btnSetStackSize;
        private Label lblStackInputEx;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private Button btnIsEmpty;
        private Button btnIsFull;
        private Label lblStackDisplay;
        private Label lblQueueTitle;
        private Label lblQueueSizeLabel;
        private Button btnSetQueueSize;
        private Label lblQueueInputEx;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnQueueIsEmpty;
        private Button btnQueueIsFull;
        private Label lblQueueDisplay;
        private Label lblPostfixTitle;
        private Label lblPostfixExample;
        private Label lblPostfixInputLabel;
        private Button btnEvaluatePostfix;
        private Label lblBinaryTitle;
        private Label lblBinaryInputEx;
        private Button btnConvertBinary;
        private Label lblBinarySteps;
    }
}