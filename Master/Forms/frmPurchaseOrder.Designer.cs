namespace Master.Forms
{
    partial class frmPurchaseOrder
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchaseOrderBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchaseOrder = new Master.Class.DataSet.dsPurchaseOrder();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipToAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayableAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDeliveryPeriod = new DevExpress.XtraEditors.TextEdit();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glItemCode = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glSuppliers = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glWarehouse = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblNetCost = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetSuppliersTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spGetSuppliersTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spGetItemsTableAdapter();
            this.purchaseOrderBufferTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.PurchaseOrderBufferTableAdapter();
            this.spGetItemCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetItemCodesTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spGetItemCodesTableAdapter();
            this.spSelectAllPurchaseOrderBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectAllPurchaseOrderBufferTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spSelectAllPurchaseOrderBufferTableAdapter();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.spGetNetAmountPurchaseOrderBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetNetAmountPurchaseOrderBufferTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spGetNetAmountPurchaseOrderBufferTableAdapter();
            this.spGetWarehousesTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.spGetWarehousesTableAdapter();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currenciesTableAdapter = new Master.Class.DataSet.dsPurchaseOrderTableAdapters.CurrenciesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPurchaseOrderBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetNetAmountPurchaseOrderBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(251, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 512);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchaseOrderBufferBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinName = "Office 2013";
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(817, 512);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseOrderBufferBindingSource
            // 
            this.purchaseOrderBufferBindingSource.DataMember = "PurchaseOrderBuffer";
            this.purchaseOrderBufferBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // dsPurchaseOrder
            // 
            this.dsPurchaseOrder.DataSetName = "dsPurchaseOrder";
            this.dsPurchaseOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colSupplierCode,
            this.colShipToAddress,
            this.colItemCode,
            this.colItemDescription,
            this.colQuantity,
            this.colUOM,
            this.colUnitCost,
            this.colExtendedCost,
            this.colTaxRate,
            this.colTaxAmount,
            this.colDiscountRate,
            this.colDiscountAmount,
            this.colNetAmount,
            this.colDeliveryPeriod,
            this.colPayableAmount,
            this.colTerminus,
            this.Remove});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.ColumnUnboundExpressionChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.gridView1_ColumnUnboundExpressionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.FocusedRowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.gridView1_FocusedRowLoaded);
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.FieldName = "SupplierCode";
            this.colSupplierCode.Name = "colSupplierCode";
            // 
            // colShipToAddress
            // 
            this.colShipToAddress.FieldName = "ShipToAddress";
            this.colShipToAddress.Name = "colShipToAddress";
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 65;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 1;
            this.colItemDescription.Width = 65;
            // 
            // colQuantity
            // 
            this.colQuantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 65;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemSpinEdit1_ValueChanged);
            this.repositoryItemSpinEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemSpinEdit1_ValueChanged);
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 3;
            this.colUOM.Width = 65;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 4;
            this.colUnitCost.Width = 65;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.Caption = "ExtendedCost";
            this.colExtendedCost.FieldName = "ExtendedCosts";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExtendedCosts", "SUM={0:n2}")});
            this.colExtendedCost.UnboundExpression = "[Quantity]*[UnitCost]";
            this.colExtendedCost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 5;
            this.colExtendedCost.Width = 65;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "TaxRate(%)";
            this.colTaxRate.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 6;
            this.colTaxRate.Width = 65;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.Caption = "TaxAmount";
            this.colTaxAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmount.FieldName = "TaxAmounts";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TaxAmounts", "SUM={0:0.##}")});
            this.colTaxAmount.UnboundExpression = "[UnitCost] * [Quantity] * [TaxRate] / ([TaxRate] + 100)";
            this.colTaxAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 7;
            this.colTaxAmount.Width = 65;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.Caption = "DiscountRate(%)";
            this.colDiscountRate.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.Visible = true;
            this.colDiscountRate.VisibleIndex = 8;
            this.colDiscountRate.Width = 65;
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colDiscountAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountAmount.FieldName = "DiscountAmounts";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiscountAmounts", "SUM={0:n2}")});
            this.colDiscountAmount.UnboundExpression = "[DiscountRate] / 100 * ([UnitCost] * [Quantity] - [UnitCost] * [Quantity] * [TaxR" +
    "ate] / ([TaxRate] + 100))";
            this.colDiscountAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiscountAmount.Visible = true;
            this.colDiscountAmount.VisibleIndex = 9;
            this.colDiscountAmount.Width = 120;
            // 
            // colNetAmount
            // 
            this.colNetAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colNetAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetAmount.FieldName = "NetAmounts";
            this.colNetAmount.MaxWidth = 110;
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetAmounts", "SUM={0:n2}")});
            this.colNetAmount.UnboundExpression = "[ExtendedCosts] - ([DiscountAmounts] + [TaxAmounts])";
            this.colNetAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNetAmount.Visible = true;
            this.colNetAmount.VisibleIndex = 10;
            this.colNetAmount.Width = 110;
            // 
            // colDeliveryPeriod
            // 
            this.colDeliveryPeriod.FieldName = "DeliveryPeriod";
            this.colDeliveryPeriod.Name = "colDeliveryPeriod";
            // 
            // colPayableAmount
            // 
            this.colPayableAmount.Caption = "Total Cost";
            this.colPayableAmount.FieldName = "colPayableAmount";
            this.colPayableAmount.Name = "colPayableAmount";
            this.colPayableAmount.UnboundExpression = "[ExtendedCosts] - [DiscountAmounts]";
            this.colPayableAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colPayableAmount.Visible = true;
            this.colPayableAmount.VisibleIndex = 11;
            // 
            // colTerminus
            // 
            this.colTerminus.FieldName = "Terminus";
            this.colTerminus.Name = "colTerminus";
            // 
            // Remove
            // 
            this.Remove.Caption = "Remove";
            this.Remove.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Remove.Name = "Remove";
            this.Remove.Visible = true;
            this.Remove.VisibleIndex = 12;
            this.Remove.Width = 20;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = global::Master.Properties.Resources.delete2;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.toolStripButton1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1068, 20);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(75, 17);
            this.saveToolStripButton.Text = "Purchase";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 17);
            this.cutToolStripButton.Text = "Edit";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(63, 17);
            this.copyToolStripButton.Text = "Cancel";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 17);
            this.toolStripButton1.Text = "Export";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 17);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 311);
            this.panel3.TabIndex = 20;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDeliveryPeriod);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Controls.Add(this.glItemCode);
            this.layoutControl1.Controls.Add(this.glSuppliers);
            this.layoutControl1.Controls.Add(this.glWarehouse);
            this.layoutControl1.Controls.Add(this.glCurrency);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(248, 311);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDeliveryPeriod
            // 
            this.txtDeliveryPeriod.Location = new System.Drawing.Point(12, 166);
            this.txtDeliveryPeriod.Name = "txtDeliveryPeriod";
            this.txtDeliveryPeriod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryPeriod.Properties.Appearance.Options.UseFont = true;
            this.txtDeliveryPeriod.Size = new System.Drawing.Size(224, 26);
            this.txtDeliveryPeriod.StyleController = this.layoutControl1;
            this.txtDeliveryPeriod.TabIndex = 8;
            // 
            // glCostCenter
            // 
            this.glCostCenter.Location = new System.Drawing.Point(12, 28);
            this.glCostCenter.Name = "glCostCenter";
            this.glCostCenter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glCostCenter.Properties.Appearance.Options.UseFont = true;
            this.glCostCenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCostCenter.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.glCostCenter.Properties.DisplayMember = "ccname";
            this.glCostCenter.Properties.ValueMember = "cccode";
            this.glCostCenter.Properties.View = this.gridLookUpEdit3View;
            this.glCostCenter.Size = new System.Drawing.Size(224, 26);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 7;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // glItemCode
            // 
            this.glItemCode.EditValue = "[Select Item]";
            this.glItemCode.Location = new System.Drawing.Point(12, 212);
            this.glItemCode.Name = "glItemCode";
            this.glItemCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glItemCode.Properties.Appearance.Options.UseFont = true;
            this.glItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glItemCode.Properties.DataSource = this.spGetItemsBindingSource;
            this.glItemCode.Properties.DisplayMember = "ItemDescription";
            this.glItemCode.Properties.ValueMember = "ItemCode";
            this.glItemCode.Properties.View = this.gridLookUpEdit2View;
            this.glItemCode.Size = new System.Drawing.Size(224, 26);
            this.glItemCode.StyleController = this.layoutControl1;
            this.glItemCode.TabIndex = 5;
            this.glItemCode.EditValueChanged += new System.EventHandler(this.glItemCode_EditValueChanged);
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // glSuppliers
            // 
            this.glSuppliers.Location = new System.Drawing.Point(12, 74);
            this.glSuppliers.Name = "glSuppliers";
            this.glSuppliers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glSuppliers.Properties.Appearance.Options.UseFont = true;
            this.glSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glSuppliers.Properties.DataSource = this.spGetSuppliersBindingSource;
            this.glSuppliers.Properties.DisplayMember = "Supplier Name";
            this.glSuppliers.Properties.ValueMember = "Supplier Code";
            this.glSuppliers.Properties.View = this.gridLookUpEdit1View;
            this.glSuppliers.Size = new System.Drawing.Size(224, 26);
            this.glSuppliers.StyleController = this.layoutControl1;
            this.glSuppliers.TabIndex = 4;
            // 
            // spGetSuppliersBindingSource
            // 
            this.spGetSuppliersBindingSource.DataMember = "spGetSuppliers";
            this.spGetSuppliersBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // glWarehouse
            // 
            this.glWarehouse.Location = new System.Drawing.Point(12, 120);
            this.glWarehouse.Name = "glWarehouse";
            this.glWarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glWarehouse.Properties.Appearance.Options.UseFont = true;
            this.glWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glWarehouse.Properties.DataSource = this.spGetWarehousesBindingSource;
            this.glWarehouse.Properties.DisplayMember = "LocationName";
            this.glWarehouse.Properties.ValueMember = "LocationCode";
            this.glWarehouse.Properties.View = this.gridView2;
            this.glWarehouse.Size = new System.Drawing.Size(224, 26);
            this.glWarehouse.StyleController = this.layoutControl1;
            this.glWarehouse.TabIndex = 4;
            // 
            // spGetWarehousesBindingSource
            // 
            this.spGetWarehousesBindingSource.DataMember = "spGetWarehouses";
            this.spGetWarehousesBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // glCurrency
            // 
            this.glCurrency.EditValue = "[Select Item]";
            this.glCurrency.Location = new System.Drawing.Point(12, 258);
            this.glCurrency.Name = "glCurrency";
            this.glCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glCurrency.Properties.Appearance.Options.UseFont = true;
            this.glCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCurrency.Properties.DataSource = this.currenciesBindingSource;
            this.glCurrency.Properties.DisplayMember = "CurrDesc";
            this.glCurrency.Properties.ValueMember = "CurrCode";
            this.glCurrency.Properties.View = this.gridView3;
            this.glCurrency.Size = new System.Drawing.Size(224, 26);
            this.glCurrency.StyleController = this.layoutControl1;
            this.glCurrency.TabIndex = 5;
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 311);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.glSuppliers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem1.Text = "Supplier";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glItemCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem2.Text = "Items";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.glCostCenter;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem4.Text = "CostCenter";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glWarehouse;
            this.layoutControlItem3.CustomizationFormText = "Supplier";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem3.Text = "Ship To Address";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDeliveryPeriod;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem5.Text = "Delivery Period";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.glCurrency;
            this.layoutControlItem6.CustomizationFormText = "Currency";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 230);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(228, 61);
            this.layoutControlItem6.Text = "Currency";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(77, 13);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.lblNetCost);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(251, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(817, 40);
            this.panelControl1.TabIndex = 22;
            // 
            // lblNetCost
            // 
            this.lblNetCost.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetCost.Appearance.Options.UseFont = true;
            this.lblNetCost.Location = new System.Drawing.Point(198, 9);
            this.lblNetCost.Name = "lblNetCost";
            this.lblNetCost.Size = new System.Drawing.Size(10, 23);
            this.lblNetCost.TabIndex = 1;
            this.lblNetCost.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(71, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Total Cost:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 346);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSuppliersTableAdapter
            // 
            this.spGetSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemsTableAdapter
            // 
            this.spGetItemsTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderBufferTableAdapter
            // 
            this.purchaseOrderBufferTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemCodesBindingSource
            // 
            this.spGetItemCodesBindingSource.DataMember = "spGetItemCodes";
            this.spGetItemCodesBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // spGetItemCodesTableAdapter
            // 
            this.spGetItemCodesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllPurchaseOrderBufferBindingSource
            // 
            this.spSelectAllPurchaseOrderBufferBindingSource.DataMember = "spSelectAllPurchaseOrderBuffer";
            this.spSelectAllPurchaseOrderBufferBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // spSelectAllPurchaseOrderBufferTableAdapter
            // 
            this.spSelectAllPurchaseOrderBufferTableAdapter.ClearBeforeFill = true;
            // 
            // imageSlider1
            // 
            this.imageSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze;
            this.imageSlider1.Location = new System.Drawing.Point(12, 509);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(227, 72);
            this.imageSlider1.TabIndex = 25;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // spGetNetAmountPurchaseOrderBufferBindingSource
            // 
            this.spGetNetAmountPurchaseOrderBufferBindingSource.DataMember = "spGetNetAmountPurchaseOrderBuffer";
            this.spGetNetAmountPurchaseOrderBufferBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // spGetNetAmountPurchaseOrderBufferTableAdapter
            // 
            this.spGetNetAmountPurchaseOrderBufferTableAdapter.ClearBeforeFill = true;
            // 
            // spGetWarehousesTableAdapter
            // 
            this.spGetWarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 586);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPurchaseOrderBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetNetAmountPurchaseOrderBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glItemCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit glSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblNetCost;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsPurchaseOrder dsPurchaseOrder;
        private System.Windows.Forms.BindingSource spGetSuppliersBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spGetSuppliersTableAdapter spGetSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private System.Windows.Forms.BindingSource purchaseOrderBufferBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.PurchaseOrderBufferTableAdapter purchaseOrderBufferTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierCode;
        private DevExpress.XtraGrid.Columns.GridColumn colShipToAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminus;
        private System.Windows.Forms.BindingSource spGetItemCodesBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spGetItemCodesTableAdapter spGetItemCodesTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllPurchaseOrderBufferBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spSelectAllPurchaseOrderBufferTableAdapter spSelectAllPurchaseOrderBufferTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Remove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.BindingSource spGetNetAmountPurchaseOrderBufferBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spGetNetAmountPurchaseOrderBufferTableAdapter spGetNetAmountPurchaseOrderBufferTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit glWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource spGetWarehousesBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.spGetWarehousesTableAdapter spGetWarehousesTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtDeliveryPeriod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colPayableAmount;
        private DevExpress.XtraEditors.GridLookUpEdit glCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private Class.DataSet.dsPurchaseOrderTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
    }
}