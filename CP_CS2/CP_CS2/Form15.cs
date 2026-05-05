namespace CP_CS2
{
    public partial class Form15 : Form
    {
        int i;
        public Form15(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {
                if (txtNum.Text == Accounts.accNumber[i])
                {
                    if (Accounts.accStat[i] == "Active")
                    {
                        Accounts.accStat[i] = "Blocked";
                        MessageBox.Show("Account status has been updated!");
                        return;
                    }
                    else
                    {
                        Accounts.accStat[i] = "Active";
                        MessageBox.Show("Account status has been updated!");
                        return;
                    }
                }
            }
        }
    }
}
