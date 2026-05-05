namespace CP_CS2
{
    public partial class Form4 : Form
    {

        int i;
        string[] accNumber;
        string[] accName;
        decimal[] bal;

        public Form4(int i, string[] accNumber, string[] accName, decimal[] bal)
        {
            InitializeComponent();
            this.i = i;
            this.accNumber = accNumber;
            this.accName = accName;
            this.bal = bal;
        }

        private void refresh()
        {
            lblAccName.Text = accName[i];
            lblBal.Text = "₱" + bal[i].ToString("N2");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            refresh();

            this.ActiveControl = null;
        }
    }
}
