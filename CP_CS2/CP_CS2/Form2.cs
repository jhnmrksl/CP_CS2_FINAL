using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
namespace CP_CS2
{
    public partial class Form2 : Form
    {
        string[] admins =
        {
            "0000-0000-0000", "0000"
        };

        int[] loginAttempt = { 0, 0, 0, 0, 0};

        public Form2()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            txtAcc.Clear();
            txtPin.Clear();
            this.ActiveControl = null;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtAcc.PlaceholderText = "xxxx-xxxx-xxxx";
            txtPin.PlaceholderText = "xxxx";
        }

        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void txtAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length < 4)
            {
                txtPin.Text += "0";
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length > 0)
            {
                txtPin.Text = txtPin.Text.Substring(0, txtPin.Text.Length - 1);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {
                if (txtAcc.Text == Accounts.accNumber[i] && Accounts.accStat[i] == "Blocked")
                {
                    MessageBox.Show("This account is BLOCKED.");
                    return;
                }

                if (txtAcc.Text == Accounts.accNumber[i] && txtPin.Text == Accounts.accPin[i])
                {
                    loginAttempt[i] = 0;
                    txtPin.Clear();

                    CP_CS2.Form3 transaction = new CP_CS2.Form3(i);

                    this.Hide();

                    transaction.ShowDialog();

                    return;
                }

                if (txtAcc.Text == admins[0] && txtPin.Text == admins[1])
                {
                    loginAttempt[i] = 0;
                    txtPin.Clear();

                    CP_CS2.Form8 admin = new CP_CS2.Form8(i);

                    this.Hide();

                    admin.ShowDialog();

                    return;
                }

                else if (txtAcc.Text == Accounts.accNumber[i])
                {
                    loginAttempt[i]++;
                    int remainingAttempt = 3 - loginAttempt[i];

                    if (remainingAttempt > 0)
                    {
                        MessageBox.Show("Wrong PIN. Attempts Left: " + remainingAttempt);
                    }
                    else
                    {
                        Accounts.accStat[i] = "Blocked";
                        MessageBox.Show("Account BLOCKED due to 3 FAILED ATTEMPTS.");
                    }

                    txtPin.Clear();
                    return;
                }
            }

            MessageBox.Show("Invalid User.");
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
