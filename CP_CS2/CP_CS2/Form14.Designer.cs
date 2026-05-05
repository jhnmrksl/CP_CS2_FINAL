namespace CP_CS2
{
    partial class Form14
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
            label1 = new Label();
            lblPin = new Label();
            lblNum = new Label();
            label2 = new Label();
            btnConfirm = new Button();
            txtNum = new TextBox();
            txtPin = new TextBox();
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
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(-1, 405);
            label1.Name = "label1";
            label1.Size = new Size(804, 23);
            label1.TabIndex = 1;
            label1.Text = "  ";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.BackColor = SystemColors.GradientActiveCaption;
            lblPin.BorderStyle = BorderStyle.Fixed3D;
            lblPin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPin.Location = new Point(315, 133);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(163, 39);
            lblPin.TabIndex = 2;
            lblPin.Text = "Change Pin";
            lblPin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.BackColor = SystemColors.GradientActiveCaption;
            lblNum.BorderStyle = BorderStyle.Fixed3D;
            lblNum.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum.Location = new Point(142, 209);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(236, 39);
            lblNum.TabIndex = 3;
            lblNum.Text = "Account Number";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 266);
            label2.Name = "label2";
            label2.Size = new Size(236, 39);
            label2.TabIndex = 4;
            label2.Text = "New Pin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.GradientActiveCaption;
            btnConfirm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(463, 327);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(170, 45);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtNum
            // 
            txtNum.BackColor = SystemColors.GradientInactiveCaption;
            txtNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(384, 209);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(249, 39);
            txtNum.TabIndex = 6;
            // 
            // txtPin
            // 
            txtPin.BackColor = SystemColors.GradientInactiveCaption;
            txtPin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPin.Location = new Point(384, 266);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(249, 39);
            txtPin.TabIndex = 7;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPin);
            Controls.Add(txtNum);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(lblNum);
            Controls.Add(lblPin);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Form14";
            Text = "Form1";
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblPin;
        private Label lblNum;
        private Label label2;
        private Button btnConfirm;
        private TextBox txtNum;
        private TextBox txtPin;
    }
}
