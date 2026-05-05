namespace CP_CS2
{
    public partial class Form10 : Form
    {
        int i;
        public Form10(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void Form10_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.accNumber.Length; i++)
            {
                dataGridView1.Rows.Add(
                    Accounts.accNumber[i], 
                    Accounts.accName[i], 
                    Accounts.bal[i], 
                    Accounts.accPin[i], 
                    Accounts.accStat[i]
                );
            }

        }
    }
}
