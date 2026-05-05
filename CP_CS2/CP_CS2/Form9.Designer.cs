namespace CP_CS2
{
    partial class Form9
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
            lblInsert = new Label();
            txtAcc = new TextBox();
            lblNo = new Label();
            btnBack = new Button();
            btnView = new Button();
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
            // lblInsert
            // 
            lblInsert.BackColor = SystemColors.GradientActiveCaption;
            lblInsert.BorderStyle = BorderStyle.Fixed3D;
            lblInsert.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(266, 133);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(260, 39);
            lblInsert.TabIndex = 3;
            lblInsert.Text = "Search Account";
            lblInsert.TextAlign = ContentAlignment.MiddleCenter;
            lblInsert.Click += lblInsert_Click;
            // 
            // txtAcc
            // 
            txtAcc.BackColor = SystemColors.GradientInactiveCaption;
            txtAcc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAcc.Location = new Point(381, 236);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(272, 39);
            txtAcc.TabIndex = 4;
            // 
            // lblNo
            // 
            lblNo.BackColor = SystemColors.GradientActiveCaption;
            lblNo.BorderStyle = BorderStyle.Fixed3D;
            lblNo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNo.Location = new Point(128, 236);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(245, 40);
            lblNo.TabIndex = 5;
            lblNo.Text = "Account Number";
            lblNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(128, 297);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 46);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.GradientActiveCaption;
            btnView.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.Location = new Point(493, 297);
            btnView.Name = "btnView";
            btnView.Size = new Size(160, 46);
            btnView.TabIndex = 7;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnView);
            Controls.Add(btnBack);
            Controls.Add(lblNo);
            Controls.Add(txtAcc);
            Controls.Add(lblInsert);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form9";
            Text = "Form1";
            Load += Form9_Load;
            Shown += Form9_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Label label1;
        private Label lblInsert;
        private TextBox txtAcc;
        private Label lblNo;
        private Button btnBack;
        private Button btnView;
    }
}
