namespace QuanLyCuaHangDM
{
    partial class frmNhaPhanPhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaPhanPhoi));
            this.layoutTop = new DevExpress.XtraLayout.LayoutControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNPP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNPP = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridCtrlNPP = new DevExpress.XtraGrid.GridControl();
            this.gv_NhaPhanPhoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTop)).BeginInit();
            this.layoutTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNPP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNPP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlNPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhaPhanPhoi)).BeginInit();
            this.pnelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTop
            // 
            this.layoutTop.Controls.Add(this.txtEmail);
            this.layoutTop.Controls.Add(this.txtDiaChi);
            this.layoutTop.Controls.Add(this.txtDT);
            this.layoutTop.Controls.Add(this.txtTenNPP);
            this.layoutTop.Controls.Add(this.txtMaNPP);
            this.layoutTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutTop.Location = new System.Drawing.Point(0, 0);
            this.layoutTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutTop.Name = "layoutTop";
            this.layoutTop.Root = this.Root;
            this.layoutTop.Size = new System.Drawing.Size(956, 132);
            this.layoutTop.TabIndex = 2;
            this.layoutTop.Text = "layoutControl1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(643, 46);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(301, 30);
            this.txtEmail.StyleController = this.layoutTop;
            this.txtEmail.TabIndex = 10;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(176, 80);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(768, 30);
            this.txtDiaChi.StyleController = this.layoutTop;
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(176, 46);
            this.txtDT.Name = "txtDT";
            this.txtDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Properties.Appearance.Options.UseFont = true;
            this.txtDT.Size = new System.Drawing.Size(299, 30);
            this.txtDT.StyleController = this.layoutTop;
            this.txtDT.TabIndex = 7;
            this.txtDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            // 
            // txtTenNPP
            // 
            this.txtTenNPP.Location = new System.Drawing.Point(643, 12);
            this.txtTenNPP.Name = "txtTenNPP";
            this.txtTenNPP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNPP.Properties.Appearance.Options.UseFont = true;
            this.txtTenNPP.Size = new System.Drawing.Size(301, 30);
            this.txtTenNPP.StyleController = this.layoutTop;
            this.txtTenNPP.TabIndex = 5;
            this.txtTenNPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtMaNPP
            // 
            this.txtMaNPP.EditValue = "";
            this.txtMaNPP.Enabled = false;
            this.txtMaNPP.Location = new System.Drawing.Point(176, 12);
            this.txtMaNPP.Name = "txtMaNPP";
            this.txtMaNPP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNPP.Properties.Appearance.Options.UseFont = true;
            this.txtMaNPP.Size = new System.Drawing.Size(299, 30);
            this.txtMaNPP.StyleController = this.layoutTop;
            this.txtMaNPP.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(956, 132);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtMaNPP;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(467, 34);
            this.layoutControlItem1.Text = "Mã nhà phân phối";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(161, 23);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtTenNPP;
            this.layoutControlItem2.Location = new System.Drawing.Point(467, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(469, 34);
            this.layoutControlItem2.Text = "Tên nhà phân phối";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(161, 23);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtDT;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(467, 34);
            this.layoutControlItem4.Text = "Điện thoại";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(161, 23);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtDiaChi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(936, 44);
            this.layoutControlItem3.Text = "Địa chỉ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(161, 23);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtEmail;
            this.layoutControlItem6.Location = new System.Drawing.Point(467, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(469, 34);
            this.layoutControlItem6.Text = "Email";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(161, 23);
            // 
            // gridCtrlNPP
            // 
            this.gridCtrlNPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlNPP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlNPP.Location = new System.Drawing.Point(0, 194);
            this.gridCtrlNPP.MainView = this.gv_NhaPhanPhoi;
            this.gridCtrlNPP.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlNPP.Name = "gridCtrlNPP";
            this.gridCtrlNPP.Size = new System.Drawing.Size(956, 255);
            this.gridCtrlNPP.TabIndex = 6;
            this.gridCtrlNPP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NhaPhanPhoi});
            // 
            // gv_NhaPhanPhoi
            // 
            this.gv_NhaPhanPhoi.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_NhaPhanPhoi.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_NhaPhanPhoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MaNPP,
            this.gc_TenNPP,
            this.gc_DiaChi,
            this.gc_DienThoai,
            this.gc_Email});
            this.gv_NhaPhanPhoi.DetailHeight = 271;
            this.gv_NhaPhanPhoi.GridControl = this.gridCtrlNPP;
            this.gv_NhaPhanPhoi.Name = "gv_NhaPhanPhoi";
            this.gv_NhaPhanPhoi.OptionsFind.AlwaysVisible = true;
            this.gv_NhaPhanPhoi.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv_NhaPhanPhoi.OptionsView.RowAutoHeight = true;
            this.gv_NhaPhanPhoi.OptionsView.ShowGroupPanel = false;
            this.gv_NhaPhanPhoi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_NhaPhanPhoi_RowClick);
            // 
            // gc_MaNPP
            // 
            this.gc_MaNPP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaNPP.AppearanceCell.Options.UseFont = true;
            this.gc_MaNPP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaNPP.AppearanceHeader.Options.UseFont = true;
            this.gc_MaNPP.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MaNPP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MaNPP.Caption = "ID";
            this.gc_MaNPP.FieldName = "MaNhaPhanPhoi";
            this.gc_MaNPP.MinWidth = 15;
            this.gc_MaNPP.Name = "gc_MaNPP";
            this.gc_MaNPP.OptionsColumn.AllowEdit = false;
            this.gc_MaNPP.Visible = true;
            this.gc_MaNPP.VisibleIndex = 0;
            this.gc_MaNPP.Width = 74;
            // 
            // gc_TenNPP
            // 
            this.gc_TenNPP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenNPP.AppearanceCell.Options.UseFont = true;
            this.gc_TenNPP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenNPP.AppearanceHeader.Options.UseFont = true;
            this.gc_TenNPP.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TenNPP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TenNPP.Caption = "Tên nhà phân phối";
            this.gc_TenNPP.FieldName = "TenNhaPhanPhoi";
            this.gc_TenNPP.MinWidth = 15;
            this.gc_TenNPP.Name = "gc_TenNPP";
            this.gc_TenNPP.OptionsColumn.AllowEdit = false;
            this.gc_TenNPP.Visible = true;
            this.gc_TenNPP.VisibleIndex = 1;
            this.gc_TenNPP.Width = 184;
            // 
            // gc_DiaChi
            // 
            this.gc_DiaChi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_DiaChi.AppearanceCell.Options.UseFont = true;
            this.gc_DiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_DiaChi.AppearanceHeader.Options.UseFont = true;
            this.gc_DiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DiaChi.Caption = "Địa chỉ";
            this.gc_DiaChi.FieldName = "DiaChi";
            this.gc_DiaChi.MinWidth = 15;
            this.gc_DiaChi.Name = "gc_DiaChi";
            this.gc_DiaChi.OptionsColumn.AllowEdit = false;
            this.gc_DiaChi.Visible = true;
            this.gc_DiaChi.VisibleIndex = 2;
            this.gc_DiaChi.Width = 213;
            // 
            // gc_DienThoai
            // 
            this.gc_DienThoai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_DienThoai.AppearanceCell.Options.UseFont = true;
            this.gc_DienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_DienThoai.AppearanceHeader.Options.UseFont = true;
            this.gc_DienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_DienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_DienThoai.Caption = "Điện thoại";
            this.gc_DienThoai.FieldName = "SDT";
            this.gc_DienThoai.MinWidth = 15;
            this.gc_DienThoai.Name = "gc_DienThoai";
            this.gc_DienThoai.OptionsColumn.AllowEdit = false;
            this.gc_DienThoai.Visible = true;
            this.gc_DienThoai.VisibleIndex = 3;
            this.gc_DienThoai.Width = 149;
            // 
            // gc_Email
            // 
            this.gc_Email.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_Email.AppearanceCell.Options.UseFont = true;
            this.gc_Email.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_Email.AppearanceHeader.Options.UseFont = true;
            this.gc_Email.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_Email.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_Email.Caption = "Email";
            this.gc_Email.FieldName = "Email";
            this.gc_Email.MinWidth = 15;
            this.gc_Email.Name = "gc_Email";
            this.gc_Email.OptionsColumn.AllowEdit = false;
            this.gc_Email.Visible = true;
            this.gc_Email.VisibleIndex = 4;
            this.gc_Email.Width = 161;
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
            this.pnelButton.Location = new System.Drawing.Point(0, 132);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(956, 62);
            this.pnelButton.TabIndex = 5;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(735, 6);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(68, 50);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(848, 6);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 50);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.DeleteList_32x32;
            this.btnXoa.Location = new System.Drawing.Point(555, 6);
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
            this.btnSua.Location = new System.Drawing.Point(391, 6);
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
            this.btnLuu.Location = new System.Drawing.Point(219, 6);
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
            this.btnThem.Size = new System.Drawing.Size(162, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhaPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 449);
            this.Controls.Add(this.gridCtrlNPP);
            this.Controls.Add(this.pnelButton);
            this.Controls.Add(this.layoutTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhaPhanPhoi";
            this.Text = "frmNhaPhanPhoi";
            this.Load += new System.EventHandler(this.frmNhaPhanPhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutTop)).EndInit();
            this.layoutTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNPP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNPP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlNPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhaPhanPhoi)).EndInit();
            this.pnelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutTop;
        private DevExpress.XtraEditors.TextEdit txtDT;
        private DevExpress.XtraEditors.TextEdit txtTenNPP;
        private DevExpress.XtraEditors.TextEdit txtMaNPP;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl gridCtrlNPP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NhaPhanPhoi;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaNPP;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenNPP;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Email;
        private System.Windows.Forms.Panel pnelButton;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}