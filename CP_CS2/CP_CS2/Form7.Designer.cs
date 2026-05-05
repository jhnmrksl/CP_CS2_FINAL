namespace CP_CS2
{
    partial class Form7
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
            lblBankTrans = new Label();
            lblAccNo = new Label();
            lblTransAm = new Label();
            btnConfirm = new Button();
            txtAccNo = new TextBox();
            txtFunds = new TextBox();
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
            lblTitle.Text = "Digital Banking of JRU";
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
            lblCredits.Text = "     ";
            // 
            // lblBankTrans
            // 
            lblBankTrans.BackColor = SystemColors.GradientActiveCaption;
            lblBankTrans.BorderStyle = BorderStyle.Fixed3D;
            lblBankTrans.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBankTrans.Location = new Point(287, 133);
            lblBankTrans.Name = "lblBankTrans";
            lblBankTrans.Size = new Size(218, 39);
            lblBankTrans.TabIndex = 2;
            lblBankTrans.Text = "Bank Transfer";
            lblBankTrans.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccNo
            // 
            lblAccNo.BackColor = SystemColors.GradientActiveCaption;
            lblAccNo.BorderStyle = BorderStyle.Fixed3D;
            lblAccNo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccNo.Location = new Point(118, 198);
            lblAccNo.Name = "lblAccNo";
            lblAccNo.Size = new Size(254, 45);
            lblAccNo.TabIndex = 3;
            lblAccNo.Text = "Account Number";
            lblAccNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransAm
            // 
            lblTransAm.BackColor = SystemColors.GradientActiveCaption;
            lblTransAm.BorderStyle = BorderStyle.Fixed3D;
            lblTransAm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransAm.Location = new Point(118, 269);
            lblTransAm.Name = "lblTransAm";
            lblTransAm.Size = new Size(254, 45);
            lblTransAm.TabIndex = 4;
            lblTransAm.Text = "Transfer Amount";
            lblTransAm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.GradientActiveCaption;
            btnConfirm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(531, 337);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 45);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtAccNo
            // 
            txtAccNo.BackColor = SystemColors.GradientInactiveCaption;
            txtAccNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAccNo.Location = new Point(381, 202);
            txtAccNo.Name = "txtAccNo";
            txtAccNo.Size = new Size(300, 39);
            txtAccNo.TabIndex = 6;
            // 
            // txtFunds
            // 
            txtFunds.BackColor = SystemColors.GradientInactiveCaption;
            txtFunds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFunds.Location = new Point(381, 273);
            txtFunds.Name = "txtFunds";
            txtFunds.Size = new Size(300, 39);
            txtFunds.TabIndex = 7;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFunds);
            Controls.Add(txtAccNo);
            Controls.Add(btnConfirm);
            Controls.Add(lblTransAm);
            Controls.Add(lblAccNo);
            Controls.Add(lblBankTrans);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form7";
            Text = "Form1";
            Load += Form7_Load;
            Shown += Form7_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblBankTrans;
        private Label lblAccNo;
        private Label lblTransAm;
        private Button btnConfirm;
        private TextBox txtAccNo;
        private TextBox txtFunds;
    }
}
