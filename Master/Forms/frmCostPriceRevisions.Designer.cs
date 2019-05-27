namespace Master.Forms
{
    partial class frmCostPriceRevisions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostPriceRevisions));
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
            this.spSelectAllCostPriceRevisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCostPriceRevisions = new Master.Class.DataSet.dsCostPriceRevisions();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceBand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectCostPriceRevisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UOMGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectAllUOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ToDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.VATRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PriceBandGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetPriceBandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DiscountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPriceBand = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVATRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUOM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscount = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCostPriceRevisionsTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectCostPriceRevisionsTableAdapter();
            this.spSelectAllCostPriceRevisionsTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectAllCostPriceRevisionsTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spGetItemsTableAdapter();
            this.spGetPriceBandsTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spGetPriceBandsTableAdapter();
            this.spSelectAllUOMTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectAllUOMTableAdapter();
            this.spSelectItemUnitCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectItemUnitCostTableAdapter = new Master.Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectItemUnitCostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCostPriceRevisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostPriceRevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCostPriceRevisionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBandGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPriceBandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVATRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectItemUnitCostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UOMGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.FromDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ToDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.VATRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PriceBandGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DiscountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitCostTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCostPriceRevisionsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(910, 409);
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
            this.toolStrip1.Size = new System.Drawing.Size(886, 20);
            this.toolStrip1.TabIndex = 21;
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
            this.gridControl1.DataSource = this.spSelectAllCostPriceRevisionsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 198);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(886, 199);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCostPriceRevisionsBindingSource
            // 
            this.spSelectAllCostPriceRevisionsBindingSource.DataMember = "spSelectAllCostPriceRevisions";
            this.spSelectAllCostPriceRevisionsBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // dsCostPriceRevisions
            // 
            this.dsCostPriceRevisions.DataSetName = "dsCostPriceRevisions";
            this.dsCostPriceRevisions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colItemCode,
            this.colUOM,
            this.colFromDate,
            this.colToDate,
            this.colVATRate,
            this.colUnitPrice,
            this.colPriceBand,
            this.colDiscount,
            this.colUnitCost});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 1;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 3;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 4;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 5;
            // 
            // colVATRate
            // 
            this.colVATRate.FieldName = "VATRate";
            this.colVATRate.Name = "colVATRate";
            this.colVATRate.Visible = true;
            this.colVATRate.VisibleIndex = 6;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 7;
            // 
            // colPriceBand
            // 
            this.colPriceBand.FieldName = "PriceBand";
            this.colPriceBand.Name = "colPriceBand";
            this.colPriceBand.Visible = true;
            this.colPriceBand.VisibleIndex = 8;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 9;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 10;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(91, 66);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(361, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 4;
            // 
            // spSelectCostPriceRevisionsBindingSource
            // 
            this.spSelectCostPriceRevisionsBindingSource.DataMember = "spSelectCostPriceRevisions";
            this.spSelectCostPriceRevisionsBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemCodeGridLookUpEdit
            // 
            this.ItemCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "ItemCode", true));
            this.ItemCodeGridLookUpEdit.Location = new System.Drawing.Point(523, 66);
            this.ItemCodeGridLookUpEdit.Name = "ItemCodeGridLookUpEdit";
            this.ItemCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemCodeGridLookUpEdit.Properties.DataSource = this.spGetItemsBindingSource;
            this.ItemCodeGridLookUpEdit.Properties.DisplayMember = "ItemDescription";
            this.ItemCodeGridLookUpEdit.Properties.NullText = "";
            this.ItemCodeGridLookUpEdit.Properties.ValueMember = "ItemCode";
            this.ItemCodeGridLookUpEdit.Properties.View = this.gridView1;
            this.ItemCodeGridLookUpEdit.Size = new System.Drawing.Size(363, 20);
            this.ItemCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemCodeGridLookUpEdit.TabIndex = 5;
            this.ItemCodeGridLookUpEdit.EditValueChanged += new System.EventHandler(this.ItemCodeGridLookUpEdit_EditValueChanged);
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // UOMGridLookUpEdit
            // 
            this.UOMGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "UOM", true));
            this.UOMGridLookUpEdit.Location = new System.Drawing.Point(91, 90);
            this.UOMGridLookUpEdit.Name = "UOMGridLookUpEdit";
            this.UOMGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UOMGridLookUpEdit.Properties.DataSource = this.spSelectAllUOMBindingSource;
            this.UOMGridLookUpEdit.Properties.DisplayMember = "Uom";
            this.UOMGridLookUpEdit.Properties.NullText = "";
            this.UOMGridLookUpEdit.Properties.ValueMember = "Uom";
            this.UOMGridLookUpEdit.Properties.View = this.gridView2;
            this.UOMGridLookUpEdit.Size = new System.Drawing.Size(361, 20);
            this.UOMGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.UOMGridLookUpEdit.TabIndex = 6;
            // 
            // spSelectAllUOMBindingSource
            // 
            this.spSelectAllUOMBindingSource.DataMember = "spSelectAllUOM";
            this.spSelectAllUOMBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // FromDateDateEdit
            // 
            this.FromDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "FromDate", true));
            this.FromDateDateEdit.EditValue = null;
            this.FromDateDateEdit.Location = new System.Drawing.Point(523, 90);
            this.FromDateDateEdit.Name = "FromDateDateEdit";
            this.FromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Size = new System.Drawing.Size(363, 20);
            this.FromDateDateEdit.StyleController = this.dataLayoutControl1;
            this.FromDateDateEdit.TabIndex = 7;
            // 
            // ToDateDateEdit
            // 
            this.ToDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "ToDate", true));
            this.ToDateDateEdit.EditValue = null;
            this.ToDateDateEdit.Location = new System.Drawing.Point(91, 114);
            this.ToDateDateEdit.Name = "ToDateDateEdit";
            this.ToDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Size = new System.Drawing.Size(361, 20);
            this.ToDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ToDateDateEdit.TabIndex = 8;
            // 
            // VATRateTextEdit
            // 
            this.VATRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "VATRate", true));
            this.VATRateTextEdit.Location = new System.Drawing.Point(523, 114);
            this.VATRateTextEdit.Name = "VATRateTextEdit";
            this.VATRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.VATRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.VATRateTextEdit.Properties.Mask.EditMask = "F";
            this.VATRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.VATRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.VATRateTextEdit.Size = new System.Drawing.Size(363, 20);
            this.VATRateTextEdit.StyleController = this.dataLayoutControl1;
            this.VATRateTextEdit.TabIndex = 9;
            // 
            // UnitPriceTextEdit
            // 
            this.UnitPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "UnitPrice", true));
            this.UnitPriceTextEdit.Location = new System.Drawing.Point(91, 138);
            this.UnitPriceTextEdit.Name = "UnitPriceTextEdit";
            this.UnitPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitPriceTextEdit.Properties.Mask.EditMask = "G";
            this.UnitPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitPriceTextEdit.Size = new System.Drawing.Size(361, 20);
            this.UnitPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitPriceTextEdit.TabIndex = 10;
            // 
            // PriceBandGridLookUpEdit
            // 
            this.PriceBandGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "PriceBand", true));
            this.PriceBandGridLookUpEdit.Location = new System.Drawing.Point(523, 138);
            this.PriceBandGridLookUpEdit.Name = "PriceBandGridLookUpEdit";
            this.PriceBandGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PriceBandGridLookUpEdit.Properties.DataSource = this.spGetPriceBandsBindingSource;
            this.PriceBandGridLookUpEdit.Properties.DisplayMember = "PriceBand";
            this.PriceBandGridLookUpEdit.Properties.NullText = "";
            this.PriceBandGridLookUpEdit.Properties.ValueMember = "PriceBand";
            this.PriceBandGridLookUpEdit.Properties.View = this.gridView3;
            this.PriceBandGridLookUpEdit.Size = new System.Drawing.Size(363, 20);
            this.PriceBandGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.PriceBandGridLookUpEdit.TabIndex = 11;
            // 
            // spGetPriceBandsBindingSource
            // 
            this.spGetPriceBandsBindingSource.DataMember = "spGetPriceBands";
            this.spGetPriceBandsBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // DiscountTextEdit
            // 
            this.DiscountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "Discount", true));
            this.DiscountTextEdit.Location = new System.Drawing.Point(91, 162);
            this.DiscountTextEdit.Name = "DiscountTextEdit";
            this.DiscountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DiscountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DiscountTextEdit.Properties.Mask.EditMask = "F";
            this.DiscountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DiscountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DiscountTextEdit.Size = new System.Drawing.Size(361, 20);
            this.DiscountTextEdit.StyleController = this.dataLayoutControl1;
            this.DiscountTextEdit.TabIndex = 12;
            // 
            // UnitCostTextEdit
            // 
            this.UnitCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostPriceRevisionsBindingSource, "UnitCost", true));
            this.UnitCostTextEdit.Location = new System.Drawing.Point(523, 162);
            this.UnitCostTextEdit.Name = "UnitCostTextEdit";
            this.UnitCostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitCostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitCostTextEdit.Properties.Mask.EditMask = "G";
            this.UnitCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitCostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitCostTextEdit.Size = new System.Drawing.Size(363, 20);
            this.UnitCostTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitCostTextEdit.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(910, 409);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(890, 389);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(890, 203);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(890, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemCode,
            this.ItemForFromDate,
            this.ItemForPriceBand,
            this.ItemForUnitCost,
            this.ItemForVATRate,
            this.ItemForCostCenter,
            this.ItemForUOM,
            this.ItemForToDate,
            this.ItemForUnitPrice,
            this.ItemForDiscount});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(890, 162);
            this.layoutControlGroup3.Text = "Cost Prices Revision";
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeGridLookUpEdit;
            this.ItemForItemCode.Location = new System.Drawing.Point(432, 0);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Size = new System.Drawing.Size(434, 24);
            this.ItemForItemCode.Text = "Item Code";
            this.ItemForItemCode.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForFromDate
            // 
            this.ItemForFromDate.Control = this.FromDateDateEdit;
            this.ItemForFromDate.Location = new System.Drawing.Point(432, 24);
            this.ItemForFromDate.Name = "ItemForFromDate";
            this.ItemForFromDate.Size = new System.Drawing.Size(434, 24);
            this.ItemForFromDate.Text = "From Date";
            this.ItemForFromDate.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForPriceBand
            // 
            this.ItemForPriceBand.Control = this.PriceBandGridLookUpEdit;
            this.ItemForPriceBand.Location = new System.Drawing.Point(432, 72);
            this.ItemForPriceBand.Name = "ItemForPriceBand";
            this.ItemForPriceBand.Size = new System.Drawing.Size(434, 24);
            this.ItemForPriceBand.Text = "Price Band";
            this.ItemForPriceBand.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForUnitCost
            // 
            this.ItemForUnitCost.Control = this.UnitCostTextEdit;
            this.ItemForUnitCost.Location = new System.Drawing.Point(432, 96);
            this.ItemForUnitCost.Name = "ItemForUnitCost";
            this.ItemForUnitCost.Size = new System.Drawing.Size(434, 24);
            this.ItemForUnitCost.Text = "Unit Cost";
            this.ItemForUnitCost.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForVATRate
            // 
            this.ItemForVATRate.Control = this.VATRateTextEdit;
            this.ItemForVATRate.Location = new System.Drawing.Point(432, 48);
            this.ItemForVATRate.Name = "ItemForVATRate";
            this.ItemForVATRate.Size = new System.Drawing.Size(434, 24);
            this.ItemForVATRate.Text = "VAT Rate(%)";
            this.ItemForVATRate.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(432, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForUOM
            // 
            this.ItemForUOM.Control = this.UOMGridLookUpEdit;
            this.ItemForUOM.Location = new System.Drawing.Point(0, 24);
            this.ItemForUOM.Name = "ItemForUOM";
            this.ItemForUOM.Size = new System.Drawing.Size(432, 24);
            this.ItemForUOM.Text = "UOM";
            this.ItemForUOM.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForToDate
            // 
            this.ItemForToDate.Control = this.ToDateDateEdit;
            this.ItemForToDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForToDate.Name = "ItemForToDate";
            this.ItemForToDate.Size = new System.Drawing.Size(432, 24);
            this.ItemForToDate.Text = "To Date";
            this.ItemForToDate.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForUnitPrice
            // 
            this.ItemForUnitPrice.Control = this.UnitPriceTextEdit;
            this.ItemForUnitPrice.Location = new System.Drawing.Point(0, 72);
            this.ItemForUnitPrice.Name = "ItemForUnitPrice";
            this.ItemForUnitPrice.Size = new System.Drawing.Size(432, 24);
            this.ItemForUnitPrice.Text = "Unit Price";
            this.ItemForUnitPrice.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForDiscount
            // 
            this.ItemForDiscount.Control = this.DiscountTextEdit;
            this.ItemForDiscount.Location = new System.Drawing.Point(0, 96);
            this.ItemForDiscount.Name = "ItemForDiscount";
            this.ItemForDiscount.Size = new System.Drawing.Size(432, 24);
            this.ItemForDiscount.Text = "Discount(%)";
            this.ItemForDiscount.TextSize = new System.Drawing.Size(64, 13);
            // 
            // spSelectCostPriceRevisionsTableAdapter
            // 
            this.spSelectCostPriceRevisionsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCostPriceRevisionsTableAdapter
            // 
            this.spSelectAllCostPriceRevisionsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemsTableAdapter
            // 
            this.spGetItemsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetPriceBandsTableAdapter
            // 
            this.spGetPriceBandsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllUOMTableAdapter
            // 
            this.spSelectAllUOMTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectItemUnitCostBindingSource
            // 
            this.spSelectItemUnitCostBindingSource.DataMember = "spSelectItemUnitCost";
            this.spSelectItemUnitCostBindingSource.DataSource = this.dsCostPriceRevisions;
            // 
            // spSelectItemUnitCostTableAdapter
            // 
            this.spSelectItemUnitCostTableAdapter.ClearBeforeFill = true;
            // 
            // frmCostPriceRevisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 409);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCostPriceRevisions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostPriceRevisions";
            this.Load += new System.EventHandler(this.frmCostPriceRevisions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCostPriceRevisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostPriceRevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCostPriceRevisionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBandGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPriceBandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVATRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectItemUnitCostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectCostPriceRevisionsBindingSource;
        private Class.DataSet.dsCostPriceRevisions dsCostPriceRevisions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit ItemCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit UOMGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit FromDateDateEdit;
        private DevExpress.XtraEditors.DateEdit ToDateDateEdit;
        private DevExpress.XtraEditors.TextEdit VATRateTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitPriceTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit PriceBandGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit DiscountTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitCostTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUOM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVATRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPriceBand;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitCost;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectCostPriceRevisionsTableAdapter spSelectCostPriceRevisionsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource spSelectAllCostPriceRevisionsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVATRate;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBand;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectAllCostPriceRevisionsTableAdapter spSelectAllCostPriceRevisionsTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private System.Windows.Forms.BindingSource spGetPriceBandsBindingSource;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spGetPriceBandsTableAdapter spGetPriceBandsTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllUOMBindingSource;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectAllUOMTableAdapter spSelectAllUOMTableAdapter;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource spSelectItemUnitCostBindingSource;
        private Class.DataSet.dsCostPriceRevisionsTableAdapters.spSelectItemUnitCostTableAdapter spSelectItemUnitCostTableAdapter;
    }
}