namespace QuanLyCuaHangDM
{
    partial class frmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.gridCtrlChucVu = new DevExpress.XtraGrid.GridControl();
            this.gv_ChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnelButton = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaCV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenCV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChucVu)).BeginInit();
            this.pnelButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrlChucVu
            // 
            this.gridCtrlChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlChucVu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlChucVu.Location = new System.Drawing.Point(0, 168);
            this.gridCtrlChucVu.MainView = this.gv_ChucVu;
            this.gridCtrlChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlChucVu.Name = "gridCtrlChucVu";
            this.gridCtrlChucVu.Size = new System.Drawing.Size(838, 231);
            this.gridCtrlChucVu.TabIndex = 33;
            this.gridCtrlChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ChucVu});
            // 
            // gv_ChucVu
            // 
            this.gv_ChucVu.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_ChucVu.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_ChucVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MaCV,
            this.gc_TenCV});
            this.gv_ChucVu.DetailHeight = 334;
            this.gv_ChucVu.GridControl = this.gridCtrlChucVu;
            this.gv_ChucVu.Name = "gv_ChucVu";
            this.gv_ChucVu.OptionsView.ShowGroupPanel = false;
            this.gv_ChucVu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_ChucVu_RowClick);
            // 
            // gc_MaCV
            // 
            this.gc_MaCV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_MaCV.AppearanceHeader.Options.UseFont = true;
            this.gc_MaCV.Caption = "Mã chức vụ";
            this.gc_MaCV.FieldName = "MaChucVu";
            this.gc_MaCV.MinWidth = 17;
            this.gc_MaCV.Name = "gc_MaCV";
            this.gc_MaCV.OptionsColumn.AllowEdit = false;
            this.gc_MaCV.Visible = true;
            this.gc_MaCV.VisibleIndex = 0;
            this.gc_MaCV.Width = 141;
            // 
            // gc_TenCV
            // 
            this.gc_TenCV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_TenCV.AppearanceHeader.Options.UseFont = true;
            this.gc_TenCV.Caption = "Tên chức vụ";
            this.gc_TenCV.FieldName = "TenChucVu";
            this.gc_TenCV.MinWidth = 17;
            this.gc_TenCV.Name = "gc_TenCV";
            this.gc_TenCV.OptionsColumn.AllowEdit = false;
            this.gc_TenCV.Visible = true;
            this.gc_TenCV.VisibleIndex = 1;
            this.gc_TenCV.Width = 274;
            // 
            // pnelButton
            // 
            this.pnelButton.Controls.Add(this.btnHuy);
            this.pnelButton.Controls.Add(this.btnThoat);
            this.pnelButton.Controls.Add(this.btnXoa);
            this.pnelButton.Controls.Add(this.btnSua);
            this.pnelButton.Controls.Add(this.btnLuu);
            this.pnelButton.Controls.Add(this.btnThem);
            this.pnelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnelButton.Location = new System.Drawing.Point(0, 109);
            this.pnelButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnelButton.Name = "pnelButton";
            this.pnelButton.Size = new System.Drawing.Size(838, 59);
            this.pnelButton.TabIndex = 32;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(612, 7);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 40);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Cancel_32x32;
            this.btnThoat.Location = new System.Drawing.Point(707, 7);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.DeleteList_32x32;
            this.btnXoa.Location = new System.Drawing.Point(467, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Edit_32x32;
            this.btnSua.Location = new System.Drawing.Point(323, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.ExportFile_32x32;
            this.btnLuu.Location = new System.Drawing.Point(178, 7);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = global::QuanLyCuaHangDM.Properties.Resources.Add_32x32;
            this.btnThem.Location = new System.Drawing.Point(34, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
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
            this.tableLayoutPanel1.Controls.Add(this.txtMaCV, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenCV, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.44037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 109);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaCV.Enabled = false;
            this.txtMaCV.Location = new System.Drawing.Point(295, 24);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(371, 22);
            this.txtMaCV.TabIndex = 2;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenCV.Location = new System.Drawing.Point(295, 56);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(371, 22);
            this.txtTenCV.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(198, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 20);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Mã chức vụ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(193, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 20);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên chức vụ:";
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 399);
            this.Controls.Add(this.gridCtrlChucVu);
            this.Controls.Add(this.pnelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucVu";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChucVu)).EndInit();
            this.pnelButton.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaCV;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenCV;
        private System.Windows.Forms.Panel pnelButton;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtMaCV;
        private DevExpress.XtraEditors.TextEdit txtTenCV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}