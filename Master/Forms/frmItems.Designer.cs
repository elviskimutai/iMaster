namespace Master.Forms
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.comboBoxEditStockType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spSelectItemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItemMaster = new Master.Class.DataSet.dsItemMaster();
            this.txVATRate = new DevExpress.XtraEditors.TextEdit();
            this.ItemCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spSelectAllItemCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Submit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllItemMasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimarySupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowBackOrders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisTaxable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSafetyStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BarCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UOMLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spSelectAllUOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ReorderLevelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AllowBackOrdersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isTaxableCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.SafetyStockTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PrimarySupplierLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBarCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUOM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSafetyStock = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReorderLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrimarySupplier = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAllowBackOrders = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForisActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForisTaxable = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectAllItemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectItemMasterTableAdapter = new Master.Class.DataSet.dsItemMasterTableAdapters.spSelectItemMasterTableAdapter();
            this.spSelectAllItemMasterTableAdapter = new Master.Class.DataSet.dsItemMasterTableAdapters.spSelectAllItemMasterTableAdapter();
            this.spGetSuppliersTableAdapter = new Master.Class.DataSet.dsItemMasterTableAdapters.spGetSuppliersTableAdapter();
            this.spSelectAllUOMTableAdapter = new Master.Class.DataSet.dsItemMasterTableAdapters.spSelectAllUOMTableAdapter();
            this.spSelectAllItemCategoriesTableAdapter = new Master.Class.DataSet.dsItemMasterTableAdapters.spSelectAllItemCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStockType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectItemMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txVATRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllItemCategoriesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllItemMasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorderLevelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowBackOrdersCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isTaxableCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafetyStockTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySupplierLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSafetyStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrimarySupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAllowBackOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisTaxable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllItemMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.comboBoxEditStockType);
            this.dataLayoutControl1.Controls.Add(this.txVATRate);
            this.dataLayoutControl1.Controls.Add(this.ItemCategoryLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BarCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemDescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UOMLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitCostTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ReorderLevelTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AllowBackOrdersCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.isTaxableCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.isActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.SafetyStockTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PrimarySupplierLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spSelectItemMasterBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(934, 456);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // comboBoxEditStockType
            // 
            this.comboBoxEditStockType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "StockType", true));
            this.comboBoxEditStockType.Location = new System.Drawing.Point(105, 114);
            this.comboBoxEditStockType.Name = "comboBoxEditStockType";
            this.comboBoxEditStockType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditStockType.Properties.Items.AddRange(new object[] {
            "Stock Item",
            "Non-Stock Item"});
            this.comboBoxEditStockType.Size = new System.Drawing.Size(359, 20);
            this.comboBoxEditStockType.StyleController = this.dataLayoutControl1;
            this.comboBoxEditStockType.TabIndex = 29;
            // 
            // spSelectItemMasterBindingSource
            // 
            this.spSelectItemMasterBindingSource.DataMember = "spSelectItemMaster";
            this.spSelectItemMasterBindingSource.DataSource = this.dsItemMaster;
            // 
            // dsItemMaster
            // 
            this.dsItemMaster.DataSetName = "dsItemMaster";
            this.dsItemMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txVATRate
            // 
            this.txVATRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "VATRate", true));
            this.txVATRate.Location = new System.Drawing.Point(549, 210);
            this.txVATRate.Name = "txVATRate";
            this.txVATRate.Size = new System.Drawing.Size(361, 20);
            this.txVATRate.StyleController = this.dataLayoutControl1;
            this.txVATRate.TabIndex = 28;
            // 
            // ItemCategoryLookUpEdit
            // 
            this.ItemCategoryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "ItemCategory", true));
            this.ItemCategoryLookUpEdit.Location = new System.Drawing.Point(549, 90);
            this.ItemCategoryLookUpEdit.Name = "ItemCategoryLookUpEdit";
            this.ItemCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemCategoryLookUpEdit.Properties.DataSource = this.spSelectAllItemCategoriesBindingSource;
            this.ItemCategoryLookUpEdit.Properties.DisplayMember = "Category";
            this.ItemCategoryLookUpEdit.Properties.NullText = "";
            this.ItemCategoryLookUpEdit.Properties.ValueMember = "Category";
            this.ItemCategoryLookUpEdit.Size = new System.Drawing.Size(361, 20);
            this.ItemCategoryLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemCategoryLookUpEdit.TabIndex = 27;
            // 
            // spSelectAllItemCategoriesBindingSource
            // 
            this.spSelectAllItemCategoriesBindingSource.DataMember = "spSelectAllItemCategories";
            this.spSelectAllItemCategoriesBindingSource.DataSource = this.dsItemMaster;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.Submit,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(584, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 20);
            this.toolStrip1.TabIndex = 26;
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
            // Submit
            // 
            this.Submit.Image = ((System.Drawing.Image)(resources.GetObject("Submit.Image")));
            this.Submit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(47, 17);
            this.Submit.Text = "Edit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
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
            this.gridControl1.DataSource = this.spSelectAllItemMasterBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 270);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(910, 174);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllItemMasterBindingSource1
            // 
            this.spSelectAllItemMasterBindingSource1.DataMember = "spSelectAllItemMaster";
            this.spSelectAllItemMasterBindingSource1.DataSource = this.dsItemMaster;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colItemCode,
            this.colBarCode,
            this.colItemDescription,
            this.colUOM,
            this.colUnitPrice,
            this.colUnitCost,
            this.colPrimarySupplier,
            this.colReorderLevel,
            this.colAllowBackOrders,
            this.colNarration,
            this.colItemCategory,
            this.colisTaxable,
            this.colisActive,
            this.colSafetyStock});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            // 
            // colBarCode
            // 
            this.colBarCode.FieldName = "BarCode";
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.Visible = true;
            this.colBarCode.VisibleIndex = 2;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 3;
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 4;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 5;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 6;
            // 
            // colPrimarySupplier
            // 
            this.colPrimarySupplier.FieldName = "PrimarySupplier";
            this.colPrimarySupplier.Name = "colPrimarySupplier";
            this.colPrimarySupplier.Visible = true;
            this.colPrimarySupplier.VisibleIndex = 7;
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.FieldName = "ReorderLevel";
            this.colReorderLevel.Name = "colReorderLevel";
            this.colReorderLevel.Visible = true;
            this.colReorderLevel.VisibleIndex = 8;
            // 
            // colAllowBackOrders
            // 
            this.colAllowBackOrders.FieldName = "AllowBackOrders";
            this.colAllowBackOrders.Name = "colAllowBackOrders";
            this.colAllowBackOrders.Visible = true;
            this.colAllowBackOrders.VisibleIndex = 9;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 10;
            // 
            // colItemCategory
            // 
            this.colItemCategory.FieldName = "ItemCategory";
            this.colItemCategory.Name = "colItemCategory";
            this.colItemCategory.Visible = true;
            this.colItemCategory.VisibleIndex = 11;
            // 
            // colisTaxable
            // 
            this.colisTaxable.FieldName = "isTaxable";
            this.colisTaxable.Name = "colisTaxable";
            this.colisTaxable.Visible = true;
            this.colisTaxable.VisibleIndex = 12;
            // 
            // colisActive
            // 
            this.colisActive.FieldName = "isActive";
            this.colisActive.Name = "colisActive";
            this.colisActive.Visible = true;
            this.colisActive.VisibleIndex = 13;
            // 
            // colSafetyStock
            // 
            this.colSafetyStock.FieldName = "SafetyStock";
            this.colSafetyStock.Name = "colSafetyStock";
            this.colSafetyStock.Visible = true;
            this.colSafetyStock.VisibleIndex = 14;
            // 
            // ItemCodeTextEdit
            // 
            this.ItemCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "ItemCode", true));
            this.ItemCodeTextEdit.Enabled = false;
            this.ItemCodeTextEdit.Location = new System.Drawing.Point(105, 66);
            this.ItemCodeTextEdit.Name = "ItemCodeTextEdit";
            this.ItemCodeTextEdit.Size = new System.Drawing.Size(359, 20);
            this.ItemCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.ItemCodeTextEdit.TabIndex = 4;
            // 
            // BarCodeTextEdit
            // 
            this.BarCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "BarCode", true));
            this.BarCodeTextEdit.Location = new System.Drawing.Point(549, 66);
            this.BarCodeTextEdit.Name = "BarCodeTextEdit";
            this.BarCodeTextEdit.Size = new System.Drawing.Size(361, 20);
            this.BarCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.BarCodeTextEdit.TabIndex = 5;
            // 
            // ItemDescriptionTextEdit
            // 
            this.ItemDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "ItemDescription", true));
            this.ItemDescriptionTextEdit.Location = new System.Drawing.Point(105, 90);
            this.ItemDescriptionTextEdit.Name = "ItemDescriptionTextEdit";
            this.ItemDescriptionTextEdit.Size = new System.Drawing.Size(359, 20);
            this.ItemDescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.ItemDescriptionTextEdit.TabIndex = 6;
            // 
            // UOMLookUpEdit
            // 
            this.UOMLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "UOM", true));
            this.UOMLookUpEdit.Location = new System.Drawing.Point(549, 114);
            this.UOMLookUpEdit.Name = "UOMLookUpEdit";
            this.UOMLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UOMLookUpEdit.Properties.DataSource = this.spSelectAllUOMBindingSource;
            this.UOMLookUpEdit.Properties.DisplayMember = "Uom";
            this.UOMLookUpEdit.Properties.NullText = "";
            this.UOMLookUpEdit.Properties.ValueMember = "Uom";
            this.UOMLookUpEdit.Size = new System.Drawing.Size(361, 20);
            this.UOMLookUpEdit.StyleController = this.dataLayoutControl1;
            this.UOMLookUpEdit.TabIndex = 7;
            // 
            // spSelectAllUOMBindingSource
            // 
            this.spSelectAllUOMBindingSource.DataMember = "spSelectAllUOM";
            this.spSelectAllUOMBindingSource.DataSource = this.dsItemMaster;
            // 
            // UnitPriceTextEdit
            // 
            this.UnitPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "UnitPrice", true));
            this.UnitPriceTextEdit.Location = new System.Drawing.Point(549, 138);
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
            // UnitCostTextEdit
            // 
            this.UnitCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "UnitCost", true));
            this.UnitCostTextEdit.Location = new System.Drawing.Point(105, 138);
            this.UnitCostTextEdit.Name = "UnitCostTextEdit";
            this.UnitCostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitCostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitCostTextEdit.Properties.Mask.EditMask = "G";
            this.UnitCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitCostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitCostTextEdit.Size = new System.Drawing.Size(359, 20);
            this.UnitCostTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitCostTextEdit.TabIndex = 11;
            // 
            // ReorderLevelTextEdit
            // 
            this.ReorderLevelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "ReorderLevel", true));
            this.ReorderLevelTextEdit.Location = new System.Drawing.Point(549, 162);
            this.ReorderLevelTextEdit.Name = "ReorderLevelTextEdit";
            this.ReorderLevelTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ReorderLevelTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ReorderLevelTextEdit.Properties.Mask.EditMask = "F";
            this.ReorderLevelTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ReorderLevelTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ReorderLevelTextEdit.Size = new System.Drawing.Size(361, 20);
            this.ReorderLevelTextEdit.StyleController = this.dataLayoutControl1;
            this.ReorderLevelTextEdit.TabIndex = 13;
            // 
            // AllowBackOrdersCheckEdit
            // 
            this.AllowBackOrdersCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "AllowBackOrders", true));
            this.AllowBackOrdersCheckEdit.Location = new System.Drawing.Point(468, 186);
            this.AllowBackOrdersCheckEdit.Name = "AllowBackOrdersCheckEdit";
            this.AllowBackOrdersCheckEdit.Properties.Caption = "AllowBackOrders";
            this.AllowBackOrdersCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.AllowBackOrdersCheckEdit.Size = new System.Drawing.Size(442, 19);
            this.AllowBackOrdersCheckEdit.StyleController = this.dataLayoutControl1;
            this.AllowBackOrdersCheckEdit.TabIndex = 14;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(550, 234);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(360, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 15;
            // 
            // isTaxableCheckEdit
            // 
            this.isTaxableCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "isTaxable", true));
            this.isTaxableCheckEdit.EditValue = true;
            this.isTaxableCheckEdit.Location = new System.Drawing.Point(24, 210);
            this.isTaxableCheckEdit.Name = "isTaxableCheckEdit";
            this.isTaxableCheckEdit.Properties.Caption = "IsTaxable";
            this.isTaxableCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isTaxableCheckEdit.Size = new System.Drawing.Size(440, 19);
            this.isTaxableCheckEdit.StyleController = this.dataLayoutControl1;
            this.isTaxableCheckEdit.TabIndex = 17;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "isActive", true));
            this.isActiveCheckEdit.EditValue = true;
            this.isActiveCheckEdit.Location = new System.Drawing.Point(24, 234);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "IsActive";
            this.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isActiveCheckEdit.Size = new System.Drawing.Size(441, 19);
            this.isActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.isActiveCheckEdit.TabIndex = 18;
            // 
            // SafetyStockTextEdit
            // 
            this.SafetyStockTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "SafetyStock", true));
            this.SafetyStockTextEdit.Location = new System.Drawing.Point(105, 162);
            this.SafetyStockTextEdit.Name = "SafetyStockTextEdit";
            this.SafetyStockTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SafetyStockTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SafetyStockTextEdit.Properties.Mask.EditMask = "F";
            this.SafetyStockTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SafetyStockTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SafetyStockTextEdit.Size = new System.Drawing.Size(359, 20);
            this.SafetyStockTextEdit.StyleController = this.dataLayoutControl1;
            this.SafetyStockTextEdit.TabIndex = 19;
            // 
            // PrimarySupplierLookUpEdit
            // 
            this.PrimarySupplierLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectItemMasterBindingSource, "PrimarySupplier", true));
            this.PrimarySupplierLookUpEdit.Location = new System.Drawing.Point(105, 186);
            this.PrimarySupplierLookUpEdit.Name = "PrimarySupplierLookUpEdit";
            this.PrimarySupplierLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PrimarySupplierLookUpEdit.Properties.DataSource = this.spGetSuppliersBindingSource;
            this.PrimarySupplierLookUpEdit.Properties.DisplayMember = "Supplier Name";
            this.PrimarySupplierLookUpEdit.Properties.NullText = "";
            this.PrimarySupplierLookUpEdit.Properties.ValueMember = "Supplier Code";
            this.PrimarySupplierLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.PrimarySupplierLookUpEdit.Size = new System.Drawing.Size(359, 20);
            this.PrimarySupplierLookUpEdit.StyleController = this.dataLayoutControl1;
            this.PrimarySupplierLookUpEdit.TabIndex = 12;
            // 
            // spGetSuppliersBindingSource
            // 
            this.spGetSuppliersBindingSource.DataMember = "spGetSuppliers";
            this.spGetSuppliersBindingSource.DataSource = this.dsItemMaster;
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(934, 456);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup3,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(914, 436);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 258);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(914, 178);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemDescription,
            this.ItemForItemCode,
            this.ItemForBarCode,
            this.layoutControlItem3,
            this.ItemForUnitCost,
            this.ItemForUnitPrice,
            this.layoutControlItem5,
            this.ItemForUOM,
            this.ItemForSafetyStock,
            this.ItemForReorderLevel,
            this.ItemForPrimarySupplier,
            this.layoutControlItem4,
            this.ItemForAllowBackOrders,
            this.ItemForisActive,
            this.ItemForisTaxable,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(914, 234);
            this.layoutControlGroup3.Text = "Items";
            // 
            // ItemForItemDescription
            // 
            this.ItemForItemDescription.Control = this.ItemDescriptionTextEdit;
            this.ItemForItemDescription.Location = new System.Drawing.Point(0, 24);
            this.ItemForItemDescription.Name = "ItemForItemDescription";
            this.ItemForItemDescription.Size = new System.Drawing.Size(444, 24);
            this.ItemForItemDescription.Text = "Item Description";
            this.ItemForItemDescription.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeTextEdit;
            this.ItemForItemCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Size = new System.Drawing.Size(444, 24);
            this.ItemForItemCode.Text = "Item Code";
            this.ItemForItemCode.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForBarCode
            // 
            this.ItemForBarCode.Control = this.BarCodeTextEdit;
            this.ItemForBarCode.Location = new System.Drawing.Point(444, 0);
            this.ItemForBarCode.Name = "ItemForBarCode";
            this.ItemForBarCode.Size = new System.Drawing.Size(446, 24);
            this.ItemForBarCode.Text = "Bar Code";
            this.ItemForBarCode.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ItemCategoryLookUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(444, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(446, 24);
            this.layoutControlItem3.Text = "ItemCategory";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForUnitCost
            // 
            this.ItemForUnitCost.Control = this.UnitCostTextEdit;
            this.ItemForUnitCost.Location = new System.Drawing.Point(0, 72);
            this.ItemForUnitCost.Name = "ItemForUnitCost";
            this.ItemForUnitCost.Size = new System.Drawing.Size(444, 24);
            this.ItemForUnitCost.Text = "Unit Cost";
            this.ItemForUnitCost.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForUnitPrice
            // 
            this.ItemForUnitPrice.Control = this.UnitPriceTextEdit;
            this.ItemForUnitPrice.Location = new System.Drawing.Point(444, 72);
            this.ItemForUnitPrice.Name = "ItemForUnitPrice";
            this.ItemForUnitPrice.Size = new System.Drawing.Size(446, 24);
            this.ItemForUnitPrice.Text = "Unit Price";
            this.ItemForUnitPrice.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.comboBoxEditStockType;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem5.Text = "Stock Type";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForUOM
            // 
            this.ItemForUOM.Control = this.UOMLookUpEdit;
            this.ItemForUOM.Location = new System.Drawing.Point(444, 48);
            this.ItemForUOM.Name = "ItemForUOM";
            this.ItemForUOM.Size = new System.Drawing.Size(446, 24);
            this.ItemForUOM.Text = "UOM";
            this.ItemForUOM.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForSafetyStock
            // 
            this.ItemForSafetyStock.Control = this.SafetyStockTextEdit;
            this.ItemForSafetyStock.Location = new System.Drawing.Point(0, 96);
            this.ItemForSafetyStock.Name = "ItemForSafetyStock";
            this.ItemForSafetyStock.Size = new System.Drawing.Size(444, 24);
            this.ItemForSafetyStock.Text = "Safety Stock";
            this.ItemForSafetyStock.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForReorderLevel
            // 
            this.ItemForReorderLevel.Control = this.ReorderLevelTextEdit;
            this.ItemForReorderLevel.Location = new System.Drawing.Point(444, 96);
            this.ItemForReorderLevel.Name = "ItemForReorderLevel";
            this.ItemForReorderLevel.Size = new System.Drawing.Size(446, 24);
            this.ItemForReorderLevel.Text = "Reorder Level";
            this.ItemForReorderLevel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForPrimarySupplier
            // 
            this.ItemForPrimarySupplier.Control = this.PrimarySupplierLookUpEdit;
            this.ItemForPrimarySupplier.Location = new System.Drawing.Point(0, 120);
            this.ItemForPrimarySupplier.Name = "ItemForPrimarySupplier";
            this.ItemForPrimarySupplier.Size = new System.Drawing.Size(444, 24);
            this.ItemForPrimarySupplier.Text = "Primary Supplier";
            this.ItemForPrimarySupplier.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForPrimarySupplier.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txVATRate;
            this.layoutControlItem4.Location = new System.Drawing.Point(444, 144);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(446, 24);
            this.layoutControlItem4.Text = "VAT Rate";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForAllowBackOrders
            // 
            this.ItemForAllowBackOrders.Control = this.AllowBackOrdersCheckEdit;
            this.ItemForAllowBackOrders.Location = new System.Drawing.Point(444, 120);
            this.ItemForAllowBackOrders.Name = "ItemForAllowBackOrders";
            this.ItemForAllowBackOrders.Size = new System.Drawing.Size(446, 24);
            this.ItemForAllowBackOrders.Text = "Allow Back Orders";
            this.ItemForAllowBackOrders.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForAllowBackOrders.TextVisible = false;
            // 
            // ItemForisActive
            // 
            this.ItemForisActive.Control = this.isActiveCheckEdit;
            this.ItemForisActive.Location = new System.Drawing.Point(0, 168);
            this.ItemForisActive.Name = "ItemForisActive";
            this.ItemForisActive.Size = new System.Drawing.Size(445, 24);
            this.ItemForisActive.Text = "is Active";
            this.ItemForisActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisActive.TextVisible = false;
            // 
            // ItemForisTaxable
            // 
            this.ItemForisTaxable.Control = this.isTaxableCheckEdit;
            this.ItemForisTaxable.Location = new System.Drawing.Point(0, 144);
            this.ItemForisTaxable.Name = "ItemForisTaxable";
            this.ItemForisTaxable.Size = new System.Drawing.Size(444, 24);
            this.ItemForisTaxable.Text = "is Taxable";
            this.ItemForisTaxable.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisTaxable.TextVisible = false;
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(445, 168);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(445, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(914, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectAllItemMasterBindingSource
            // 
            this.spSelectAllItemMasterBindingSource.DataMember = "spSelectAllItemMaster";
            this.spSelectAllItemMasterBindingSource.DataSource = this.dsItemMaster;
            // 
            // spSelectItemMasterTableAdapter
            // 
            this.spSelectItemMasterTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllItemMasterTableAdapter
            // 
            this.spSelectAllItemMasterTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSuppliersTableAdapter
            // 
            this.spGetSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllUOMTableAdapter
            // 
            this.spSelectAllUOMTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllItemCategoriesTableAdapter
            // 
            this.spSelectAllItemCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 456);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStockType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectItemMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txVATRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllItemCategoriesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllItemMasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorderLevelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowBackOrdersCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isTaxableCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafetyStockTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimarySupplierLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSafetyStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrimarySupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAllowBackOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisTaxable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllItemMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit ItemCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectItemMasterBindingSource;
        private Class.DataSet.dsItemMaster dsItemMaster;
        private DevExpress.XtraEditors.TextEdit BarCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit ItemDescriptionTextEdit;
        private DevExpress.XtraEditors.LookUpEdit UOMLookUpEdit;
        private DevExpress.XtraEditors.TextEdit UnitPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitCostTextEdit;
        private DevExpress.XtraEditors.TextEdit ReorderLevelTextEdit;
        private DevExpress.XtraEditors.CheckEdit AllowBackOrdersCheckEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraEditors.CheckEdit isTaxableCheckEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit SafetyStockTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBarCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUOM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitCost;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrimarySupplier;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReorderLevel;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAllowBackOrders;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisTaxable;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSafetyStock;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsItemMasterTableAdapters.spSelectItemMasterTableAdapter spSelectItemMasterTableAdapter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource spSelectAllItemMasterBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimarySupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowBackOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colisTaxable;
        private DevExpress.XtraGrid.Columns.GridColumn colisActive;
        private DevExpress.XtraGrid.Columns.GridColumn colSafetyStock;
        private Class.DataSet.dsItemMasterTableAdapters.spSelectAllItemMasterTableAdapter spSelectAllItemMasterTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Submit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit ItemCategoryLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GridLookUpEdit PrimarySupplierLookUpEdit;
        private System.Windows.Forms.BindingSource spGetSuppliersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Class.DataSet.dsItemMasterTableAdapters.spGetSuppliersTableAdapter spGetSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllUOMBindingSource;
        private Class.DataSet.dsItemMasterTableAdapters.spSelectAllUOMTableAdapter spSelectAllUOMTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllItemCategoriesBindingSource;
        private Class.DataSet.dsItemMasterTableAdapters.spSelectAllItemCategoriesTableAdapter spSelectAllItemCategoriesTableAdapter;
        private DevExpress.XtraEditors.TextEdit txVATRate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditStockType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource spSelectAllItemMasterBindingSource1;
    }
}