namespace Master.Forms
{
    partial class frmInvoiceMatching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceMatching));
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalCost = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtDueDate = new DevExpress.XtraEditors.DateEdit();
            this.glCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInvoiceMatching = new Master.Class.DataSet.dsInvoiceMatching();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtInvoice = new DevExpress.XtraEditors.TextEdit();
            this.glOrderNo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectPOReceiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glSupplier = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.oderno = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spGetPurchaseOrderReceiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spGetSuppliersTableAdapter = new Master.Class.DataSet.dsInvoiceMatchingTableAdapters.spGetSuppliersTableAdapter();
            this.currenciesTableAdapter = new Master.Class.DataSet.dsInvoiceMatchingTableAdapters.CurrenciesTableAdapter();
            this.spSelectPOReceiptsTableAdapter = new Master.Class.DataSet.dsInvoiceMatchingTableAdapters.spSelectPOReceiptsTableAdapter();
            this.spGetPurchaseOrderReceiptsTableAdapter = new Master.Class.DataSet.dsInvoiceMatchingTableAdapters.spGetPurchaseOrderReceiptsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoiceMatching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPOReceiptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oderno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPurchaseOrderReceiptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(12, 488);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(227, 40);
            this.imageSlider1.TabIndex = 43;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 314);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 42;
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
            this.panelControl1.Location = new System.Drawing.Point(251, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(735, 40);
            this.panelControl1.TabIndex = 41;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Appearance.Options.UseFont = true;
            this.lblTotalCost.Location = new System.Drawing.Point(201, 9);
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
            this.labelControl1.Size = new System.Drawing.Size(124, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Gross Amount:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 272);
            this.panel3.TabIndex = 40;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtDueDate);
            this.layoutControl1.Controls.Add(this.glCurrency);
            this.layoutControl1.Controls.Add(this.txtInvoice);
            this.layoutControl1.Controls.Add(this.glOrderNo);
            this.layoutControl1.Controls.Add(this.glSupplier);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(244, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtDueDate
            // 
            this.dtDueDate.EditValue = null;
            this.dtDueDate.Location = new System.Drawing.Point(12, 212);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtDueDate.Properties.Appearance.Options.UseFont = true;
            this.dtDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDueDate.Size = new System.Drawing.Size(220, 26);
            this.dtDueDate.StyleController = this.layoutControl1;
            this.dtDueDate.TabIndex = 9;
            // 
            // glCurrency
            // 
            this.glCurrency.EditValue = "Currency";
            this.glCurrency.Location = new System.Drawing.Point(12, 166);
            this.glCurrency.Name = "glCurrency";
            this.glCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.glCurrency.Properties.Appearance.Options.UseFont = true;
            this.glCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCurrency.Properties.DataSource = this.currenciesBindingSource;
            this.glCurrency.Properties.DisplayMember = "CurrDesc";
            this.glCurrency.Properties.ValueMember = "CurrCode";
            this.glCurrency.Properties.View = this.gridLookUpEdit1View;
            this.glCurrency.Size = new System.Drawing.Size(220, 26);
            this.glCurrency.StyleController = this.layoutControl1;
            this.glCurrency.TabIndex = 8;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.dsInvoiceMatching;
            // 
            // dsInvoiceMatching
            // 
            this.dsInvoiceMatching.DataSetName = "dsInvoiceMatching";
            this.dsInvoiceMatching.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(12, 120);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.Properties.Appearance.Options.UseFont = true;
            this.txtInvoice.Size = new System.Drawing.Size(220, 26);
            this.txtInvoice.StyleController = this.layoutControl1;
            this.txtInvoice.TabIndex = 7;
            this.txtInvoice.EditValueChanged += new System.EventHandler(this.txtInvoice_EditValueChanged);
            // 
            // glOrderNo
            // 
            this.glOrderNo.EditValue = "";
            this.glOrderNo.Location = new System.Drawing.Point(12, 74);
            this.glOrderNo.Name = "glOrderNo";
            this.glOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.glOrderNo.Properties.Appearance.Options.UseFont = true;
            this.glOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.glOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glOrderNo.Properties.DataSource = this.spSelectPOReceiptsBindingSource;
            this.glOrderNo.Properties.DisplayMember = "PONo";
            this.glOrderNo.Properties.ValueMember = "PONo";
            this.glOrderNo.Properties.View = this.gridLookUpEdit2View;
            this.glOrderNo.Size = new System.Drawing.Size(220, 26);
            this.glOrderNo.StyleController = this.layoutControl1;
            this.glOrderNo.TabIndex = 5;
            this.glOrderNo.EditValueChanged += new System.EventHandler(this.glOrderNo_EditValueChanged);
            // 
            // spSelectPOReceiptsBindingSource
            // 
            this.spSelectPOReceiptsBindingSource.DataMember = "spSelectPOReceipts";
            this.spSelectPOReceiptsBindingSource.DataSource = this.dsInvoiceMatching;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // glSupplier
            // 
            this.glSupplier.Location = new System.Drawing.Point(12, 28);
            this.glSupplier.Name = "glSupplier";
            this.glSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glSupplier.Properties.Appearance.Options.UseFont = true;
            this.glSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glSupplier.Properties.DataSource = this.spGetSuppliersBindingSource;
            this.glSupplier.Properties.DisplayMember = "Supplier Name";
            this.glSupplier.Properties.NullText = "";
            this.glSupplier.Properties.ValueMember = "Supplier Code";
            this.glSupplier.Properties.View = this.gridLookUpEdit3View;
            this.glSupplier.Size = new System.Drawing.Size(220, 26);
            this.glSupplier.StyleController = this.layoutControl1;
            this.glSupplier.TabIndex = 6;
            this.glSupplier.EditValueChanged += new System.EventHandler(this.glSupplier_EditValueChanged);
            // 
            // spGetSuppliersBindingSource
            // 
            this.spGetSuppliersBindingSource.DataMember = "spGetSuppliers";
            this.spGetSuppliersBindingSource.DataSource = this.dsInvoiceMatching;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.oderno,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(244, 268);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // oderno
            // 
            this.oderno.Control = this.glOrderNo;
            this.oderno.Location = new System.Drawing.Point(0, 46);
            this.oderno.Name = "oderno";
            this.oderno.Size = new System.Drawing.Size(224, 46);
            this.oderno.Text = "Purchase Order";
            this.oderno.TextLocation = DevExpress.Utils.Locations.Top;
            this.oderno.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glSupplier;
            this.layoutControlItem3.CustomizationFormText = "Supplier";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem3.Text = "Supplier";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtInvoice;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem2.Text = "Invoice No";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.glCurrency;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(224, 46);
            this.layoutControlItem1.Text = "Currency";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtDueDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 64);
            this.layoutControlItem4.Text = "Due Date";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.cutToolStripButton,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 20);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 17);
            this.saveToolStripButton.Text = "Save";
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
            this.panel1.Location = new System.Drawing.Point(251, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 447);
            this.panel1.TabIndex = 38;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spGetPurchaseOrderReceiptsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(735, 447);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spGetPurchaseOrderReceiptsBindingSource
            // 
            this.spGetPurchaseOrderReceiptsBindingSource.DataMember = "spGetPurchaseOrderReceipts";
            this.spGetPurchaseOrderReceiptsBindingSource.DataSource = this.dsInvoiceMatching;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemDescription,
            this.colQtyReceived,
            this.colUOM,
            this.colUnitCost,
            this.colCurrency,
            this.colTaxRate,
            this.colTaxAmount,
            this.colDiscountRate,
            this.colDiscountAmount,
            this.colNetAmount,
            this.colExtendedCost,
            this.colOrderDate,
            this.colSuppName,
            this.colGrossAmount,
            this.colOrderBy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colQtyReceived
            // 
            this.colQtyReceived.FieldName = "QtyReceived";
            this.colQtyReceived.Name = "colQtyReceived";
            this.colQtyReceived.Visible = true;
            this.colQtyReceived.VisibleIndex = 2;
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
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 4;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.FieldName = "ExtendedCost";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 10;
            // 
            // colTaxRate
            // 
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 6;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 7;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.FieldName = "DiscountAmount";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.Visible = true;
            this.colDiscountAmount.VisibleIndex = 8;
            // 
            // colNetAmount
            // 
            this.colNetAmount.FieldName = "NetAmount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.Visible = true;
            this.colNetAmount.VisibleIndex = 9;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 5;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // colSuppName
            // 
            this.colSuppName.FieldName = "SuppName";
            this.colSuppName.Name = "colSuppName";
            // 
            // colGrossAmount
            // 
            this.colGrossAmount.FieldName = "GrossAmount";
            this.colGrossAmount.Name = "colGrossAmount";
            // 
            // colOrderBy
            // 
            this.colOrderBy.FieldName = "OrderBy";
            this.colOrderBy.Name = "colOrderBy";
            // 
            // spGetSuppliersTableAdapter
            // 
            this.spGetSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectPOReceiptsTableAdapter
            // 
            this.spSelectPOReceiptsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetPurchaseOrderReceiptsTableAdapter
            // 
            this.spGetPurchaseOrderReceiptsTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoiceMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 536);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmInvoiceMatching";
            this.Text = "Invoice Matching";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoiceMatching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoiceMatching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPOReceiptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oderno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetPurchaseOrderReceiptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalCost;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtInvoice;
        private DevExpress.XtraEditors.GridLookUpEdit glOrderNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit glSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem oderno;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GridLookUpEdit glCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource spGetSuppliersBindingSource;
        private Class.DataSet.dsInvoiceMatching dsInvoiceMatching;
        private Class.DataSet.dsInvoiceMatchingTableAdapters.spGetSuppliersTableAdapter spGetSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private Class.DataSet.dsInvoiceMatchingTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
        private System.Windows.Forms.BindingSource spSelectPOReceiptsBindingSource;
        private Class.DataSet.dsInvoiceMatchingTableAdapters.spSelectPOReceiptsTableAdapter spSelectPOReceiptsTableAdapter;
        private System.Windows.Forms.BindingSource spGetPurchaseOrderReceiptsBindingSource;
        private Class.DataSet.dsInvoiceMatchingTableAdapters.spGetPurchaseOrderReceiptsTableAdapter spGetPurchaseOrderReceiptsTableAdapter;
        private DevExpress.XtraEditors.DateEdit dtDueDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyReceived;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderBy;
    }
}