namespace CP_CS2
{
    public partial class Form6 : Form
    {

        decimal[] bal;
        int i;

        public Form6(int i, decimal[] bal)
        {
            InitializeComponent();
            this.i = i;
            this.bal = bal;

            this.KeyPreview = true;
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (decimal.TryParse(txtAmount.Text.Replace("₱", "").Trim(), out decimal amount))
                {
                    txtAmount.Text = "₱" + amount.ToString("N2");
                }

                else
                {
                    MessageBox.Show("Invalid amount.");
                }

                e.SuppressKeyPress = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string input = txtAmount.Text.Replace("₱", "").Trim();

            if (!decimal.TryParse(input, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                txtAmount.Clear();
                return;
            }

            if (amount < 100)
            {
                MessageBox.Show("Minimum Deposit is ₱100.00");
                txtAmount.Clear();
                return;
            }

            bal[i] += amount;

            MessageBox.Show("Deposit Successful!\nNew Balance: ₱" + bal[i].ToString("N2"));
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtAmount.PlaceholderText = "Enter amount";
        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
