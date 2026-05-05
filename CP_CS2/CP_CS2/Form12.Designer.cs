namespace CP_CS2
{
    partial class Form12
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
            lblEdit = new Label();
            lblNum = new Label();
            lblName = new Label();
            txtNum = new TextBox();
            txtName = new TextBox();
            btnChange = new Button();
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
            lblCredits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdit
            // 
            lblEdit.BackColor = SystemColors.GradientActiveCaption;
            lblEdit.BorderStyle = BorderStyle.Fixed3D;
            lblEdit.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdit.Location = new Point(322, 133);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(153, 39);
            lblEdit.TabIndex = 2;
            lblEdit.Text = "Edit Name";
            lblEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.BackColor = SystemColors.GradientActiveCaption;
            lblNum.BorderStyle = BorderStyle.Fixed3D;
            lblNum.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum.Location = new Point(132, 205);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(236, 39);
            lblNum.TabIndex = 3;
            lblNum.Text = "Account Number";
            lblNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.GradientActiveCaption;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(132, 264);
            lblName.Name = "lblName";
            lblName.Size = new Size(236, 39);
            lblName.TabIndex = 4;
            lblName.Text = "New Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            txtNum.BackColor = SystemColors.GradientInactiveCaption;
            txtNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(374, 205);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(282, 39);
            txtNum.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GradientInactiveCaption;
            txtName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(374, 264);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 39);
            txtName.TabIndex = 6;
            // 
            // btnChange
            // 
            btnChange.BackColor = SystemColors.GradientActiveCaption;
            btnChange.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(497, 326);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(159, 45);
            btnChange.TabIndex = 7;
            btnChange.Text = "CHANGE";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChange);
            Controls.Add(txtName);
            Controls.Add(txtNum);
            Controls.Add(lblName);
            Controls.Add(lblNum);
            Controls.Add(lblEdit);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form12";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label lblEdit;
        private Label lblNum;
        private Label lblName;
        private TextBox txtNum;
        private TextBox txtName;
        private Button btnChange;
    }
}
