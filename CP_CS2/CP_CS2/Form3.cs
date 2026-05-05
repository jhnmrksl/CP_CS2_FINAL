namespace CP_CS2
{
    public partial class Form3 : Form
    {

        int i;
        string[] accName;
        string[] accNumber;
        decimal[] bal;

        Form2 parent;

        public Form3(int i)
        {
            InitializeComponent();
            this.i = i;
            this.accNumber = Accounts.accNumber;
            this.accName = Accounts.accName;
            this.bal = Accounts.bal;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form4 balInquiry = new CP_CS2.Form4(i, accNumber, accName, bal);
            balInquiry.ShowDialog();

            this.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form5 balWithdraw = new CP_CS2.Form5(i, bal);
            balWithdraw.ShowDialog();

            this.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form6 balDeposit = new CP_CS2.Form6(i, bal);
            balDeposit.ShowDialog();

            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form7 balTrans = new CP_CS2.Form7(accNumber, accName, i, bal, parent);
            balTrans.ShowDialog();

            this.Show();
        }
    }
}
