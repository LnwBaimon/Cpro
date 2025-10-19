namespace Cal
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void num_1_Click(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal_Click(object sender, EventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || operationPressed)
                display.Clear();

            operationPressed = false;
            Button b = (Button)sender;
            display.Text += b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(display.Text);
            operationPressed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(display.Text);
            switch (operation)
            {
                case "+": display.Text = (value + secondValue).ToString(); break;
                case "-": display.Text = (value - secondValue).ToString(); break;
                case "*": display.Text = (value * secondValue).ToString(); break;
                case "/":
                    display.Text = secondValue != 0 ?
                        (value / secondValue).ToString() : "Error";
                    break;
            }

            operationPressed = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            value = 0;
            operation = "";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Cursor = Cursors.Hand;
                }
            }
        }
    }
}
