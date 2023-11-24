namespace DỰ_ÁN_11
{
    partial class GIAO_DIỆN_CHỨC_NĂNG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIAO_DIỆN_CHỨC_NĂNG));
            groupBox1 = new GroupBox();
            button6 = new Button();
            label1 = new Label();
            btnKM = new Button();
            btnKH = new Button();
            button3 = new Button();
            btnHD = new Button();
            btnSP = new Button();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnKM);
            groupBox1.Controls.Add(btnKH);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnHD);
            groupBox1.Controls.Add(btnSP);
            groupBox1.Location = new Point(-3, -4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 624);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button6
            // 
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(60, 550);
            button6.Name = "button6";
            button6.Size = new Size(130, 49);
            button6.TabIndex = 6;
            button6.Text = "Đăng Xuất";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(123, 46);
            label1.TabIndex = 5;
            label1.Text = "HOME";
            // 
            // btnKM
            // 
            btnKM.Image = (Image)resources.GetObject("btnKM.Image");
            btnKM.ImageAlign = ContentAlignment.MiddleLeft;
            btnKM.Location = new Point(6, 462);
            btnKM.Name = "btnKM";
            btnKM.Size = new Size(234, 78);
            btnKM.TabIndex = 4;
            btnKM.Text = "Khuyến Mãi";
            btnKM.UseVisualStyleBackColor = true;
            btnKM.Click += btnKM_Click;
            // 
            // btnKH
            // 
            btnKH.Image = (Image)resources.GetObject("btnKH.Image");
            btnKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnKH.Location = new Point(6, 379);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(234, 77);
            btnKH.TabIndex = 3;
            btnKH.Text = "Kho Hàng";
            btnKH.UseVisualStyleBackColor = true;
            btnKH.Click += btnKH_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 291);
            button3.Name = "button3";
            button3.Size = new Size(234, 82);
            button3.TabIndex = 2;
            button3.Text = "Thanh Toán";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnHD
            // 
            btnHD.Image = (Image)resources.GetObject("btnHD.Image");
            btnHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnHD.Location = new Point(6, 205);
            btnHD.Name = "btnHD";
            btnHD.Size = new Size(234, 80);
            btnHD.TabIndex = 1;
            btnHD.Text = "Hoá Đơn";
            btnHD.UseVisualStyleBackColor = true;
            btnHD.Click += button2_Click;
            // 
            // btnSP
            // 
            btnSP.BackColor = Color.Transparent;
            btnSP.Image = (Image)resources.GetObject("btnSP.Image");
            btnSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSP.Location = new Point(7, 120);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(234, 79);
            btnSP.TabIndex = 0;
            btnSP.Text = "Sản Phẩm";
            btnSP.UseVisualStyleBackColor = false;
            btnSP.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(249, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(934, 96);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm sản phẩm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(609, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // GIAO_DIỆN_CHỨC_NĂNG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1253, 632);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GIAO_DIỆN_CHỨC_NĂNG";
            Text = "GIAO_DIỆN_CHỨC_NĂNG";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnKM;
        private Button btnKH;
        private Button button3;
        private Button btnHD;
        private Button btnSP;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button6;
    }
}