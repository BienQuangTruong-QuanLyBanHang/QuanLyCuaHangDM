namespace QuanLyCuaHangDM
{
    partial class frmHangSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangSX));
            this.gridCtrlHangSX = new DevExpress.XtraGrid.GridControl();
            this.gv_HangSanXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaHSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenHSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlHangSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HangSanXuat)).BeginInit();
            this.pnelButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrlHangSX
            // 
            this.gridCtrlHangSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlHangSX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlHangSX.Location = new System.Drawing.Point(0, 129);
            this.gridCtrlHangSX.MainView = this.gv_HangSanXuat;
            this.gridCtrlHangSX.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlHangSX.Name = "gridCtrlHangSX";
            this.gridCtrlHangSX.Size = new System.Drawing.Size(698, 195);
            this.gridCtrlHangSX.TabIndex = 30;
            this.gridCtrlHangSX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HangSanXuat});
            // 
            // gv_HangSanXuat
            // 
            this.gv_HangSanXuat.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_HangSanXuat.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_HangSanXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MaHSX,
            this.gc_TenHSX});
            this.gv_HangSanXuat.DetailHeight = 271;
            this.gv_HangSanXuat.GridControl = this.gridCtrlHangSX;
            this.gv_HangSanXuat.Name = "gv_HangSanXuat";
            this.gv_HangSanXuat.OptionsFind.AlwaysVisible = true;
            this.gv_HangSanXuat.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv_HangSanXuat.OptionsView.RowAutoHeight = true;
            this.gv_HangSanXuat.OptionsView.ShowGroupPanel = false;
            this.gv_HangSanXuat.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_HangSanXuat_RowClick);
            // 
            // gc_MaHSX
            // 
            this.gc_MaHSX.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaHSX.AppearanceCell.Options.UseFont = true;
            this.gc_MaHSX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaHSX.AppearanceHeader.Options.UseFont = true;
            this.gc_MaHSX.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MaHSX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MaHSX.Caption = "Mã hãng sản xuất";
            this.gc_MaHSX.FieldName = "MaHangSanXuat";
            this.gc_MaHSX.MinWidth = 15;
            this.gc_MaHSX.Name = "gc_MaHSX";
            this.gc_MaHSX.OptionsColumn.AllowEdit = false;
            this.gc_MaHSX.Visible = true;
            this.gc_MaHSX.VisibleIndex = 0;
            this.gc_MaHSX.Width = 34;
            // 
            // gc_TenHSX
            // 
            this.gc_TenHSX.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenHSX.AppearanceCell.Options.UseFont = true;
            this.gc_TenHSX.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenHSX.AppearanceHeader.Options.UseFont = true;
            this.gc_TenHSX.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_TenHSX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_TenHSX.Caption = "Tên hãng sản xuất";
            this.gc_TenHSX.FieldName = "TenHangSanXuat";
            this.gc_TenHSX.MinWidth = 15;
            this.gc_TenHSX.Name = "gc_TenHSX";
            this.gc_TenHSX.OptionsColumn.AllowEdit = false;
            this.gc_TenHSX.Visible = true;
            this.gc_TenHSX.VisibleIndex = 1;
            this.gc_TenHSX.Width = 133;
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
            this.pnelButton.Location = new System.Drawing.Point(0, 83);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(698, 46);
            this.pnelButton.TabIndex = 29;
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(536, 6);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(59, 32);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "IN";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(609, 4);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 32);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.DeleteList_32x32;
            this.btnXoa.Location = new System.Drawing.Point(398, 6);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(265, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuu.Location = new System.Drawing.Point(137, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 32);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThem.Location = new System.Drawing.Point(10, 6);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 32);
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
            this.tableLayoutPanel1.Controls.Add(this.txtMaHang, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenHang, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 83);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(246, 18);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(308, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenHang.Location = new System.Drawing.Point(246, 42);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(308, 20);
            this.txtTenHang.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(181, 18);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 17);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Mã hãng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(175, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Tên hãng:";
            // 
            // frmHangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 324);
            this.Controls.Add(this.gridCtrlHangSX);
            this.Controls.Add(this.pnelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHangSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHangSX";
            this.Load += new System.EventHandler(this.frmHangSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlHangSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HangSanXuat)).EndInit();
            this.pnelButton.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlHangSX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HangSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaHSX;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenHSX;
        private System.Windows.Forms.Panel pnelButton;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private DevExpress.XtraEditors.TextEdit txtTenHang;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}