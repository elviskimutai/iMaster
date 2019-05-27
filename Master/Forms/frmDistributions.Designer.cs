namespace Master.Forms
{
    partial class frmDistributions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistributions));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalCost = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.distributionOrdersBufferBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDistributionOrders = new Master.Class.DataSet.dsDistributionOrders();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDamages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDriver = new DevExpress.XtraEditors.TextEdit();
            this.txtSalesPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtRoute = new DevExpress.XtraEditors.TextEdit();
            this.txtDirection = new DevExpress.XtraEditors.TextEdit();
            this.txtVehicleNo = new DevExpress.XtraEditors.TextEdit();
            this.glItemCode = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glWarehouse = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetWarehousesTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.spGetWarehousesTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.spGetItemsTableAdapter();
            this.spGetItemCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetItemCodesTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.spGetItemCodesTableAdapter();
            this.distributionOrdersBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distributionOrdersBufferTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.DistributionOrdersBufferTableAdapter();
            this.totalCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalCostTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.TotalCostTableAdapter();
            this.spSelectAllDistributionOrdersBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectAllDistributionOrdersBufferTableAdapter = new Master.Class.DataSet.dsDistributionOrdersTableAdapters.spSelectAllDistributionOrdersBufferTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionOrdersBufferBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDistributionOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDriver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehicleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionOrdersBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllDistributionOrdersBufferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.lblTotalCost);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(256, 24);
            this.panelControl1.LookAndFeel.SkinName = "London Liquid Sky";
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(668, 40);
            this.panelControl1.TabIndex = 35;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(198, 9);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(10, 23);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Location = new System.Drawing.Point(71, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Total Cost:";
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
            this.toolStrip1.Size = new System.Drawing.Size(934, 20);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(78, 17);
            this.saveToolStripButton.Text = "Distribute";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 17);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(54, 17);
            this.copyToolStripButton.Text = "Clear";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(256, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 403);
            this.panel1.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.distributionOrdersBufferBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(668, 403);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // distributionOrdersBufferBindingSource1
            // 
            this.distributionOrdersBufferBindingSource1.DataMember = "DistributionOrdersBuffer";
            this.distributionOrdersBufferBindingSource1.DataSource = this.dsDistributionOrders;
            // 
            // dsDistributionOrders
            // 
            this.dsDistributionOrders.DataSetName = "dsDistributionOrders";
            this.dsDistributionOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderNo,
            this.colDirection,
            this.colCompCode,
            this.colCostCenter,
            this.colVehicleNo,
            this.colRoute,
            this.colSalesPerson,
            this.colDriverDetails,
            this.colItemCode,
            this.colItemDescription,
            this.colQty,
            this.colDamages,
            this.colUOM,
            this.colUnitCost,
            this.colExtendedCost,
            this.colWareHouse,
            this.colOrderStatus,
            this.colUserName,
            this.colNarration,
            this.Cost,
            this.colTerminus,
            this.Remove});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.Name = "colOrderNo";
            // 
            // colDirection
            // 
            this.colDirection.FieldName = "Direction";
            this.colDirection.Name = "colDirection";
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
            // colVehicleNo
            // 
            this.colVehicleNo.FieldName = "VehicleNo";
            this.colVehicleNo.Name = "colVehicleNo";
            // 
            // colRoute
            // 
            this.colRoute.FieldName = "Route";
            this.colRoute.Name = "colRoute";
            // 
            // colSalesPerson
            // 
            this.colSalesPerson.FieldName = "SalesPerson";
            this.colSalesPerson.Name = "colSalesPerson";
            // 
            // colDriverDetails
            // 
            this.colDriverDetails.FieldName = "DriverDetails";
            this.colDriverDetails.Name = "colDriverDetails";
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 1;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 2;
            // 
            // colDamages
            // 
            this.colDamages.FieldName = "Damages";
            this.colDamages.Name = "colDamages";
            this.colDamages.Visible = true;
            this.colDamages.VisibleIndex = 3;
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 4;
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
            // 
            // colWareHouse
            // 
            this.colWareHouse.FieldName = "WareHouse";
            this.colWareHouse.Name = "colWareHouse";
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.FieldName = "OrderStatus";
            this.colOrderStatus.Name = "colOrderStatus";
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            // 
            // Cost
            // 
            this.Cost.Caption = "Cost";
            this.Cost.FieldName = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.UnboundExpression = "[Qty]*[UnitCost]";
            this.Cost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 6;
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
            this.Remove.VisibleIndex = 7;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ContextImage = global::Master.Properties.Resources.delete2;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 447);
            this.panel3.TabIndex = 36;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDriver);
            this.layoutControl1.Controls.Add(this.txtSalesPerson);
            this.layoutControl1.Controls.Add(this.txtRoute);
            this.layoutControl1.Controls.Add(this.txtDirection);
            this.layoutControl1.Controls.Add(this.txtVehicleNo);
            this.layoutControl1.Controls.Add(this.glItemCode);
            this.layoutControl1.Controls.Add(this.glWarehouse);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(244, 443);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(12, 350);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriver.Properties.Appearance.Options.UseFont = true;
            this.txtDriver.Size = new System.Drawing.Size(220, 26);
            this.txtDriver.StyleController = this.layoutControl1;
            this.txtDriver.TabIndex = 11;
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(12, 304);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesPerson.Properties.Appearance.Options.UseFont = true;
            this.txtSalesPerson.Size = new System.Drawing.Size(220, 26);
            this.txtSalesPerson.StyleController = this.layoutControl1;
            this.txtSalesPerson.TabIndex = 10;
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(12, 258);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoute.Properties.Appearance.Options.UseFont = true;
            this.txtRoute.Size = new System.Drawing.Size(220, 26);
            this.txtRoute.StyleController = this.layoutControl1;
            this.txtRoute.TabIndex = 9;
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(12, 212);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirection.Properties.Appearance.Options.UseFont = true;
            this.txtDirection.Size = new System.Drawing.Size(220, 26);
            this.txtDirection.StyleController = this.layoutControl1;
            this.txtDirection.TabIndex = 8;
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(12, 166);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Properties.Appearance.Options.UseFont = true;
            this.txtVehicleNo.Size = new System.Drawing.Size(220, 26);
            this.txtVehicleNo.StyleController = this.layoutControl1;
            this.txtVehicleNo.TabIndex = 7;
            // 
            // glItemCode
            // 
            this.glItemCode.EditValue = "Select Item";
            this.glItemCode.Location = new System.Drawing.Point(12, 120);
            this.glItemCode.Name = "glItemCode";
            this.glItemCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glItemCode.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.glItemCode.Properties.Appearance.Options.UseFont = true;
            this.glItemCode.Properties.Appearance.Options.UseForeColor = true;
            this.glItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glItemCode.Properties.DataSource = this.spGetItemsBindingSource;
            this.glItemCode.Properties.DisplayMember = "ItemDescription";
            this.glItemCode.Properties.ValueMember = "ItemCode";
            this.glItemCode.Properties.View = this.gridLookUpEdit2View;
            this.glItemCode.Size = new System.Drawing.Size(220, 26);
            this.glItemCode.StyleController = this.layoutControl1;
            this.glItemCode.TabIndex = 5;
            this.glItemCode.EditValueChanged += new System.EventHandler(this.glItemCode_EditValueChanged);
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // glWarehouse
            // 
            this.glWarehouse.Location = new System.Drawing.Point(12, 74);
            this.glWarehouse.Name = "glWarehouse";
            this.glWarehouse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glWarehouse.Properties.Appearance.Options.UseFont = true;
            this.glWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glWarehouse.Properties.DataSource = this.spGetWarehousesBindingSource;
            this.glWarehouse.Properties.DisplayMember = "LocationName";
            this.glWarehouse.Properties.ValueMember = "LocationCode";
            this.glWarehouse.Properties.View = this.gridLookUpEdit1View;
            this.glWarehouse.Size = new System.Drawing.Size(220, 26);
            this.glWarehouse.StyleController = this.layoutControl1;
            this.glWarehouse.TabIndex = 4;
            // 
            // spGetWarehousesBindingSource
            // 
            this.spGetWarehousesBindingSource.DataMember = "spGetWarehouses";
            this.spGetWarehousesBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.glCostCenter.Properties.NullText = "";
            this.glCostCenter.Properties.ValueMember = "cccode";
            this.glCostCenter.Properties.View = this.gridLookUpEdit3View;
            this.glCostCenter.Size = new System.Drawing.Size(220, 26);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 6;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(244, 443);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glItemCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem2.Text = "Items";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glCostCenter;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem3.Text = "CostCenter";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.glWarehouse;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem1.Text = "Warehouse";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlItem4.Control = this.txtVehicleNo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem4.Text = "Vehicle No";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDirection;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem5.Text = "Direction";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtRoute;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 230);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem6.Text = "Route";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSalesPerson;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 276);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem7.Text = "Sales Person";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtDriver;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 322);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(224, 101);
            this.layoutControlItem8.Text = "Driver";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(61, 13);
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetWarehousesTableAdapter
            // 
            this.spGetWarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemsTableAdapter
            // 
            this.spGetItemsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemCodesBindingSource
            // 
            this.spGetItemCodesBindingSource.DataMember = "spGetItemCodes";
            this.spGetItemCodesBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // spGetItemCodesTableAdapter
            // 
            this.spGetItemCodesTableAdapter.ClearBeforeFill = true;
            // 
            // distributionOrdersBufferBindingSource
            // 
            this.distributionOrdersBufferBindingSource.DataMember = "DistributionOrdersBuffer";
            this.distributionOrdersBufferBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // distributionOrdersBufferTableAdapter
            // 
            this.distributionOrdersBufferTableAdapter.ClearBeforeFill = true;
            // 
            // totalCostBindingSource
            // 
            this.totalCostBindingSource.DataMember = "TotalCost";
            this.totalCostBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // totalCostTableAdapter
            // 
            this.totalCostTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllDistributionOrdersBufferBindingSource
            // 
            this.spSelectAllDistributionOrdersBufferBindingSource.DataMember = "spSelectAllDistributionOrdersBuffer";
            this.spSelectAllDistributionOrdersBufferBindingSource.DataSource = this.dsDistributionOrders;
            // 
            // spSelectAllDistributionOrdersBufferTableAdapter
            // 
            this.spSelectAllDistributionOrdersBufferTableAdapter.ClearBeforeFill = true;
            // 
            // frmDistributions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDistributions";
            this.Text = "Distributions Orders";
            this.Load += new System.EventHandler(this.frmDistributions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionOrdersBufferBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDistributionOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDriver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehicleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionOrdersBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllDistributionOrdersBufferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalCost;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtDriver;
        private DevExpress.XtraEditors.TextEdit txtSalesPerson;
        private DevExpress.XtraEditors.TextEdit txtRoute;
        private DevExpress.XtraEditors.TextEdit txtDirection;
        private DevExpress.XtraEditors.TextEdit txtVehicleNo;
        private DevExpress.XtraEditors.GridLookUpEdit glItemCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit glWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource spGetWarehousesBindingSource;
        private Class.DataSet.dsDistributionOrders dsDistributionOrders;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsDistributionOrdersTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private Class.DataSet.dsDistributionOrdersTableAdapters.spGetWarehousesTableAdapter spGetWarehousesTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsDistributionOrdersTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemCodesBindingSource;
        private Class.DataSet.dsDistributionOrdersTableAdapters.spGetItemCodesTableAdapter spGetItemCodesTableAdapter;
        private System.Windows.Forms.BindingSource distributionOrdersBufferBindingSource;
        private Class.DataSet.dsDistributionOrdersTableAdapters.DistributionOrdersBufferTableAdapter distributionOrdersBufferTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource distributionOrdersBufferBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDirection;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colDamages;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouse;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminus;
        private System.Windows.Forms.BindingSource totalCostBindingSource;
        private Class.DataSet.dsDistributionOrdersTableAdapters.TotalCostTableAdapter totalCostTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllDistributionOrdersBufferBindingSource;
        private Class.DataSet.dsDistributionOrdersTableAdapters.spSelectAllDistributionOrdersBufferTableAdapter spSelectAllDistributionOrdersBufferTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Remove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
    }
}