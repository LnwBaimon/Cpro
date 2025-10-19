namespace Slot
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int winCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
            win.Text = "Wins: 0";
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
        
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);
            int num3 = rand.Next(1, 10);
 
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();

            if (num1 == num2 && num2 == num3)
            {
                winCount++;
                win.Text = $"Wins: {winCount}";
                MessageBox.Show("🎉 Nice win!", "Damn Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            winCount = 0;
            win.Text = "Wins: 0";
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = rand.Next(1, 10).ToString();
            label2.Text = rand.Next(1, 10).ToString();
            label3.Text = rand.Next(1, 10).ToString();
        }

        private async void StopSpin()
        {
            await Task.Delay(1000); 
            timer1.Stop();

            int num1 = int.Parse(label1.Text);
            int num2 = int.Parse(label2.Text);
            int num3 = int.Parse(label3.Text);

            if (num1 == num2 && num2 == num3)
            {
                winCount++;
                win.Text = $"Wins: {winCount}";
                MessageBox.Show("🎉 Nice win");
            }
        }

        private void Spin_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
