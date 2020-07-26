namespace QuanLyCuaHangDM
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridCtrlCTHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLuuCTHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCTHD = new DevExpress.XtraEditors.SimpleButton();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHD = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayLapHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridCtrlCTHD);
            this.groupControl2.Controls.Add(this.panel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 180);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1016, 284);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chi tiết phiếu nhập";
            // 
            // gridCtrlCTHD
            // 
            this.gridCtrlCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlCTHD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlCTHD.Location = new System.Drawing.Point(431, 20);
            this.gridCtrlCTHD.MainView = this.gridView1;
            this.gridCtrlCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlCTHD.Name = "gridCtrlCTHD";
            this.gridCtrlCTHD.Size = new System.Drawing.Size(583, 262);
            this.gridCtrlCTHD.TabIndex = 24;
            this.gridCtrlCTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.DetailHeight = 271;
            this.gridView1.GridControl = this.gridCtrlCTHD;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Mã sản phẩm";
            this.gridColumn4.FieldName = "MaSanPham";
            this.gridColumn4.MinWidth = 15;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Số lượng";
            this.gridColumn5.FieldName = "SoLuong";
            this.gridColumn5.MinWidth = 15;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 81;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Tổng tiền";
            this.gridColumn6.FieldName = "TongTien";
            this.gridColumn6.MinWidth = 15;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 85;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 262);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.labelControl9, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelControl5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSoLuong, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtGiaBan, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cboMaSP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMaHD, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl10, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(114, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(315, 262);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(31, 82);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 17);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Số lượng:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 62);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Giá bán:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 17);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Sản phẩm:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(97, 82);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(183, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(97, 62);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(183, 20);
            this.txtGiaBan.TabIndex = 4;
            // 
            // cboMaSP
            // 
            this.cboMaSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(97, 42);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(183, 21);
            this.cboMaSP.TabIndex = 3;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged_1);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(97, 22);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(183, 20);
            this.txtMaHD.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(33, 22);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 17);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Hóa đơn:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnLuuCTHD, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnThemCTHD, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.43439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(114, 262);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnLuuCTHD
            // 
            this.btnLuuCTHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuuCTHD.Location = new System.Drawing.Point(2, 73);
            this.btnLuuCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuCTHD.Name = "btnLuuCTHD";
            this.btnLuuCTHD.Size = new System.Drawing.Size(110, 50);
            this.btnLuuCTHD.TabIndex = 5;
            this.btnLuuCTHD.Text = "LƯU";
            this.btnLuuCTHD.Click += new System.EventHandler(this.btnLuuCTHD_Click);
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThemCTHD.Location = new System.Drawing.Point(2, 19);
            this.btnThemCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(110, 50);
            this.btnThemCTHD.TabIndex = 4;
            this.btnThemCTHD.Text = "THÊM MỚI";
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // pnelButton
            // 
            this.pnelButton.Controls.Add(this.btnIn);
            this.pnelButton.Controls.Add(this.btnHuy);
            this.pnelButton.Controls.Add(this.btnThoat);
            this.pnelButton.Controls.Add(this.btnLuuHD);
            this.pnelButton.Controls.Add(this.btnThemHD);
            this.pnelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelButton.Location = new System.Drawing.Point(2, 108);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(1012, 70);
            this.pnelButton.TabIndex = 23;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(788, 6);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(68, 50);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(292, 6);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 50);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Cancel_32x32;
            this.btnThoat.Location = new System.Drawing.Point(875, 6);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 50);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuuHD.Location = new System.Drawing.Point(148, 6);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(124, 50);
            this.btnLuuHD.TabIndex = 1;
            this.btnLuuHD.Text = "LƯU";
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThemHD.Location = new System.Drawing.Point(10, 6);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(124, 50);
            this.btnThemHD.TabIndex = 0;
            this.btnThemHD.Text = "THÊM MỚI";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pnelButton);
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1016, 180);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Phiếu nhập";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl11, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNV, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNgayLapHoaDon, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl7, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTongTien, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboMaHD, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboMaKH, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 88);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(659, 2);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(101, 17);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Mã khách hàng:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(457, 2);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(196, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtNgayLapHoaDon
            // 
            this.txtNgayLapHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNgayLapHoaDon.Enabled = false;
            this.txtNgayLapHoaDon.Location = new System.Drawing.Point(457, 46);
            this.txtNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayLapHoaDon.Name = "txtNgayLapHoaDon";
            this.txtNgayLapHoaDon.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNgayLapHoaDon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNgayLapHoaDon.Size = new System.Drawing.Size(196, 20);
            this.txtNgayLapHoaDon.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(378, 46);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 17);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Ngày nhập:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(154, 46);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTongTien.Size = new System.Drawing.Size(176, 20);
            this.txtTongTien.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(69, 2);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã hóa đơn:";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(84, 46);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 17);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Tổng tiền:";
            // 
            // cboMaHD
            // 
            this.cboMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(154, 2);
            this.cboMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(176, 21);
            this.cboMaHD.TabIndex = 14;
            this.cboMaHD.SelectedIndexChanged += new System.EventHandler(this.cboMaHD_SelectedIndexChanged_1);
            // 
            // cboMaKH
            // 
            this.cboMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(760, 2);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(196, 21);
            this.cboMaKH.TabIndex = 16;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 464);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private System.Windows.Forms.ComboBox cboMaSP;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnThemCTHD;
        private System.Windows.Forms.Panel pnelButton;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLuuHD;
        private DevExpress.XtraEditors.SimpleButton btnThemHD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtNgayLapHoaDon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.ComboBox cboMaKH;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnLuuCTHD;
        private DevExpress.XtraGrid.GridControl gridCtrlCTHD;
    }
}