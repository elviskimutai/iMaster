namespace Master.Forms
{
    partial class frmJournalEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalEntry));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboEntry = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridcostcenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJournalEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJournalEntry = new Master.Class.DataSet.dsJournalEntry();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.spselectAllJournalEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLOffSet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoEremarlks = new DevExpress.XtraEditors.MemoExEdit();
            this.txtrefNo = new DevExpress.XtraEditors.TextEdit();
            this.glLedger = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetledgersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gldate = new DevExpress.XtraEditors.DateEdit();
            this.glAcc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetGlAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gloffset = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetGlAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.glCostcenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spselectAllJournalEntriesTableAdapter = new Master.Class.DataSet.dsJournalEntryTableAdapters.spselectAllJournalEntriesTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsJournalEntryTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spgetGlAccountsTableAdapter = new Master.Class.DataSet.dsJournalEntryTableAdapters.spgetGlAccountsTableAdapter();
            this.spgetledgersTableAdapter = new Master.Class.DataSet.dsJournalEntryTableAdapters.spgetledgersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboEntry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcostcenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournalEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournalEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectAllJournalEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEremarlks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrefNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glLedger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetledgersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetGlAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gloffset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetGlAccountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboEntry);
            this.layoutControl1.Controls.Add(this.gridcostcenter);
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.memoEremarlks);
            this.layoutControl1.Controls.Add(this.txtrefNo);
            this.layoutControl1.Controls.Add(this.glLedger);
            this.layoutControl1.Controls.Add(this.gldate);
            this.layoutControl1.Controls.Add(this.glAcc);
            this.layoutControl1.Controls.Add(this.gloffset);
            this.layoutControl1.Controls.Add(this.txtAmount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(905, 405);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboEntry
            // 
            this.comboEntry.Location = new System.Drawing.Point(80, 114);
            this.comboEntry.Name = "comboEntry";
            this.comboEntry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboEntry.Properties.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.comboEntry.Size = new System.Drawing.Size(381, 20);
            this.comboEntry.StyleController = this.layoutControl1;
            this.comboEntry.TabIndex = 24;
            // 
            // gridcostcenter
            // 
            this.gridcostcenter.EditValue = "";
            this.gridcostcenter.Location = new System.Drawing.Point(80, 66);
            this.gridcostcenter.Name = "gridcostcenter";
            this.gridcostcenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridcostcenter.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.gridcostcenter.Properties.DisplayMember = "ccname";
            this.gridcostcenter.Properties.ValueMember = "cccode";
            this.gridcostcenter.Properties.View = this.gridView2;
            this.gridcostcenter.Size = new System.Drawing.Size(381, 20);
            this.gridcostcenter.StyleController = this.layoutControl1;
            this.gridcostcenter.TabIndex = 23;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsJournalEntryBindingSource;
            // 
            // dsJournalEntryBindingSource
            // 
            this.dsJournalEntryBindingSource.DataSource = this.dsJournalEntry;
            this.dsJournalEntryBindingSource.Position = 0;
            // 
            // dsJournalEntry
            // 
            this.dsJournalEntry.DataSetName = "dsJournalEntry";
            this.dsJournalEntry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.toolStrip1.TabIndex = 22;
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
            this.Submit.Size = new System.Drawing.Size(65, 17);
            this.Submit.Text = "Upload";
            this.Submit.Click += new System.EventHandler(this.cutToolStripButton_Click);
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
            this.gridControl1.DataSource = this.spselectAllJournalEntriesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 198);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(881, 195);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spselectAllJournalEntriesBindingSource
            // 
            this.spselectAllJournalEntriesBindingSource.DataMember = "spselectAllJournalEntries";
            this.spselectAllJournalEntriesBindingSource.DataSource = this.dsJournalEntryBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNo,
            this.colDocType,
            this.colJournalLine,
            this.colGLDate,
            this.colGLAccount,
            this.colGLOffSet,
            this.colLedger,
            this.colDebit,
            this.colCredit,
            this.colRefNo,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colDocNo
            // 
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            this.colDocNo.Visible = true;
            this.colDocNo.VisibleIndex = 0;
            // 
            // colDocType
            // 
            this.colDocType.FieldName = "DocType";
            this.colDocType.Name = "colDocType";
            this.colDocType.Visible = true;
            this.colDocType.VisibleIndex = 1;
            // 
            // colJournalLine
            // 
            this.colJournalLine.FieldName = "JournalLine";
            this.colJournalLine.Name = "colJournalLine";
            this.colJournalLine.Visible = true;
            this.colJournalLine.VisibleIndex = 2;
            // 
            // colGLDate
            // 
            this.colGLDate.FieldName = "GLDate";
            this.colGLDate.Name = "colGLDate";
            this.colGLDate.Visible = true;
            this.colGLDate.VisibleIndex = 3;
            // 
            // colGLAccount
            // 
            this.colGLAccount.FieldName = "GLAccount";
            this.colGLAccount.Name = "colGLAccount";
            this.colGLAccount.Visible = true;
            this.colGLAccount.VisibleIndex = 4;
            // 
            // colGLOffSet
            // 
            this.colGLOffSet.FieldName = "GLOffSet";
            this.colGLOffSet.Name = "colGLOffSet";
            this.colGLOffSet.Visible = true;
            this.colGLOffSet.VisibleIndex = 5;
            // 
            // colLedger
            // 
            this.colLedger.FieldName = "Ledger";
            this.colLedger.Name = "colLedger";
            this.colLedger.Visible = true;
            this.colLedger.VisibleIndex = 6;
            // 
            // colDebit
            // 
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 7;
            // 
            // colCredit
            // 
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 8;
            // 
            // colRefNo
            // 
            this.colRefNo.FieldName = "RefNo";
            this.colRefNo.Name = "colRefNo";
            this.colRefNo.Visible = true;
            this.colRefNo.VisibleIndex = 9;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 10;
            // 
            // memoEremarlks
            // 
            this.memoEremarlks.Location = new System.Drawing.Point(80, 162);
            this.memoEremarlks.Name = "memoEremarlks";
            this.memoEremarlks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoEremarlks.Size = new System.Drawing.Size(381, 20);
            this.memoEremarlks.StyleController = this.layoutControl1;
            this.memoEremarlks.TabIndex = 12;
            // 
            // txtrefNo
            // 
            this.txtrefNo.Location = new System.Drawing.Point(521, 90);
            this.txtrefNo.Name = "txtrefNo";
            this.txtrefNo.Size = new System.Drawing.Size(360, 20);
            this.txtrefNo.StyleController = this.layoutControl1;
            this.txtrefNo.TabIndex = 11;
            // 
            // glLedger
            // 
            this.glLedger.EditValue = "";
            this.glLedger.Location = new System.Drawing.Point(521, 66);
            this.glLedger.Name = "glLedger";
            this.glLedger.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glLedger.Properties.DataSource = this.spgetledgersBindingSource;
            this.glLedger.Properties.DisplayMember = "Ledgername";
            this.glLedger.Properties.ValueMember = "LedgerCode";
            this.glLedger.Properties.View = this.gridLookUpEdit3View;
            this.glLedger.Size = new System.Drawing.Size(360, 20);
            this.glLedger.StyleController = this.layoutControl1;
            this.glLedger.TabIndex = 10;
            // 
            // spgetledgersBindingSource
            // 
            this.spgetledgersBindingSource.DataMember = "spgetledgers";
            this.spgetledgersBindingSource.DataSource = this.dsJournalEntryBindingSource;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // gldate
            // 
            this.gldate.EditValue = null;
            this.gldate.Location = new System.Drawing.Point(80, 90);
            this.gldate.Name = "gldate";
            this.gldate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gldate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gldate.Size = new System.Drawing.Size(381, 20);
            this.gldate.StyleController = this.layoutControl1;
            this.gldate.TabIndex = 9;
            // 
            // glAcc
            // 
            this.glAcc.EditValue = "";
            this.glAcc.Location = new System.Drawing.Point(80, 138);
            this.glAcc.Name = "glAcc";
            this.glAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glAcc.Properties.DataSource = this.spgetGlAccountsBindingSource;
            this.glAcc.Properties.DisplayMember = "AccName";
            this.glAcc.Properties.ValueMember = "AccCode";
            this.glAcc.Properties.View = this.gridLookUpEdit2View;
            this.glAcc.Size = new System.Drawing.Size(381, 20);
            this.glAcc.StyleController = this.layoutControl1;
            this.glAcc.TabIndex = 8;
            // 
            // spgetGlAccountsBindingSource
            // 
            this.spgetGlAccountsBindingSource.DataMember = "spgetGlAccounts";
            this.spgetGlAccountsBindingSource.DataSource = this.dsJournalEntryBindingSource;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gloffset
            // 
            this.gloffset.EditValue = "";
            this.gloffset.Location = new System.Drawing.Point(521, 114);
            this.gloffset.Name = "gloffset";
            this.gloffset.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gloffset.Properties.DataSource = this.spgetGlAccountsBindingSource1;
            this.gloffset.Properties.DisplayMember = "AccName";
            this.gloffset.Properties.ValueMember = "AccCode";
            this.gloffset.Properties.View = this.gridLookUpEdit1View;
            this.gloffset.Size = new System.Drawing.Size(360, 20);
            this.gloffset.StyleController = this.layoutControl1;
            this.gloffset.TabIndex = 7;
            // 
            // spgetGlAccountsBindingSource1
            // 
            this.spgetGlAccountsBindingSource1.DataMember = "spgetGlAccounts";
            this.spgetGlAccountsBindingSource1.DataSource = this.dsJournalEntryBindingSource;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(521, 138);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(360, 20);
            this.txtAmount.StyleController = this.layoutControl1;
            this.txtAmount.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlGroup2,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(905, 405);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.gridControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(885, 199);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.glCostcenter,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(885, 162);
            this.layoutControlGroup2.Text = "Journal Entry";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gldate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(441, 24);
            this.layoutControlItem6.Text = "GLDate";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.memoEremarlks;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(441, 24);
            this.layoutControlItem9.Text = "Remarks";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.glLedger;
            this.layoutControlItem7.Location = new System.Drawing.Point(441, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem7.Text = "Ledger";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.glAcc;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(441, 24);
            this.layoutControlItem5.Text = "GLAccount";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(53, 13);
            // 
            // glCostcenter
            // 
            this.glCostcenter.Control = this.gridcostcenter;
            this.glCostcenter.Location = new System.Drawing.Point(0, 0);
            this.glCostcenter.Name = "glCostcenter";
            this.glCostcenter.Size = new System.Drawing.Size(441, 24);
            this.glCostcenter.Text = "Costcenter";
            this.glCostcenter.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtrefNo;
            this.layoutControlItem8.Location = new System.Drawing.Point(441, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem8.Text = "RefNo";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboEntry;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(441, 24);
            this.layoutControlItem2.Text = "Entry";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gloffset;
            this.layoutControlItem4.Location = new System.Drawing.Point(441, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem4.Text = "GLOffSet";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtAmount;
            this.layoutControlItem3.Location = new System.Drawing.Point(441, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 48);
            this.layoutControlItem3.Text = "Amount";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.toolStrip1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(885, 24);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // spselectAllJournalEntriesTableAdapter
            // 
            this.spselectAllJournalEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetGlAccountsTableAdapter
            // 
            this.spgetGlAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // spgetledgersTableAdapter
            // 
            this.spgetledgersTableAdapter.ClearBeforeFill = true;
            // 
            // frmJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 405);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmJournalEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Entry";
            this.Load += new System.EventHandler(this.frmJournalEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboEntry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcostcenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournalEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournalEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectAllJournalEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEremarlks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrefNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glLedger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetledgersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gldate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetGlAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gloffset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetGlAccountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glAcc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gloffset;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit gldate;
        private DevExpress.XtraEditors.GridLookUpEdit glLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.TextEdit txtrefNo;
        private DevExpress.XtraEditors.MemoExEdit memoEremarlks;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.BindingSource spselectAllJournalEntriesBindingSource;
        private System.Windows.Forms.BindingSource dsJournalEntryBindingSource;
        private Class.DataSet.dsJournalEntry dsJournalEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDocType;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalLine;
        private DevExpress.XtraGrid.Columns.GridColumn colGLDate;
        private DevExpress.XtraGrid.Columns.GridColumn colGLAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colGLOffSet;
        private DevExpress.XtraGrid.Columns.GridColumn colLedger;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private Class.DataSet.dsJournalEntryTableAdapters.spselectAllJournalEntriesTableAdapter spselectAllJournalEntriesTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit gridcostcenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem glCostcenter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsJournalEntryTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spgetGlAccountsBindingSource;
        private System.Windows.Forms.BindingSource spgetGlAccountsBindingSource1;
        private Class.DataSet.dsJournalEntryTableAdapters.spgetGlAccountsTableAdapter spgetGlAccountsTableAdapter;
        private System.Windows.Forms.BindingSource spgetledgersBindingSource;
        private Class.DataSet.dsJournalEntryTableAdapters.spgetledgersTableAdapter spgetledgersTableAdapter;
        private DevExpress.XtraEditors.ComboBoxEdit comboEntry;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}