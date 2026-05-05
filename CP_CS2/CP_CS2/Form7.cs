namespace CP_CS2
{
    public partial class Form7 : Form
    {

        decimal[] bal;
        int i;
        string[] accNumber;
        string[] accName;

        Form2 parent;

        public Form7(string[] accNumber, string[] accName, int i, decimal[] bal, Form2 parent)
        {
            InitializeComponent();
            this.accNumber = accNumber;
            this.accName = accName;
            this.i = i;
            this.bal = bal;
            this.parent = parent;

            this.KeyPreview = true;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            txtAccNo.PlaceholderText = "Enter recipient number";
            txtFunds.PlaceholderText = "Enter amount";
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string recipientAcc = txtAccNo.Text.Trim();
            string input = txtFunds.Text.Replace("₱", "").Trim();

            if (!decimal.TryParse(input, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                txtFunds.Clear();
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Enter a valid transfer amount.");
                txtFunds.Clear();
                return;
            }

            if (amount > bal[i])
            {
                MessageBox.Show("Insufficient balance.");
                txtFunds.Clear();
                return;
            }

            int recipientIndex = -1;

            for (int j = 0; j < accNumber.Length; j++)
            {
                if (accNumber[j] == recipientAcc)
                {
                    recipientIndex = j;
                    break;
                }
            }

            if (recipientIndex == -1)
            {
                MessageBox.Show("That account is not found.");
                txtAccNo.Clear();
                txtFunds.Clear();
                return;
            }

            else if (recipientIndex == i)
            {
                MessageBox.Show("You cannot transfer to your own account.");
                txtAccNo.Clear();
                return;
            }

            decimal fee = 0;

            if (amount >= 1000m)
            {
                fee = Math.Ceiling(amount / 1000m) * 25;
            }

            decimal receivedAmount = amount - fee;

            if (receivedAmount <= 0)
            {
                MessageBox.Show("Transfer amount is too small after fees.");
                return;
            }

            bal[i] -= amount;
            bal[recipientIndex] += receivedAmount;

            MessageBox.Show("Transfer Successful!\n\n" + "Sent: ₱" + amount.ToString("N2") + "\nFee Deducted: ₱" + fee.ToString("N2") + 
                "\nRecipient Received: ₱" + receivedAmount.ToString("N2") + "\nTo: " + accName[recipientIndex] + "\nNew Balance: ₱" + 
                bal[i].ToString("N2"));

            Refresh();
            this.Close();
        }
    }
}
