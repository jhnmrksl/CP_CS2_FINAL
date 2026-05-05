namespace CP_CS2
{
    public partial class Form8 : Form
    {
        int i;

        public Form8(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form10 viewInfo = new CP_CS2.Form10(i);
            viewInfo.ShowDialog();

            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form9 searchAcc = new CP_CS2.Form9(i);
            searchAcc.ShowDialog();

            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form11 addAcc = new CP_CS2.Form11(i);
            addAcc.ShowDialog();

            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form12 editName = new CP_CS2.Form12(i);
            editName.ShowDialog();

            this.Show();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form14 changePin = new CP_CS2.Form14(i);
            changePin.ShowDialog();

            this.Show();
        }

        private void btsTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form13 transFunds = new CP_CS2.Form13(i);
            transFunds.ShowDialog();

            this.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();

            CP_CS2.Form15 changeStats = new CP_CS2.Form15(i);
            changeStats.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
