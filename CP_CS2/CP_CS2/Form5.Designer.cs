namespace CP_CS2
{
    partial class Form5
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
            lblWithdraw = new Label();
            btn100 = new Button();
            btn200 = new Button();
            btn500 = new Button();
            txtCustom = new TextBox();
            btnWithdrawCustom = new Button();
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
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.BackColor = SystemColors.GradientActiveCaption;
            lblWithdraw.BorderStyle = BorderStyle.Fixed3D;
            lblWithdraw.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWithdraw.Location = new Point(305, 133);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(175, 39);
            lblWithdraw.TabIndex = 2;
            lblWithdraw.Text = "WITHDRAW";
            lblWithdraw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn100
            // 
            btn100.BackColor = SystemColors.GradientActiveCaption;
            btn100.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn100.Location = new Point(149, 194);
            btn100.Name = "btn100";
            btn100.Size = new Size(225, 45);
            btn100.TabIndex = 3;
            btn100.Text = "₱100.00";
            btn100.UseVisualStyleBackColor = false;
            btn100.Click += btn100_Click;
            // 
            // btn200
            // 
            btn200.BackColor = SystemColors.GradientActiveCaption;
            btn200.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn200.Location = new Point(407, 194);
            btn200.Name = "btn200";
            btn200.Size = new Size(225, 45);
            btn200.TabIndex = 4;
            btn200.Text = "₱200.00";
            btn200.UseVisualStyleBackColor = false;
            btn200.Click += btn200_Click;
            // 
            // btn500
            // 
            btn500.BackColor = SystemColors.GradientActiveCaption;
            btn500.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn500.Location = new Point(149, 258);
            btn500.Name = "btn500";
            btn500.Size = new Size(225, 45);
            btn500.TabIndex = 5;
            btn500.Text = "₱500.00";
            btn500.UseVisualStyleBackColor = false;
            btn500.Click += btn500_Click;
            // 
            // txtCustom
            // 
            txtCustom.BackColor = SystemColors.GradientInactiveCaption;
            txtCustom.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustom.Location = new Point(407, 260);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(225, 43);
            txtCustom.TabIndex = 6;
            txtCustom.KeyDown += txtCustom_KeyDown;
            // 
            // btnWithdrawCustom
            // 
            btnWithdrawCustom.BackColor = SystemColors.GradientActiveCaption;
            btnWithdrawCustom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrawCustom.Location = new Point(407, 321);
            btnWithdrawCustom.Name = "btnWithdrawCustom";
            btnWithdrawCustom.Size = new Size(225, 55);
            btnWithdrawCustom.TabIndex = 7;
            btnWithdrawCustom.Text = "Withdraw Custom Amount";
            btnWithdrawCustom.UseVisualStyleBackColor = false;
            btnWithdrawCustom.Click += btnWithdrawCustom_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWithdrawCustom);
            Controls.Add(txtCustom);
            Controls.Add(btn500);
            Controls.Add(btn200);
            Controls.Add(btn100);
            Controls.Add(lblWithdraw);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form5";
            Text = "Form1";
            Load += Form5_Load;
            Shown += Form5_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblWithdraw;
        private Button btn100;
        private Button btn200;
        private Button btn500;
        private TextBox txtCustom;
        private Button btnWithdrawCustom;
    }
}
