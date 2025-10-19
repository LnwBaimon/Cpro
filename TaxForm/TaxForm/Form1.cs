namespace TaxForm
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double purchaseAmt, percent;
            string inValue;
            inValue = txtPurchase.Text;
            purchaseAmt = double .Parse(inValue);
            inValue = perc.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent = double.Parse(inValue) / 100;
            double ans;

            ans = (purchaseAmt * percent) + purchaseAmt;

            txtTotalDue.Text = String.Format("{0:C}", ans).ToString();
        }
    }
}
