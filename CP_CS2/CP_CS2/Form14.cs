using System.Xml.Linq;

namespace CP_CS2
{
    public partial class Form14 : Form
    {
        int i;
        public Form14(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {

                if (txtNum.Text == Accounts.accNumber[i])
                {
                    Accounts.accPin[i] = txtPin.Text;
                    MessageBox.Show("Account Pin has been updated!");
                    return;
                }
                else
                {
                    MessageBox.Show("Account does not exist!");
                    return;
                }
            }
        }
    }
}
