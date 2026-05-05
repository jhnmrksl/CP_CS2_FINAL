namespace CP_CS2
{
    partial class Form4
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
            lblAcc = new Label();
            lblMoney = new Label();
            btnBack = new Button();
            lblAccName = new Label();
            lblBalInq = new Label();
            lblBal = new Label();
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
            // 
            // lblAcc
            // 
            lblAcc.BackColor = SystemColors.GradientActiveCaption;
            lblAcc.BorderStyle = BorderStyle.Fixed3D;
            lblAcc.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcc.Location = new Point(118, 198);
            lblAcc.Name = "lblAcc";
            lblAcc.Size = new Size(225, 45);
            lblAcc.TabIndex = 2;
            lblAcc.Text = "Account Name";
            lblAcc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMoney
            // 
            lblMoney.BackColor = SystemColors.GradientActiveCaption;
            lblMoney.BorderStyle = BorderStyle.Fixed3D;
            lblMoney.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(118, 269);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(225, 45);
            lblMoney.TabIndex = 3;
            lblMoney.Text = "Balance";
            lblMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(499, 337);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 45);
            btnBack.TabIndex = 4;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblAccName
            // 
            lblAccName.BackColor = SystemColors.GradientInactiveCaption;
            lblAccName.BorderStyle = BorderStyle.Fixed3D;
            lblAccName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccName.Location = new Point(349, 198);
            lblAccName.Name = "lblAccName";
            lblAccName.Size = new Size(300, 45);
            lblAccName.TabIndex = 5;
            lblAccName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBal
            // 
            lblBal.BackColor = SystemColors.GradientInactiveCaption;
            lblBal.BorderStyle = BorderStyle.Fixed3D;
            lblBal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBal.Location = new Point(349, 269);
            lblBal.Name = "lblBal";
            lblBal.Size = new Size(300, 45);
            lblBal.TabIndex = 6;
            lblBal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBalInq
            // 
            lblBalInq.AutoSize = true;
            lblBalInq.BackColor = SystemColors.GradientActiveCaption;
            lblBalInq.BorderStyle = BorderStyle.Fixed3D;
            lblBalInq.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalInq.Location = new Point(287, 133);
            lblBalInq.Name = "lblBalInq";
            lblBalInq.Size = new Size(218, 39);
            lblBalInq.TabIndex = 7;
            lblBalInq.Text = "Balance Inquiry";
            lblBalInq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBalInq);
            Controls.Add(lblBal);
            Controls.Add(lblAccName);
            Controls.Add(btnBack);
            Controls.Add(lblMoney);
            Controls.Add(lblAcc);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            Shown += Form4_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblAcc;
        private Label lblMoney;
        private Button btnBack;
        private Label lblAccName;
        private Label lblBal;
        private Label lblBalInq;
    }
}
