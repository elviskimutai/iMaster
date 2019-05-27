namespace Master.Forms
{
    partial class frmSupplierQuotations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierQuotations));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.currencygridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSupplierQuotations = new Master.Class.DataSet.dsSupplierQuotations();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllSupplierQUotationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colReqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ReqNoGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectSupplierQUotationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetApprovedRequsitionNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SupplierGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectItemsperRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QuantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TaxRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TaxAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ExtendedCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DiscountRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DiscountAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.QuotationNoGridLookUpEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReqNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuotationNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuantity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscountRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExtendedCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscountAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupplier = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectSupplierQUotationsTableAdapter = new Master.Class.DataSet.dsSupplierQuotationsTableAdapters.spSelectSupplierQUotationsTableAdapter();
            this.spGetSuppliersTableAdapter = new Master.Class.DataSet.dsSupplierQuotationsTableAdapters.spGetSuppliersTableAdapter();
            this.spSelectAllSupplierQUotationsTableAdapter = new Master.Class.DataSet.dsSupplierQuotationsTableAdapters.spSelectAllSupplierQUotationsTableAdapter();
            this.spgetApprovedRequsitionNoTableAdapter = new Master.Class.DataSet.dsSupplierQuotationsTableAdapters.spgetApprovedRequsitionNoTableAdapter();
            this.spSelectItemsperRequisitionTableAdapter = new Master.Class.DataSet.dsSupplierQuotationsTableAdapters.spSelectItemsperRequisitionTableAdapter();
            this.spgetCurrenciesTableAdapter = new Master.Class.DataSet.dsSupplierQuotationsTableAdapters.spgetCurrenciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencygridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierQuotations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierQUotationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqNoGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierQUotationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetApprovedRequsitionNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectItemsperRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendedCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationNoGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuotationNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExtendedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.currencygridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.ReqNoGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.SupplierGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.QuantityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitCostTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxAmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ExtendedCostTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DiscountRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DiscountAmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.QuotationNoGridLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spSelectSupplierQUotationsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(872, 550);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // currencygridLookUpEdit
            // 
            this.currencygridLookUpEdit.EditValue = "";
            this.currencygridLookUpEdit.Location = new System.Drawing.Point(96, 180);
            this.currencygridLookUpEdit.Name = "currencygridLookUpEdit";
            this.currencygridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencygridLookUpEdit.Properties.DataSource = this.spgetCurrenciesBindingSource;
            this.currencygridLookUpEdit.Properties.DisplayMember = "CurrDesc";
            this.currencygridLookUpEdit.Properties.ValueMember = "CurrCode";
            this.currencygridLookUpEdit.Properties.View = this.gridView1;
            this.currencygridLookUpEdit.Size = new System.Drawing.Size(329, 20);
            this.currencygridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.currencygridLookUpEdit.TabIndex = 40;
            // 
            // spgetCurrenciesBindingSource
            // 
            this.spgetCurrenciesBindingSource.DataMember = "spgetCurrencies";
            this.spgetCurrenciesBindingSource.DataSource = this.dsSupplierQuotations;
            // 
            // dsSupplierQuotations
            // 
            this.dsSupplierQuotations.DataSetName = "dsSupplierQuotations";
            this.dsSupplierQuotations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(429, 180);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(431, 22);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Upload Quotation";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllSupplierQUotationsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 206);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(848, 332);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // spSelectAllSupplierQUotationsBindingSource
            // 
            this.spSelectAllSupplierQUotationsBindingSource.DataMember = "spSelectAllSupplierQUotations";
            this.spSelectAllSupplierQUotationsBindingSource.DataSource = this.dsSupplierQuotations;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colReqNo,
            this.colQuotationNo,
            this.colOrderDate,
            this.colSupplier,
            this.colItemCode,
            this.colItemDescription,
            this.colQuantity,
            this.colUnitCost,
            this.colTaxRate,
            this.colTaxAmount,
            this.colExtendedCost,
            this.colDepartment,
            this.colDiscountRate,
            this.colDiscountAmount});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Download";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = global::Master.Properties.Resources.icons8_downloading_updates_16;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // colReqNo
            // 
            this.colReqNo.FieldName = "ReqNo";
            this.colReqNo.Name = "colReqNo";
            this.colReqNo.OptionsColumn.AllowEdit = false;
            this.colReqNo.Visible = true;
            this.colReqNo.VisibleIndex = 1;
            // 
            // colQuotationNo
            // 
            this.colQuotationNo.FieldName = "QuotationNo";
            this.colQuotationNo.Name = "colQuotationNo";
            this.colQuotationNo.OptionsColumn.AllowEdit = false;
            this.colQuotationNo.Visible = true;
            this.colQuotationNo.VisibleIndex = 2;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowEdit = false;
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 3;
            // 
            // colSupplier
            // 
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowEdit = false;
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 4;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 5;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.OptionsColumn.AllowEdit = false;
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 6;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 7;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.OptionsColumn.AllowEdit = false;
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 8;
            // 
            // colTaxRate
            // 
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.OptionsColumn.AllowEdit = false;
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 9;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.OptionsColumn.AllowEdit = false;
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 10;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.FieldName = "ExtendedCost";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.OptionsColumn.AllowEdit = false;
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 11;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.OptionsColumn.AllowEdit = false;
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 12;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.OptionsColumn.AllowEdit = false;
            this.colDiscountRate.Visible = true;
            this.colDiscountRate.VisibleIndex = 13;
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.FieldName = "DiscountAmount";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.OptionsColumn.AllowEdit = false;
            this.colDiscountAmount.Visible = true;
            this.colDiscountAmount.VisibleIndex = 14;
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
            this.toolStrip1.TabIndex = 25;
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
            // ReqNoGridLookUpEdit
            // 
            this.ReqNoGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "ReqNo", true));
            this.ReqNoGridLookUpEdit.Location = new System.Drawing.Point(96, 36);
            this.ReqNoGridLookUpEdit.Name = "ReqNoGridLookUpEdit";
            this.ReqNoGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ReqNoGridLookUpEdit.Properties.DataSource = this.spgetApprovedRequsitionNoBindingSource;
            this.ReqNoGridLookUpEdit.Properties.DisplayMember = "DeptName";
            this.ReqNoGridLookUpEdit.Properties.NullText = "";
            this.ReqNoGridLookUpEdit.Properties.ValueMember = "ReqNo";
            this.ReqNoGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.ReqNoGridLookUpEdit.Size = new System.Drawing.Size(329, 20);
            this.ReqNoGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ReqNoGridLookUpEdit.TabIndex = 26;
            this.ReqNoGridLookUpEdit.EditValueChanged += new System.EventHandler(this.ReqNoGridLookUpEdit_EditValueChanged_1);
            // 
            // spSelectSupplierQUotationsBindingSource
            // 
            this.spSelectSupplierQUotationsBindingSource.DataMember = "spSelectSupplierQUotations";
            this.spSelectSupplierQUotationsBindingSource.DataSource = this.dsSupplierQuotations;
            // 
            // spgetApprovedRequsitionNoBindingSource
            // 
            this.spgetApprovedRequsitionNoBindingSource.DataMember = "spgetApprovedRequsitionNo";
            this.spgetApprovedRequsitionNoBindingSource.DataSource = this.dsSupplierQuotations;
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
            // SupplierGridLookUpEdit
            // 
            this.SupplierGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "Supplier", true));
            this.SupplierGridLookUpEdit.Location = new System.Drawing.Point(513, 36);
            this.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit";
            this.SupplierGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupplierGridLookUpEdit.Properties.DataSource = this.spGetSuppliersBindingSource;
            this.SupplierGridLookUpEdit.Properties.DisplayMember = "Supplier Name";
            this.SupplierGridLookUpEdit.Properties.NullText = "";
            this.SupplierGridLookUpEdit.Properties.ValueMember = "Supplier Code";
            this.SupplierGridLookUpEdit.Properties.View = this.gridView2;
            this.SupplierGridLookUpEdit.Size = new System.Drawing.Size(347, 20);
            this.SupplierGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.SupplierGridLookUpEdit.TabIndex = 28;
            this.SupplierGridLookUpEdit.EditValueChanged += new System.EventHandler(this.SupplierGridLookUpEdit_EditValueChanged);
            // 
            // spGetSuppliersBindingSource
            // 
            this.spGetSuppliersBindingSource.DataMember = "spGetSuppliers";
            this.spGetSuppliersBindingSource.DataSource = this.dsSupplierQuotations;
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
            // ItemCodeGridLookUpEdit
            // 
            this.ItemCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "ItemCode", true));
            this.ItemCodeGridLookUpEdit.Location = new System.Drawing.Point(513, 60);
            this.ItemCodeGridLookUpEdit.Name = "ItemCodeGridLookUpEdit";
            this.ItemCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemCodeGridLookUpEdit.Properties.DataSource = this.spSelectItemsperRequisitionBindingSource;
            this.ItemCodeGridLookUpEdit.Properties.DisplayMember = "ItemDescription";
            this.ItemCodeGridLookUpEdit.Properties.NullText = "";
            this.ItemCodeGridLookUpEdit.Properties.ValueMember = "ItemCode";
            this.ItemCodeGridLookUpEdit.Properties.View = this.gridView3;
            this.ItemCodeGridLookUpEdit.Size = new System.Drawing.Size(347, 20);
            this.ItemCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemCodeGridLookUpEdit.TabIndex = 29;
            this.ItemCodeGridLookUpEdit.EditValueChanged += new System.EventHandler(this.ItemCodeGridLookUpEdit_EditValueChanged);
            // 
            // spSelectItemsperRequisitionBindingSource
            // 
            this.spSelectItemsperRequisitionBindingSource.DataMember = "spSelectItemsperRequisition";
            this.spSelectItemsperRequisitionBindingSource.DataSource = this.dsSupplierQuotations;
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
            // QuantityTextEdit
            // 
            this.QuantityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "Quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.QuantityTextEdit.Location = new System.Drawing.Point(96, 84);
            this.QuantityTextEdit.Name = "QuantityTextEdit";
            this.QuantityTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QuantityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QuantityTextEdit.Properties.Mask.EditMask = "F";
            this.QuantityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QuantityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QuantityTextEdit.Size = new System.Drawing.Size(329, 20);
            this.QuantityTextEdit.StyleController = this.dataLayoutControl1;
            this.QuantityTextEdit.TabIndex = 30;
            this.QuantityTextEdit.EditValueChanged += new System.EventHandler(this.QuantityTextEdit_EditValueChanged);
            // 
            // UnitCostTextEdit
            // 
            this.UnitCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "UnitCost", true));
            this.UnitCostTextEdit.EditValue = "0";
            this.UnitCostTextEdit.Location = new System.Drawing.Point(513, 84);
            this.UnitCostTextEdit.Name = "UnitCostTextEdit";
            this.UnitCostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitCostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitCostTextEdit.Properties.Mask.EditMask = "G";
            this.UnitCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitCostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitCostTextEdit.Size = new System.Drawing.Size(347, 20);
            this.UnitCostTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitCostTextEdit.TabIndex = 31;
            this.UnitCostTextEdit.EditValueChanged += new System.EventHandler(this.UnitCostTextEdit_EditValueChanged_1);
            // 
            // TaxRateTextEdit
            // 
            this.TaxRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "TaxRate", true));
            this.TaxRateTextEdit.Location = new System.Drawing.Point(96, 108);
            this.TaxRateTextEdit.Name = "TaxRateTextEdit";
            this.TaxRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TaxRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TaxRateTextEdit.Properties.Mask.EditMask = "F";
            this.TaxRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TaxRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TaxRateTextEdit.Size = new System.Drawing.Size(329, 20);
            this.TaxRateTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxRateTextEdit.TabIndex = 32;
            this.TaxRateTextEdit.EditValueChanged += new System.EventHandler(this.TaxRateTextEdit_EditValueChanged);
            // 
            // TaxAmountTextEdit
            // 
            this.TaxAmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "TaxAmount", true));
            this.TaxAmountTextEdit.Enabled = false;
            this.TaxAmountTextEdit.Location = new System.Drawing.Point(513, 108);
            this.TaxAmountTextEdit.Name = "TaxAmountTextEdit";
            this.TaxAmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TaxAmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TaxAmountTextEdit.Properties.Mask.EditMask = "G";
            this.TaxAmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TaxAmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TaxAmountTextEdit.Size = new System.Drawing.Size(347, 20);
            this.TaxAmountTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxAmountTextEdit.TabIndex = 33;
            // 
            // ExtendedCostTextEdit
            // 
            this.ExtendedCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "ExtendedCost", true));
            this.ExtendedCostTextEdit.Location = new System.Drawing.Point(96, 156);
            this.ExtendedCostTextEdit.Name = "ExtendedCostTextEdit";
            this.ExtendedCostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ExtendedCostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ExtendedCostTextEdit.Properties.Mask.EditMask = "G";
            this.ExtendedCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ExtendedCostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ExtendedCostTextEdit.Size = new System.Drawing.Size(329, 20);
            this.ExtendedCostTextEdit.StyleController = this.dataLayoutControl1;
            this.ExtendedCostTextEdit.TabIndex = 34;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(513, 156);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(347, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 35;
            // 
            // DiscountRateTextEdit
            // 
            this.DiscountRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "DiscountRate", true));
            this.DiscountRateTextEdit.Location = new System.Drawing.Point(96, 132);
            this.DiscountRateTextEdit.Name = "DiscountRateTextEdit";
            this.DiscountRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DiscountRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DiscountRateTextEdit.Properties.Mask.EditMask = "F";
            this.DiscountRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DiscountRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DiscountRateTextEdit.Size = new System.Drawing.Size(329, 20);
            this.DiscountRateTextEdit.StyleController = this.dataLayoutControl1;
            this.DiscountRateTextEdit.TabIndex = 36;
            this.DiscountRateTextEdit.EditValueChanged += new System.EventHandler(this.DiscountRateTextEdit_EditValueChanged);
            // 
            // DiscountAmountTextEdit
            // 
            this.DiscountAmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "DiscountAmount", true));
            this.DiscountAmountTextEdit.Location = new System.Drawing.Point(513, 132);
            this.DiscountAmountTextEdit.Name = "DiscountAmountTextEdit";
            this.DiscountAmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DiscountAmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DiscountAmountTextEdit.Properties.Mask.EditMask = "G";
            this.DiscountAmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DiscountAmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DiscountAmountTextEdit.Size = new System.Drawing.Size(347, 20);
            this.DiscountAmountTextEdit.StyleController = this.dataLayoutControl1;
            this.DiscountAmountTextEdit.TabIndex = 37;
            this.DiscountAmountTextEdit.EditValueChanged += new System.EventHandler(this.DiscountAmountTextEdit_EditValueChanged);
            // 
            // QuotationNoGridLookUpEdit
            // 
            this.QuotationNoGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierQUotationsBindingSource, "QuotationNo", true));
            this.QuotationNoGridLookUpEdit.Location = new System.Drawing.Point(96, 60);
            this.QuotationNoGridLookUpEdit.Name = "QuotationNoGridLookUpEdit";
            this.QuotationNoGridLookUpEdit.Size = new System.Drawing.Size(329, 20);
            this.QuotationNoGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.QuotationNoGridLookUpEdit.TabIndex = 27;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(872, 550);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForReqNo,
            this.ItemForQuotationNo,
            this.ItemForQuantity,
            this.ItemForTaxRate,
            this.ItemForDiscountRate,
            this.ItemForExtendedCost,
            this.ItemForNarration,
            this.ItemForDiscountAmount,
            this.ItemForTaxAmount,
            this.ItemForUnitCost,
            this.ItemForItemCode,
            this.ItemForSupplier,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(852, 530);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 194);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(852, 336);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(852, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForReqNo
            // 
            this.ItemForReqNo.Control = this.ReqNoGridLookUpEdit;
            this.ItemForReqNo.Location = new System.Drawing.Point(0, 24);
            this.ItemForReqNo.Name = "ItemForReqNo";
            this.ItemForReqNo.Size = new System.Drawing.Size(417, 24);
            this.ItemForReqNo.Text = "Req No";
            this.ItemForReqNo.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForQuotationNo
            // 
            this.ItemForQuotationNo.Control = this.QuotationNoGridLookUpEdit;
            this.ItemForQuotationNo.Location = new System.Drawing.Point(0, 48);
            this.ItemForQuotationNo.Name = "ItemForQuotationNo";
            this.ItemForQuotationNo.Size = new System.Drawing.Size(417, 24);
            this.ItemForQuotationNo.Text = "Quotation No";
            this.ItemForQuotationNo.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForQuantity
            // 
            this.ItemForQuantity.Control = this.QuantityTextEdit;
            this.ItemForQuantity.Location = new System.Drawing.Point(0, 72);
            this.ItemForQuantity.Name = "ItemForQuantity";
            this.ItemForQuantity.Size = new System.Drawing.Size(417, 24);
            this.ItemForQuantity.Text = "Quantity";
            this.ItemForQuantity.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForTaxRate
            // 
            this.ItemForTaxRate.Control = this.TaxRateTextEdit;
            this.ItemForTaxRate.Location = new System.Drawing.Point(0, 96);
            this.ItemForTaxRate.Name = "ItemForTaxRate";
            this.ItemForTaxRate.Size = new System.Drawing.Size(417, 24);
            this.ItemForTaxRate.Text = "Tax Rate";
            this.ItemForTaxRate.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForDiscountRate
            // 
            this.ItemForDiscountRate.Control = this.DiscountRateTextEdit;
            this.ItemForDiscountRate.Location = new System.Drawing.Point(0, 120);
            this.ItemForDiscountRate.Name = "ItemForDiscountRate";
            this.ItemForDiscountRate.Size = new System.Drawing.Size(417, 24);
            this.ItemForDiscountRate.Text = "Discount Rate";
            this.ItemForDiscountRate.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForExtendedCost
            // 
            this.ItemForExtendedCost.Control = this.ExtendedCostTextEdit;
            this.ItemForExtendedCost.Enabled = false;
            this.ItemForExtendedCost.Location = new System.Drawing.Point(0, 144);
            this.ItemForExtendedCost.Name = "ItemForExtendedCost";
            this.ItemForExtendedCost.Size = new System.Drawing.Size(417, 24);
            this.ItemForExtendedCost.Text = "Extended Cost";
            this.ItemForExtendedCost.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(417, 144);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(435, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForDiscountAmount
            // 
            this.ItemForDiscountAmount.Control = this.DiscountAmountTextEdit;
            this.ItemForDiscountAmount.Location = new System.Drawing.Point(417, 120);
            this.ItemForDiscountAmount.Name = "ItemForDiscountAmount";
            this.ItemForDiscountAmount.Size = new System.Drawing.Size(435, 24);
            this.ItemForDiscountAmount.Text = "Discount Amount";
            this.ItemForDiscountAmount.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForTaxAmount
            // 
            this.ItemForTaxAmount.Control = this.TaxAmountTextEdit;
            this.ItemForTaxAmount.Location = new System.Drawing.Point(417, 96);
            this.ItemForTaxAmount.Name = "ItemForTaxAmount";
            this.ItemForTaxAmount.Size = new System.Drawing.Size(435, 24);
            this.ItemForTaxAmount.Text = "Tax Amount";
            this.ItemForTaxAmount.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForUnitCost
            // 
            this.ItemForUnitCost.Control = this.UnitCostTextEdit;
            this.ItemForUnitCost.Location = new System.Drawing.Point(417, 72);
            this.ItemForUnitCost.Name = "ItemForUnitCost";
            this.ItemForUnitCost.Size = new System.Drawing.Size(435, 24);
            this.ItemForUnitCost.Text = "Unit Cost";
            this.ItemForUnitCost.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeGridLookUpEdit;
            this.ItemForItemCode.Location = new System.Drawing.Point(417, 48);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Size = new System.Drawing.Size(435, 24);
            this.ItemForItemCode.Text = "Item Code";
            this.ItemForItemCode.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ItemForSupplier
            // 
            this.ItemForSupplier.Control = this.SupplierGridLookUpEdit;
            this.ItemForSupplier.Location = new System.Drawing.Point(417, 24);
            this.ItemForSupplier.Name = "ItemForSupplier";
            this.ItemForSupplier.Size = new System.Drawing.Size(435, 24);
            this.ItemForSupplier.Text = "Supplier";
            this.ItemForSupplier.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(417, 168);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(435, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.currencygridLookUpEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(417, 26);
            this.layoutControlItem4.Text = "Currecny";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // spSelectSupplierQUotationsTableAdapter
            // 
            this.spSelectSupplierQUotationsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSuppliersTableAdapter
            // 
            this.spGetSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllSupplierQUotationsTableAdapter
            // 
            this.spSelectAllSupplierQUotationsTableAdapter.ClearBeforeFill = true;
            // 
            // spgetApprovedRequsitionNoTableAdapter
            // 
            this.spgetApprovedRequsitionNoTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectItemsperRequisitionTableAdapter
            // 
            this.spSelectItemsperRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCurrenciesTableAdapter
            // 
            this.spgetCurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSupplierQuotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 550);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmSupplierQuotations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Quotations";
            this.Load += new System.EventHandler(this.frmSupplierQuotations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencygridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierQuotations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierQUotationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqNoGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierQUotationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetApprovedRequsitionNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectItemsperRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendedCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationNoGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuotationNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExtendedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource spSelectSupplierQUotationsBindingSource;
        private Class.DataSet.dsSupplierQuotations dsSupplierQuotations;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private Class.DataSet.dsSupplierQuotationsTableAdapters.spSelectSupplierQUotationsTableAdapter spSelectSupplierQUotationsTableAdapter;
        private System.Windows.Forms.BindingSource spGetSuppliersBindingSource;
        private Class.DataSet.dsSupplierQuotationsTableAdapters.spGetSuppliersTableAdapter spGetSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllSupplierQUotationsBindingSource;
        private Class.DataSet.dsSupplierQuotationsTableAdapters.spSelectAllSupplierQUotationsTableAdapter spSelectAllSupplierQUotationsTableAdapter;
        private System.Windows.Forms.BindingSource spgetApprovedRequsitionNoBindingSource;
        private Class.DataSet.dsSupplierQuotationsTableAdapters.spgetApprovedRequsitionNoTableAdapter spgetApprovedRequsitionNoTableAdapter;
        private System.Windows.Forms.BindingSource spSelectItemsperRequisitionBindingSource;
        private Class.DataSet.dsSupplierQuotationsTableAdapters.spSelectItemsperRequisitionTableAdapter spSelectItemsperRequisitionTableAdapter;
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
        private DevExpress.XtraEditors.GridLookUpEdit ReqNoGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit SupplierGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit ItemCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit QuantityTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitCostTextEdit;
        private DevExpress.XtraEditors.TextEdit TaxRateTextEdit;
        private DevExpress.XtraEditors.TextEdit TaxAmountTextEdit;
        private DevExpress.XtraEditors.TextEdit ExtendedCostTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraEditors.TextEdit DiscountRateTextEdit;
        private DevExpress.XtraEditors.TextEdit DiscountAmountTextEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colReqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountAmount;
        private DevExpress.XtraEditors.TextEdit QuotationNoGridLookUpEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReqNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuotationNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuantity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscountRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExtendedCost;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscountAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitCost;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupplier;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit currencygridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource spgetCurrenciesBindingSource;
        private Class.DataSet.dsSupplierQuotationsTableAdapters.spgetCurrenciesTableAdapter spgetCurrenciesTableAdapter;
    }
}