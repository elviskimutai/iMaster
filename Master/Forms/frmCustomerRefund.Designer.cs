namespace Master.Forms
{
    partial class frmCustomerRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRefund));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllCustomerRefundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCustomerRefund = new Master.Class.DataSet.dsCustomerRefund();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRefundNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreditNoGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCustCreditNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCustomerWithCreditNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TransDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.RefNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GLAccountGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetAssetIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PayModeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetUDCByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTransDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRefNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGLAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreditNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectAllCustomerRefundsTableAdapter = new Master.Class.DataSet.dsCustomerRefundTableAdapters.spSelectAllCustomerRefundsTableAdapter();
            this.spGetCustomerWithCreditNotesTableAdapter = new Master.Class.DataSet.dsCustomerRefundTableAdapters.spGetCustomerWithCreditNotesTableAdapter();
            this.spGetAsset_IncomeTableAdapter = new Master.Class.DataSet.dsCustomerRefundTableAdapters.spGetAsset_IncomeTableAdapter();
            this.spgetUDCByCategoryTableAdapter = new Master.Class.DataSet.dsCustomerRefundTableAdapters.spgetUDCByCategoryTableAdapter();
            this.spGetCustCreditNotesTableAdapter = new Master.Class.DataSet.dsCustomerRefundTableAdapters.spGetCustCreditNotesTableAdapter();
            this.DocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCustomerRefundsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerRefund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditNoGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustCreditNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomerWithCreditNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLAccountGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAssetIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayModeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTransDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRefNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGLAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreditNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CreditNoGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.TransDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.RefNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GLAccountGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PayModeTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(829, 451);
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
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 23);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 20);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 20);
            this.toolStripButton1.Text = "Export";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllCustomerRefundsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 135);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(805, 304);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // spSelectAllCustomerRefundsBindingSource
            // 
            this.spSelectAllCustomerRefundsBindingSource.DataMember = "spSelectAllCustomerRefunds";
            this.spSelectAllCustomerRefundsBindingSource.DataSource = this.dsCustomerRefund;
            // 
            // dsCustomerRefund
            // 
            this.dsCustomerRefund.DataSetName = "dsCustomerRefund";
            this.dsCustomerRefund.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRefundNo,
            this.colCreditNo,
            this.colCustomer,
            this.colTransDate,
            this.colRefNo,
            this.colPayMode,
            this.colGLAccount,
            this.colAmount,
            this.colRemarks});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            // 
            // colRefundNo
            // 
            this.colRefundNo.FieldName = "RefundNo";
            this.colRefundNo.Name = "colRefundNo";
            this.colRefundNo.Visible = true;
            this.colRefundNo.VisibleIndex = 0;
            // 
            // colCreditNo
            // 
            this.colCreditNo.FieldName = "CreditNo";
            this.colCreditNo.Name = "colCreditNo";
            this.colCreditNo.Visible = true;
            this.colCreditNo.VisibleIndex = 1;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 2;
            // 
            // colTransDate
            // 
            this.colTransDate.FieldName = "TransDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 3;
            // 
            // colRefNo
            // 
            this.colRefNo.FieldName = "RefNo";
            this.colRefNo.Name = "colRefNo";
            this.colRefNo.Visible = true;
            this.colRefNo.VisibleIndex = 4;
            // 
            // colPayMode
            // 
            this.colPayMode.FieldName = "PayMode";
            this.colPayMode.Name = "colPayMode";
            this.colPayMode.Visible = true;
            this.colPayMode.VisibleIndex = 5;
            // 
            // colGLAccount
            // 
            this.colGLAccount.FieldName = "GLAccount";
            this.colGLAccount.Name = "colGLAccount";
            this.colGLAccount.Visible = true;
            this.colGLAccount.VisibleIndex = 6;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 7;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 8;
            // 
            // CreditNoGridLookUpEdit
            // 
            this.CreditNoGridLookUpEdit.Location = new System.Drawing.Point(473, 39);
            this.CreditNoGridLookUpEdit.Name = "CreditNoGridLookUpEdit";
            this.CreditNoGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreditNoGridLookUpEdit.Properties.DataSource = this.spGetCustCreditNotesBindingSource;
            this.CreditNoGridLookUpEdit.Properties.DisplayMember = "CustName";
            this.CreditNoGridLookUpEdit.Properties.NullText = "";
            this.CreditNoGridLookUpEdit.Properties.ValueMember = "DocNo";
            this.CreditNoGridLookUpEdit.Properties.View = this.gridView1;
            this.CreditNoGridLookUpEdit.Size = new System.Drawing.Size(344, 20);
            this.CreditNoGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CreditNoGridLookUpEdit.TabIndex = 5;
            this.CreditNoGridLookUpEdit.EditValueChanged += new System.EventHandler(this.CreditNoGridLookUpEdit_EditValueChanged);
            // 
            // spGetCustCreditNotesBindingSource
            // 
            this.spGetCustCreditNotesBindingSource.DataMember = "spGetCustCreditNotes";
            this.spGetCustCreditNotesBindingSource.DataSource = this.dsCustomerRefund;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DocNo,
            this.InvoiceNo,
            this.CustCode,
            this.CustName,
            this.Currency,
            this.Amount});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CustomerGridLookUpEdit
            // 
            this.CustomerGridLookUpEdit.Location = new System.Drawing.Point(69, 39);
            this.CustomerGridLookUpEdit.Name = "CustomerGridLookUpEdit";
            this.CustomerGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerGridLookUpEdit.Properties.DataSource = this.spGetCustomerWithCreditNotesBindingSource;
            this.CustomerGridLookUpEdit.Properties.DisplayMember = "CustName";
            this.CustomerGridLookUpEdit.Properties.NullText = "";
            this.CustomerGridLookUpEdit.Properties.ValueMember = "CustCode";
            this.CustomerGridLookUpEdit.Properties.View = this.gridView2;
            this.CustomerGridLookUpEdit.Size = new System.Drawing.Size(343, 20);
            this.CustomerGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CustomerGridLookUpEdit.TabIndex = 6;
            this.CustomerGridLookUpEdit.EditValueChanged += new System.EventHandler(this.CustomerGridLookUpEdit_EditValueChanged);
            // 
            // spGetCustomerWithCreditNotesBindingSource
            // 
            this.spGetCustomerWithCreditNotesBindingSource.DataMember = "spGetCustomerWithCreditNotes";
            this.spGetCustomerWithCreditNotesBindingSource.DataSource = this.dsCustomerRefund;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // TransDateDateEdit
            // 
            this.TransDateDateEdit.EditValue = null;
            this.TransDateDateEdit.Location = new System.Drawing.Point(69, 63);
            this.TransDateDateEdit.Name = "TransDateDateEdit";
            this.TransDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransDateDateEdit.Size = new System.Drawing.Size(343, 20);
            this.TransDateDateEdit.StyleController = this.dataLayoutControl1;
            this.TransDateDateEdit.TabIndex = 7;
            // 
            // RefNoTextEdit
            // 
            this.RefNoTextEdit.Location = new System.Drawing.Point(473, 63);
            this.RefNoTextEdit.Name = "RefNoTextEdit";
            this.RefNoTextEdit.Size = new System.Drawing.Size(344, 20);
            this.RefNoTextEdit.StyleController = this.dataLayoutControl1;
            this.RefNoTextEdit.TabIndex = 8;
            // 
            // GLAccountGridLookUpEdit
            // 
            this.GLAccountGridLookUpEdit.Location = new System.Drawing.Point(473, 87);
            this.GLAccountGridLookUpEdit.Name = "GLAccountGridLookUpEdit";
            this.GLAccountGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GLAccountGridLookUpEdit.Properties.DataSource = this.spGetAssetIncomeBindingSource;
            this.GLAccountGridLookUpEdit.Properties.DisplayMember = "AccName";
            this.GLAccountGridLookUpEdit.Properties.NullText = "";
            this.GLAccountGridLookUpEdit.Properties.ValueMember = "AccCode";
            this.GLAccountGridLookUpEdit.Properties.View = this.gridView3;
            this.GLAccountGridLookUpEdit.Size = new System.Drawing.Size(344, 20);
            this.GLAccountGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GLAccountGridLookUpEdit.TabIndex = 10;
            // 
            // spGetAssetIncomeBindingSource
            // 
            this.spGetAssetIncomeBindingSource.DataMember = "spGetAsset&Income";
            this.spGetAssetIncomeBindingSource.DataSource = this.dsCustomerRefund;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.Location = new System.Drawing.Point(69, 111);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "G";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(343, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 11;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.Location = new System.Drawing.Point(473, 111);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(344, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 12;
            // 
            // PayModeTextEdit
            // 
            this.PayModeTextEdit.Location = new System.Drawing.Point(69, 87);
            this.PayModeTextEdit.Name = "PayModeTextEdit";
            this.PayModeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayModeTextEdit.Properties.DataSource = this.spgetUDCByCategoryBindingSource;
            this.PayModeTextEdit.Properties.DisplayMember = "Code";
            this.PayModeTextEdit.Properties.NullText = "";
            this.PayModeTextEdit.Properties.ValueMember = "Description";
            this.PayModeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.PayModeTextEdit.Size = new System.Drawing.Size(343, 20);
            this.PayModeTextEdit.StyleController = this.dataLayoutControl1;
            this.PayModeTextEdit.TabIndex = 9;
            // 
            // spgetUDCByCategoryBindingSource
            // 
            this.spgetUDCByCategoryBindingSource.DataMember = "spgetUDCByCategory";
            this.spgetUDCByCategoryBindingSource.DataSource = this.dsCustomerRefund;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(829, 451);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTransDate,
            this.ItemForPayMode,
            this.ItemForAmount,
            this.layoutControlItem1,
            this.ItemForRefNo,
            this.ItemForGLAccount,
            this.ItemForRemarks,
            this.layoutControlItem2,
            this.ItemForCustomer,
            this.ItemForCreditNo});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(809, 431);
            // 
            // ItemForTransDate
            // 
            this.ItemForTransDate.Control = this.TransDateDateEdit;
            this.ItemForTransDate.Location = new System.Drawing.Point(0, 51);
            this.ItemForTransDate.Name = "ItemForTransDate";
            this.ItemForTransDate.Size = new System.Drawing.Size(404, 24);
            this.ItemForTransDate.Text = "Trans Date";
            this.ItemForTransDate.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForPayMode
            // 
            this.ItemForPayMode.Control = this.PayModeTextEdit;
            this.ItemForPayMode.Location = new System.Drawing.Point(0, 75);
            this.ItemForPayMode.Name = "ItemForPayMode";
            this.ItemForPayMode.Size = new System.Drawing.Size(404, 24);
            this.ItemForPayMode.Text = "Pay Mode";
            this.ItemForPayMode.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 99);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(404, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(809, 308);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForRefNo
            // 
            this.ItemForRefNo.Control = this.RefNoTextEdit;
            this.ItemForRefNo.Location = new System.Drawing.Point(404, 51);
            this.ItemForRefNo.Name = "ItemForRefNo";
            this.ItemForRefNo.Size = new System.Drawing.Size(405, 24);
            this.ItemForRefNo.Text = "Ref No";
            this.ItemForRefNo.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForGLAccount
            // 
            this.ItemForGLAccount.Control = this.GLAccountGridLookUpEdit;
            this.ItemForGLAccount.Location = new System.Drawing.Point(404, 75);
            this.ItemForGLAccount.Name = "ItemForGLAccount";
            this.ItemForGLAccount.Size = new System.Drawing.Size(405, 24);
            this.ItemForGLAccount.Text = "GL Account";
            this.ItemForGLAccount.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(404, 99);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(405, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(809, 27);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForCustomer
            // 
            this.ItemForCustomer.Control = this.CustomerGridLookUpEdit;
            this.ItemForCustomer.Location = new System.Drawing.Point(0, 27);
            this.ItemForCustomer.Name = "ItemForCustomer";
            this.ItemForCustomer.Size = new System.Drawing.Size(404, 24);
            this.ItemForCustomer.Text = "Customer";
            this.ItemForCustomer.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForCreditNo
            // 
            this.ItemForCreditNo.Control = this.CreditNoGridLookUpEdit;
            this.ItemForCreditNo.Location = new System.Drawing.Point(404, 27);
            this.ItemForCreditNo.Name = "ItemForCreditNo";
            this.ItemForCreditNo.Size = new System.Drawing.Size(405, 24);
            this.ItemForCreditNo.Text = "Credit No";
            this.ItemForCreditNo.TextSize = new System.Drawing.Size(54, 13);
            // 
            // spSelectAllCustomerRefundsTableAdapter
            // 
            this.spSelectAllCustomerRefundsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCustomerWithCreditNotesTableAdapter
            // 
            this.spGetCustomerWithCreditNotesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetAsset_IncomeTableAdapter
            // 
            this.spGetAsset_IncomeTableAdapter.ClearBeforeFill = true;
            // 
            // spgetUDCByCategoryTableAdapter
            // 
            this.spgetUDCByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCustCreditNotesTableAdapter
            // 
            this.spGetCustCreditNotesTableAdapter.ClearBeforeFill = true;
            // 
            // DocNo
            // 
            this.DocNo.Caption = "DocNo";
            this.DocNo.FieldName = "DocNo";
            this.DocNo.Name = "DocNo";
            this.DocNo.Visible = true;
            this.DocNo.VisibleIndex = 0;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Caption = "InvoiceNo";
            this.InvoiceNo.FieldName = "InvoiceNo";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Visible = true;
            this.InvoiceNo.VisibleIndex = 1;
            // 
            // CustCode
            // 
            this.CustCode.Caption = "CustCode";
            this.CustCode.FieldName = "CustCode";
            this.CustCode.Name = "CustCode";
            this.CustCode.Visible = true;
            this.CustCode.VisibleIndex = 2;
            // 
            // CustName
            // 
            this.CustName.Caption = "CustName";
            this.CustName.FieldName = "CustName";
            this.CustName.Name = "CustName";
            this.CustName.Visible = true;
            this.CustName.VisibleIndex = 3;
            // 
            // Currency
            // 
            this.Currency.Caption = "Currency";
            this.Currency.FieldName = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.Visible = true;
            this.Currency.VisibleIndex = 4;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 5;
            // 
            // frmCustomerRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 451);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCustomerRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Refund";
            this.Load += new System.EventHandler(this.frmCustomerRefund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCustomerRefundsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerRefund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditNoGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustCreditNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomerWithCreditNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLAccountGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAssetIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayModeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTransDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRefNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGLAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreditNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource spSelectAllCustomerRefundsBindingSource;
        private Class.DataSet.dsCustomerRefund dsCustomerRefund;
        private DevExpress.XtraEditors.GridLookUpEdit CreditNoGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit CustomerGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit TransDateDateEdit;
        private DevExpress.XtraEditors.TextEdit RefNoTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit GLAccountGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomer;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRefNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGLAccount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreditNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTransDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayMode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsCustomerRefundTableAdapters.spSelectAllCustomerRefundsTableAdapter spSelectAllCustomerRefundsTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraGrid.Columns.GridColumn colRefundNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPayMode;
        private DevExpress.XtraGrid.Columns.GridColumn colGLAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spGetCustomerWithCreditNotesBindingSource;
        private Class.DataSet.dsCustomerRefundTableAdapters.spGetCustomerWithCreditNotesTableAdapter spGetCustomerWithCreditNotesTableAdapter;
        private System.Windows.Forms.BindingSource spGetAssetIncomeBindingSource;
        private Class.DataSet.dsCustomerRefundTableAdapters.spGetAsset_IncomeTableAdapter spGetAsset_IncomeTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit PayModeTextEdit;
        private System.Windows.Forms.BindingSource spgetUDCByCategoryBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Class.DataSet.dsCustomerRefundTableAdapters.spgetUDCByCategoryTableAdapter spgetUDCByCategoryTableAdapter;
        private System.Windows.Forms.BindingSource spGetCustCreditNotesBindingSource;
        private Class.DataSet.dsCustomerRefundTableAdapters.spGetCustCreditNotesTableAdapter spGetCustCreditNotesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn DocNo;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn CustCode;
        private DevExpress.XtraGrid.Columns.GridColumn CustName;
        private DevExpress.XtraGrid.Columns.GridColumn Currency;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
    }
}