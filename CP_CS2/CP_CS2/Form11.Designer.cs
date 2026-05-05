namespace CP_CS2
{
    partial class Form11
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
            lblAcc = new Label();
            lblName = new Label();
            lblNumber = new Label();
            lblPin = new Label();
            txtNum = new TextBox();
            txtName = new TextBox();
            txtPin = new TextBox();
            btnCreate = new Button();
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
            label1.Text = "   ";
            // 
            // lblAcc
            // 
            lblAcc.AutoSize = true;
            lblAcc.BackColor = SystemColors.GradientActiveCaption;
            lblAcc.BorderStyle = BorderStyle.Fixed3D;
            lblAcc.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcc.Location = new Point(316, 125);
            lblAcc.Name = "lblAcc";
            lblAcc.Size = new Size(184, 39);
            lblAcc.TabIndex = 2;
            lblAcc.Text = "Add Account";
            lblAcc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.GradientActiveCaption;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(122, 231);
            lblName.Name = "lblName";
            lblName.Size = new Size(236, 39);
            lblName.TabIndex = 3;
            lblName.Text = "Account Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = SystemColors.GradientActiveCaption;
            lblNumber.BorderStyle = BorderStyle.Fixed3D;
            lblNumber.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(122, 176);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(236, 39);
            lblNumber.TabIndex = 4;
            lblNumber.Text = "Account Number";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPin
            // 
            lblPin.BackColor = SystemColors.GradientActiveCaption;
            lblPin.BorderStyle = BorderStyle.Fixed3D;
            lblPin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPin.Location = new Point(122, 290);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(236, 39);
            lblPin.TabIndex = 5;
            lblPin.Text = "Account Pin";
            lblPin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            txtNum.BackColor = SystemColors.GradientInactiveCaption;
            txtNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(364, 176);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(261, 39);
            txtNum.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GradientInactiveCaption;
            txtName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(364, 231);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 39);
            txtName.TabIndex = 7;
            // 
            // txtPin
            // 
            txtPin.BackColor = SystemColors.GradientInactiveCaption;
            txtPin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPin.Location = new Point(364, 290);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(261, 39);
            txtPin.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.GradientActiveCaption;
            btnCreate.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(479, 346);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(146, 45);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(txtPin);
            Controls.Add(txtName);
            Controls.Add(txtNum);
            Controls.Add(lblPin);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(lblAcc);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Form11";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblAcc;
        private Label lblName;
        private Label lblNumber;
        private Label lblPin;
        private TextBox txtNum;
        private TextBox txtName;
        private TextBox txtPin;
        private Button btnCreate;
    }
}
