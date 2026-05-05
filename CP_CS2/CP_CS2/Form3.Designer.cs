namespace CP_CS2
{
    partial class Form3
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
            lblSelect = new Label();
            btnBal = new Button();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnCancel = new Button();
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
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.BackColor = SystemColors.GradientActiveCaption;
            lblSelect.BorderStyle = BorderStyle.Fixed3D;
            lblSelect.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelect.Location = new Point(233, 128);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(333, 39);
            lblSelect.TabIndex = 2;
            lblSelect.Text = "SELECT A TRANSACTION";
            lblSelect.Click += lblSelect_Click;
            // 
            // btnBal
            // 
            btnBal.BackColor = SystemColors.GradientActiveCaption;
            btnBal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBal.Location = new Point(160, 193);
            btnBal.Name = "btnBal";
            btnBal.Size = new Size(230, 45);
            btnBal.TabIndex = 3;
            btnBal.Text = "Balance Inquiry";
            btnBal.UseVisualStyleBackColor = false;
            btnBal.Click += btnBal_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.GradientActiveCaption;
            btnWithdraw.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(406, 193);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(230, 45);
            btnWithdraw.TabIndex = 4;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = SystemColors.GradientActiveCaption;
            btnDeposit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(160, 253);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(230, 45);
            btnDeposit.TabIndex = 5;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = SystemColors.GradientActiveCaption;
            btnTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.Location = new Point(406, 253);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(230, 45);
            btnTransfer.TabIndex = 6;
            btnTransfer.Text = "Transfer Fund";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(279, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(230, 45);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnBal);
            Controls.Add(lblSelect);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form3";
            Text = "Form1";
            Load += Form3_Load;
            Shown += Form3_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblSelect;
        private Button btnBal;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnTransfer;
        private Button btnCancel;
    }
}
