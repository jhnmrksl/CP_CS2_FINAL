namespace CP_CS2
{
    public partial class Form11 : Form
    {
        int i;

        public Form11(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "" || txtName.Text == "" || txtPin.Text == "")
            {
                MessageBox.Show("All inputs are required!");
            }
            else
            {
                for (int i = 0; i < Accounts.accNumber.Length; i++)
                {

                    if (txtNum.Text == Accounts.accNumber[i])
                    {
                        MessageBox.Show("Account already exists!");
                        return;
                    }
                }

                Array.Resize(ref Accounts.accNumber, Accounts.accNumber.Length + 1);
                Accounts.accNumber[Accounts.accNumber.Length - 1] = txtNum.Text;

                Array.Resize(ref Accounts.accName, Accounts.accName.Length + 1);
                Accounts.accName[Accounts.accName.Length - 1] = txtName.Text;

                Array.Resize(ref Accounts.accPin, Accounts.accPin.Length + 1);
                Accounts.accPin[Accounts.accPin.Length - 1] = txtPin.Text;

                Array.Resize(ref Accounts.bal, Accounts.bal.Length + 1);
                Accounts.bal[Accounts.bal.Length - 1] = 0;

                Array.Resize(ref Accounts.accStat, Accounts.accStat.Length + 1);
                Accounts.accStat[Accounts.accStat.Length - 1] = "Active";

                MessageBox.Show("Account successfully created!");
            }


        }
    }
}
