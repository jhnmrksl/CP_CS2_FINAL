namespace CP_CS2
{
    partial class Form10
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblCredits = new Label();
            lblSearch = new Label();
            dataGridView1 = new DataGridView();
            colAccNo = new DataGridViewTextBoxColumn();
            colAccName = new DataGridViewTextBoxColumn();
            colBal = new DataGridViewTextBoxColumn();
            colPin = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.BorderStyle = BorderStyle.Fixed3D;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(-1, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(804, 82);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Digital Bank of JRU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCredits
            // 
            lblCredits.BackColor = SystemColors.GradientActiveCaption;
            lblCredits.BorderStyle = BorderStyle.Fixed3D;
            lblCredits.Location = new Point(-1, 405);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(804, 23);
            lblCredits.TabIndex = 1;
            lblCredits.Text = "    ";
            lblCredits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            lblSearch.BackColor = SystemColors.GradientActiveCaption;
            lblSearch.BorderStyle = BorderStyle.Fixed3D;
            lblSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(216, 133);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(361, 39);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "View Account Information";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAccNo, colAccName, colBal, colPin, colStatus });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(114, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(543, 198);
            dataGridView1.TabIndex = 3;
            // 
            // colAccNo
            // 
            colAccNo.HeaderText = "Account No.";
            colAccNo.Name = "colAccNo";
            colAccNo.ReadOnly = true;
            // 
            // colAccName
            // 
            colAccName.HeaderText = "Account Name";
            colAccName.Name = "colAccName";
            colAccName.ReadOnly = true;
            // 
            // colBal
            // 
            colBal.HeaderText = "Balance";
            colBal.Name = "colBal";
            colBal.ReadOnly = true;
            // 
            // colPin
            // 
            colPin.HeaderText = "Account Pin";
            colPin.Name = "colPin";
            colPin.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(lblSearch);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form10";
            Text = "Form1";
            Load += Form10_Load;
            Shown += Form10_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAccNo;
        private DataGridViewTextBoxColumn colAccName;
        private DataGridViewTextBoxColumn colBal;
        private DataGridViewTextBoxColumn colPin;
        private DataGridViewTextBoxColumn colStatus;
    }
}
