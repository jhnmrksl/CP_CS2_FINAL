using CP_CS2;

namespace CP_CS2
{
    public partial class Form12 : Form
    {

        int i;

        public Form12(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {

                if (txtNum.Text == Accounts.accNumber[i])
                {
                    Accounts.accName[i] = txtName.Text;
                    MessageBox.Show("Account has been updated!");
                }
                else
                {
                    MessageBox.Show("Account does not exist!");
                }
            }
        }
    }
}
