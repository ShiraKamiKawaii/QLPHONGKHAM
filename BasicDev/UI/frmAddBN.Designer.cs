namespace QLPHONGKHAM.UI
{
    partial class frmAddBN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBN));
            tbBN = new DevExpress.Utils.Layout.TablePanel();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            radioNu = new System.Windows.Forms.RadioButton();
            radioNam = new System.Windows.Forms.RadioButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            txtdienThoai = new DevExpress.XtraEditors.TextEdit();
            dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            btnSaveBN = new DevExpress.XtraEditors.SimpleButton();
            txtdiaChi = new DevExpress.XtraEditors.TextEdit();
            txtsoCCCD = new DevExpress.XtraEditors.TextEdit();
            txthoTenBN = new DevExpress.XtraEditors.TextEdit();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            label7 = new System.Windows.Forms.Label();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)tbBN).BeginInit();
            tbBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtdienThoai.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtdiaChi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtsoCCCD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txthoTenBN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // tbBN
            // 
            tbBN.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.12F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.88F) });
            tbBN.Controls.Add(layoutControl1);
            tbBN.Controls.Add(txtdienThoai);
            tbBN.Controls.Add(dateNgaySinh);
            tbBN.Controls.Add(btnSaveBN);
            tbBN.Controls.Add(txtdiaChi);
            tbBN.Controls.Add(txtsoCCCD);
            tbBN.Controls.Add(txthoTenBN);
            tbBN.Controls.Add(label6);
            tbBN.Controls.Add(label5);
            tbBN.Controls.Add(label4);
            tbBN.Controls.Add(label3);
            tbBN.Controls.Add(label2);
            tbBN.Controls.Add(label1);
            tbBN.Dock = System.Windows.Forms.DockStyle.Bottom;
            tbBN.Location = new System.Drawing.Point(0, 72);
            tbBN.Name = "tbBN";
            tbBN.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F, true, new System.DateOnly(2025, 3, 18)), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F) });
            tbBN.Size = new System.Drawing.Size(405, 356);
            tbBN.TabIndex = 1;
            tbBN.UseSkinIndents = true;
            // 
            // layoutControl1
            // 
            tbBN.SetColumn(layoutControl1, 1);
            layoutControl1.Controls.Add(radioNu);
            layoutControl1.Controls.Add(radioNam);
            layoutControl1.Location = new System.Drawing.Point(103, 92);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(691, 0, 650, 400);
            layoutControl1.Root = Root;
            tbBN.SetRow(layoutControl1, 2);
            layoutControl1.Size = new System.Drawing.Size(289, 36);
            layoutControl1.TabIndex = 18;
            layoutControl1.Text = "layoutControl1";
            // 
            // radioNu
            // 
            radioNu.Location = new System.Drawing.Point(145, 2);
            radioNu.Name = "radioNu";
            radioNu.Size = new System.Drawing.Size(142, 25);
            radioNu.TabIndex = 5;
            radioNu.TabStop = true;
            radioNu.Text = "Nữ";
            radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            radioNam.Checked = true;
            radioNam.Location = new System.Drawing.Point(2, 2);
            radioNam.Name = "radioNam";
            radioNam.Size = new System.Drawing.Size(139, 25);
            radioNam.TabIndex = 4;
            radioNam.TabStop = true;
            radioNam.Text = "Nam";
            radioNam.UseVisualStyleBackColor = true;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(289, 36);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = radioNam;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(143, 36);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = radioNu;
            layoutControlItem2.Location = new System.Drawing.Point(143, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(146, 36);
            layoutControlItem2.TextVisible = false;
            // 
            // txtdienThoai
            // 
            tbBN.SetColumn(txtdienThoai, 1);
            txtdienThoai.Location = new System.Drawing.Point(103, 180);
            txtdienThoai.Name = "txtdienThoai";
            tbBN.SetRow(txtdienThoai, 4);
            txtdienThoai.Size = new System.Drawing.Size(289, 20);
            txtdienThoai.TabIndex = 17;
            // 
            // dateNgaySinh
            // 
            tbBN.SetColumn(dateNgaySinh, 1);
            dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateNgaySinh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateNgaySinh.Location = new System.Drawing.Point(103, 57);
            dateNgaySinh.Name = "dateNgaySinh";
            tbBN.SetRow(dateNgaySinh, 1);
            dateNgaySinh.Size = new System.Drawing.Size(289, 26);
            dateNgaySinh.TabIndex = 16;
            // 
            // btnSaveBN
            // 
            btnSaveBN.AllowFocus = false;
            btnSaveBN.Appearance.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btnSaveBN.Appearance.BorderColor = System.Drawing.Color.Lime;
            btnSaveBN.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnSaveBN.Appearance.Options.UseBackColor = true;
            btnSaveBN.Appearance.Options.UseBorderColor = true;
            btnSaveBN.Appearance.Options.UseFont = true;
            tbBN.SetColumn(btnSaveBN, 1);
            btnSaveBN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSaveBN.ImageOptions.Image");
            btnSaveBN.Location = new System.Drawing.Point(103, 276);
            btnSaveBN.Name = "btnSaveBN";
            tbBN.SetRow(btnSaveBN, 6);
            btnSaveBN.Size = new System.Drawing.Size(289, 42);
            btnSaveBN.TabIndex = 15;
            btnSaveBN.Text = "Lưu";
            btnSaveBN.Click += btnSaveBN_Click;
            // 
            // txtdiaChi
            // 
            tbBN.SetColumn(txtdiaChi, 1);
            txtdiaChi.Location = new System.Drawing.Point(103, 140);
            txtdiaChi.Name = "txtdiaChi";
            tbBN.SetRow(txtdiaChi, 3);
            txtdiaChi.Size = new System.Drawing.Size(289, 20);
            txtdiaChi.TabIndex = 10;
            // 
            // txtsoCCCD
            // 
            tbBN.SetColumn(txtsoCCCD, 1);
            txtsoCCCD.Location = new System.Drawing.Point(103, 220);
            txtsoCCCD.Name = "txtsoCCCD";
            tbBN.SetRow(txtsoCCCD, 5);
            txtsoCCCD.Size = new System.Drawing.Size(289, 20);
            txtsoCCCD.TabIndex = 7;
            // 
            // txthoTenBN
            // 
            tbBN.SetColumn(txthoTenBN, 1);
            txthoTenBN.Location = new System.Drawing.Point(103, 20);
            txthoTenBN.Name = "txthoTenBN";
            tbBN.SetRow(txthoTenBN, 0);
            txthoTenBN.Size = new System.Drawing.Size(289, 20);
            txthoTenBN.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tbBN.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(14, 210);
            label6.Name = "label6";
            tbBN.SetRow(label6, 5);
            label6.Size = new System.Drawing.Size(84, 40);
            label6.TabIndex = 5;
            label6.Text = "Số CCCD";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tbBN.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(14, 170);
            label5.Name = "label5";
            tbBN.SetRow(label5, 4);
            label5.Size = new System.Drawing.Size(84, 40);
            label5.TabIndex = 4;
            label5.Text = "Điện thoại";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tbBN.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(14, 130);
            label4.Name = "label4";
            tbBN.SetRow(label4, 3);
            label4.Size = new System.Drawing.Size(84, 40);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tbBN.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(14, 90);
            label3.Name = "label3";
            tbBN.SetRow(label3, 2);
            label3.Size = new System.Drawing.Size(84, 40);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tbBN.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(14, 50);
            label2.Name = "label2";
            tbBN.SetRow(label2, 1);
            label2.Size = new System.Drawing.Size(84, 40);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tbBN.SetColumn(label1, 0);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Name = "label1";
            tbBN.SetRow(label1, 0);
            label1.Size = new System.Drawing.Size(84, 40);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(label7);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Top;
            layoutControl2.Location = new System.Drawing.Point(0, 0);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(405, 79);
            layoutControl2.TabIndex = 2;
            layoutControl2.Text = "layoutControl2";
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(12, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(381, 55);
            label7.TabIndex = 19;
            label7.Text = "Thông tin bệnh nhân";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(405, 79);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = label7;
            layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(385, 59);
            layoutControlItem3.TextVisible = false;
            // 
            // frmAddBN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(405, 428);
            Controls.Add(layoutControl2);
            Controls.Add(tbBN);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddBN";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FORM THÊM BỆNH NHÂN";
            ((System.ComponentModel.ISupportInitialize)tbBN).EndInit();
            tbBN.ResumeLayout(false);
            tbBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtdienThoai.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtdiaChi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtsoCCCD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txthoTenBN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tbBN;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtdienThoai;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnSaveBN;
        private DevExpress.XtraEditors.TextEdit txtdiaChi;
        private DevExpress.XtraEditors.TextEdit txtsoCCCD;
        private DevExpress.XtraEditors.TextEdit txthoTenBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}