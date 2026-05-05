namespace CP_CS2
{
    partial class Form8
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
            btnInfo = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnPin = new Button();
            btsTransfer = new Button();
            btnStats = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.BorderStyle = BorderStyle.Fixed3D;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(-1, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(804, 82);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ADMINISTRATOR";
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
            // btnInfo
            // 
            btnInfo.BackColor = SystemColors.GradientActiveCaption;
            btnInfo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(167, 131);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(225, 50);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "Account Info.";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.GradientActiveCaption;
            btnSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(411, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(225, 50);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Accs.";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(167, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Acc.";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(411, 198);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(225, 50);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Acc. Info.";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnPin
            // 
            btnPin.BackColor = SystemColors.GradientActiveCaption;
            btnPin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPin.Location = new Point(167, 265);
            btnPin.Name = "btnPin";
            btnPin.Size = new Size(225, 50);
            btnPin.TabIndex = 6;
            btnPin.Text = "Change Pin";
            btnPin.UseVisualStyleBackColor = false;
            btnPin.Click += btnPin_Click;
            // 
            // btsTransfer
            // 
            btsTransfer.BackColor = SystemColors.GradientActiveCaption;
            btsTransfer.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btsTransfer.Location = new Point(411, 265);
            btsTransfer.Name = "btsTransfer";
            btsTransfer.Size = new Size(225, 50);
            btsTransfer.TabIndex = 7;
            btsTransfer.Text = "Transfer Funds";
            btsTransfer.UseVisualStyleBackColor = false;
            btsTransfer.Click += btsTransfer_Click;
            // 
            // btnStats
            // 
            btnStats.BackColor = SystemColors.GradientActiveCaption;
            btnStats.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStats.Location = new Point(167, 333);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(225, 50);
            btnStats.TabIndex = 8;
            btnStats.Text = "Activate/Block";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(411, 333);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(225, 50);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnStats);
            Controls.Add(btsTransfer);
            Controls.Add(btnPin);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(btnInfo);
            Controls.Add(lblCredits);
            Controls.Add(lblTitle);
            Name = "Form8";
            Text = "Form1";
            Load += Form8_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblCredits;
        private Button btnInfo;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnPin;
        private Button btsTransfer;
        private Button btnStats;
        private Button btnExit;
    }
}
