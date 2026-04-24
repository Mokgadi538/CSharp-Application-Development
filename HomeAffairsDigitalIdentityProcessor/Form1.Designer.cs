namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblName = new Label();
            lblID = new Label();
            lblCitizenship = new Label();
            lblValidationResult = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            btnValidate = new Button();
            btnGenerate = new Button();
            pictureBox1 = new PictureBox();
            txtResults = new TextBox();
            cmbCitizenship = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(550, 26);
            label1.Name = "label1";
            label1.Size = new Size(609, 45);
            label1.TabIndex = 0;
            label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(550, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(194, 30);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(550, 187);
            lblID.Name = "lblID";
            lblID.Size = new Size(156, 30);
            lblID.TabIndex = 2;
            lblID.Text = "Enter your ID:";
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCitizenship.Location = new Point(550, 245);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(224, 30);
            lblCitizenship.TabIndex = 3;
            lblCitizenship.Text = "Choose your Citizen:";
            // 
            // lblValidationResult
            // 
            lblValidationResult.AutoSize = true;
            lblValidationResult.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValidationResult.Location = new Point(750, 360);
            lblValidationResult.Name = "lblValidationResult";
            lblValidationResult.Size = new Size(0, 28);
            lblValidationResult.TabIndex = 13;
            // 
            // txtName
            // Mokgadi
            txtName.Location = new Point(791, 124);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 31);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(791, 186);
            txtID.Name = "txtID";
            txtID.Size = new Size(251, 31);
            txtID.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.FromArgb(0, 192, 0);
            btnValidate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.ForeColor = Color.Black;
            btnValidate.Location = new Point(815, 311);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(138, 34);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 192, 0);
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(1014, 663);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(170, 41);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(250, 160, 100);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(516, 630);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(919, 404);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(355, 253);
            txtResults.TabIndex = 11;
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Items.AddRange(new object[] { "Citizen", "Visitor", "Permanent Resident" });
            cmbCitizenship.Location = new Point(791, 242);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(251, 33);
            cmbCitizenship.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 160, 100);
            ClientSize = new Size(1319, 716);
            Controls.Add(cmbCitizenship);
            Controls.Add(txtResults);
            Controls.Add(lblValidationResult);
            Controls.Add(pictureBox1);
            Controls.Add(btnGenerate);
            Controls.Add(btnValidate);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblCitizenship);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblID;
        private Label lblCitizenship;
        private Label lblValidationResult;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnValidate;
        private Button btnGenerate;
        private PictureBox pictureBox1;
        private TextBox txtResults;
        private ComboBox cmbCitizenship;
    }
}