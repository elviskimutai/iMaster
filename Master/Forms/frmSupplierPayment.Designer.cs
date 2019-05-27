namespace Master.Forms
{
    partial class frmSupplierPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierPayment));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtRefNo = new DevExpress.XtraEditors.TextEdit();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSupplierPayment = new Master.Class.DataSet.dsSupplierPayment();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glSuppliers = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersWithBalancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glPaymode = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetUDCByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glAccountNumber = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetBankAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glApplyCredit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSupplierDebtorsNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spGetSupplierInvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsSupplierPaymentTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetSuppliersWithBalancesTableAdapter = new Master.Class.DataSet.dsSupplierPaymentTableAdapters.spGetSuppliersWithBalancesTableAdapter();
            this.spgetUDCByCategoryTableAdapter = new Master.Class.DataSet.dsSupplierPaymentTableAdapters.spgetUDCByCategoryTableAdapter();
            this.spGetBankAccountsTableAdapter = new Master.Class.DataSet.dsSupplierPaymentTableAdapters.spGetBankAccountsTableAdapter();
            this.spGetSupplierInvoicesTableAdapter = new Master.Class.DataSet.dsSupplierPaymentTableAdapters.spGetSupplierInvoicesTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.spSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.spGetSupplierDebtorsNoteTableAdapter = new Master.Class.DataSet.dsSupplierPaymentTableAdapters.spGetSupplierDebtorsNoteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersWithBalancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPaymode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetBankAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glApplyCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSupplierDebtorsNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSupplierInvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(3, 337);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 30;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.lblTotalAmount);
            this.panelControl1.Controls.Add(this.lblTotal);
            this.panelControl1.Location = new System.Drawing.Point(242, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(797, 38);
            this.panelControl1.TabIndex = 29;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Appearance.Options.UseFont = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(198, 9);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(10, 23);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Amount :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(-9, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 301);
            this.panel3.TabIndex = 28;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtRefNo);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Controls.Add(this.glSuppliers);
            this.layoutControl1.Controls.Add(this.glPaymode);
            this.layoutControl1.Controls.Add(this.glAccountNumber);
            this.layoutControl1.Controls.Add(this.glApplyCredit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(248, 301);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(12, 212);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRefNo.Properties.Appearance.Options.UseFont = true;
            this.txtRefNo.Size = new System.Drawing.Size(224, 26);
            this.txtRefNo.StyleController = this.layoutControl1;
            this.txtRefNo.TabIndex = 8;
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
            this.glCostCenter.EditValueChanged += new System.EventHandler(this.glCostCenter_EditValueChanged);
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsSupplierPayment;
            // 
            // dsSupplierPayment
            // 
            this.dsSupplierPayment.DataSetName = "dsSupplierPayment";
            this.dsSupplierPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // glSuppliers
            // 
            this.glSuppliers.Location = new System.Drawing.Point(12, 74);
            this.glSuppliers.Name = "glSuppliers";
            this.glSuppliers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glSuppliers.Properties.Appearance.Options.UseFont = true;
            this.glSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glSuppliers.Properties.DataSource = this.spGetSuppliersWithBalancesBindingSource;
            this.glSuppliers.Properties.DisplayMember = "Supplier Name";
            this.glSuppliers.Properties.ValueMember = "Supplier Code";
            this.glSuppliers.Properties.View = this.gridLookUpEdit1View;
            this.glSuppliers.Size = new System.Drawing.Size(224, 26);
            this.glSuppliers.StyleController = this.layoutControl1;
            this.glSuppliers.TabIndex = 4;
            this.glSuppliers.EditValueChanged += new System.EventHandler(this.glSuppliers_EditValueChanged);
            // 
            // spGetSuppliersWithBalancesBindingSource
            // 
            this.spGetSuppliersWithBalancesBindingSource.DataMember = "spGetSuppliersWithBalances";
            this.spGetSuppliersWithBalancesBindingSource.DataSource = this.dsSupplierPayment;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // glPaymode
            // 
            this.glPaymode.EditValue = "[Add Paymode]";
            this.glPaymode.Location = new System.Drawing.Point(12, 120);
            this.glPaymode.Name = "glPaymode";
            this.glPaymode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glPaymode.Properties.Appearance.Options.UseFont = true;
            this.glPaymode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPaymode.Properties.DataSource = this.spgetUDCByCategoryBindingSource;
            this.glPaymode.Properties.DisplayMember = "Description";
            this.glPaymode.Properties.ValueMember = "Code";
            this.glPaymode.Properties.View = this.gridView2;
            this.glPaymode.Size = new System.Drawing.Size(224, 26);
            this.glPaymode.StyleController = this.layoutControl1;
            this.glPaymode.TabIndex = 4;
            // 
            // spgetUDCByCategoryBindingSource
            // 
            this.spgetUDCByCategoryBindingSource.DataMember = "spgetUDCByCategory";
            this.spgetUDCByCategoryBindingSource.DataSource = this.dsSupplierPayment;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // glAccountNumber
            // 
            this.glAccountNumber.EditValue = "Add Account";
            this.glAccountNumber.Location = new System.Drawing.Point(12, 166);
            this.glAccountNumber.Name = "glAccountNumber";
            this.glAccountNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glAccountNumber.Properties.Appearance.Options.UseFont = true;
            this.glAccountNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glAccountNumber.Properties.DataSource = this.spGetBankAccountsBindingSource;
            this.glAccountNumber.Properties.DisplayMember = "AccName";
            this.glAccountNumber.Properties.ValueMember = "AccNumber";
            this.glAccountNumber.Properties.View = this.gridView3;
            this.glAccountNumber.Size = new System.Drawing.Size(224, 26);
            this.glAccountNumber.StyleController = this.layoutControl1;
            this.glAccountNumber.TabIndex = 4;
            // 
            // spGetBankAccountsBindingSource
            // 
            this.spGetBankAccountsBindingSource.DataMember = "spGetBankAccounts";
            this.spGetBankAccountsBindingSource.DataSource = this.dsSupplierPayment;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Account No";
            this.gridColumn1.FieldName = "AccNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Account Name";
            this.gridColumn2.FieldName = "AccName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // glApplyCredit
            // 
            this.glApplyCredit.EditValue = "Select Credit";
            this.glApplyCredit.Location = new System.Drawing.Point(12, 258);
            this.glApplyCredit.Name = "glApplyCredit";
            this.glApplyCredit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.glApplyCredit.Properties.Appearance.Options.UseFont = true;
            this.glApplyCredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glApplyCredit.Properties.DataSource = this.spGetSupplierDebtorsNoteBindingSource;
            this.glApplyCredit.Properties.DisplayMember = "SupplierName";
            this.glApplyCredit.Properties.NullText = "Select credit";
            this.glApplyCredit.Properties.ValueMember = "DocNo";
            this.glApplyCredit.Properties.View = this.gridView4;
            this.glApplyCredit.Size = new System.Drawing.Size(224, 26);
            this.glApplyCredit.StyleController = this.layoutControl1;
            this.glApplyCredit.TabIndex = 9;
            // 
            // spGetSupplierDebtorsNoteBindingSource
            // 
            this.spGetSupplierDebtorsNoteBindingSource.DataMember = "spGetSupplierDebtorsNote";
            this.spGetSupplierDebtorsNoteBindingSource.DataSource = this.dsSupplierPayment;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DocNo,
            this.OrderNo,
            this.SuppCode,
            this.SupplierName,
            this.Currency,
            this.Amount});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsSelection.MultiSelect = true;
            this.gridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView4_SelectionChanged);
            // 
            // DocNo
            // 
            this.DocNo.Caption = "DocNo";
            this.DocNo.FieldName = "DocNo";
            this.DocNo.Name = "DocNo";
            this.DocNo.Visible = true;
            this.DocNo.VisibleIndex = 1;
            // 
            // OrderNo
            // 
            this.OrderNo.Caption = "OrderNo";
            this.OrderNo.FieldName = "OrderNo";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.Visible = true;
            this.OrderNo.VisibleIndex = 2;
            // 
            // SuppCode
            // 
            this.SuppCode.Caption = "SuppCode";
            this.SuppCode.FieldName = "SuppCode";
            this.SuppCode.Name = "SuppCode";
            this.SuppCode.Visible = true;
            this.SuppCode.VisibleIndex = 3;
            // 
            // SupplierName
            // 
            this.SupplierName.Caption = "SupplierName";
            this.SupplierName.FieldName = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Visible = true;
            this.SupplierName.VisibleIndex = 4;
            // 
            // Currency
            // 
            this.Currency.Caption = "Currency";
            this.Currency.FieldName = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.Visible = true;
            this.Currency.VisibleIndex = 5;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 301);
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
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.glCostCenter;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem4.Text = "CostCenter";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glPaymode;
            this.layoutControlItem3.CustomizationFormText = "Account No";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem3.Text = "Pay Mode";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.glAccountNumber;
            this.layoutControlItem5.CustomizationFormText = "Account No";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem5.Text = "Account No";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtRefNo;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem6.Text = "RefNo";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glApplyCredit;
            this.layoutControlItem2.CustomizationFormText = "Apply Credit";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 230);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 51);
            this.layoutControlItem2.Text = "Apply Credit";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(242, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 421);
            this.panel1.TabIndex = 26;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spGetSupplierInvoicesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(797, 421);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spGetSupplierInvoicesBindingSource
            // 
            this.spGetSupplierInvoicesBindingSource.DataMember = "spGetSupplierInvoices";
            this.spGetSupplierInvoicesBindingSource.DataSource = this.dsSupplierPayment;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colDueDate,
            this.colTotalInvoiceAmount,
            this.colCurrency,
            this.colAmountPaid,
            this.colOpenAmount,
            this.colAmount,
            this.colCredit,
            this.colDocNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.OptionsColumn.AllowEdit = false;
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 0;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.OptionsColumn.AllowEdit = false;
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 1;
            // 
            // colDueDate
            // 
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.OptionsColumn.AllowEdit = false;
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 2;
            // 
            // colTotalInvoiceAmount
            // 
            this.colTotalInvoiceAmount.Caption = "Invoice Amount";
            this.colTotalInvoiceAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colTotalInvoiceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalInvoiceAmount.FieldName = "TotalInvoiceAmount";
            this.colTotalInvoiceAmount.Name = "colTotalInvoiceAmount";
            this.colTotalInvoiceAmount.OptionsColumn.AllowEdit = false;
            this.colTotalInvoiceAmount.Visible = true;
            this.colTotalInvoiceAmount.VisibleIndex = 3;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowEdit = false;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 4;
            // 
            // colAmountPaid
            // 
            this.colAmountPaid.DisplayFormat.FormatString = "{0:n2}";
            this.colAmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmountPaid.FieldName = "AmountPaid";
            this.colAmountPaid.Name = "colAmountPaid";
            this.colAmountPaid.OptionsColumn.AllowEdit = false;
            this.colAmountPaid.Visible = true;
            this.colAmountPaid.VisibleIndex = 5;
            // 
            // colOpenAmount
            // 
            this.colOpenAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colOpenAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpenAmount.FieldName = "OpenAmount";
            this.colOpenAmount.Name = "colOpenAmount";
            this.colOpenAmount.OptionsColumn.AllowEdit = false;
            this.colOpenAmount.Visible = true;
            this.colOpenAmount.VisibleIndex = 6;
            // 
            // colAmount
            // 
            this.colAmount.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 7;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colCredit
            // 
            this.colCredit.Caption = "Credit";
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.OptionsColumn.AllowEdit = false;
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 8;
            // 
            // colDocNo
            // 
            this.colDocNo.Caption = "DocNo";
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSuppliersWithBalancesTableAdapter
            // 
            this.spGetSuppliersWithBalancesTableAdapter.ClearBeforeFill = true;
            // 
            // spgetUDCByCategoryTableAdapter
            // 
            this.spgetUDCByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // spGetBankAccountsTableAdapter
            // 
            this.spGetBankAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSupplierInvoicesTableAdapter
            // 
            this.spGetSupplierInvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spSave,
            this.toolStripSeparator2,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1039, 21);
            this.toolStrip2.TabIndex = 31;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // spSave
            // 
            this.spSave.Image = ((System.Drawing.Image)(resources.GetObject("spSave.Image")));
            this.spSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spSave.Name = "spSave";
            this.spSave.Size = new System.Drawing.Size(51, 18);
            this.spSave.Text = "&Save";
            this.spSave.Click += new System.EventHandler(this.spSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 18);
            this.toolStripButton5.Text = "He&lp";
            // 
            // spGetSupplierDebtorsNoteTableAdapter
            // 
            this.spGetSupplierDebtorsNoteTableAdapter.ClearBeforeFill = true;
            // 
            // frmSupplierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 503);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmSupplierPayment";
            this.Text = "Supplier Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSupplierPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersWithBalancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPaymode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetBankAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glApplyCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSupplierDebtorsNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSupplierInvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalAmount;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.GridLookUpEdit glSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtRefNo;
        private DevExpress.XtraEditors.GridLookUpEdit glPaymode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit glAccountNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsSupplierPayment dsSupplierPayment;
        private Class.DataSet.dsSupplierPaymentTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetSuppliersWithBalancesBindingSource;
        private System.Windows.Forms.BindingSource spgetUDCByCategoryBindingSource;
        private Class.DataSet.dsSupplierPaymentTableAdapters.spGetSuppliersWithBalancesTableAdapter spGetSuppliersWithBalancesTableAdapter;
        private Class.DataSet.dsSupplierPaymentTableAdapters.spgetUDCByCategoryTableAdapter spgetUDCByCategoryTableAdapter;
        private System.Windows.Forms.BindingSource spGetBankAccountsBindingSource;
        private Class.DataSet.dsSupplierPaymentTableAdapters.spGetBankAccountsTableAdapter spGetBankAccountsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource spGetSupplierInvoicesBindingSource;
        private Class.DataSet.dsSupplierPaymentTableAdapters.spGetSupplierInvoicesTableAdapter spGetSupplierInvoicesTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalInvoiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton spSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private DevExpress.XtraEditors.GridLookUpEdit glApplyCredit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn DocNo;
        private DevExpress.XtraGrid.Columns.GridColumn OrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn SuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn Currency;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private System.Windows.Forms.BindingSource spGetSupplierDebtorsNoteBindingSource;
        private Class.DataSet.dsSupplierPaymentTableAdapters.spGetSupplierDebtorsNoteTableAdapter spGetSupplierDebtorsNoteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNo;
    }
}