namespace Master.Forms
{
    partial class frmInventoryAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryAdjustment));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.mmoNarration = new DevExpress.XtraEditors.MemoEdit();
            this.glItemCode = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventoryAdjustment = new Master.Class.DataSet.dsInventoryAdjustment();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.inventoryAdjustmentBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdjustmentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAverageCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NewQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAdjustmentQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdjustmentValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.inventoryAdjustmentBufferTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.InventoryAdjustmentBufferTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetWarehousesTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetWarehousesTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetItemsTableAdapter();
            this.spGetItemQtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetItemQtyTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetItemQtyTableAdapter();
            this.spSelectAllInventoryAdjustmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectAllInventoryAdjustmentsTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.spSelectAllInventoryAdjustmentsTableAdapter();
            this.spSelectAllInventoryAdjustmentBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectAllInventoryAdjustmentBufferTableAdapter = new Master.Class.DataSet.dsInventoryAdjustmentTableAdapters.spSelectAllInventoryAdjustmentBufferTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNarration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryAdjustment)).BeginInit();
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
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryAdjustmentBufferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemQtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllInventoryAdjustmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllInventoryAdjustmentBufferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 302);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 41;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(249, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(824, 40);
            this.panelControl1.TabIndex = 40;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(305, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Inventory Adjustment";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.panel3.Location = new System.Drawing.Point(-2, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 214);
            this.panel3.TabIndex = 39;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.mmoNarration);
            this.layoutControl1.Controls.Add(this.glItemCode);
            this.layoutControl1.Controls.Add(this.glWarehouse);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(248, 214);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // mmoNarration
            // 
            this.mmoNarration.Location = new System.Drawing.Point(12, 166);
            this.mmoNarration.Name = "mmoNarration";
            this.mmoNarration.Size = new System.Drawing.Size(224, 36);
            this.mmoNarration.StyleController = this.layoutControl1;
            this.mmoNarration.TabIndex = 4;
            // 
            // glItemCode
            // 
            this.glItemCode.EditValue = "Select Item";
            this.glItemCode.Location = new System.Drawing.Point(12, 120);
            this.glItemCode.Name = "glItemCode";
            this.glItemCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glItemCode.Properties.Appearance.Options.UseFont = true;
            this.glItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glItemCode.Properties.DataSource = this.spGetItemsBindingSource;
            this.glItemCode.Properties.DisplayMember = "ItemDescription";
            this.glItemCode.Properties.ValueMember = "ItemCode";
            this.glItemCode.Properties.View = this.gridLookUpEdit2View;
            this.glItemCode.Size = new System.Drawing.Size(224, 26);
            this.glItemCode.StyleController = this.layoutControl1;
            this.glItemCode.TabIndex = 3;
            this.glItemCode.EditValueChanged += new System.EventHandler(this.glItemCode_EditValueChanged);
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsInventoryAdjustment;
            // 
            // dsInventoryAdjustment
            // 
            this.dsInventoryAdjustment.DataSetName = "dsInventoryAdjustment";
            this.dsInventoryAdjustment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.glWarehouse.Size = new System.Drawing.Size(224, 26);
            this.glWarehouse.StyleController = this.layoutControl1;
            this.glWarehouse.TabIndex = 2;
            // 
            // spGetWarehousesBindingSource
            // 
            this.spGetWarehousesBindingSource.DataMember = "spGetWarehouses";
            this.spGetWarehousesBindingSource.DataSource = this.dsInventoryAdjustment;
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
            this.glCostCenter.Size = new System.Drawing.Size(224, 26);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 0;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsInventoryAdjustment;
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
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 214);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glItemCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem2.Text = "Items";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glCostCenter;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem3.Text = "CostCenter";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.glWarehouse;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem1.Text = "Warehouse";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.mmoNarration;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 56);
            this.layoutControlItem4.Text = "Narration";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
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
            this.toolStrip1.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.ForeColor = System.Drawing.Color.Blue;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "Edit";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.ForeColor = System.Drawing.Color.Blue;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Export";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.ForeColor = System.Drawing.Color.Blue;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(249, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 459);
            this.panel1.TabIndex = 37;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.inventoryAdjustmentBufferBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(824, 459);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // inventoryAdjustmentBufferBindingSource
            // 
            this.inventoryAdjustmentBufferBindingSource.DataMember = "InventoryAdjustmentBuffer";
            this.inventoryAdjustmentBufferBindingSource.DataSource = this.dsInventoryAdjustment;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colWarehouse,
            this.colAdjustmentDate,
            this.colReferenceNo,
            this.colItemNo,
            this.colAverageCost,
            this.colCurrentQuantity,
            this.colNewQuantity,
            this.NewQty,
            this.colAdjustmentQuantity,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colCurrentValue,
            this.colNewValue,
            this.colAdjustmentValue,
            this.colNarration,
            this.colTerminus,
            this.Remove});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.ColumnUnboundExpressionChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.gridView1_ColumnUnboundExpressionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.FocusedRowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.gridView1_FocusedRowLoaded);
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
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            // 
            // colAdjustmentDate
            // 
            this.colAdjustmentDate.FieldName = "AdjustmentDate";
            this.colAdjustmentDate.Name = "colAdjustmentDate";
            this.colAdjustmentDate.Visible = true;
            this.colAdjustmentDate.VisibleIndex = 1;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.FieldName = "ReferenceNo";
            this.colReferenceNo.Name = "colReferenceNo";
            // 
            // colItemNo
            // 
            this.colItemNo.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colItemNo.FieldName = "ItemNo";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = true;
            this.colItemNo.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.spGetItemsBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "ItemDescription";
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
            // colAverageCost
            // 
            this.colAverageCost.FieldName = "AverageCost";
            this.colAverageCost.Name = "colAverageCost";
            this.colAverageCost.Visible = true;
            this.colAverageCost.VisibleIndex = 2;
            // 
            // colCurrentQuantity
            // 
            this.colCurrentQuantity.FieldName = "CurrentQuantity";
            this.colCurrentQuantity.Name = "colCurrentQuantity";
            this.colCurrentQuantity.Visible = true;
            this.colCurrentQuantity.VisibleIndex = 3;
            // 
            // colNewQuantity
            // 
            this.colNewQuantity.FieldName = "NewQuantity";
            this.colNewQuantity.Name = "colNewQuantity";
            this.colNewQuantity.UnboundExpression = "NewQty";
            this.colNewQuantity.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // NewQty
            // 
            this.NewQty.Caption = "New Quantity";
            this.NewQty.ColumnEdit = this.repositoryItemTextEdit1;
            this.NewQty.FieldName = "NewQty";
            this.NewQty.Name = "NewQty";
            this.NewQty.UnboundExpression = "[CurrentQuantity] + [AdjustmentQuantity]";
            this.NewQty.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.NewQty.Visible = true;
            this.NewQty.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemTextEdit1_EditValueChanged);
            // 
            // colAdjustmentQuantity
            // 
            this.colAdjustmentQuantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colAdjustmentQuantity.FieldName = "AdjustmentQuantity";
            this.colAdjustmentQuantity.Name = "colAdjustmentQuantity";
            this.colAdjustmentQuantity.Visible = true;
            this.colAdjustmentQuantity.VisibleIndex = 5;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Current Value";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "([CurrentQuantity]*[AverageCost])";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "New Value";
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundExpression = "([CurrentQuantity] + [AdjustmentQuantity]) * [AverageCost]";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Adjustment Quantity";
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundExpression = "([AverageCost]*[AdjustmentQuantity])";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // colCurrentValue
            // 
            this.colCurrentValue.FieldName = "CurrentValue";
            this.colCurrentValue.Name = "colCurrentValue";
            // 
            // colNewValue
            // 
            this.colNewValue.FieldName = "NewValue";
            this.colNewValue.Name = "colNewValue";
            // 
            // colAdjustmentValue
            // 
            this.colAdjustmentValue.FieldName = "AdjustmentValue";
            this.colAdjustmentValue.Name = "colAdjustmentValue";
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
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
            this.Remove.VisibleIndex = 9;
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
            // inventoryAdjustmentBufferTableAdapter
            // 
            this.inventoryAdjustmentBufferTableAdapter.ClearBeforeFill = true;
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
            // spGetItemQtyBindingSource
            // 
            this.spGetItemQtyBindingSource.DataMember = "spGetItemQty";
            this.spGetItemQtyBindingSource.DataSource = this.dsInventoryAdjustment;
            // 
            // spGetItemQtyTableAdapter
            // 
            this.spGetItemQtyTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllInventoryAdjustmentsBindingSource
            // 
            this.spSelectAllInventoryAdjustmentsBindingSource.DataMember = "spSelectAllInventoryAdjustments";
            this.spSelectAllInventoryAdjustmentsBindingSource.DataSource = this.dsInventoryAdjustment;
            // 
            // spSelectAllInventoryAdjustmentsTableAdapter
            // 
            this.spSelectAllInventoryAdjustmentsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllInventoryAdjustmentBufferBindingSource
            // 
            this.spSelectAllInventoryAdjustmentBufferBindingSource.DataMember = "spSelectAllInventoryAdjustmentBuffer";
            this.spSelectAllInventoryAdjustmentBufferBindingSource.DataSource = this.dsInventoryAdjustment;
            // 
            // spSelectAllInventoryAdjustmentBufferTableAdapter
            // 
            this.spSelectAllInventoryAdjustmentBufferTableAdapter.ClearBeforeFill = true;
            // 
            // frmInventoryAdjustment
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 531);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmInventoryAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Adjustment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventoryAdjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmoNarration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryAdjustment)).EndInit();
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryAdjustmentBufferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemQtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllInventoryAdjustmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllInventoryAdjustmentBufferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private Class.DataSet.dsInventoryAdjustment dsInventoryAdjustment;
        private System.Windows.Forms.BindingSource inventoryAdjustmentBufferBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.InventoryAdjustmentBufferTableAdapter inventoryAdjustmentBufferTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetWarehousesBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetWarehousesTableAdapter spGetWarehousesTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private DevExpress.XtraEditors.MemoEdit mmoNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource spGetItemQtyBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.spGetItemQtyTableAdapter spGetItemQtyTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colAdjustmentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAverageCost;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNewQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAdjustmentQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNewValue;
        private DevExpress.XtraGrid.Columns.GridColumn colAdjustmentValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminus;
        private System.Windows.Forms.BindingSource spSelectAllInventoryAdjustmentsBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.spSelectAllInventoryAdjustmentsTableAdapter spSelectAllInventoryAdjustmentsTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllInventoryAdjustmentBufferBindingSource;
        private Class.DataSet.dsInventoryAdjustmentTableAdapters.spSelectAllInventoryAdjustmentBufferTableAdapter spSelectAllInventoryAdjustmentBufferTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Remove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn NewQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}