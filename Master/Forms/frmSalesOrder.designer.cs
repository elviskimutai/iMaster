namespace Master.Forms
{
    partial class frmSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrder));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.dsSalesOrder = new Master.Class.DataSet.dsSalesOrder();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelHeldOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtBarCode = new DevExpress.XtraEditors.TextEdit();
            this.sleItems = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glCostCenter = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sleCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spGetCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sleCurrency = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spgetCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sleWarehouse = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spGetWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sleSalesPerson = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spGetSalesRepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.spGetCustomersTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetCustomersTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetItemsTableAdapter();
            this.spGetSalesRepsTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetSalesRepsTableAdapter();
            this.txtCash = new DevExpress.XtraEditors.TextEdit();
            this.txtCard = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileMoney = new DevExpress.XtraEditors.TextEdit();
            this.txtRefNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblSalesTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblPaid = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblChange = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtNarration = new System.Windows.Forms.RichTextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SbQuotation = new DevExpress.XtraEditors.SimpleButton();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.salesOrdersBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.salesOrdersBufferTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.SalesOrdersBufferTableAdapter();
            this.spGetItemCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetItemCodesTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetItemCodesTableAdapter();
            this.spGetItemUnitCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetItemUnitCostTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetItemUnitCostTableAdapter();
            this.spgetCurrenciesTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spgetCurrenciesTableAdapter();
            this.spGenerateOrderNosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGenerateOrderNosTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGenerateOrderNosTableAdapter();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.spGetWarehousesTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGetWarehousesTableAdapter();
            this.spGenerateQNosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGenerateQNosTableAdapter = new Master.Class.DataSet.dsSalesOrderTableAdapters.spGenerateQNosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleSalesPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSalesRepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemUnitCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerateOrderNosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerateQNosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSalesOrder
            // 
            this.dsSalesOrder.DataSetName = "dsSalesOrder";
            this.dsSalesOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printerSetupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printerSetupToolStripMenuItem
            // 
            this.printerSetupToolStripMenuItem.Name = "printerSetupToolStripMenuItem";
            this.printerSetupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.printerSetupToolStripMenuItem.Text = "Printer Setup";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holdToolStripMenuItem,
            this.recalToolStripMenuItem,
            this.cancelHeldOrdersToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // holdToolStripMenuItem
            // 
            this.holdToolStripMenuItem.Name = "holdToolStripMenuItem";
            this.holdToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.holdToolStripMenuItem.Text = "&Hold";
            // 
            // recalToolStripMenuItem
            // 
            this.recalToolStripMenuItem.Name = "recalToolStripMenuItem";
            this.recalToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.recalToolStripMenuItem.Text = "&Recall";
            // 
            // cancelHeldOrdersToolStripMenuItem
            // 
            this.cancelHeldOrdersToolStripMenuItem.Name = "cancelHeldOrdersToolStripMenuItem";
            this.cancelHeldOrdersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cancelHeldOrdersToolStripMenuItem.Text = "Cancel Held Orders";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.ToolTipText = "SalesOrders";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(796, 20);
            this.toolStripMenuItem3.Text = resources.GetString("toolStripMenuItem3.Text");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = " ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.layoutControl1);
            this.panelControl2.Location = new System.Drawing.Point(0, 27);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(262, 258);
            this.panelControl2.TabIndex = 18;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtBarCode);
            this.layoutControl1.Controls.Add(this.sleItems);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Controls.Add(this.sleCustomers);
            this.layoutControl1.Controls.Add(this.sleCurrency);
            this.layoutControl1.Controls.Add(this.sleWarehouse);
            this.layoutControl1.Controls.Add(this.sleSalesPerson);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(258, 254);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.Location = new System.Drawing.Point(22, 182);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Properties.Appearance.Options.UseFont = true;
            this.txtBarCode.Properties.NullText = "Barcode";
            this.txtBarCode.Size = new System.Drawing.Size(224, 26);
            this.txtBarCode.StyleController = this.layoutControl1;
            this.txtBarCode.TabIndex = 4;
            this.txtBarCode.ToolTip = "Barcode";
            // 
            // sleItems
            // 
            this.sleItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sleItems.Location = new System.Drawing.Point(22, 148);
            this.sleItems.Name = "sleItems";
            this.sleItems.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.sleItems.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleItems.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sleItems.Properties.Appearance.Options.UseBackColor = true;
            this.sleItems.Properties.Appearance.Options.UseFont = true;
            this.sleItems.Properties.Appearance.Options.UseForeColor = true;
            this.sleItems.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.sleItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleItems.Properties.DataSource = this.spGetItemsBindingSource;
            this.sleItems.Properties.DisplayMember = "ItemDescription";
            this.sleItems.Properties.NullText = "Item Search";
            this.sleItems.Properties.ValueMember = "ItemCode";
            this.sleItems.Properties.View = this.gridView2;
            this.sleItems.Size = new System.Drawing.Size(224, 30);
            this.sleItems.StyleController = this.layoutControl1;
            this.sleItems.TabIndex = 3;
            this.sleItems.EditValueChanged += new System.EventHandler(this.sleItems_EditValueChanged);
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsSalesOrder;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // glCostCenter
            // 
            this.glCostCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glCostCenter.Location = new System.Drawing.Point(22, 46);
            this.glCostCenter.Name = "glCostCenter";
            this.glCostCenter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glCostCenter.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.glCostCenter.Properties.Appearance.Options.UseFont = true;
            this.glCostCenter.Properties.Appearance.Options.UseForeColor = true;
            this.glCostCenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCostCenter.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.glCostCenter.Properties.DisplayMember = "ccname";
            this.glCostCenter.Properties.NullText = "Search CostCenter";
            this.glCostCenter.Properties.ValueMember = "cccode";
            this.glCostCenter.Properties.View = this.gridView5;
            this.glCostCenter.Size = new System.Drawing.Size(224, 30);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 2;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsSalesOrder;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // sleCustomers
            // 
            this.sleCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sleCustomers.Location = new System.Drawing.Point(22, 12);
            this.sleCustomers.Name = "sleCustomers";
            this.sleCustomers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleCustomers.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sleCustomers.Properties.Appearance.Options.UseFont = true;
            this.sleCustomers.Properties.Appearance.Options.UseForeColor = true;
            this.sleCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleCustomers.Properties.DataSource = this.spGetCustomersBindingSource;
            this.sleCustomers.Properties.DisplayMember = "CustName";
            this.sleCustomers.Properties.NullText = "Cash Customer";
            this.sleCustomers.Properties.ValueMember = "CustCode";
            this.sleCustomers.Properties.View = this.searchLookUpEdit1View;
            this.sleCustomers.Size = new System.Drawing.Size(224, 30);
            this.sleCustomers.StyleController = this.layoutControl1;
            this.sleCustomers.TabIndex = 0;
            // 
            // spGetCustomersBindingSource
            // 
            this.spGetCustomersBindingSource.DataMember = "spGetCustomers";
            this.spGetCustomersBindingSource.DataSource = this.dsSalesOrder;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // sleCurrency
            // 
            this.sleCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sleCurrency.EditValue = "Search Currency";
            this.sleCurrency.Location = new System.Drawing.Point(22, 114);
            this.sleCurrency.Name = "sleCurrency";
            this.sleCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleCurrency.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sleCurrency.Properties.Appearance.Options.UseFont = true;
            this.sleCurrency.Properties.Appearance.Options.UseForeColor = true;
            this.sleCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleCurrency.Properties.DataSource = this.spgetCurrenciesBindingSource;
            this.sleCurrency.Properties.DisplayMember = "CurrDesc";
            this.sleCurrency.Properties.NullText = "Search CostCenter";
            this.sleCurrency.Properties.ValueMember = "CurrCode";
            this.sleCurrency.Properties.View = this.gridView3;
            this.sleCurrency.Size = new System.Drawing.Size(224, 30);
            this.sleCurrency.StyleController = this.layoutControl1;
            this.sleCurrency.TabIndex = 2;
            // 
            // spgetCurrenciesBindingSource
            // 
            this.spgetCurrenciesBindingSource.DataMember = "spgetCurrencies";
            this.spgetCurrenciesBindingSource.DataSource = this.dsSalesOrder;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // sleWarehouse
            // 
            this.sleWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sleWarehouse.EditValue = "Search Warehouse";
            this.sleWarehouse.Location = new System.Drawing.Point(22, 80);
            this.sleWarehouse.Name = "sleWarehouse";
            this.sleWarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleWarehouse.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sleWarehouse.Properties.Appearance.Options.UseFont = true;
            this.sleWarehouse.Properties.Appearance.Options.UseForeColor = true;
            this.sleWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleWarehouse.Properties.DataSource = this.spGetWarehousesBindingSource;
            this.sleWarehouse.Properties.DisplayMember = "LocationName";
            this.sleWarehouse.Properties.NullText = "Search CostCenter";
            this.sleWarehouse.Properties.ValueMember = "LocationCode";
            this.sleWarehouse.Properties.View = this.gridView4;
            this.sleWarehouse.Size = new System.Drawing.Size(224, 30);
            this.sleWarehouse.StyleController = this.layoutControl1;
            this.sleWarehouse.TabIndex = 2;
            // 
            // spGetWarehousesBindingSource
            // 
            this.spGetWarehousesBindingSource.DataMember = "spGetWarehouses";
            this.spGetWarehousesBindingSource.DataSource = this.dsSalesOrder;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // sleSalesPerson
            // 
            this.sleSalesPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sleSalesPerson.EditValue = "Sales Rep";
            this.sleSalesPerson.Location = new System.Drawing.Point(22, 212);
            this.sleSalesPerson.Name = "sleSalesPerson";
            this.sleSalesPerson.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleSalesPerson.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sleSalesPerson.Properties.Appearance.Options.UseFont = true;
            this.sleSalesPerson.Properties.Appearance.Options.UseForeColor = true;
            this.sleSalesPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleSalesPerson.Properties.DataSource = this.spGetSalesRepsBindingSource;
            this.sleSalesPerson.Properties.DisplayMember = "RepName";
            this.sleSalesPerson.Properties.NullText = "Search CostCenter";
            this.sleSalesPerson.Properties.ValueMember = "RepNo";
            this.sleSalesPerson.Properties.View = this.gridView6;
            this.sleSalesPerson.Size = new System.Drawing.Size(224, 30);
            this.sleSalesPerson.StyleController = this.layoutControl1;
            this.sleSalesPerson.TabIndex = 2;
            // 
            // spGetSalesRepsBindingSource
            // 
            this.spGetSalesRepsBindingSource.DataMember = "spGetSalesReps";
            this.spGetSalesRepsBindingSource.DataSource = this.dsSalesOrder;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(258, 254);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glCostCenter;
            this.layoutControlItem2.Location = new System.Drawing.Point(10, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sleItems;
            this.layoutControlItem3.Location = new System.Drawing.Point(10, 136);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtBarCode;
            this.layoutControlItem6.Location = new System.Drawing.Point(10, 170);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(228, 30);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 234);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sleCurrency;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem4.Location = new System.Drawing.Point(10, 102);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 34);
            this.layoutControlItem4.Text = "layoutControlItem2";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sleCustomers;
            this.layoutControlItem1.Location = new System.Drawing.Point(10, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 34);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sleWarehouse;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem5.Location = new System.Drawing.Point(10, 68);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 34);
            this.layoutControlItem5.Text = "layoutControlItem2";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.sleSalesPerson;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem7.Location = new System.Drawing.Point(10, 200);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(228, 34);
            this.layoutControlItem7.Text = "layoutControlItem2";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // imageSlider1
            // 
            this.imageSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(2, 392);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(260, 137);
            this.imageSlider1.TabIndex = 21;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // spGetCustomersTableAdapter
            // 
            this.spGetCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemsTableAdapter
            // 
            this.spGetItemsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSalesRepsTableAdapter
            // 
            this.spGetSalesRepsTableAdapter.ClearBeforeFill = true;
            // 
            // txtCash
            // 
            this.txtCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCash.EditValue = "0";
            this.txtCash.Location = new System.Drawing.Point(215, 432);
            this.txtCash.Name = "txtCash";
            this.txtCash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtCash.Properties.Appearance.Options.UseFont = true;
            this.txtCash.Properties.Appearance.Options.UseForeColor = true;
            this.txtCash.Size = new System.Drawing.Size(166, 22);
            this.txtCash.TabIndex = 5;
            this.txtCash.EditValueChanged += new System.EventHandler(this.txtCash_EditValueChanged);
            this.txtCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // txtCard
            // 
            this.txtCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCard.EditValue = "0";
            this.txtCard.Location = new System.Drawing.Point(215, 460);
            this.txtCard.Name = "txtCard";
            this.txtCard.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Properties.Appearance.Options.UseFont = true;
            this.txtCard.Size = new System.Drawing.Size(166, 22);
            this.txtCard.TabIndex = 5;
            this.txtCard.EditValueChanged += new System.EventHandler(this.txtCard_EditValueChanged);
            this.txtCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // txtMobileMoney
            // 
            this.txtMobileMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobileMoney.EditValue = "0";
            this.txtMobileMoney.Location = new System.Drawing.Point(499, 427);
            this.txtMobileMoney.Name = "txtMobileMoney";
            this.txtMobileMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileMoney.Properties.Appearance.Options.UseFont = true;
            this.txtMobileMoney.Size = new System.Drawing.Size(147, 22);
            this.txtMobileMoney.TabIndex = 5;
            this.txtMobileMoney.EditValueChanged += new System.EventHandler(this.txtMobileMoney_EditValueChanged);
            this.txtMobileMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // txtRefNo
            // 
            this.txtRefNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefNo.EditValue = "0";
            this.txtRefNo.Location = new System.Drawing.Point(499, 460);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Properties.Appearance.Options.UseFont = true;
            this.txtRefNo.Size = new System.Drawing.Size(147, 22);
            this.txtRefNo.TabIndex = 5;
            this.txtRefNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(118, 436);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Cash";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(118, 465);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Card";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(402, 430);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mobile Money";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(402, 463);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(91, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Reference No(s)";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(58, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(139, 33);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Sales Total:";
            // 
            // lblSalesTotal
            // 
            this.lblSalesTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalesTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTotal.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSalesTotal.Appearance.Options.UseFont = true;
            this.lblSalesTotal.Appearance.Options.UseForeColor = true;
            this.lblSalesTotal.Location = new System.Drawing.Point(203, 11);
            this.lblSalesTotal.Name = "lblSalesTotal";
            this.lblSalesTotal.Size = new System.Drawing.Size(53, 33);
            this.lblSalesTotal.TabIndex = 8;
            this.lblSalesTotal.Text = "0.00";
            this.lblSalesTotal.Click += new System.EventHandler(this.lblSalesTotal_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(388, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 33);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Paid:";
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaid.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblPaid.Appearance.Options.UseFont = true;
            this.lblPaid.Appearance.Options.UseForeColor = true;
            this.lblPaid.Location = new System.Drawing.Point(454, 11);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(53, 33);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "0.00";
            this.lblPaid.Click += new System.EventHandler(this.lblPaid_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(623, 9);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(99, 33);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Change:";
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblChange.Appearance.Options.UseFont = true;
            this.lblChange.Appearance.Options.UseForeColor = true;
            this.lblChange.Location = new System.Drawing.Point(728, 11);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(53, 33);
            this.lblChange.TabIndex = 8;
            this.lblChange.Text = "0.00";
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(118, 395);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(53, 13);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNarration.Location = new System.Drawing.Point(215, 392);
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(647, 32);
            this.txtNarration.TabIndex = 16;
            this.txtNarration.Text = "Sales Order";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.SbQuotation);
            this.panelControl1.Controls.Add(this.sbSave);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.txtNarration);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.lblChange);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.lblPaid);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.lblSalesTotal);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtRefNo);
            this.panelControl1.Controls.Add(this.txtMobileMoney);
            this.panelControl1.Controls.Add(this.txtCard);
            this.panelControl1.Controls.Add(this.txtCash);
            this.panelControl1.Location = new System.Drawing.Point(268, 27);
            this.panelControl1.LookAndFeel.SkinName = "Glass Oceans";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(874, 502);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = global::Master.Properties.Resources.print;
            this.simpleButton1.Location = new System.Drawing.Point(779, 463);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(83, 35);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "DNote";
            // 
            // SbQuotation
            // 
            this.SbQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SbQuotation.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.SbQuotation.Appearance.Options.UseForeColor = true;
            this.SbQuotation.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.SbQuotation.ImageOptions.Image = global::Master.Properties.Resources.WPSave;
            this.SbQuotation.Location = new System.Drawing.Point(779, 421);
            this.SbQuotation.Name = "SbQuotation";
            this.SbQuotation.Size = new System.Drawing.Size(83, 45);
            this.SbQuotation.TabIndex = 19;
            this.SbQuotation.Text = "Quote";
            this.SbQuotation.Click += new System.EventHandler(this.sbQuotation_Click);
            // 
            // sbSave
            // 
            this.sbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbSave.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.sbSave.Appearance.Options.UseFont = true;
            this.sbSave.Appearance.Options.UseForeColor = true;
            this.sbSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.sbSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbSave.ImageOptions.Image")));
            this.sbSave.Location = new System.Drawing.Point(660, 421);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(121, 77);
            this.sbSave.TabIndex = 18;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.salesOrdersBufferBindingSource;
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3,
            gridLevelNode4});
            this.gridControl1.Location = new System.Drawing.Point(5, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(864, 327);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // salesOrdersBufferBindingSource
            // 
            this.salesOrdersBufferBindingSource.DataMember = "SalesOrdersBuffer";
            this.salesOrdersBufferBindingSource.DataSource = this.dsSalesOrder;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemDescription,
            this.colQuantity,
            this.colUOM,
            this.colUnitCost,
            this.colCurrency,
            this.colVAt,
            this.colDiscount,
            this.colTax,
            this.colNetPrice,
            this.colTotalCost,
            this.colNet,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ColumnUnboundExpressionChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.gridView1_ColumnUnboundExpressionChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.RowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.gridView1_RowLoaded);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // colItemCode
            // 
            this.colItemCode.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.spGetItemsBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "ItemCode";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "ItemCode";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.ColumnEdit = this.repositoryItemTextEdit1;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemTextEdit1_EditValueChanged);
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 3;
            // 
            // colUnitCost
            // 
            this.colUnitCost.DisplayFormat.FormatString = "{0:n2}";
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.OptionsColumn.AllowEdit = false;
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 4;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Currency";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 5;
            // 
            // colVAt
            // 
            this.colVAt.Caption = "VAT";
            this.colVAt.DisplayFormat.FormatString = "{0:n2}";
            this.colVAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVAt.FieldName = "VAT";
            this.colVAt.Name = "colVAt";
            this.colVAt.OptionsColumn.AllowEdit = false;
            this.colVAt.UnboundExpression = "[Tax] * ([UnitCost] * [Quantity])";
            this.colVAt.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colVAt.Visible = true;
            this.colVAt.VisibleIndex = 6;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 8;
            // 
            // colTax
            // 
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            // 
            // colNetPrice
            // 
            this.colNetPrice.FieldName = "NetPrice";
            this.colNetPrice.Name = "colNetPrice";
            // 
            // colTotalCost
            // 
            this.colTotalCost.Caption = "TotalCost";
            this.colTotalCost.DisplayFormat.FormatString = "{0:n2}";
            this.colTotalCost.FieldName = "gridColumn1";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.OptionsColumn.AllowEdit = false;
            this.colTotalCost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "SUM={0:0.##}")});
            this.colTotalCost.UnboundExpression = "[UnitCost] * [Quantity]";
            this.colTotalCost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 7;
            // 
            // colNet
            // 
            this.colNet.Caption = "Net Price";
            this.colNet.DisplayFormat.FormatString = "{0:n2}";
            this.colNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNet.FieldName = "NetCost";
            this.colNet.Name = "colNet";
            this.colNet.OptionsColumn.AllowEdit = false;
            this.colNet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetCost", "SUM={0:n2}")});
            this.colNet.UnboundExpression = "[gridColumn1] - [Discount]";
            this.colNet.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNet.Visible = true;
            this.colNet.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Delete";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
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
            // salesOrdersBufferTableAdapter
            // 
            this.salesOrdersBufferTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemCodesBindingSource
            // 
            this.spGetItemCodesBindingSource.DataMember = "spGetItemCodes";
            this.spGetItemCodesBindingSource.DataSource = this.dsSalesOrder;
            // 
            // spGetItemCodesTableAdapter
            // 
            this.spGetItemCodesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemUnitCostBindingSource
            // 
            this.spGetItemUnitCostBindingSource.DataMember = "spGetItemUnitCost";
            this.spGetItemUnitCostBindingSource.DataSource = this.dsSalesOrder;
            // 
            // spGetItemUnitCostTableAdapter
            // 
            this.spGetItemUnitCostTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCurrenciesTableAdapter
            // 
            this.spgetCurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // spGenerateOrderNosBindingSource
            // 
            this.spGenerateOrderNosBindingSource.DataMember = "spGenerateOrderNos";
            this.spGenerateOrderNosBindingSource.DataSource = this.dsSalesOrder;
            // 
            // spGenerateOrderNosTableAdapter
            // 
            this.spGenerateOrderNosTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl3.Controls.Add(this.calendarControl1);
            this.panelControl3.Location = new System.Drawing.Point(2, 289);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(260, 97);
            this.panelControl3.TabIndex = 22;
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(12, 9);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(238, 227);
            this.calendarControl1.TabIndex = 0;
            // 
            // spGetWarehousesTableAdapter
            // 
            this.spGetWarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // spGenerateQNosBindingSource
            // 
            this.spGenerateQNosBindingSource.DataMember = "spGenerateQNos";
            this.spGenerateQNosBindingSource.DataSource = this.dsSalesOrder;
            // 
            // spGenerateQNosTableAdapter
            // 
            this.spGenerateQNosTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 537);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmSalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleSalesPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSalesRepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemUnitCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerateOrderNosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerateQNosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelHeldOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.SearchLookUpEdit sleCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtBarCode;
        private DevExpress.XtraEditors.SearchLookUpEdit sleItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsSalesOrder dsSalesOrder;
        private System.Windows.Forms.BindingSource spGetCustomersBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetCustomersTableAdapter spGetCustomersTableAdapter;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private System.Windows.Forms.BindingSource spGetSalesRepsBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetSalesRepsTableAdapter spGetSalesRepsTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCash;
        private DevExpress.XtraEditors.TextEdit txtCard;
        private DevExpress.XtraEditors.TextEdit txtMobileMoney;
        private DevExpress.XtraEditors.TextEdit txtRefNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblSalesTotal;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblPaid;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblChange;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.RichTextBox txtNarration;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource salesOrdersBufferBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.SalesOrdersBufferTableAdapter salesOrdersBufferTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colNetPrice;
        private System.Windows.Forms.BindingSource spGetItemCodesBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetItemCodesTableAdapter spGetItemCodesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private System.Windows.Forms.BindingSource spGetItemUnitCostBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetItemUnitCostTableAdapter spGetItemUnitCostTableAdapter;
        private System.Windows.Forms.BindingSource spgetCurrenciesBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spgetCurrenciesTableAdapter spgetCurrenciesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colVAt;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource spGenerateOrderNosBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGenerateOrderNosTableAdapter spGenerateOrderNosTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit sleCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraEditors.SearchLookUpEdit sleWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource spGetWarehousesBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit sleSalesPerson;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private Class.DataSet.dsSalesOrderTableAdapters.spGetWarehousesTableAdapter spGetWarehousesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton SbQuotation;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.BindingSource spGenerateQNosBindingSource;
        private Class.DataSet.dsSalesOrderTableAdapters.spGenerateQNosTableAdapter spGenerateQNosTableAdapter;
    }
}