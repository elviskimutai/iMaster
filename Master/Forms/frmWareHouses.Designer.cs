namespace Master.Forms
{
    partial class frmWareHouses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWareHouses));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllWareHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWarehouses = new Master.Class.DataSet.dsWarehouses();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectWareHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocationNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CostCenterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DimensionsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForLocationCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLocationName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDimensions = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectWareHousesTableAdapter = new Master.Class.DataSet.dsWarehousesTableAdapters.spSelectWareHousesTableAdapter();
            this.spSelectAllWareHousesTableAdapter = new Master.Class.DataSet.dsWarehousesTableAdapters.spSelectAllWareHousesTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsWarehousesTableAdapters.spGetCompanyCostCentersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllWareHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWarehouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectWareHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLocationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLocationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDimensions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.LocationCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LocationNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DimensionsTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectWareHousesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(620, 382);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.cutToolStripButton,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 20);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 17);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 17);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 17);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 17);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllWareHousesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(596, 244);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllWareHousesBindingSource
            // 
            this.spSelectAllWareHousesBindingSource.DataMember = "spSelectAllWareHouses";
            this.spSelectAllWareHousesBindingSource.DataSource = this.dsWarehouses;
            // 
            // dsWarehouses
            // 
            this.dsWarehouses.DataSetName = "dsWarehouses";
            this.dsWarehouses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLocationCode,
            this.colLocationName,
            this.colCostCenter,
            this.colDimensions});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colLocationCode
            // 
            this.colLocationCode.FieldName = "LocationCode";
            this.colLocationCode.Name = "colLocationCode";
            this.colLocationCode.Visible = true;
            this.colLocationCode.VisibleIndex = 0;
            // 
            // colLocationName
            // 
            this.colLocationName.FieldName = "LocationName";
            this.colLocationName.Name = "colLocationName";
            this.colLocationName.Visible = true;
            this.colLocationName.VisibleIndex = 1;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 2;
            // 
            // colDimensions
            // 
            this.colDimensions.FieldName = "Dimensions";
            this.colDimensions.Name = "colDimensions";
            this.colDimensions.Visible = true;
            this.colDimensions.VisibleIndex = 3;
            // 
            // LocationCodeTextEdit
            // 
            this.LocationCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectWareHousesBindingSource, "LocationCode", true));
            this.LocationCodeTextEdit.Location = new System.Drawing.Point(97, 66);
            this.LocationCodeTextEdit.Name = "LocationCodeTextEdit";
            this.LocationCodeTextEdit.Size = new System.Drawing.Size(211, 20);
            this.LocationCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.LocationCodeTextEdit.TabIndex = 4;
            // 
            // spSelectWareHousesBindingSource
            // 
            this.spSelectWareHousesBindingSource.DataMember = "spSelectWareHouses";
            this.spSelectWareHousesBindingSource.DataSource = this.dsWarehouses;
            // 
            // LocationNameTextEdit
            // 
            this.LocationNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectWareHousesBindingSource, "LocationName", true));
            this.LocationNameTextEdit.Location = new System.Drawing.Point(385, 66);
            this.LocationNameTextEdit.Name = "LocationNameTextEdit";
            this.LocationNameTextEdit.Size = new System.Drawing.Size(211, 20);
            this.LocationNameTextEdit.StyleController = this.dataLayoutControl1;
            this.LocationNameTextEdit.TabIndex = 5;
            // 
            // CostCenterLookUpEdit
            // 
            this.CostCenterLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectWareHousesBindingSource, "CostCenter", true));
            this.CostCenterLookUpEdit.Location = new System.Drawing.Point(97, 90);
            this.CostCenterLookUpEdit.Name = "CostCenterLookUpEdit";
            this.CostCenterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterLookUpEdit.Properties.NullText = "";
            this.CostCenterLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterLookUpEdit.Size = new System.Drawing.Size(211, 20);
            this.CostCenterLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterLookUpEdit.TabIndex = 6;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsWarehouses;
            // 
            // DimensionsTextEdit
            // 
            this.DimensionsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectWareHousesBindingSource, "Dimensions", true));
            this.DimensionsTextEdit.Location = new System.Drawing.Point(385, 90);
            this.DimensionsTextEdit.Name = "DimensionsTextEdit";
            this.DimensionsTextEdit.Size = new System.Drawing.Size(211, 20);
            this.DimensionsTextEdit.StyleController = this.dataLayoutControl1;
            this.DimensionsTextEdit.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(620, 382);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(600, 114);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForLocationCode,
            this.ItemForCostCenter,
            this.ItemForLocationName,
            this.ItemForDimensions});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(600, 90);
            this.layoutControlGroup3.Text = "Warehouses";
            // 
            // ItemForLocationCode
            // 
            this.ItemForLocationCode.Control = this.LocationCodeTextEdit;
            this.ItemForLocationCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForLocationCode.Name = "ItemForLocationCode";
            this.ItemForLocationCode.Size = new System.Drawing.Size(288, 24);
            this.ItemForLocationCode.Text = "Location Code";
            this.ItemForLocationCode.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 24);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(288, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForLocationName
            // 
            this.ItemForLocationName.Control = this.LocationNameTextEdit;
            this.ItemForLocationName.Location = new System.Drawing.Point(288, 0);
            this.ItemForLocationName.Name = "ItemForLocationName";
            this.ItemForLocationName.Size = new System.Drawing.Size(288, 24);
            this.ItemForLocationName.Text = "Location Name";
            this.ItemForLocationName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForDimensions
            // 
            this.ItemForDimensions.Control = this.DimensionsTextEdit;
            this.ItemForDimensions.Location = new System.Drawing.Point(288, 24);
            this.ItemForDimensions.Name = "ItemForDimensions";
            this.ItemForDimensions.Size = new System.Drawing.Size(288, 24);
            this.ItemForDimensions.Text = "Dimensions";
            this.ItemForDimensions.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(600, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(600, 248);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectWareHousesTableAdapter
            // 
            this.spSelectWareHousesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllWareHousesTableAdapter
            // 
            this.spSelectAllWareHousesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // frmWareHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 382);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmWareHouses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHouses";
            this.Load += new System.EventHandler(this.frmWareHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllWareHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWarehouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectWareHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLocationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLocationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDimensions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit LocationCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectWareHousesBindingSource;
        private Class.DataSet.dsWarehouses dsWarehouses;
        private DevExpress.XtraEditors.TextEdit LocationNameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit CostCenterLookUpEdit;
        private DevExpress.XtraEditors.TextEdit DimensionsTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLocationCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLocationName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDimensions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsWarehousesTableAdapters.spSelectWareHousesTableAdapter spSelectWareHousesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.BindingSource spSelectAllWareHousesBindingSource;
        private Class.DataSet.dsWarehousesTableAdapters.spSelectAllWareHousesTableAdapter spSelectAllWareHousesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationName;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsWarehousesTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
    }
}