﻿namespace QuanLyCuaHangDM
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
            this.gv_CTHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnXoaCTHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaCTHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCTHD = new DevExpress.XtraEditors.SimpleButton();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHD = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayLapHoaDon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHD)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridCtrlCTHD);
            this.groupControl2.Controls.Add(this.panel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 222);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1185, 349);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chi tiết hóa đơn";
            // 
            // gridCtrlCTHD
            // 
            this.gridCtrlCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlCTHD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlCTHD.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gridCtrlCTHD.Location = new System.Drawing.Point(614, 30);
            this.gridCtrlCTHD.MainView = this.gv_CTHD;
            this.gridCtrlCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlCTHD.Name = "gridCtrlCTHD";
            this.gridCtrlCTHD.Size = new System.Drawing.Size(569, 317);
            this.gridCtrlCTHD.TabIndex = 24;
            this.gridCtrlCTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTHD});
            // 
            // gv_CTHD
            // 
            this.gv_CTHD.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_CTHD.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_CTHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MaSP,
            this.gc_TenSanPham,
            this.gc_SoLuong,
            this.gc_ThanhTien});
            this.gv_CTHD.DetailHeight = 334;
            this.gv_CTHD.GridControl = this.gridCtrlCTHD;
            this.gv_CTHD.Name = "gv_CTHD";
            this.gv_CTHD.OptionsBehavior.ReadOnly = true;
            this.gv_CTHD.OptionsFind.AlwaysVisible = true;
            this.gv_CTHD.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv_CTHD.OptionsView.RowAutoHeight = true;
            this.gv_CTHD.OptionsView.ShowGroupPanel = false;
            this.gv_CTHD.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_CTHD_RowClick);
            // 
            // gc_MaSP
            // 
            this.gc_MaSP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaSP.AppearanceCell.Options.UseFont = true;
            this.gc_MaSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaSP.AppearanceHeader.Options.UseFont = true;
            this.gc_MaSP.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MaSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MaSP.Caption = "Mã sản phẩm";
            this.gc_MaSP.FieldName = "MaSanPham";
            this.gc_MaSP.MinWidth = 23;
            this.gc_MaSP.Name = "gc_MaSP";
            this.gc_MaSP.OptionsColumn.AllowEdit = false;
            this.gc_MaSP.Visible = true;
            this.gc_MaSP.VisibleIndex = 0;
            this.gc_MaSP.Width = 87;
            // 
            // gc_TenSanPham
            // 
            this.gc_TenSanPham.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenSanPham.AppearanceCell.Options.UseFont = true;
            this.gc_TenSanPham.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenSanPham.AppearanceHeader.Options.UseFont = true;
            this.gc_TenSanPham.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TenSanPham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TenSanPham.Caption = "Tên sản phẩm";
            this.gc_TenSanPham.FieldName = "TenSanPham";
            this.gc_TenSanPham.MinWidth = 17;
            this.gc_TenSanPham.Name = "gc_TenSanPham";
            this.gc_TenSanPham.OptionsColumn.AllowEdit = false;
            this.gc_TenSanPham.Visible = true;
            this.gc_TenSanPham.VisibleIndex = 1;
            this.gc_TenSanPham.Width = 131;
            // 
            // gc_SoLuong
            // 
            this.gc_SoLuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_SoLuong.AppearanceCell.Options.UseFont = true;
            this.gc_SoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_SoLuong.AppearanceHeader.Options.UseFont = true;
            this.gc_SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_SoLuong.Caption = "Số lượng";
            this.gc_SoLuong.FieldName = "SoLuong";
            this.gc_SoLuong.MinWidth = 17;
            this.gc_SoLuong.Name = "gc_SoLuong";
            this.gc_SoLuong.OptionsColumn.AllowEdit = false;
            this.gc_SoLuong.Visible = true;
            this.gc_SoLuong.VisibleIndex = 2;
            this.gc_SoLuong.Width = 94;
            // 
            // gc_ThanhTien
            // 
            this.gc_ThanhTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_ThanhTien.AppearanceCell.Options.UseFont = true;
            this.gc_ThanhTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_ThanhTien.AppearanceHeader.Options.UseFont = true;
            this.gc_ThanhTien.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ThanhTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ThanhTien.Caption = "Thành tiền";
            this.gc_ThanhTien.FieldName = "TongTien";
            this.gc_ThanhTien.MinWidth = 17;
            this.gc_ThanhTien.Name = "gc_ThanhTien";
            this.gc_ThanhTien.OptionsColumn.AllowEdit = false;
            this.gc_ThanhTien.Visible = true;
            this.gc_ThanhTien.VisibleIndex = 3;
            this.gc_ThanhTien.Width = 99;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 317);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.37401F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.65252F));
            this.tableLayoutPanel3.Controls.Add(this.labelControl9, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelControl5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSoLuong, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtGiaBan, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cboMaSP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMaHD, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl10, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(173, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(439, 317);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(26, 102);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(102, 29);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Số lượng:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(39, 77);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 29);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Giá bán:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 52);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Sản phẩm:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(134, 102);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoLuong.Size = new System.Drawing.Size(289, 36);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaBan.Location = new System.Drawing.Point(134, 77);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Properties.Appearance.Options.UseFont = true;
            this.txtGiaBan.Properties.ReadOnly = true;
            this.txtGiaBan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaBan.Size = new System.Drawing.Size(289, 36);
            this.txtGiaBan.TabIndex = 4;
            // 
            // cboMaSP
            // 
            this.cboMaSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(134, 52);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(289, 37);
            this.cboMaSP.TabIndex = 3;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged_1);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaHD.Location = new System.Drawing.Point(134, 27);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Properties.Appearance.Options.UseFont = true;
            this.txtMaHD.Properties.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(289, 36);
            this.txtMaHD.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(31, 27);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(97, 29);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Hóa đơn:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnXoaCTHD, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSuaCTHD, 0, 2);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 317);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaCTHD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTHD.Appearance.Options.UseFont = true;
            this.btnXoaCTHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTHD.ImageOptions.Image")));
            this.btnXoaCTHD.Location = new System.Drawing.Point(12, 165);
            this.btnXoaCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.btnXoaCTHD.Size = new System.Drawing.Size(159, 62);
            this.btnXoaCTHD.TabIndex = 5;
            this.btnXoaCTHD.Text = "XÓA";
            this.btnXoaCTHD.Click += new System.EventHandler(this.btnXoaCTHD_Click);
            // 
            // btnSuaCTHD
            // 
            this.btnSuaCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaCTHD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCTHD.Appearance.Options.UseFont = true;
            this.btnSuaCTHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCTHD.ImageOptions.Image")));
            this.btnSuaCTHD.Location = new System.Drawing.Point(12, 87);
            this.btnSuaCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaCTHD.Name = "btnSuaCTHD";
            this.btnSuaCTHD.Size = new System.Drawing.Size(159, 62);
            this.btnSuaCTHD.TabIndex = 6;
            this.btnSuaCTHD.Text = "SỬA";
            this.btnSuaCTHD.Click += new System.EventHandler(this.btnSuaCTHD_Click);
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCTHD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTHD.Appearance.Options.UseFont = true;
            this.btnThemCTHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThemCTHD.Location = new System.Drawing.Point(12, 22);
            this.btnThemCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(159, 58);
            this.btnThemCTHD.TabIndex = 4;
            this.btnThemCTHD.Text = "CHỌN";
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // pnelButton
            // 
            this.pnelButton.Controls.Add(this.btnIn);
            this.pnelButton.Controls.Add(this.btnHuy);
            this.pnelButton.Controls.Add(this.btnLuuHD);
            this.pnelButton.Controls.Add(this.btnThemHD);
            this.pnelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelButton.Location = new System.Drawing.Point(2, 138);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(1181, 82);
            this.pnelButton.TabIndex = 23;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(1067, 7);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(79, 62);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(420, 7);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 62);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.Appearance.Options.UseFont = true;
            this.btnLuuHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuuHD.Location = new System.Drawing.Point(236, 7);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(145, 62);
            this.btnLuuHD.TabIndex = 1;
            this.btnLuuHD.Text = "LƯU";
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.Appearance.Options.UseFont = true;
            this.btnThemHD.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThemHD.Location = new System.Drawing.Point(12, 7);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(189, 62);
            this.btnThemHD.TabIndex = 0;
            this.btnThemHD.Text = "THÊM MỚI";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.pnelButton);
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1185, 222);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Hóa đơn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58002F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30991F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.73328F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.24132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl11, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNV, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl7, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboMaHD, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboMaKH, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl6, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTongTien, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNgayLapHoaDon, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1181, 108);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(713, 2);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(167, 29);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Mã khách hàng:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNV.Location = new System.Drawing.Point(532, 2);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(168, 34);
            this.txtMaNV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên:";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(405, 56);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(121, 29);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Ngày nhập:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 2);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 29);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã hóa đơn:";
            // 
            // cboMaHD
            // 
            this.cboMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaHD.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(179, 2);
            this.cboMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(178, 36);
            this.cboMaHD.TabIndex = 14;
            this.cboMaHD.SelectedIndexChanged += new System.EventHandler(this.cboMaHD_SelectedIndexChanged_1);
            // 
            // cboMaKH
            // 
            this.cboMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaKH.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(886, 2);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(230, 36);
            this.cboMaKH.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(772, 56);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(108, 29);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Location = new System.Drawing.Point(886, 56);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTongTien.Properties.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(230, 34);
            this.txtTongTien.TabIndex = 11;
            // 
            // txtNgayLapHoaDon
            // 
            this.txtNgayLapHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNgayLapHoaDon.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtNgayLapHoaDon.Location = new System.Drawing.Point(532, 56);
            this.txtNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayLapHoaDon.Mask = "00/00/0000";
            this.txtNgayLapHoaDon.Name = "txtNgayLapHoaDon";
            this.txtNgayLapHoaDon.ReadOnly = true;
            this.txtNgayLapHoaDon.Size = new System.Drawing.Size(168, 36);
            this.txtNgayLapHoaDon.TabIndex = 17;
            this.txtNgayLapHoaDon.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(179, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 28);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "VAT 10%";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 571);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHD)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTHD;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ThanhTien;
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
        private DevExpress.XtraEditors.SimpleButton btnLuuHD;
        private DevExpress.XtraEditors.SimpleButton btnThemHD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.ComboBox cboMaKH;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXoaCTHD;
        private DevExpress.XtraGrid.GridControl gridCtrlCTHD;
        private DevExpress.XtraEditors.SimpleButton btnSuaCTHD;
        private System.Windows.Forms.MaskedTextBox txtNgayLapHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaSP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}