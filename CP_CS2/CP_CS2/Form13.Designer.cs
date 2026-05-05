namespace CP_CS2
{
    partial class Form13
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
            lblTransfer = new Label();
            lblSender = new Label();
            lblRecipient = new Label();
            lblAmount = new Label();
            btnConfirm = new Button();
            txtSender = new TextBox();
            txtReceive = new TextBox();
            txtAmount = new TextBox();
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
            lblCredits.Text = "   ";
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.BackColor = SystemColors.GradientActiveCaption;
            lblTransfer.BorderStyle = BorderStyle.Fixed3D;
            lblTransfer.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransfer.Location = new Point(302, 133);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new Size(205, 39);
            lblTransfer.TabIndex = 2;
            lblTransfer.Text = "Transfer Funds";
            lblTransfer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSender
            // 
            lblSender.BackColor = SystemColors.GradientActiveCaption;
            lblSender.BorderStyle = BorderStyle.Fixed3D;
            lblSender.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSender.Location = new Point(139, 184);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(251, 39);
            lblSender.TabIndex = 3;
            lblSender.Text = "Sender Account";
            lblSender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.BackColor = SystemColors.GradientActiveCaption;
            lblRecipient.BorderStyle = BorderStyle.Fixed3D;
            lblRecipient.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipient.Location = new Point(139, 239);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(251, 39);
            lblRecipient.TabIndex = 4;
            lblRecipient.Text = "Recipient Account";
            lblRecipient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.BackColor = SystemColors.GradientActiveCaption;
            lblAmount.BorderStyle = BorderStyle.Fixed3D;
            lblAmount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(139, 295);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(251, 39);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.GradientActiveCaption;
            btnConfirm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(471, 342);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(163, 45);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtSender
            // 
            txtSender.BackColor = SystemColors.GradientInactiveCaption;
            txtSender.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSender.Location = new Point(396, 183);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(238, 39);
            txtSender.TabIndex = 7;
            // 
            // txtReceive
            // 
            txtReceive.BackColor = SystemColors.GradientInactiveCaption;
            txtReceive.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReceive.Location = new Point(396, 239);
            txtReceive.Name = "txtReceive";
            txtReceive.Size = new Size(238, 39);
            txtReceive.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.GradientInactiveCaption;
            txtAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(396, 295);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(238, 39);
            txtAmount.TabIndex = 9;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAmount);
            Controls.Add(txtReceive);
            Controls.Add(txtSender);
            Controls.Add(btnConfirm);
            Controls.Add(lblAmount);
            Controls.Add(lblRecipient);
            Controls.Add(lblSender);
            Controls.Add(lblTransfer);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form13";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblTransfer;
        private Label lblSender;
        private Label lblRecipient;
        private Label lblAmount;
        private Button btnConfirm;
        private TextBox txtSender;
        private TextBox txtReceive;
        private TextBox txtAmount;
    }
}
