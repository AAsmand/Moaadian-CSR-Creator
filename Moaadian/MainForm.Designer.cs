namespace Moaadian
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            txtFullName = new TextBox();
            btnExit = new Button();
            BtnSave = new Button();
            label6 = new Label();
            cmbType = new ComboBox();
            label10 = new Label();
            txtNationalCode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtOrganizationPart2 = new TextBox();
            txtOrganizationPart1 = new TextBox();
            txtOrganizationName = new TextBox();
            errorProvider = new ErrorProvider(components);
            panel1 = new Panel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtNationalCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtOrganizationPart2);
            groupBox1.Controls.Add(txtOrganizationPart1);
            groupBox1.Controls.Add(txtOrganizationName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(559, 286);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "مشخصات سازمان/شرکت";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            label12.ForeColor = SystemColors.ActiveBorder;
            label12.Location = new Point(6, 270);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(18, 13);
            label12.TabIndex = 52;
            label12.Text = "V1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 34);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(434, 177);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(13, 14);
            label9.TabIndex = 49;
            label9.Text = "*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(420, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 14);
            label2.TabIndex = 47;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(494, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(13, 14);
            label1.TabIndex = 46;
            label1.Text = "*";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.Location = new Point(442, 65);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 14);
            label8.TabIndex = 45;
            label8.Text = "نام سازمان به انگلیسی";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullName.Location = new Point(202, 62);
            txtFullName.Margin = new Padding(2, 3, 2, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(213, 22);
            txtFullName.TabIndex = 2;
            txtFullName.Validating += txtFullName_Validating;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.DimGray;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(397, 232);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 39);
            btnExit.TabIndex = 43;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSave.BackColor = Color.ForestGreen;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            BtnSave.ForeColor = SystemColors.ButtonFace;
            BtnSave.Location = new Point(26, 232);
            BtnSave.Margin = new Padding(2, 3, 2, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(362, 39);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "ایجاد و ذخیره";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.Location = new Point(452, 149);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 14);
            label6.TabIndex = 26;
            label6.Text = "نام واحد سازمانی 2";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbType.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(202, 34);
            cmbType.Margin = new Padding(2, 3, 2, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(213, 22);
            cmbType.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label10.Location = new Point(451, 177);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 14);
            label10.TabIndex = 20;
            label10.Text = "شناسه ملی سازمان";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNationalCode.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNationalCode.Location = new Point(202, 174);
            txtNationalCode.Margin = new Padding(2, 3, 2, 3);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(213, 22);
            txtNationalCode.TabIndex = 6;
            txtNationalCode.Validating += txtNationalCode_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(452, 121);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 14);
            label5.TabIndex = 13;
            label5.Text = "نام واحد سازمانی 1";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(446, 93);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 14);
            label4.TabIndex = 12;
            label4.Text = "نام سازمان به فارسی";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(514, 37);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 14);
            label3.TabIndex = 11;
            label3.Text = "نوع";
            // 
            // txtOrganizationPart2
            // 
            txtOrganizationPart2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrganizationPart2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOrganizationPart2.Location = new Point(202, 146);
            txtOrganizationPart2.Margin = new Padding(2, 3, 2, 3);
            txtOrganizationPart2.Name = "txtOrganizationPart2";
            txtOrganizationPart2.Size = new Size(213, 22);
            txtOrganizationPart2.TabIndex = 5;
            // 
            // txtOrganizationPart1
            // 
            txtOrganizationPart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrganizationPart1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOrganizationPart1.Location = new Point(202, 118);
            txtOrganizationPart1.Margin = new Padding(2, 3, 2, 3);
            txtOrganizationPart1.Name = "txtOrganizationPart1";
            txtOrganizationPart1.Size = new Size(213, 22);
            txtOrganizationPart1.TabIndex = 4;
            // 
            // txtOrganizationName
            // 
            txtOrganizationName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrganizationName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOrganizationName.Location = new Point(202, 90);
            txtOrganizationName.Margin = new Padding(2, 3, 2, 3);
            txtOrganizationName.Name = "txtOrganizationName";
            txtOrganizationName.Size = new Size(213, 22);
            txtOrganizationName.TabIndex = 3;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.RightToLeft = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 286);
            panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(559, 286);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(1500, 1500);
            MinimumSize = new Size(575, 325);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            Text = "تولید CSR-سپیدار";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnExit;
        private Button BtnSave;
        private Label label6;
        private ComboBox cmbType;
        private Label label10;
        private TextBox txtNationalCode;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtOrganizationPart2;
        private TextBox txtOrganizationPart1;
        private TextBox txtOrganizationName;
        private Label label8;
        private TextBox txtFullName;
        private ErrorProvider errorProvider;
        private Label label9;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label12;
        private Panel panel1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}