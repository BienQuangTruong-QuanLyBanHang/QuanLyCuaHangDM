﻿namespace QuanLyCuaHangDM
{
    partial class frmLoaiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiKhachHang));
            this.gridCtrlLoaiKH = new DevExpress.XtraGrid.GridControl();
            this.gv_LoaiKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlLoaiKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_LoaiKH)).BeginInit();
            this.pnelButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrlLoaiKH
            // 
            this.gridCtrlLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlLoaiKH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlLoaiKH.Location = new System.Drawing.Point(0, 137);
            this.gridCtrlLoaiKH.MainView = this.gv_LoaiKH;
            this.gridCtrlLoaiKH.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlLoaiKH.Name = "gridCtrlLoaiKH";
            this.gridCtrlLoaiKH.Size = new System.Drawing.Size(769, 192);
            this.gridCtrlLoaiKH.TabIndex = 30;
            this.gridCtrlLoaiKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_LoaiKH});
            // 
            // gv_LoaiKH
            // 
            this.gv_LoaiKH.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_LoaiKH.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_LoaiKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MaLoai,
            this.gc_TenLoai});
            this.gv_LoaiKH.DetailHeight = 271;
            this.gv_LoaiKH.GridControl = this.gridCtrlLoaiKH;
            this.gv_LoaiKH.Name = "gv_LoaiKH";
            this.gv_LoaiKH.OptionsFind.AlwaysVisible = true;
            this.gv_LoaiKH.OptionsView.AllowHtmlDrawHeaders = true;
            this.gv_LoaiKH.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gv_LoaiKH.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gv_LoaiKH.OptionsView.RowAutoHeight = true;
            this.gv_LoaiKH.OptionsView.ShowGroupPanel = false;
            this.gv_LoaiKH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_LoaiKH_RowClick);
            // 
            // gc_MaLoai
            // 
            this.gc_MaLoai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaLoai.AppearanceCell.Options.UseFont = true;
            this.gc_MaLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaLoai.AppearanceHeader.Options.UseFont = true;
            this.gc_MaLoai.Caption = "Mã loại khách hàng";
            this.gc_MaLoai.FieldName = "MaLoaiKhachHang";
            this.gc_MaLoai.MinWidth = 15;
            this.gc_MaLoai.Name = "gc_MaLoai";
            this.gc_MaLoai.OptionsColumn.AllowEdit = false;
            this.gc_MaLoai.Visible = true;
            this.gc_MaLoai.VisibleIndex = 0;
            this.gc_MaLoai.Width = 121;
            // 
            // gc_TenLoai
            // 
            this.gc_TenLoai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenLoai.AppearanceCell.Options.UseFont = true;
            this.gc_TenLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenLoai.AppearanceHeader.Options.UseFont = true;
            this.gc_TenLoai.Caption = "Tên loại khách hàng";
            this.gc_TenLoai.FieldName = "TenLoaiKhachHang";
            this.gc_TenLoai.MinWidth = 15;
            this.gc_TenLoai.Name = "gc_TenLoai";
            this.gc_TenLoai.OptionsColumn.AllowEdit = false;
            this.gc_TenLoai.Visible = true;
            this.gc_TenLoai.VisibleIndex = 1;
            this.gc_TenLoai.Width = 235;
            // 
            // pnelButton
            // 
            this.pnelButton.Controls.Add(this.btnHuy);
            this.pnelButton.Controls.Add(this.btnXoa);
            this.pnelButton.Controls.Add(this.btnSua);
            this.pnelButton.Controls.Add(this.btnLuu);
            this.pnelButton.Controls.Add(this.btnThem);
            this.pnelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnelButton.Location = new System.Drawing.Point(0, 89);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(769, 48);
            this.pnelButton.TabIndex = 29;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(515, 6);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 32);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.DeleteList_32x32;
            this.btnXoa.Location = new System.Drawing.Point(389, 6);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(271, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuu.Location = new System.Drawing.Point(155, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 32);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThem.Location = new System.Drawing.Point(2, 6);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaLoai, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenLoai, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.44037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 89);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(271, 19);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Properties.Appearance.Options.UseFont = true;
            this.txtMaLoai.Size = new System.Drawing.Size(340, 28);
            this.txtMaLoai.TabIndex = 2;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenLoai.Location = new System.Drawing.Point(271, 45);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoai.Properties.MaxLength = 50;
            this.txtTenLoai.Size = new System.Drawing.Size(340, 28);
            this.txtTenLoai.TabIndex = 3;
            this.txtTenLoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenLoai_KeyDown);
            this.txtTenLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoai_KeyPress);
            this.txtTenLoai.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTenLoai_MouseDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(199, 19);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 23);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Mã loại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(192, 45);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 23);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên loại:";
            // 
            // frmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 329);
            this.Controls.Add(this.gridCtrlLoaiKH);
            this.Controls.Add(this.pnelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiKhachHang";
            this.Load += new System.EventHandler(this.frmLoaiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlLoaiKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_LoaiKH)).EndInit();
            this.pnelButton.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlLoaiKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_LoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenLoai;
        private System.Windows.Forms.Panel pnelButton;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}