namespace CP_CS2
{
    partial class Form15
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
            lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum = new TextBox();
            btnChange = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.BackColor = SystemColors.GradientActiveCaption;
            lbl.BorderStyle = BorderStyle.Fixed3D;
            lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(-1, 28);
            lbl.Name = "lbl";
            lbl.Size = new Size(804, 82);
            lbl.TabIndex = 0;
            lbl.Text = "Digital Bank of JRU";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 133);
            label2.Name = "label2";
            label2.Size = new Size(201, 39);
            label2.TabIndex = 2;
            label2.Text = "Change Status";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(148, 237);
            label3.Name = "label3";
            label3.Size = new Size(236, 39);
            label3.TabIndex = 3;
            label3.Text = "Account Number";
            // 
            // txtNum
            // 
            txtNum.BackColor = SystemColors.GradientInactiveCaption;
            txtNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(390, 237);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(249, 39);
            txtNum.TabIndex = 4;
            // 
            // btnChange
            // 
            btnChange.BackColor = SystemColors.GradientActiveCaption;
            btnChange.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(484, 292);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(155, 45);
            btnChange.TabIndex = 5;
            btnChange.Text = "CHANGE";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChange);
            Controls.Add(txtNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl);
            Name = "Form15";
            Text = "Form1";
            Load += Form15_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum;
        private Button btnChange;
    }
}
