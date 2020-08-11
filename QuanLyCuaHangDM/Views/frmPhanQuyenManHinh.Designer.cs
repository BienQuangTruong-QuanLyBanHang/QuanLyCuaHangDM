namespace QuanLyCuaHangDM
{
    partial class frmPhanQuyenManHinh
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridCtrlChucVu = new DevExpress.XtraGrid.GridControl();
            this.gv_ChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCtrlPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gv_PhanQuyenManHinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_CoQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanQuyenManHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Check)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(3, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "LƯU";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridCtrlChucVu
            // 
            // 
            // 
            // 
            this.gridCtrlChucVu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlChucVu.Location = new System.Drawing.Point(6, 54);
            this.gridCtrlChucVu.MainView = this.gv_ChucVu;
            this.gridCtrlChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlChucVu.Name = "gridCtrlChucVu";
            this.gridCtrlChucVu.Size = new System.Drawing.Size(379, 404);
            this.gridCtrlChucVu.TabIndex = 34;
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
            this.gv_ChucVu.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv_ChucVu.OptionsView.RowAutoHeight = true;
            this.gv_ChucVu.OptionsView.ShowGroupPanel = false;
            this.gv_ChucVu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_ChucVu_RowClick);
            // 
            // gc_MaCV
            // 
            this.gc_MaCV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaCV.AppearanceCell.Options.UseFont = true;
            this.gc_MaCV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaCV.AppearanceHeader.Options.UseFont = true;
            this.gc_MaCV.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MaCV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.gc_TenCV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenCV.AppearanceCell.Options.UseFont = true;
            this.gc_TenCV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            // gridCtrlPhanQuyen
            // 
            // 
            // 
            // 
            this.gridCtrlPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridCtrlPhanQuyen.Location = new System.Drawing.Point(21, 54);
            this.gridCtrlPhanQuyen.MainView = this.gv_PhanQuyenManHinh;
            this.gridCtrlPhanQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlPhanQuyen.Name = "gridCtrlPhanQuyen";
            this.gridCtrlPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_Check});
            this.gridCtrlPhanQuyen.Size = new System.Drawing.Size(569, 500);
            this.gridCtrlPhanQuyen.TabIndex = 35;
            this.gridCtrlPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PhanQuyenManHinh});
            // 
            // gv_PhanQuyenManHinh
            // 
            this.gv_PhanQuyenManHinh.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gv_PhanQuyenManHinh.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_PhanQuyenManHinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MaMH,
            this.gc_TenMH,
            this.gridColumn2,
            this.gridColumn1,
            this.gc_CoQuyen});
            this.gv_PhanQuyenManHinh.DetailHeight = 334;
            this.gv_PhanQuyenManHinh.GridControl = this.gridCtrlPhanQuyen;
            this.gv_PhanQuyenManHinh.Name = "gv_PhanQuyenManHinh";
            this.gv_PhanQuyenManHinh.OptionsSelection.MultiSelect = true;
            this.gv_PhanQuyenManHinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_PhanQuyenManHinh.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gv_PhanQuyenManHinh.OptionsView.RowAutoHeight = true;
            this.gv_PhanQuyenManHinh.OptionsView.ShowGroupPanel = false;
            // 
            // gc_MaMH
            // 
            this.gc_MaMH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_MaMH.AppearanceCell.Options.UseFont = true;
            this.gc_MaMH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_MaMH.AppearanceHeader.Options.UseFont = true;
            this.gc_MaMH.Caption = "Mã màn hình";
            this.gc_MaMH.FieldName = "MaMH";
            this.gc_MaMH.MinWidth = 17;
            this.gc_MaMH.Name = "gc_MaMH";
            this.gc_MaMH.OptionsColumn.AllowEdit = false;
            this.gc_MaMH.Visible = true;
            this.gc_MaMH.VisibleIndex = 1;
            this.gc_MaMH.Width = 141;
            // 
            // gc_TenMH
            // 
            this.gc_TenMH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_TenMH.AppearanceCell.Options.UseFont = true;
            this.gc_TenMH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_TenMH.AppearanceHeader.Options.UseFont = true;
            this.gc_TenMH.Caption = "Tên màn hình";
            this.gc_TenMH.FieldName = "TenMH";
            this.gc_TenMH.MinWidth = 17;
            this.gc_TenMH.Name = "gc_TenMH";
            this.gc_TenMH.OptionsColumn.AllowEdit = false;
            this.gc_TenMH.Visible = true;
            this.gc_TenMH.VisibleIndex = 2;
            this.gc_TenMH.Width = 274;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.ColumnEdit = this.rep_Check;
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 87;
            // 
            // rep_Check
            // 
            this.rep_Check.AutoHeight = false;
            this.rep_Check.Name = "rep_Check";
            this.rep_Check.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 87;
            // 
            // gc_CoQuyen
            // 
            this.gc_CoQuyen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gc_CoQuyen.AppearanceCell.Options.UseFont = true;
            this.gc_CoQuyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gc_CoQuyen.AppearanceHeader.Options.UseFont = true;
            this.gc_CoQuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_CoQuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_CoQuyen.Caption = "Có quyền";
            this.gc_CoQuyen.ColumnEdit = this.rep_Check;
            this.gc_CoQuyen.FieldName = "CoQuyen";
            this.gc_CoQuyen.MinWidth = 23;
            this.gc_CoQuyen.Name = "gc_CoQuyen";
            this.gc_CoQuyen.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.gc_CoQuyen.Visible = true;
            this.gc_CoQuyen.VisibleIndex = 5;
            this.gc_CoQuyen.Width = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCtrlChucVu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(3, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(441, 596);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chức vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCtrlPhanQuyen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(450, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(665, 596);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách quyền chức năng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1118, 671);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // frmPhanQuyenManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhanQuyenManHinh";
            this.Text = "frmPhanQuyenManHinh";
            this.Load += new System.EventHandler(this.frmPhanQuyenManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhanQuyenManHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Check)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridCtrlChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaCV;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenCV;
        private DevExpress.XtraGrid.GridControl gridCtrlPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PhanQuyenManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenMH;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CoQuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rep_Check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}