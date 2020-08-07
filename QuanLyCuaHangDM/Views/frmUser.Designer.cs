namespace QuanLyCuaHangDM
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.layoutTop = new DevExpress.XtraLayout.LayoutControl();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridCtrlUser = new DevExpress.XtraGrid.GridControl();
            this.gv_User = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTop)).BeginInit();
            this.layoutTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).BeginInit();
            this.pnelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTop
            // 
            this.layoutTop.Controls.Add(this.cboMaNV);
            this.layoutTop.Controls.Add(this.txtTenDN);
            this.layoutTop.Controls.Add(this.txtMatKhau);
            this.layoutTop.Controls.Add(this.txtID);
            this.layoutTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutTop.Location = new System.Drawing.Point(0, 0);
            this.layoutTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutTop.Name = "layoutTop";
            this.layoutTop.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(888, 0, 650, 400);
            this.layoutTop.Root = this.Root;
            this.layoutTop.Size = new System.Drawing.Size(836, 125);
            this.layoutTop.TabIndex = 2;
            this.layoutTop.Text = "layoutControl1";
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(552, 12);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(272, 31);
            this.cboMaNV.TabIndex = 11;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(145, 46);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Properties.Appearance.Options.UseFont = true;
            this.txtTenDN.Size = new System.Drawing.Size(679, 30);
            this.txtTenDN.StyleController = this.layoutTop;
            this.txtTenDN.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(145, 80);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Size = new System.Drawing.Size(679, 30);
            this.txtMatKhau.StyleController = this.layoutTop;
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.EditValue = "";
            this.txtID.Location = new System.Drawing.Point(145, 12);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(270, 30);
            this.txtID.StyleController = this.layoutTop;
            this.txtID.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(836, 125);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtMatKhau;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(816, 37);
            this.layoutControlItem2.Text = "Mật khẩu";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(130, 23);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.cboMaNV;
            this.layoutControlItem8.Location = new System.Drawing.Point(407, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(409, 34);
            this.layoutControlItem8.Text = "Mã nhân viên";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(130, 23);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(407, 34);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(130, 23);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtTenDN;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(816, 34);
            this.layoutControlItem4.Text = "Tên đăng nhập";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(130, 23);
            // 
            // gridCtrlUser
            // 
            this.gridCtrlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlUser.Location = new System.Drawing.Point(0, 198);
            this.gridCtrlUser.MainView = this.gv_User;
            this.gridCtrlUser.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlUser.Name = "gridCtrlUser";
            this.gridCtrlUser.Size = new System.Drawing.Size(836, 293);
            this.gridCtrlUser.TabIndex = 6;
            this.gridCtrlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_User});
            // 
            // gv_User
            // 
            this.gv_User.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_User.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_User.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_ID,
            this.gc_MaNV,
            this.gc_TenNV,
            this.gc_TenDN,
            this.gc_MK});
            this.gv_User.DetailHeight = 271;
            this.gv_User.GridControl = this.gridCtrlUser;
            this.gv_User.Name = "gv_User";
            this.gv_User.OptionsFind.AlwaysVisible = true;
            this.gv_User.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv_User.OptionsView.ShowGroupPanel = false;
            this.gv_User.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_User_RowClick);
            // 
            // gc_ID
            // 
            this.gc_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_ID.AppearanceCell.Options.UseFont = true;
            this.gc_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_ID.AppearanceHeader.Options.UseFont = true;
            this.gc_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ID.Caption = "ID";
            this.gc_ID.FieldName = "ID";
            this.gc_ID.MinWidth = 15;
            this.gc_ID.Name = "gc_ID";
            this.gc_ID.OptionsColumn.AllowEdit = false;
            this.gc_ID.Visible = true;
            this.gc_ID.VisibleIndex = 0;
            this.gc_ID.Width = 74;
            // 
            // gc_MaNV
            // 
            this.gc_MaNV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaNV.AppearanceCell.Options.UseFont = true;
            this.gc_MaNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaNV.AppearanceHeader.Options.UseFont = true;
            this.gc_MaNV.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MaNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MaNV.Caption = "Mã nhân viên";
            this.gc_MaNV.FieldName = "MaNhanVien";
            this.gc_MaNV.MinWidth = 15;
            this.gc_MaNV.Name = "gc_MaNV";
            this.gc_MaNV.OptionsColumn.AllowEdit = false;
            this.gc_MaNV.Visible = true;
            this.gc_MaNV.VisibleIndex = 1;
            this.gc_MaNV.Width = 114;
            // 
            // gc_TenNV
            // 
            this.gc_TenNV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenNV.AppearanceCell.Options.UseFont = true;
            this.gc_TenNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenNV.AppearanceHeader.Options.UseFont = true;
            this.gc_TenNV.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TenNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TenNV.Caption = "Tên nhân viên";
            this.gc_TenNV.FieldName = "TenNV";
            this.gc_TenNV.Name = "gc_TenNV";
            this.gc_TenNV.OptionsColumn.AllowEdit = false;
            this.gc_TenNV.Visible = true;
            this.gc_TenNV.VisibleIndex = 2;
            this.gc_TenNV.Width = 171;
            // 
            // gc_TenDN
            // 
            this.gc_TenDN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenDN.AppearanceCell.Options.UseFont = true;
            this.gc_TenDN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenDN.AppearanceHeader.Options.UseFont = true;
            this.gc_TenDN.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TenDN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TenDN.Caption = "Tên đăng nhập";
            this.gc_TenDN.FieldName = "TenDangNhap";
            this.gc_TenDN.MinWidth = 15;
            this.gc_TenDN.Name = "gc_TenDN";
            this.gc_TenDN.OptionsColumn.AllowEdit = false;
            this.gc_TenDN.Visible = true;
            this.gc_TenDN.VisibleIndex = 3;
            this.gc_TenDN.Width = 151;
            // 
            // gc_MK
            // 
            this.gc_MK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MK.AppearanceCell.Options.UseFont = true;
            this.gc_MK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MK.AppearanceHeader.Options.UseFont = true;
            this.gc_MK.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MK.Caption = "Mật khẩu";
            this.gc_MK.FieldName = "MatKhau";
            this.gc_MK.MinWidth = 15;
            this.gc_MK.Name = "gc_MK";
            this.gc_MK.OptionsColumn.AllowEdit = false;
            this.gc_MK.Visible = true;
            this.gc_MK.VisibleIndex = 4;
            this.gc_MK.Width = 182;
            // 
            // pnelButton
            // 
            this.pnelButton.Controls.Add(this.btnIn);
            this.pnelButton.Controls.Add(this.btnHuy);
            this.pnelButton.Controls.Add(this.btnXoa);
            this.pnelButton.Controls.Add(this.btnSua);
            this.pnelButton.Controls.Add(this.btnLuu);
            this.pnelButton.Controls.Add(this.btnThem);
            this.pnelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnelButton.Location = new System.Drawing.Point(0, 125);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(836, 73);
            this.pnelButton.TabIndex = 5;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(623, 6);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(81, 50);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(733, 6);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 50);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.DeleteList_32x32;
            this.btnXoa.Location = new System.Drawing.Point(527, 6);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 50);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(363, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuu.Location = new System.Drawing.Point(196, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 50);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThem.Location = new System.Drawing.Point(10, 6);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 491);
            this.Controls.Add(this.gridCtrlUser);
            this.Controls.Add(this.pnelButton);
            this.Controls.Add(this.layoutTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutTop)).EndInit();
            this.layoutTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).EndInit();
            this.pnelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutTop;
        private System.Windows.Forms.ComboBox cboMaNV;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.GridControl gridCtrlUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_User;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenDN;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MK;
        private System.Windows.Forms.Panel pnelButton;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenNV;
    }
}