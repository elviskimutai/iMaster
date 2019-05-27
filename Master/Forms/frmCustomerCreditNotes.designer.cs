namespace Master.Forms
{
    partial class frmCustomerCreditNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerCreditNotes));
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
            this.Invoicegl = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetCustomerInvoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCustomerCreditNotes = new Master.Class.DataSet.dsCustomerCreditNotes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spselectAllCustomerCrediNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spselectCustomerCrediNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DocNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescriptionGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetCustomerInvoiceItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ExtendedCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQty = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExtendedCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spselectCustomerCrediNotesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spgetCustomerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCustomerCreditNotes1 = new Master.Class.DataSet.dsCustomerCreditNotes();
            this.spselectCustomerCrediNotesTableAdapter = new Master.Class.DataSet.dsCustomerCreditNotesTableAdapters.spselectCustomerCrediNotesTableAdapter();
            this.spselectAllCustomerCrediNotesTableAdapter = new Master.Class.DataSet.dsCustomerCreditNotesTableAdapters.spselectAllCustomerCrediNotesTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsCustomerCreditNotesTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetCustomersTableAdapter = new Master.Class.DataSet.dsCustomerCreditNotesTableAdapters.spGetCustomersTableAdapter();
            this.spgetCustomerInvoiceItems1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spgetCustomerInvoiceItemsTableAdapter = new Master.Class.DataSet.dsCustomerCreditNotesTableAdapters.spgetCustomerInvoiceItemsTableAdapter();
            this.spgetCustomerInvoiceTableAdapter = new Master.Class.DataSet.dsCustomerCreditNotesTableAdapters.spgetCustomerInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoicegl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerCreditNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectAllCustomerCrediNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectCustomerCrediNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendedCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExtendedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectCustomerCrediNotesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerCreditNotes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceItems1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.Invoicegl);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DocNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemDescriptionGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.QtyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitCostTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ExtendedCostTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustCodeGridLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spselectCustomerCrediNotesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(966, 313);
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
            this.toolStrip1.Size = new System.Drawing.Size(942, 20);
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
            // Invoicegl
            // 
            this.Invoicegl.EditValue = "";
            this.Invoicegl.Location = new System.Drawing.Point(566, 60);
            this.Invoicegl.Name = "Invoicegl";
            this.Invoicegl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Invoicegl.Properties.DataSource = this.spgetCustomerInvoiceBindingSource1;
            this.Invoicegl.Properties.DisplayMember = "InvoiceNo";
            this.Invoicegl.Properties.ValueMember = "InvoiceNo";
            this.Invoicegl.Properties.View = this.gridView1;
            this.Invoicegl.Size = new System.Drawing.Size(388, 20);
            this.Invoicegl.StyleController = this.dataLayoutControl1;
            this.Invoicegl.TabIndex = 14;
            this.Invoicegl.EditValueChanged += new System.EventHandler(this.Invoicegl_EditValueChanged);
            // 
            // spgetCustomerInvoiceBindingSource1
            // 
            this.spgetCustomerInvoiceBindingSource1.DataMember = "spgetCustomerInvoice";
            this.spgetCustomerInvoiceBindingSource1.DataSource = this.dsCustomerCreditNotes;
            // 
            // dsCustomerCreditNotes
            // 
            this.dsCustomerCreditNotes.DataSetName = "dsCustomerCreditNotes";
            this.dsCustomerCreditNotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spselectAllCustomerCrediNotesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 156);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(942, 145);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spselectAllCustomerCrediNotesBindingSource
            // 
            this.spselectAllCustomerCrediNotesBindingSource.DataMember = "spselectAllCustomerCrediNotes";
            this.spselectAllCustomerCrediNotesBindingSource.DataSource = this.dsCustomerCreditNotes;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colDocNo,
            this.colDocType,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colItemDescription,
            this.colQty,
            this.colUnitCost,
            this.colExtendedCost,
            this.colRemarks,
            this.colCustName,
            this.colCurrency,
            this.colCNStatus});
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
            // colDocNo
            // 
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            this.colDocNo.Visible = true;
            this.colDocNo.VisibleIndex = 2;
            // 
            // colDocType
            // 
            this.colDocType.FieldName = "DocType";
            this.colDocType.Name = "colDocType";
            this.colDocType.Visible = true;
            this.colDocType.VisibleIndex = 3;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 4;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 5;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 6;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 7;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 8;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.FieldName = "ExtendedCost";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 9;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 10;
            // 
            // colCustName
            // 
            this.colCustName.FieldName = "CustName";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 11;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 12;
            // 
            // colCNStatus
            // 
            this.colCNStatus.FieldName = "CNStatus";
            this.colCNStatus.Name = "colCNStatus";
            this.colCNStatus.Visible = true;
            this.colCNStatus.VisibleIndex = 13;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(93, 36);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(388, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 4;
            // 
            // spselectCustomerCrediNotesBindingSource
            // 
            this.spselectCustomerCrediNotesBindingSource.DataMember = "spselectCustomerCrediNotes";
            this.spselectCustomerCrediNotesBindingSource.DataSource = this.dsCustomerCreditNotes;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsCustomerCreditNotes;
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
            // DocNoTextEdit
            // 
            this.DocNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "DocNo", true));
            this.DocNoTextEdit.Location = new System.Drawing.Point(566, 36);
            this.DocNoTextEdit.Name = "DocNoTextEdit";
            this.DocNoTextEdit.Size = new System.Drawing.Size(388, 20);
            this.DocNoTextEdit.StyleController = this.dataLayoutControl1;
            this.DocNoTextEdit.TabIndex = 5;
            // 
            // ItemDescriptionGridLookUpEdit
            // 
            this.ItemDescriptionGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "ItemDescription", true));
            this.ItemDescriptionGridLookUpEdit.Location = new System.Drawing.Point(93, 84);
            this.ItemDescriptionGridLookUpEdit.Name = "ItemDescriptionGridLookUpEdit";
            this.ItemDescriptionGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDescriptionGridLookUpEdit.Properties.DataSource = this.spgetCustomerInvoiceItemsBindingSource;
            this.ItemDescriptionGridLookUpEdit.Properties.DisplayMember = "Itemdescription";
            this.ItemDescriptionGridLookUpEdit.Properties.NullText = "";
            this.ItemDescriptionGridLookUpEdit.Properties.ValueMember = "ItemCode";
            this.ItemDescriptionGridLookUpEdit.Properties.View = this.gridView2;
            this.ItemDescriptionGridLookUpEdit.Size = new System.Drawing.Size(388, 20);
            this.ItemDescriptionGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemDescriptionGridLookUpEdit.TabIndex = 7;
            this.ItemDescriptionGridLookUpEdit.EditValueChanged += new System.EventHandler(this.ItemDescriptionGridLookUpEdit_EditValueChanged);
            // 
            // spgetCustomerInvoiceItemsBindingSource
            // 
            this.spgetCustomerInvoiceItemsBindingSource.DataMember = "spgetCustomerInvoiceItems";
            this.spgetCustomerInvoiceItemsBindingSource.DataSource = this.dsCustomerCreditNotes;
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
            // QtyTextEdit
            // 
            this.QtyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "Qty", true));
            this.QtyTextEdit.Location = new System.Drawing.Point(93, 108);
            this.QtyTextEdit.Name = "QtyTextEdit";
            this.QtyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtyTextEdit.Properties.Mask.EditMask = "F";
            this.QtyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QtyTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QtyTextEdit.Size = new System.Drawing.Size(388, 20);
            this.QtyTextEdit.StyleController = this.dataLayoutControl1;
            this.QtyTextEdit.TabIndex = 8;
            this.QtyTextEdit.EditValueChanged += new System.EventHandler(this.QtyTextEdit_EditValueChanged);
            // 
            // UnitCostTextEdit
            // 
            this.UnitCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "UnitCost", true));
            this.UnitCostTextEdit.Location = new System.Drawing.Point(566, 84);
            this.UnitCostTextEdit.Name = "UnitCostTextEdit";
            this.UnitCostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitCostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitCostTextEdit.Properties.Mask.EditMask = "G";
            this.UnitCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitCostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitCostTextEdit.Size = new System.Drawing.Size(388, 20);
            this.UnitCostTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitCostTextEdit.TabIndex = 9;
            // 
            // ExtendedCostTextEdit
            // 
            this.ExtendedCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "ExtendedCost", true));
            this.ExtendedCostTextEdit.Location = new System.Drawing.Point(566, 108);
            this.ExtendedCostTextEdit.Name = "ExtendedCostTextEdit";
            this.ExtendedCostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ExtendedCostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ExtendedCostTextEdit.Properties.Mask.EditMask = "G";
            this.ExtendedCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ExtendedCostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ExtendedCostTextEdit.Size = new System.Drawing.Size(388, 20);
            this.ExtendedCostTextEdit.StyleController = this.dataLayoutControl1;
            this.ExtendedCostTextEdit.TabIndex = 10;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(93, 132);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(388, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 11;
            // 
            // CustCodeGridLookUpEdit
            // 
            this.CustCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spselectCustomerCrediNotesBindingSource, "CustCode", true));
            this.CustCodeGridLookUpEdit.Location = new System.Drawing.Point(93, 60);
            this.CustCodeGridLookUpEdit.Name = "CustCodeGridLookUpEdit";
            this.CustCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustCodeGridLookUpEdit.Properties.DataSource = this.spGetCustomersBindingSource;
            this.CustCodeGridLookUpEdit.Properties.DisplayMember = "CustName";
            this.CustCodeGridLookUpEdit.Properties.NullText = "";
            this.CustCodeGridLookUpEdit.Properties.ValueMember = "CustCode";
            this.CustCodeGridLookUpEdit.Properties.View = this.gridView3;
            this.CustCodeGridLookUpEdit.Size = new System.Drawing.Size(388, 20);
            this.CustCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CustCodeGridLookUpEdit.TabIndex = 12;
            this.CustCodeGridLookUpEdit.EditValueChanged += new System.EventHandler(this.CustCodeGridLookUpEdit_EditValueChanged);
            // 
            // spGetCustomersBindingSource
            // 
            this.spGetCustomersBindingSource.DataMember = "spGetCustomers";
            this.spGetCustomersBindingSource.DataSource = this.dsCustomerCreditNotes;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(966, 313);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.ItemForQty,
            this.ItemForCustCode,
            this.ItemForCostCenter,
            this.ItemForDocNo,
            this.ItemForItemDescription,
            this.ItemForUnitCost,
            this.ItemForExtendedCost,
            this.ItemForRemarks,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(946, 293);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(946, 149);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForQty
            // 
            this.ItemForQty.Control = this.QtyTextEdit;
            this.ItemForQty.Location = new System.Drawing.Point(0, 96);
            this.ItemForQty.Name = "ItemForQty";
            this.ItemForQty.Size = new System.Drawing.Size(473, 24);
            this.ItemForQty.Text = "Qty";
            this.ItemForQty.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForCustCode
            // 
            this.ItemForCustCode.Control = this.CustCodeGridLookUpEdit;
            this.ItemForCustCode.Location = new System.Drawing.Point(0, 48);
            this.ItemForCustCode.Name = "ItemForCustCode";
            this.ItemForCustCode.Size = new System.Drawing.Size(473, 24);
            this.ItemForCustCode.Text = "Cust Code";
            this.ItemForCustCode.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 24);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(473, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForDocNo
            // 
            this.ItemForDocNo.Control = this.DocNoTextEdit;
            this.ItemForDocNo.Location = new System.Drawing.Point(473, 24);
            this.ItemForDocNo.Name = "ItemForDocNo";
            this.ItemForDocNo.Size = new System.Drawing.Size(473, 24);
            this.ItemForDocNo.Text = "Doc No";
            this.ItemForDocNo.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForItemDescription
            // 
            this.ItemForItemDescription.Control = this.ItemDescriptionGridLookUpEdit;
            this.ItemForItemDescription.Location = new System.Drawing.Point(0, 72);
            this.ItemForItemDescription.Name = "ItemForItemDescription";
            this.ItemForItemDescription.Size = new System.Drawing.Size(473, 24);
            this.ItemForItemDescription.Text = "Item Description";
            this.ItemForItemDescription.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForUnitCost
            // 
            this.ItemForUnitCost.Control = this.UnitCostTextEdit;
            this.ItemForUnitCost.Location = new System.Drawing.Point(473, 72);
            this.ItemForUnitCost.Name = "ItemForUnitCost";
            this.ItemForUnitCost.Size = new System.Drawing.Size(473, 24);
            this.ItemForUnitCost.Text = "Unit Cost";
            this.ItemForUnitCost.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForExtendedCost
            // 
            this.ItemForExtendedCost.Control = this.ExtendedCostTextEdit;
            this.ItemForExtendedCost.Location = new System.Drawing.Point(473, 96);
            this.ItemForExtendedCost.Name = "ItemForExtendedCost";
            this.ItemForExtendedCost.Size = new System.Drawing.Size(473, 48);
            this.ItemForExtendedCost.Text = "Extended Cost";
            this.ItemForExtendedCost.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 120);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(473, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Invoicegl;
            this.layoutControlItem2.Location = new System.Drawing.Point(473, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem2.Text = "Invoice  No";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.toolStrip1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(946, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // spselectCustomerCrediNotesBindingSource1
            // 
            this.spselectCustomerCrediNotesBindingSource1.DataMember = "spselectCustomerCrediNotes";
            this.spselectCustomerCrediNotesBindingSource1.DataSource = this.dsCustomerCreditNotes;
            // 
            // spgetCustomerInvoiceBindingSource
            // 
            this.spgetCustomerInvoiceBindingSource.DataMember = "spgetCustomerInvoice";
            this.spgetCustomerInvoiceBindingSource.DataSource = this.dsCustomerCreditNotes1;
            // 
            // dsCustomerCreditNotes1
            // 
            this.dsCustomerCreditNotes1.DataSetName = "dsCustomerCreditNotes";
            this.dsCustomerCreditNotes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spselectCustomerCrediNotesTableAdapter
            // 
            this.spselectCustomerCrediNotesTableAdapter.ClearBeforeFill = true;
            // 
            // spselectAllCustomerCrediNotesTableAdapter
            // 
            this.spselectAllCustomerCrediNotesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCustomersTableAdapter
            // 
            this.spGetCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCustomerInvoiceItems1BindingSource1
            // 
            this.spgetCustomerInvoiceItems1BindingSource1.DataMember = "spgetCustomerInvoiceItems1";
            this.spgetCustomerInvoiceItems1BindingSource1.DataSource = this.dsCustomerCreditNotes;
            // 
            // spgetCustomerInvoiceItemsTableAdapter
            // 
            this.spgetCustomerInvoiceItemsTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCustomerInvoiceTableAdapter
            // 
            this.spgetCustomerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // frmCustomerCreditNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 313);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCustomerCreditNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer CreditNotes";
            this.Load += new System.EventHandler(this.frmCustomerCreditNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoicegl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerCreditNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectAllCustomerCrediNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectCustomerCrediNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendedCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExtendedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectCustomerCrediNotesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerCreditNotes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCustomerInvoiceItems1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private System.Windows.Forms.BindingSource spselectCustomerCrediNotesBindingSource;
        private Class.DataSet.dsCustomerCreditNotes dsCustomerCreditNotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit DocNoTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit ItemDescriptionGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit QtyTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitCostTextEdit;
        private DevExpress.XtraEditors.TextEdit ExtendedCostTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit CustCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQty;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitCost;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExtendedCost;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustCode;
        private Class.DataSet.dsCustomerCreditNotesTableAdapters.spselectCustomerCrediNotesTableAdapter spselectCustomerCrediNotesTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource spselectAllCustomerCrediNotesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDocType;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCNStatus;
        private Class.DataSet.dsCustomerCreditNotesTableAdapters.spselectAllCustomerCrediNotesTableAdapter spselectAllCustomerCrediNotesTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsCustomerCreditNotesTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetCustomersBindingSource;
        private Class.DataSet.dsCustomerCreditNotesTableAdapters.spGetCustomersTableAdapter spGetCustomersTableAdapter;
        private System.Windows.Forms.BindingSource spgetCustomerInvoiceItems1BindingSource1;
        private System.Windows.Forms.BindingSource spgetCustomerInvoiceItemsBindingSource;
        private Class.DataSet.dsCustomerCreditNotesTableAdapters.spgetCustomerInvoiceItemsTableAdapter spgetCustomerInvoiceItemsTableAdapter;
        private System.Windows.Forms.BindingSource spgetCustomerInvoiceBindingSource;
        private Class.DataSet.dsCustomerCreditNotes dsCustomerCreditNotes1;
        private Class.DataSet.dsCustomerCreditNotesTableAdapters.spgetCustomerInvoiceTableAdapter spgetCustomerInvoiceTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit Invoicegl;
        private System.Windows.Forms.BindingSource spgetCustomerInvoiceBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource spselectCustomerCrediNotesBindingSource1;
    }
}