namespace CP_CS2
{
    public partial class Form9 : Form
    {
        int i;

        public Form9(int i)
        {
            InitializeComponent();
            this.i = i;

            this.KeyPreview = true;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            txtAcc.PlaceholderText = "Enter account number";
        }

        private void Form9_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {

                if (txtAcc.Text == Accounts.accNumber[i])
                {
                    MessageBox.Show("Account Number: " + Accounts.accNumber[i] + "\nAccount Name: " + Accounts.accName[i] +
                        "\nAccount Pin: " + Accounts.accPin[i] + "\nCurrent Balance: ₱" + Accounts.bal[i] + "\nCurrent Status: "
                        + Accounts.accStat[i]);
                    this.Show();
                    return;
                }
            }
        }

        private void lblInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
