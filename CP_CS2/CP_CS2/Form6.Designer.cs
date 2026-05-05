namespace CP_CS2
{
    partial class Form6
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
            lblDeposit = new Label();
            lblAmount = new Label();
            txtAmount = new TextBox();
            btnConfirm = new Button();
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
            // lblDeposit
            // 
            lblDeposit.BackColor = SystemColors.GradientActiveCaption;
            lblDeposit.BorderStyle = BorderStyle.Fixed3D;
            lblDeposit.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeposit.Location = new Point(305, 133);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(175, 39);
            lblDeposit.TabIndex = 2;
            lblDeposit.Text = "DEPOSIT";
            lblDeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.BackColor = SystemColors.GradientActiveCaption;
            lblAmount.BorderStyle = BorderStyle.Fixed3D;
            lblAmount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(118, 243);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(223, 39);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.GradientInactiveCaption;
            txtAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(349, 243);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(300, 39);
            txtAmount.TabIndex = 5;
            txtAmount.KeyDown += txtAmount_KeyDown;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.GradientActiveCaption;
            btnConfirm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(499, 300);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 45);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(lblDeposit);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form6";
            Text = "Form1";
            Load += Form6_Load;
            Shown += Form6_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblDeposit;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnConfirm;
    }
}
