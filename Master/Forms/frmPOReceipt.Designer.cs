namespace Master.Forms
{
    partial class frmPOReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOReceipt));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalCost = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtContainer = new DevExpress.XtraEditors.TextEdit();
            this.txtDeliveryNote = new DevExpress.XtraEditors.TextEdit();
            this.glOrderNo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetPurchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPOReceipt = new Master.Class.DataSet.dsPOReceipt();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glWarehouse = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.oderno = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spGetPurchaseOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyToReceive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colShipToAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Reject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsPOReceiptTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetWarehousesTableAdapter = new Master.Class.DataSet.dsPOReceiptTableAdapters.spGetWarehousesTableAdapter();
            this.spGetPurchaseOrderTableAdapter = new Master.Class.DataSet.dsPOReceiptTableAdapters.spGetPurchaseOrderTableAdapter();
            this.spGetPurchaseOrderDetailsTableAdapter = new Master.Class.DataSet.dsPOReceiptTableAdapters.spGetPurchaseOrderDetailsTableAdapter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPurchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPOReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oderno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPurchaseOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.lblTotalCost);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(251, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(735, 40);
            this.panelControl1.TabIndex = 35;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Appearance.Options.UseFont = true;
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
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(71, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Total Cost:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 272);
            this.panel3.TabIndex = 34;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtContainer);
            this.layoutControl1.Controls.Add(this.txtDeliveryNote);
            this.layoutControl1.Controls.Add(this.glOrderNo);
            this.layoutControl1.Controls.Add(this.glWarehouse);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(244, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(12, 212);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainer.Properties.Appearance.Options.UseFont = true;
            this.txtContainer.Size = new System.Drawing.Size(220, 26);
            this.txtContainer.StyleController = this.layoutControl1;
            this.txtContainer.TabIndex = 8;
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Location = new System.Drawing.Point(12, 166);
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryNote.Properties.Appearance.Options.UseFont = true;
            this.txtDeliveryNote.Size = new System.Drawing.Size(220, 26);
            this.txtDeliveryNote.StyleController = this.layoutControl1;
            this.txtDeliveryNote.TabIndex = 7;
            // 
            // glOrderNo
            // 
            this.glOrderNo.EditValue = "";
            this.glOrderNo.Location = new System.Drawing.Point(12, 120);
            this.glOrderNo.Name = "glOrderNo";
            this.glOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.glOrderNo.Properties.Appearance.Options.UseFont = true;
            this.glOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.glOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glOrderNo.Properties.DataSource = this.spGetPurchaseOrderBindingSource;
            this.glOrderNo.Properties.DisplayMember = "OrderNo";
            this.glOrderNo.Properties.ValueMember = "OrderNo";
            this.glOrderNo.Properties.View = this.gridLookUpEdit2View;
            this.glOrderNo.Size = new System.Drawing.Size(220, 26);
            this.glOrderNo.StyleController = this.layoutControl1;
            this.glOrderNo.TabIndex = 5;
            this.glOrderNo.EditValueChanged += new System.EventHandler(this.glIOrderNo_EditValueChanged);
            // 
            // spGetPurchaseOrderBindingSource
            // 
            this.spGetPurchaseOrderBindingSource.DataMember = "spGetPurchaseOrder";
            this.spGetPurchaseOrderBindingSource.DataSource = this.dsPOReceipt;
            // 
            // dsPOReceipt
            // 
            this.dsPOReceipt.DataSetName = "dsPOReceipt";
            this.dsPOReceipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.glWarehouse.EditValue = "";
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
            this.glWarehouse.EditValueChanged += new System.EventHandler(this.glWarehouse_EditValueChanged);
            // 
            // spGetWarehousesBindingSource
            // 
            this.spGetWarehousesBindingSource.DataMember = "spGetWarehouses";
            this.spGetWarehousesBindingSource.DataSource = this.dsPOReceipt;
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
            this.glCostCenter.EditValueChanged += new System.EventHandler(this.glCostCenter_EditValueChanged);
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsPOReceipt;
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
            this.oderno,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(244, 268);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // oderno
            // 
            this.oderno.Control = this.glOrderNo;
            this.oderno.Location = new System.Drawing.Point(0, 92);
            this.oderno.Name = "oderno";
            this.oderno.Size = new System.Drawing.Size(224, 46);
            this.oderno.Text = "Order";
            this.oderno.TextLocation = DevExpress.Utils.Locations.Top;
            this.oderno.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glCostCenter;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem3.Text = "CostCenter";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.glWarehouse;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem1.Text = "Warehouse";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDeliveryNote;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem2.Text = "Delivery Note";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtContainer;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 64);
            this.layoutControlItem4.Text = "ContainerNo";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(65, 13);
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
            this.toolStrip1.Size = new System.Drawing.Size(986, 20);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(67, 17);
            this.saveToolStripButton.Text = "Receive";
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
            this.copyToolStripButton.Size = new System.Drawing.Size(59, 17);
            this.copyToolStripButton.Text = "Reject";
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(251, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 447);
            this.panel1.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spGetPurchaseOrderDetailsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(735, 447);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spGetPurchaseOrderDetailsBindingSource
            // 
            this.spGetPurchaseOrderDetailsBindingSource.DataMember = "spGetPurchaseOrderDetails";
            this.spGetPurchaseOrderDetailsBindingSource.DataSource = this.dsPOReceipt;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemDescription,
            this.colQuantity,
            this.colQtyToReceive,
            this.colUOM,
            this.colUnitCost,
            this.colCurrency,
            this.colExtendedCost,
            this.colTaxRate,
            this.colTaxAmount,
            this.colDiscountRate,
            this.colDiscountAmount,
            this.colNetAmount,
            this.colSerialNumber,
            this.colShipToAddress,
            this.colDeliveryPeriod,
            this.colSupplierCode,
            this.colOrderDate,
            this.colOrderBy,
            this.Reject});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ColumnUnboundExpressionChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.gridView1_ColumnUnboundExpressionChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
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
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colQtyToReceive
            // 
            this.colQtyToReceive.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colQtyToReceive.FieldName = "QtyToReceive";
            this.colQtyToReceive.Name = "colQtyToReceive";
            this.colQtyToReceive.ToolTip = "Amount you have received from supplier";
            this.colQtyToReceive.Visible = true;
            this.colQtyToReceive.VisibleIndex = 3;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemSpinEdit1_EditValueChanging);
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
            this.colUnitCost.DisplayFormat.FormatString = "{0:n2}";
            this.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 5;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.Caption = "Cost";
            this.colExtendedCost.FieldName = "ExtendedCost";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.UnboundExpression = "[QtyToReceive] * [UnitCost]";
            this.colExtendedCost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 12;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "TaxRate(%)";
            this.colTaxRate.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 7;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.UnboundExpression = "[QtyToReceive] * [UnitCost] * [TaxRate] / (100 + [TaxRate])";
            this.colTaxAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 8;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.Caption = "DiscountRate(%)";
            this.colDiscountRate.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.Visible = true;
            this.colDiscountRate.VisibleIndex = 9;
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colDiscountAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountAmount.FieldName = "DiscountAmount";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.UnboundExpression = "[DiscountRate] / 100 * ([UnitCost] * [QtyToReceive] - [UnitCost] * [QtyToReceive]" +
    " * [TaxRate] / ([TaxRate] + 100))";
            this.colDiscountAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDiscountAmount.Visible = true;
            this.colDiscountAmount.VisibleIndex = 10;
            // 
            // colNetAmount
            // 
            this.colNetAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colNetAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetAmount.FieldName = "NetAmount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.UnboundExpression = "[ExtendedCost] - ([DiscountAmount] + [TaxAmount])";
            this.colNetAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNetAmount.Visible = true;
            this.colNetAmount.VisibleIndex = 11;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "SerialNo";
            this.colSerialNumber.ColumnEdit = this.repositoryItemTextEdit1;
            this.colSerialNumber.FieldName = "SerialNo";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 13;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colShipToAddress
            // 
            this.colShipToAddress.Caption = "ShipToAddress";
            this.colShipToAddress.FieldName = "ShipToAddress";
            this.colShipToAddress.Name = "colShipToAddress";
            // 
            // colDeliveryPeriod
            // 
            this.colDeliveryPeriod.Caption = "DeliveryPeriod";
            this.colDeliveryPeriod.FieldName = "DeliveryPeriod";
            this.colDeliveryPeriod.Name = "colDeliveryPeriod";
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Caption = "SupplierCode";
            this.colSupplierCode.FieldName = "SupplierCode";
            this.colSupplierCode.Name = "colSupplierCode";
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "OrderDate";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 6;
            // 
            // colOrderBy
            // 
            this.colOrderBy.FieldName = "OrderBy";
            this.colOrderBy.Name = "colOrderBy";
            // 
            // Reject
            // 
            this.Reject.Caption = "Reject";
            this.Reject.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Reject.Name = "Reject";
            this.Reject.Visible = true;
            this.Reject.VisibleIndex = 14;
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
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetWarehousesTableAdapter
            // 
            this.spGetWarehousesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetPurchaseOrderTableAdapter
            // 
            this.spGetPurchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // spGetPurchaseOrderDetailsTableAdapter
            // 
            this.spGetPurchaseOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 306);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 36;
            // 
            // imageSlider1
            // 
            this.imageSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(12, 480);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(227, 40);
            this.imageSlider1.TabIndex = 37;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // frmPOReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 525);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPOReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Receipt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContainer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPurchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPOReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetWarehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oderno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPurchaseOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalCost;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glOrderNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit glWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem oderno;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource spGetWarehousesBindingSource;
        private Class.DataSet.dsPOReceipt dsPOReceipt;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsPOReceiptTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private Class.DataSet.dsPOReceiptTableAdapters.spGetWarehousesTableAdapter spGetWarehousesTableAdapter;
        private System.Windows.Forms.BindingSource spGetPurchaseOrderBindingSource;
        private Class.DataSet.dsPOReceiptTableAdapters.spGetPurchaseOrderTableAdapter spGetPurchaseOrderTableAdapter;
        private System.Windows.Forms.BindingSource spGetPurchaseOrderDetailsBindingSource;
        private Class.DataSet.dsPOReceiptTableAdapters.spGetPurchaseOrderDetailsTableAdapter spGetPurchaseOrderDetailsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyToReceive;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderBy;
        private DevExpress.XtraGrid.Columns.GridColumn Reject;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.TextEdit txtContainer;
        private DevExpress.XtraEditors.TextEdit txtDeliveryNote;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
       // private Class.DataSet.dsPOReceiptTableAdapters.spSavePOReceiptTableAdapter spSavePOReceiptTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colShipToAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierCode;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
    }
}