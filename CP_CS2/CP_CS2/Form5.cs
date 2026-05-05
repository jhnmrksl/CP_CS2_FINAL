namespace CP_CS2
{
    public partial class Form5 : Form
    {

        decimal[] bal;
        int i;

        public Form5(int i, decimal[] bal)
        {
            InitializeComponent();
            this.i = i;
            this.bal = bal;

            this.KeyPreview = true;
        }

        private void withdraw(decimal amount)
        {
            if (amount < 100)
            {
                MessageBox.Show("Minimum Withdrawal is ₱100.00");
                return;
            }

            if (amount % 100 != 0)
            {
                MessageBox.Show("Amount MUST be in ₱100.00 denominations.");
                return;
            }

            if (amount > bal[i])
            {
                MessageBox.Show($"Insufficient balance. \nCurrent Balance: ₱{bal[i]:N2}");
                return;
            }

            bal[i] -= amount;

            MessageBox.Show("Withdrawal Successful! \nNew Balance: ₱" + bal[i].ToString("N2"));
            this.Close();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            withdraw(200);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            withdraw(100);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            withdraw(500);
        }

        private void txtCustom_Enter(object sender, EventArgs e)
        {
            txtCustom.Text = txtCustom.Text.Replace("₱", "");
        }

        private void txtCustom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (decimal.TryParse(txtCustom.Text.Replace("₱", "").Trim(), out decimal amount))
                {
                    txtCustom.Text = "₱" + amount.ToString("N2");
                }

                else
                {
                    MessageBox.Show("Invalid amount.");
                }

                e.SuppressKeyPress = true;
            }
        }

        private void btnWithdrawCustom_Click(object sender, EventArgs e)
        {

            string input = txtCustom.Text.Replace("₱", "").Trim();

            if (!decimal.TryParse(input, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            withdraw(amount);
            txtCustom.Clear();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtCustom.PlaceholderText = "Enter amount";
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
