using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace CP_CS2
{
    public partial class Form13 : Form
    {

        int i;

        public Form13(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool senderExist = false;
            bool receiverExist = false;
            decimal price = decimal.Parse(txtAmount.Text);

            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {

                if (txtSender.Text == Accounts.accNumber[i])
                {
                    senderExist = true;
                }

            }

            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {

                if (txtReceive.Text == Accounts.accNumber[i])
                {
                    receiverExist = true;
                }

            }

            if (!senderExist)
            {
                MessageBox.Show("Account sender does not exist!");
                return;
            }
            else if (!receiverExist)
            {
                MessageBox.Show("Account receiver does not exist!");
                return;
            }

            if (txtSender.Text == txtReceive.Text)
            {
                MessageBox.Show("Transfer accounts must not match!");
                return;
            }
            else
            {

                if (price <= 0)
                {
                    MessageBox.Show("Transfer amount is too small after fees.");
                    return;
                }

                if (price > Accounts.bal[i])
                {
                    MessageBox.Show("Insufficient balance.");
                    return;
                }
                else
                {
                    for (int i = 0; i < Accounts.accNumber.Length; i++)
                    {

                        if (txtReceive.Text == Accounts.accNumber[i])
                        {
                            Accounts.bal[i] += price;
                        }
                    }

                    for (int i = 0; i < Accounts.accNumber.Length; i++)
                    {

                        if (txtSender.Text == Accounts.accNumber[i])
                        {
                            Accounts.bal[i] -= price;
                        }
                    }

                }
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
