using System;
using System.Linq;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        // --- Stack variables ---
        int[] stackArray;
        int stackTop = -1;
        int stackSize = 0;

        // --- Queue variables (Circular) ---
        int[] queueArray;
        int front = 0;    // Index of the first item
        int rear = 0;     // Index of the *next available* slot
        int queueCount = 0; // Number of items in the queue
        int queueSize = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // ========== MENU NAVIGATION ==========
        private void btnStack_Click(object sender, EventArgs e)
        {
            ShowPanel(panelStack);
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            ShowPanel(panelQueue);
        }

        private void btnPostfix_Click(object sender, EventArgs e)
        {
            ShowPanel(panelPostfix);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            ShowPanel(panelBinary);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPanel(Panel p)
        {
            panelStack.Visible = false;
            panelQueue.Visible = false;
            panelPostfix.Visible = false;
            panelBinary.Visible = false;
            p.Visible = true;
        }

        // ================== STACK SECTION ==================
        private void btnSetStackSize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStackSize.Text, out stackSize) && stackSize > 0)
            {
                stackArray = new int[stackSize];
                stackTop = -1;
                lblStackStatus.Text = $"Stack size set to {stackSize}.";
            }
            else lblStackStatus.Text = "Invalid size. Please enter a positive number.";
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (stackArray == null)
            {
                lblStackStatus.Text = "?? Set the stack size first.";
                return;
            }
            if (stackTop == stackSize - 1)
            {
                lblStackStatus.Text = "Stack Overflow!";
                return;
            }
            if (int.TryParse(txtStackInput.Text, out int value))
            {
                stackTop++;
                stackArray[stackTop] = value;
                lblStackStatus.Text = $"Pushed {value} to stack.";
                DisplayStack();
                txtStackInput.Clear();
            }
            else lblStackStatus.Text = "Enter a valid number.";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stackArray == null)
            {
                lblStackStatus.Text = "?? Set the stack size first.";
                return;
            }
            if (stackTop == -1)
            {
                lblStackStatus.Text = "Stack Underflow!";
                return;
            }
            int popped = stackArray[stackTop--];
            lblStackStatus.Text = $"Popped {popped} from stack.";
            DisplayStack();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (stackTop == -1)
                lblStackStatus.Text = "Stack is empty.";
            else
                lblStackStatus.Text = $"Top element: {stackArray[stackTop]}";
        }

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            lblStackStatus.Text = stackTop == -1 ? "Stack is empty." : "Stack is not empty.";
        }

        private void btnIsFull_Click(object sender, EventArgs e)
        {
            lblStackStatus.Text = (stackTop == stackSize - 1) ? "Stack is full." : "Stack is not full.";
        }

        private void DisplayStack()
        {
            listStack.Items.Clear();
            for (int i = stackTop; i >= 0; i--)
                listStack.Items.Add(stackArray[i]);
        }

        // ================== QUEUE SECTION (CIRCULAR) ==================
        private void btnSetQueueSize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQueueSize.Text, out queueSize) && queueSize > 0)
            {
                queueArray = new int[queueSize];
                front = 0;
                rear = 0;
                queueCount = 0; // Reset count
                lblQueueStatus.Text = $"Queue size set to {queueSize}.";
                DisplayQueue();
            }
            else lblQueueStatus.Text = "Invalid size. Please enter a positive number.";
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (queueArray == null)
            {
                lblQueueStatus.Text = "?? Set the queue size first.";
                return;
            }
            // Use queueCount to check if full
            if (queueCount == queueSize)
            {
                lblQueueStatus.Text = "Queue Overflow!";
                return;
            }
            if (int.TryParse(txtQueueInput.Text, out int value))
            {
                queueArray[rear] = value;
                rear = (rear + 1) % queueSize; // Wrap around if at the end
                queueCount++; // Increment count
                lblQueueStatus.Text = $"Enqueued {value}.";
                DisplayQueue();
                txtQueueInput.Clear();
            }
            else lblQueueStatus.Text = "Enter a valid number.";
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            // Use queueCount to check if empty
            if (queueCount == 0)
            {
                lblQueueStatus.Text = "Queue Underflow!";
                return;
            }

            int dequeued = queueArray[front];
            front = (front + 1) % queueSize; // Wrap around if at the end
            queueCount--; // Decrement count
            lblQueueStatus.Text = $"Dequeued {dequeued}.";
            DisplayQueue();
        }

        private void btnQueueIsEmpty_Click(object sender, EventArgs e)
        {
            // Check count
            lblQueueStatus.Text = (queueCount == 0) ? "Queue is empty." : "Queue has elements.";
        }

        private void btnQueueIsFull_Click(object sender, EventArgs e)
        {
            // Check count
            lblQueueStatus.Text = (queueCount == queueSize) ? "Queue is full." : "Queue is not full.";
        }

        private void DisplayQueue()
        {
            listQueue.Items.Clear();
            if (queueCount == 0) return;

            // Loop from front, 'queueCount' times
            int i = front;
            for (int c = 0; c < queueCount; c++)
            {
                listQueue.Items.Add(queueArray[i]);
                i = (i + 1) % queueSize; // Move to next item, wrapping if necessary
            }
        }

        // ================== POSTFIX EVALUATION ==================
        private void btnEvaluatePostfix_Click(object sender, EventArgs e)
        {
            string expression = txtPostfixInput.Text.Trim();
            if (string.IsNullOrEmpty(expression))
            {
                lblPostfixResult.Text = "Enter a postfix expression.";
                return;
            }

            try
            {
                double result = EvaluatePostfix(expression);
                lblPostfixResult.Text = $"Result: {result}";
            }
            catch (Exception ex)
            {
                lblPostfixResult.Text = $"Error: {ex.Message}";
            }
        }

        private double EvaluatePostfix(string expr)
        {
            string[] tokens = expr.Split(' ');
            double[] stack = new double[100];
            int top = -1;

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double num))
                {
                    stack[++top] = num;
                }
                else
                {
                    if (top < 1)
                        throw new Exception("Invalid Expression!");

                    double b = stack[top--];
                    double a = stack[top--];
                    double res = token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b == 0 ? throw new DivideByZeroException() : a / b,
                        _ => throw new Exception("Invalid Operator!")
                    };
                    stack[++top] = res;
                }
            }
            return stack[top];
        }

        // ================== DECIMAL TO BINARY ==================
        private void btnConvertBinary_Click(object sender, EventArgs e)
        {
            listBinary.Items.Clear();
            if (!int.TryParse(txtDecimalInput.Text, out int num) || num < 0)
            {
                lblBinaryResult.Text = "Enter a valid non-negative integer.";
                return;
            }

            if (num == 0)
            {
                listBinary.Items.Add("Push remainder 0");
                lblBinaryResult.Text = "Binary: 0";
                return;
            }

            int[] stack = new int[100];
            int top = -1;
            int temp = num;

            // Push process
            while (temp > 0)
            {
                int remainder = temp % 2;
                stack[++top] = remainder;
                listBinary.Items.Add($"Push remainder {remainder}");
                temp /= 2;
            }

            // Pop process
            string binary = "";
            while (top >= 0)
            {
                listBinary.Items.Add($"Pop {stack[top]}");
                binary += stack[top--].ToString();
            }

            lblBinaryResult.Text = $"Binary: {binary}";
        }

        private void listStack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}