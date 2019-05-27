namespace Master.Forms
{
    partial class frmDirectSupplierInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectSupplierInvoice));
            this.dsSupplierInvoices = new Master.Class.DataSet.dsSupplierInvoices();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.textEditDiscountamnt = new DevExpress.XtraEditors.TextEdit();
            this.textEditExtended = new DevExpress.XtraEditors.TextEdit();
            this.textEdidUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            this.spSelectAllSupplierInvoicesBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxableAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectSupplierInvoicesBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SupplierGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InvoiceNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InvoiceDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.DueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.DocCurrencyGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetCurrenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DiscountRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UOMGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectAllUOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupplier = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInvoiceNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInvoiceDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQty = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscountRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUOM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spgetCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectSupplierInvoicesBufferTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spSelectSupplierInvoicesBufferTableAdapter();
            this.spSelectAllSupplierInvoicesBufferTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spSelectAllSupplierInvoicesBufferTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetSuppliersTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spGetSuppliersTableAdapter();
            this.spgetCurrenciesTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spgetCurrenciesTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spGetItemsTableAdapter();
            this.spSelectAllUOMTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spSelectAllUOMTableAdapter();
            this.spgetCompanyCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetCompanyCurrencyTableAdapter = new Master.Class.DataSet.dsSupplierInvoicesTableAdapters.spgetCompanyCurrencyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDiscountamnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExtended.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdidUnitPrice.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierInvoicesBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierInvoicesBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocCurrencyGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoiceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCompanyCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSupplierInvoices
            // 
            this.dsSupplierInvoices.DataSetName = "dsSupplierInvoices";
            this.dsSupplierInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.textEditDiscountamnt);
            this.dataLayoutControl1.Controls.Add(this.textEditExtended);
            this.dataLayoutControl1.Controls.Add(this.textEdidUnitPrice);
            this.dataLayoutControl1.Controls.Add(this.maskedTextBox1);
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.SupplierGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.InvoiceNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.InvoiceDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.DueDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.DocCurrencyGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.QtyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DiscountRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UOMGridLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spSelectSupplierInvoicesBufferBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1119, 452);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // textEditDiscountamnt
            // 
            this.textEditDiscountamnt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "DiscountAmount", true));
            this.textEditDiscountamnt.Location = new System.Drawing.Point(658, 180);
            this.textEditDiscountamnt.Name = "textEditDiscountamnt";
            this.textEditDiscountamnt.Size = new System.Drawing.Size(449, 20);
            this.textEditDiscountamnt.StyleController = this.dataLayoutControl1;
            this.textEditDiscountamnt.TabIndex = 25;
            // 
            // textEditExtended
            // 
            this.textEditExtended.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "ExtendedCost", true));
            this.textEditExtended.Location = new System.Drawing.Point(108, 108);
            this.textEditExtended.Name = "textEditExtended";
            this.textEditExtended.Size = new System.Drawing.Size(449, 20);
            this.textEditExtended.StyleController = this.dataLayoutControl1;
            this.textEditExtended.TabIndex = 24;
            // 
            // textEdidUnitPrice
            // 
            this.textEdidUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "UnitCost", true));
            this.textEdidUnitPrice.Location = new System.Drawing.Point(657, 84);
            this.textEdidUnitPrice.Name = "textEdidUnitPrice";
            this.textEdidUnitPrice.Size = new System.Drawing.Size(450, 20);
            this.textEdidUnitPrice.StyleController = this.dataLayoutControl1;
            this.textEdidUnitPrice.TabIndex = 23;
            this.textEdidUnitPrice.EditValueChanged += new System.EventHandler(this.textEdidUnitPrice_EditValueChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(108, 420);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(999, 20);
            this.maskedTextBox1.TabIndex = 22;
            this.maskedTextBox1.Text = "maskedTextBox1";
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
            this.toolStrip1.Size = new System.Drawing.Size(1095, 20);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(49, 17);
            this.saveToolStripButton.Text = "Add";
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
            this.cutToolStripButton.Size = new System.Drawing.Size(51, 17);
            this.cutToolStripButton.Text = "Save";
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
            this.gridControl1.DataSource = this.spSelectAllSupplierInvoicesBufferBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 204);
            this.gridControl1.MainView = this.gridView6;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1095, 212);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllSupplierInvoicesBufferBindingSource
            // 
            this.spSelectAllSupplierInvoicesBufferBindingSource.DataMember = "spSelectAllSupplierInvoicesBuffer";
            this.spSelectAllSupplierInvoicesBufferBindingSource.DataSource = this.dsSupplierInvoices;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplier,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colItemDescription,
            this.colQty,
            this.colUnitCost,
            this.colExtendedCost,
            this.colTaxableAmount,
            this.colTaxAmount,
            this.colDiscountAmount,
            this.colTotalInvoiceAmount,
            this.colRemarks});
            this.gridView6.GridControl = this.gridControl1;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsBehavior.Editable = false;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSupplier
            // 
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 0;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 1;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 2;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 3;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 4;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 5;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.FieldName = "ExtendedCost";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 6;
            // 
            // colTaxableAmount
            // 
            this.colTaxableAmount.FieldName = "TaxableAmount";
            this.colTaxableAmount.Name = "colTaxableAmount";
            this.colTaxableAmount.Visible = true;
            this.colTaxableAmount.VisibleIndex = 7;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 8;
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.FieldName = "DiscountAmount";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.Visible = true;
            this.colDiscountAmount.VisibleIndex = 9;
            // 
            // colTotalInvoiceAmount
            // 
            this.colTotalInvoiceAmount.FieldName = "TotalInvoiceAmount";
            this.colTotalInvoiceAmount.Name = "colTotalInvoiceAmount";
            this.colTotalInvoiceAmount.Visible = true;
            this.colTotalInvoiceAmount.VisibleIndex = 10;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 11;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(108, 36);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(450, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 4;
            // 
            // spSelectSupplierInvoicesBufferBindingSource
            // 
            this.spSelectSupplierInvoicesBufferBindingSource.DataMember = "spSelectSupplierInvoicesBuffer";
            this.spSelectSupplierInvoicesBufferBindingSource.DataSource = this.dsSupplierInvoices;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsSupplierInvoices;
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
            this.SupplierGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "Supplier", true));
            this.SupplierGridLookUpEdit.Location = new System.Drawing.Point(108, 60);
            this.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit";
            this.SupplierGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupplierGridLookUpEdit.Properties.DataSource = this.spGetSuppliersBindingSource;
            this.SupplierGridLookUpEdit.Properties.DisplayMember = "Supplier Name";
            this.SupplierGridLookUpEdit.Properties.NullText = "";
            this.SupplierGridLookUpEdit.Properties.ValueMember = "Supplier Code";
            this.SupplierGridLookUpEdit.Properties.View = this.gridView1;
            this.SupplierGridLookUpEdit.Size = new System.Drawing.Size(450, 20);
            this.SupplierGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.SupplierGridLookUpEdit.TabIndex = 6;
            // 
            // spGetSuppliersBindingSource
            // 
            this.spGetSuppliersBindingSource.DataMember = "spGetSuppliers";
            this.spGetSuppliersBindingSource.DataSource = this.dsSupplierInvoices;
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
            // InvoiceNoTextEdit
            // 
            this.InvoiceNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "InvoiceNo", true));
            this.InvoiceNoTextEdit.Location = new System.Drawing.Point(658, 36);
            this.InvoiceNoTextEdit.Name = "InvoiceNoTextEdit";
            this.InvoiceNoTextEdit.Size = new System.Drawing.Size(449, 20);
            this.InvoiceNoTextEdit.StyleController = this.dataLayoutControl1;
            this.InvoiceNoTextEdit.TabIndex = 7;
            // 
            // InvoiceDateDateEdit
            // 
            this.InvoiceDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "InvoiceDate", true));
            this.InvoiceDateDateEdit.EditValue = null;
            this.InvoiceDateDateEdit.Location = new System.Drawing.Point(108, 156);
            this.InvoiceDateDateEdit.Name = "InvoiceDateDateEdit";
            this.InvoiceDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoiceDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoiceDateDateEdit.Size = new System.Drawing.Size(450, 20);
            this.InvoiceDateDateEdit.StyleController = this.dataLayoutControl1;
            this.InvoiceDateDateEdit.TabIndex = 8;
            // 
            // DueDateDateEdit
            // 
            this.DueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "DueDate", true));
            this.DueDateDateEdit.EditValue = null;
            this.DueDateDateEdit.Location = new System.Drawing.Point(108, 132);
            this.DueDateDateEdit.Name = "DueDateDateEdit";
            this.DueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Size = new System.Drawing.Size(449, 20);
            this.DueDateDateEdit.StyleController = this.dataLayoutControl1;
            this.DueDateDateEdit.TabIndex = 9;
            // 
            // DocCurrencyGridLookUpEdit
            // 
            this.DocCurrencyGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "DocCurrency", true));
            this.DocCurrencyGridLookUpEdit.Enabled = false;
            this.DocCurrencyGridLookUpEdit.Location = new System.Drawing.Point(657, 132);
            this.DocCurrencyGridLookUpEdit.Name = "DocCurrencyGridLookUpEdit";
            this.DocCurrencyGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocCurrencyGridLookUpEdit.Properties.DataSource = this.spgetCurrenciesBindingSource1;
            this.DocCurrencyGridLookUpEdit.Properties.DisplayMember = "CurrDesc";
            this.DocCurrencyGridLookUpEdit.Properties.NullText = "";
            this.DocCurrencyGridLookUpEdit.Properties.ValueMember = "CurrCode";
            this.DocCurrencyGridLookUpEdit.Properties.View = this.gridView3;
            this.DocCurrencyGridLookUpEdit.Size = new System.Drawing.Size(450, 20);
            this.DocCurrencyGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DocCurrencyGridLookUpEdit.TabIndex = 11;
            // 
            // spgetCurrenciesBindingSource1
            // 
            this.spgetCurrenciesBindingSource1.DataMember = "spgetCurrencies";
            this.spgetCurrenciesBindingSource1.DataSource = this.dsSupplierInvoices;
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
            // ItemCodeGridLookUpEdit
            // 
            this.ItemCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "ItemCode", true));
            this.ItemCodeGridLookUpEdit.Location = new System.Drawing.Point(658, 60);
            this.ItemCodeGridLookUpEdit.Name = "ItemCodeGridLookUpEdit";
            this.ItemCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemCodeGridLookUpEdit.Properties.DataSource = this.spGetItemsBindingSource;
            this.ItemCodeGridLookUpEdit.Properties.DisplayMember = "ItemDescription";
            this.ItemCodeGridLookUpEdit.Properties.NullText = "";
            this.ItemCodeGridLookUpEdit.Properties.ValueMember = "ItemCode";
            this.ItemCodeGridLookUpEdit.Properties.View = this.gridView4;
            this.ItemCodeGridLookUpEdit.Size = new System.Drawing.Size(449, 20);
            this.ItemCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemCodeGridLookUpEdit.TabIndex = 12;
            this.ItemCodeGridLookUpEdit.EditValueChanged += new System.EventHandler(this.ItemCodeGridLookUpEdit_EditValueChanged);
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsSupplierInvoices;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // QtyTextEdit
            // 
            this.QtyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "Qty", true));
            this.QtyTextEdit.Location = new System.Drawing.Point(108, 84);
            this.QtyTextEdit.Name = "QtyTextEdit";
            this.QtyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtyTextEdit.Properties.Mask.EditMask = "F";
            this.QtyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QtyTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QtyTextEdit.Size = new System.Drawing.Size(449, 20);
            this.QtyTextEdit.StyleController = this.dataLayoutControl1;
            this.QtyTextEdit.TabIndex = 13;
            this.QtyTextEdit.EditValueChanged += new System.EventHandler(this.QtyTextEdit_EditValueChanged);
            // 
            // DiscountRateTextEdit
            // 
            this.DiscountRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "DiscountRate", true));
            this.DiscountRateTextEdit.Location = new System.Drawing.Point(658, 156);
            this.DiscountRateTextEdit.Name = "DiscountRateTextEdit";
            this.DiscountRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DiscountRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DiscountRateTextEdit.Properties.Mask.EditMask = "F";
            this.DiscountRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DiscountRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DiscountRateTextEdit.Size = new System.Drawing.Size(449, 20);
            this.DiscountRateTextEdit.StyleController = this.dataLayoutControl1;
            this.DiscountRateTextEdit.TabIndex = 14;
            this.DiscountRateTextEdit.EditValueChanged += new System.EventHandler(this.DiscountRateTextEdit_EditValueChanged);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(108, 180);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(450, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 15;
            // 
            // UOMGridLookUpEdit
            // 
            this.UOMGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierInvoicesBufferBindingSource, "UOM", true));
            this.UOMGridLookUpEdit.Enabled = false;
            this.UOMGridLookUpEdit.Location = new System.Drawing.Point(657, 108);
            this.UOMGridLookUpEdit.Name = "UOMGridLookUpEdit";
            this.UOMGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UOMGridLookUpEdit.Properties.DataSource = this.spSelectAllUOMBindingSource;
            this.UOMGridLookUpEdit.Properties.DisplayMember = "Uom";
            this.UOMGridLookUpEdit.Properties.NullText = "";
            this.UOMGridLookUpEdit.Properties.ValueMember = "Uom";
            this.UOMGridLookUpEdit.Properties.View = this.gridView5;
            this.UOMGridLookUpEdit.Size = new System.Drawing.Size(450, 20);
            this.UOMGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.UOMGridLookUpEdit.TabIndex = 16;
            // 
            // spSelectAllUOMBindingSource
            // 
            this.spSelectAllUOMBindingSource.DataMember = "spSelectAllUOM";
            this.spSelectAllUOMBindingSource.DataSource = this.dsSupplierInvoices;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1119, 452);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCostCenter,
            this.ItemForSupplier,
            this.ItemForInvoiceNo,
            this.ItemForInvoiceDate,
            this.ItemForDueDate,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForQty,
            this.ItemForDiscountRate,
            this.ItemForItemCode,
            this.ItemForUOM,
            this.ItemForDocCurrency,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.ItemForRemarks,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1099, 408);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 24);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(550, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForSupplier
            // 
            this.ItemForSupplier.Control = this.SupplierGridLookUpEdit;
            this.ItemForSupplier.Location = new System.Drawing.Point(0, 48);
            this.ItemForSupplier.Name = "ItemForSupplier";
            this.ItemForSupplier.Size = new System.Drawing.Size(550, 24);
            this.ItemForSupplier.Text = "Supplier";
            this.ItemForSupplier.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForInvoiceNo
            // 
            this.ItemForInvoiceNo.Control = this.InvoiceNoTextEdit;
            this.ItemForInvoiceNo.Location = new System.Drawing.Point(550, 24);
            this.ItemForInvoiceNo.Name = "ItemForInvoiceNo";
            this.ItemForInvoiceNo.Size = new System.Drawing.Size(549, 24);
            this.ItemForInvoiceNo.Text = "Invoice No";
            this.ItemForInvoiceNo.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForInvoiceDate
            // 
            this.ItemForInvoiceDate.Control = this.InvoiceDateDateEdit;
            this.ItemForInvoiceDate.Location = new System.Drawing.Point(0, 144);
            this.ItemForInvoiceDate.Name = "ItemForInvoiceDate";
            this.ItemForInvoiceDate.Size = new System.Drawing.Size(550, 24);
            this.ItemForInvoiceDate.Text = "Invoice Date";
            this.ItemForInvoiceDate.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForDueDate
            // 
            this.ItemForDueDate.Control = this.DueDateDateEdit;
            this.ItemForDueDate.Location = new System.Drawing.Point(0, 120);
            this.ItemForDueDate.Name = "ItemForDueDate";
            this.ItemForDueDate.Size = new System.Drawing.Size(549, 24);
            this.ItemForDueDate.Text = "Due Date";
            this.ItemForDueDate.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1099, 216);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1099, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForQty
            // 
            this.ItemForQty.Control = this.QtyTextEdit;
            this.ItemForQty.Location = new System.Drawing.Point(0, 72);
            this.ItemForQty.Name = "ItemForQty";
            this.ItemForQty.Size = new System.Drawing.Size(549, 24);
            this.ItemForQty.Text = "Qty";
            this.ItemForQty.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForDiscountRate
            // 
            this.ItemForDiscountRate.Control = this.DiscountRateTextEdit;
            this.ItemForDiscountRate.Location = new System.Drawing.Point(550, 144);
            this.ItemForDiscountRate.Name = "ItemForDiscountRate";
            this.ItemForDiscountRate.Size = new System.Drawing.Size(549, 24);
            this.ItemForDiscountRate.Text = "Discount Rate(%)";
            this.ItemForDiscountRate.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeGridLookUpEdit;
            this.ItemForItemCode.Location = new System.Drawing.Point(550, 48);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Size = new System.Drawing.Size(549, 24);
            this.ItemForItemCode.Text = "Item Code";
            this.ItemForItemCode.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForUOM
            // 
            this.ItemForUOM.Control = this.UOMGridLookUpEdit;
            this.ItemForUOM.Location = new System.Drawing.Point(549, 96);
            this.ItemForUOM.Name = "ItemForUOM";
            this.ItemForUOM.Size = new System.Drawing.Size(550, 24);
            this.ItemForUOM.Text = "UOM";
            this.ItemForUOM.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForDocCurrency
            // 
            this.ItemForDocCurrency.Control = this.DocCurrencyGridLookUpEdit;
            this.ItemForDocCurrency.Location = new System.Drawing.Point(549, 120);
            this.ItemForDocCurrency.Name = "ItemForDocCurrency";
            this.ItemForDocCurrency.Size = new System.Drawing.Size(550, 24);
            this.ItemForDocCurrency.Text = "Doc Currency";
            this.ItemForDocCurrency.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdidUnitPrice;
            this.layoutControlItem4.Location = new System.Drawing.Point(549, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(550, 24);
            this.layoutControlItem4.Text = "UnitCost";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEditExtended;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(549, 24);
            this.layoutControlItem5.Text = "ExtendedCost";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 168);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(550, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEditDiscountamnt;
            this.layoutControlItem6.Location = new System.Drawing.Point(550, 168);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(549, 24);
            this.layoutControlItem6.Text = "DiscountAmount";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.maskedTextBox1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1099, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // spgetCurrenciesBindingSource
            // 
            this.spgetCurrenciesBindingSource.DataMember = "spgetCurrencies";
            this.spgetCurrenciesBindingSource.DataSource = this.dsSupplierInvoices;
            // 
            // spSelectSupplierInvoicesBufferTableAdapter
            // 
            this.spSelectSupplierInvoicesBufferTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllSupplierInvoicesBufferTableAdapter
            // 
            this.spSelectAllSupplierInvoicesBufferTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSuppliersTableAdapter
            // 
            this.spGetSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCurrenciesTableAdapter
            // 
            this.spgetCurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemsTableAdapter
            // 
            this.spGetItemsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllUOMTableAdapter
            // 
            this.spSelectAllUOMTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCompanyCurrencyBindingSource
            // 
            this.spgetCompanyCurrencyBindingSource.DataMember = "spgetCompanyCurrency";
            this.spgetCompanyCurrencyBindingSource.DataSource = this.dsSupplierInvoices;
            // 
            // spgetCompanyCurrencyTableAdapter
            // 
            this.spgetCompanyCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // frmDirectSupplierInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 452);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmDirectSupplierInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direct Supplier Invoice";
            this.Load += new System.EventHandler(this.frmDirectSupplierInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditDiscountamnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExtended.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdidUnitPrice.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierInvoicesBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierInvoicesBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocCurrencyGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoiceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCompanyCurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Class.DataSet.dsSupplierInvoices dsSupplierInvoices;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectSupplierInvoicesBufferBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit SupplierGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit InvoiceNoTextEdit;
        private DevExpress.XtraEditors.DateEdit InvoiceDateDateEdit;
        private DevExpress.XtraEditors.DateEdit DueDateDateEdit;
        private DevExpress.XtraEditors.GridLookUpEdit DocCurrencyGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit ItemCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.TextEdit QtyTextEdit;
        private DevExpress.XtraEditors.TextEdit DiscountRateTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit UOMGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupplier;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInvoiceNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInvoiceDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDueDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocCurrency;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQty;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscountRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUOM;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spSelectSupplierInvoicesBufferTableAdapter spSelectSupplierInvoicesBufferTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllSupplierInvoicesBufferBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxableAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalInvoiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spSelectAllSupplierInvoicesBufferTableAdapter spSelectAllSupplierInvoicesBufferTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetSuppliersBindingSource;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spGetSuppliersTableAdapter spGetSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource spgetCurrenciesBindingSource;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spgetCurrenciesTableAdapter spgetCurrenciesTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private System.Windows.Forms.BindingSource spgetCurrenciesBindingSource1;
        private System.Windows.Forms.BindingSource spSelectAllUOMBindingSource;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spSelectAllUOMTableAdapter spSelectAllUOMTableAdapter;
        private System.Windows.Forms.BindingSource spgetCompanyCurrencyBindingSource;
        private Class.DataSet.dsSupplierInvoicesTableAdapters.spgetCompanyCurrencyTableAdapter spgetCompanyCurrencyTableAdapter;
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
        private DevExpress.XtraEditors.TextEdit textEditExtended;
        private DevExpress.XtraEditors.TextEdit textEdidUnitPrice;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit textEditDiscountamnt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}