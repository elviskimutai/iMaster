using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars;
using DevExpress.Utils.Menu;
using Master.Forms;
using Master.ReportLaunchers;
using Master;
using System.Windows.Forms.Layout;
using DevExpress.XtraBars.Helpers;


 public   class Navigator
    {
    Security _Security = new Security();
    public void LoadActions(RibbonControl iBusinessRibbonControl)
    {
        RibbonPage pgActions = new RibbonPage("Actions");
        // Create Page Groups.
        RibbonPageGroup grpActions = new RibbonPageGroup("Actions");
        BarButtonItem close = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(close);
        close.Caption = "Close";
        close.ImageIndex = 16;
        close.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        close.ItemClick += new ItemClickEventHandler(itemClose_ItemClick);

        BarButtonItem logoff = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(logoff);
        logoff.Caption = "Log Off";
        logoff.ImageIndex = 17;
        logoff.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        logoff.ItemClick += new ItemClickEventHandler(itemLoggOff_ItemClick);
        grpActions.ItemLinks.AddRange(new BarItem[] { close, logoff });
        pgActions.Groups.Add(grpActions);
        iBusinessRibbonControl.Pages.Add(pgActions);
        pgActions.Groups.Add(grpActions);
    }
    public void LoadSystemAdministration(NavBarControl MyNavBarControl)
    {
        MyNavBarControl.Dock = DockStyle.Fill;
        // Apply the "SkinExplorerBarView" style.
        MyNavBarControl.PaintStyleName = "SkinExplorerBarView";
        NavBarGroup groupLocal = new NavBarGroup("Administrator");
        NavBarGroup Configuration = new NavBarGroup("Configuration");
        NavBarGroup Reports = new NavBarGroup("Reports");

        NavBarItem CostCenters = new NavBarItem("CostCenters");
        CostCenters.SmallImageIndex = 23;
        // Create a disabled Sent Items item.
        NavBarItem CostCenterAccess = new NavBarItem("CostCenter Access");
        CostCenterAccess.SmallImageIndex = 24;
        NavBarItem SecurityGroups = new NavBarItem("Security Groups");
        SecurityGroups.SmallImageIndex = 25;

        NavBarItem Roles = new NavBarItem("Roles");
        Roles.SmallImageIndex = 26;
        NavBarItem UserRoles = new NavBarItem("User Roles");
        UserRoles.SmallImageIndex = 27;
        NavBarItem Users = new NavBarItem("Users");
        Users.SmallImageIndex = 22;
        NavBarItem UserGroups = new NavBarItem("User Groups");
        UserGroups.SmallImageIndex = 28;
        NavBarItem Countries = new NavBarItem("Countries");
        Countries.SmallImageIndex = 33;
        NavBarItem Counties = new NavBarItem("Counties");
        Counties.SmallImageIndex = 34;
        NavBarItem Companies = new NavBarItem("Companies");
        Companies.SmallImageIndex = 21;
        NavBarItem Approver = new NavBarItem("Approvers");
        Approver.SmallImageIndex = 29;
        NavBarItem Currencies = new NavBarItem("Currencies");
        Currencies.SmallImageIndex = 32;
        NavBarItem UserCodes = new NavBarItem("User Codes");
        UserCodes.SmallImageIndex = 31;
        NavBarItem UserCodeCategories = new NavBarItem("User Code Categories");
        UserCodeCategories.SmallImageIndex = 30;
        NavBarItem departmentacces = new NavBarItem("Department Access");
        departmentacces.SmallImageIndex = 30;
        
        MyNavBarControl.BeginUpdate();
       

        MyNavBarControl.Groups.Add(groupLocal);
        groupLocal.ItemLinks.Add(CostCenters);
        groupLocal.ItemLinks.Add(CostCenterAccess);
        groupLocal.ItemLinks.Add(departmentacces);
        groupLocal.ItemLinks.Add(SecurityGroups);
        groupLocal.ItemLinks.Add(Companies);
        groupLocal.ItemLinks.Add(Users);


        groupLocal.Expanded = true;
        MyNavBarControl.Groups.Add(Configuration);
        Configuration.ItemLinks.Add(Roles);
        Configuration.ItemLinks.Add(UserRoles);
        Configuration.ItemLinks.Add(UserGroups);
        Configuration.ItemLinks.Add(Approver);
        Configuration.ItemLinks.Add(UserCodeCategories);
        Configuration.ItemLinks.Add(UserCodes);
        Configuration.ItemLinks.Add(Currencies);
        Configuration.ItemLinks.Add(Counties);
        Configuration.ItemLinks.Add(Countries);
        Configuration.Expanded = true;
        MyNavBarControl.Groups.Add(Reports);
        Reports.Expanded = true;

        MyNavBarControl.EndUpdate();
    }
    public void LoadAccounts(NavBarControl MyNavBarControl)
    {
        MyNavBarControl.Dock = DockStyle.Fill;
        // Apply the "SkinExplorerBarView" style.
        MyNavBarControl.PaintStyleName = "SkinExplorerBarView";
        NavBarGroup Accounts = new NavBarGroup("Settings");
        NavBarGroup Proceses = new NavBarGroup("Process");
        NavBarItem CashBook = new NavBarItem("Cash Book");
        CashBook.SmallImageIndex = 37;
        NavBarItem Currencies = new NavBarItem("Currencies");
        Currencies.SmallImageIndex = 32;
        NavBarItem ChequeBook = new NavBarItem("Cheque Books");
        ChequeBook.SmallImageIndex = 67;        NavBarItem Ledgers = new NavBarItem("Ledgers");
        Ledgers.SmallImageIndex = 66;
        NavBarItem Banks = new NavBarItem("Banks");
        Banks.SmallImageIndex = 65;
        NavBarItem BankBranches = new NavBarItem("Bank Branches");
        BankBranches.SmallImageIndex = 32;
        NavBarItem BankAccounts = new NavBarItem("Bank Accounts");
        BankAccounts.SmallImageIndex = 20;

        NavBarItem ExchangeRates = new NavBarItem("Exchange Rates");
        ExchangeRates.SmallImageIndex = 17;
        NavBarItem PostingPeriods = new NavBarItem("Posting Periods");
        PostingPeriods.SmallImageIndex = 11;
        NavBarItem COA = new NavBarItem("COA");
        COA.SmallImageIndex = 62;

        //procesess
        NavBarItem SupplierPayments = new NavBarItem("Supplier Payments");
        SupplierPayments.SmallImageIndex =71;
        NavBarItem CustomerPayments = new NavBarItem("Customer Payments");
        CustomerPayments.SmallImageIndex = 20;

        NavBarItem JournalEntry = new NavBarItem("Journal Entry");
        JournalEntry.SmallImageIndex = 68;
        NavBarItem Petty = new NavBarItem("Petty Cash");
        Petty.SmallImageIndex = 69;


        MyNavBarControl.BeginUpdate();

        MyNavBarControl.Groups.Add(Accounts);


        Accounts.ItemLinks.Add(Ledgers);
        Accounts.ItemLinks.Add(CashBook);
        Accounts.ItemLinks.Add(ChequeBook);
        Accounts.ItemLinks.Add(COA);
        Accounts.ItemLinks.Add(PostingPeriods);
        Accounts.ItemLinks.Add(ExchangeRates);
        Accounts.ItemLinks.Add(Banks);
        Accounts.ItemLinks.Add(BankBranches);
        Accounts.ItemLinks.Add(BankAccounts);
        Accounts.ItemLinks.Add(Currencies);
        Accounts.ItemLinks.Add(ExchangeRates);
        Accounts.Expanded = true;

        MyNavBarControl.Groups.Add(Proceses);
        Proceses.ItemLinks.Add(JournalEntry);
        Proceses.ItemLinks.Add(Petty);
        Proceses.ItemLinks.Add(SupplierPayments);
        Proceses.ItemLinks.Add(CustomerPayments);
        Proceses.Expanded = true;


        NavBarGroup Reports = new NavBarGroup("Reports");
        NavBarItem Quoations = new NavBarItem("Quoations");
        Quoations.SmallImageIndex = 46;
        NavBarItem PoReprint = new NavBarItem("Purchase Order Reprint");
        PoReprint.SmallImageIndex = 47;
        NavBarItem SupplierInvoice = new NavBarItem("Supplier Invoice");
        SupplierInvoice.SmallImageIndex = 27;
        NavBarItem SupplierBalance = new NavBarItem("Supplier Balances ");
        SupplierBalance.SmallImageIndex = 70;
        NavBarItem CustomerBalances = new NavBarItem("Customer Balances");
        CustomerBalances.SmallImageIndex = 39;
        NavBarItem CustomerCreditNote = new NavBarItem("Customer Credit Note");
        CustomerCreditNote.SmallImageIndex = 28;

        MyNavBarControl.Groups.Add(Reports);
        Reports.ItemLinks.Add(Quoations);
        Reports.ItemLinks.Add(PoReprint);
        Reports.ItemLinks.Add(SupplierInvoice);
        Reports.ItemLinks.Add(SupplierBalance);
        Reports.ItemLinks.Add(CustomerBalances);
        Reports.ItemLinks.Add(CustomerCreditNote);
        Reports.Expanded = true;

        MyNavBarControl.EndUpdate();
    }

    public void LoadMenus(RibbonControl iBusinessRibbonControl)
        {
        RibbonPageGroup Skins = new RibbonPageGroup();
        RibbonGalleryBarItem rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();

        rgbiSkins.Caption = "Skins";

        rgbiSkins.Gallery.AllowHoverImages = true;
        rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
        rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
        rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        rgbiSkins.Gallery.ColumnCount = 4;
        rgbiSkins.Gallery.FixedHoverImageSize = false;
        rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
        rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
        rgbiSkins.Gallery.RowCount = 4;
        rgbiSkins.Id = 60;
        rgbiSkins.Name = "rgbiSkins";
        iBusinessRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { rgbiSkins });
        Skins.ItemLinks.Add(rgbiSkins);
        Skins.Name = "skinsRibbonPageGroup";
        Skins.ShowCaptionButton = false;
        Skins.Text = "Skins";
        SkinHelper.InitSkinGallery(rgbiSkins, true);

        RibbonPage Inventory = new RibbonPage("Inventory Management");
                            Inventory.Name= "Inventory";
                            iBusinessRibbonControl.Pages.Add(Inventory);

                            RibbonPageGroup grpInventory = new RibbonPageGroup("Quick");   
                            RibbonPageGroup grpInquiries = new RibbonPageGroup("Inquiries");
                            RibbonPageGroup grpShortcut = new RibbonPageGroup("Shortcuts");
                            BarButtonItem OpeningStock = new BarButtonItem();
                            iBusinessRibbonControl.Items.Add(OpeningStock);
                            OpeningStock.Caption = "Opening Stock";
                            OpeningStock.LargeImageIndex = 29;
                            OpeningStock.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                              // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            OpeningStock.ItemClick += new ItemClickEventHandler(OpeningStock_ItemClick);

                            BarButtonItem Receive = new BarButtonItem();
                          
                            Receive.Caption = "Receive Stock";
                            Receive.ImageIndex = 32;
                            Receive.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                            Receive.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            Receive.ItemClick += new ItemClickEventHandler(Receive_ItemClick);
                             iBusinessRibbonControl.Items.Add(Receive);
                            BarButtonItem Inquiry = new BarButtonItem();
                           
                            Inquiry.Caption = "Stock Check";
                            Inquiry.ImageIndex = 33;
                            Inquiry.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                            Inquiry.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            Inquiry.ItemClick += new ItemClickEventHandler(Inquiry_ItemClick);
                            iBusinessRibbonControl.Items.Add(Inquiry);
                            grpInventory.ItemLinks.AddRange(new BarItem[] { OpeningStock , Receive, Inquiry });

                            BarButtonItem NewItem = new BarButtonItem();
                            iBusinessRibbonControl.Items.Add(NewItem);
                            NewItem.Caption = "New Item";
                            NewItem.LargeImageIndex = 28;
                            NewItem.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                          // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            NewItem.ItemClick += new ItemClickEventHandler(NewItem_ItemClick);
                            BarButtonItem UOM = new BarButtonItem();
                            iBusinessRibbonControl.Items.Add(UOM);
                            UOM.Caption = "UOM";
                            UOM.LargeImageIndex = 32;
                            UOM.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                                    // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            UOM.ItemClick += new ItemClickEventHandler(UOM_ItemClick);

                            BarButtonItem Categories = new BarButtonItem();
                            iBusinessRibbonControl.Items.Add(Categories);
                            Categories.Caption = "Item Categories";
                            Categories.LargeImageIndex = 31;
                            Categories.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                                           // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            Categories.ItemClick += new ItemClickEventHandler(Categories_ItemClick);

                            grpShortcut.ItemLinks.AddRange(new BarItem[] { NewItem, UOM, Categories });
                            BarButtonItem Supplier = new BarButtonItem();
                            iBusinessRibbonControl.Items.Add(Supplier);
                            Supplier.Caption = "New Supplier";
                            Supplier.LargeImageIndex = 33;
                            Supplier.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                                         // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
                            Supplier.ItemClick += new ItemClickEventHandler(Supplier_ItemClick);
                            grpInquiries.ItemLinks.AddRange(new BarItem[] { Supplier });
                            Inventory.Groups.Add(grpInventory);
                            Inventory.Groups.Add(grpShortcut);
                            Inventory.Groups.Add(grpInquiries);
                            //end of load menu



        

        RibbonPage Financial = new RibbonPage("Financial Management");
        Financial.Name = "Finance";
        iBusinessRibbonControl.Pages.Add(Financial);
       
        
        RibbonPageGroup grpSettings = new RibbonPageGroup("Quick Setups");
        RibbonPageGroup grpquickreports = new RibbonPageGroup("Quick reports");
      




        BarButtonItem JournalEntry = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(JournalEntry);
        JournalEntry.Caption = "Journal Entry";
        JournalEntry.ImageIndex = 30;
        JournalEntry.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        //User.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        JournalEntry.ItemClick += new ItemClickEventHandler(JournalEntry_ItemClick);

        BarButtonItem PettyCash = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(PettyCash);
        PettyCash.Caption = "Petty Cash";
        PettyCash.ImageIndex = 29;
        PettyCash.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        PettyCash.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        PettyCash.ItemClick += new ItemClickEventHandler(PettyCash_ItemClick);

       
        grpSettings.ItemLinks.AddRange(new BarItem[] { JournalEntry, PettyCash });

        BarButtonItem SupplierBalancesReport = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(SupplierBalancesReport);
        SupplierBalancesReport.Caption = "Supplier Balance";
        SupplierBalancesReport.LargeImageIndex = 28;
        SupplierBalancesReport.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                                   // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        SupplierBalancesReport.ItemClick += new ItemClickEventHandler(SupplierBalancesReport_ItemClick);

        BarButtonItem CustomerBalanceReport = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(CustomerBalanceReport);
        CustomerBalanceReport.Caption = "Customer Balance Report";
        CustomerBalanceReport.LargeImageIndex = 32;
        CustomerBalanceReport.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                                  // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        CustomerBalanceReport.ItemClick += new ItemClickEventHandler(CustomerBalanceReport_ItemClick);


        grpquickreports.ItemLinks.AddRange(new BarItem[] { SupplierBalancesReport, CustomerBalanceReport });

        Financial.Groups.Add(grpSettings);
        Financial.Groups.Add(grpquickreports);
        Financial.Groups.Add(Skins);

        //load system Administration
        RibbonPage Administration = new RibbonPage("System Administration");
        Administration.Name = "Admin";
        iBusinessRibbonControl.Pages.Add(Administration);
        RibbonPageGroup grpAdmin = new RibbonPageGroup("Quick Admin");
        RibbonPageGroup grpRoles = new RibbonPageGroup("Roles");
       


     

        BarButtonItem User = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(User);
        User.Caption = "New System user";
        User.LargeImageIndex = 30;
        User.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        //User.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        User.ItemClick += new ItemClickEventHandler(User_ItemClick);

        BarButtonItem UserGroups = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(UserGroups);
        UserGroups.Caption = "User Groups";
        UserGroups.LargeImageIndex = 29;
        UserGroups.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                       // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        UserGroups.ItemClick += new ItemClickEventHandler(UserGroups_ItemClick);

        BarButtonItem CostcenterAcess = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(CostcenterAcess);
        CostcenterAcess.Caption = "Cost Center Acces";
        CostcenterAcess.ImageIndex = 34; ;
        CostcenterAcess.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        CostcenterAcess.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        CostcenterAcess.ItemClick += new ItemClickEventHandler(CostcenterAcess_ItemClick);
        grpAdmin.ItemLinks.AddRange(new BarItem[] { User, UserGroups, CostcenterAcess });

        BarButtonItem Roles = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(Roles);
        Roles.Caption = "New Role";
        Roles.LargeImageIndex = 28;
        Roles.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                  // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        Roles.ItemClick += new ItemClickEventHandler(Roles_ItemClick);
        BarButtonItem UserRoles = new BarButtonItem();
        iBusinessRibbonControl.Items.Add(UserRoles);
        UserRoles.Caption = "User Roles";
        UserRoles.LargeImageIndex = 32;
        UserRoles.Id = iBusinessRibbonControl.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                      // NewItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        UserRoles.ItemClick += new ItemClickEventHandler(UserRoles_ItemClick);


        grpRoles.ItemLinks.AddRange(new BarItem[] { Roles, UserRoles });
       
        Administration.Groups.Add(grpAdmin);
        Administration.Groups.Add(grpRoles);
        Administration.Groups.Add(Skins);
        //end load system Administration


    }
    private void CustomerBalanceReport_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmCustomerBalanceLauncher _frmCustomerBalanceLauncher = new frmCustomerBalanceLauncher();
        _frmCustomerBalanceLauncher.ShowDialog();
    }
    private void SupplierBalancesReport_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmrptSupplierBalance _frmrptSupplierBalance = new frmrptSupplierBalance();
        _frmrptSupplierBalance.ShowDialog();
    }
    private void Exchagerates_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmExchangeRates _frmExchangeRates = new frmExchangeRates();
        _frmExchangeRates.ShowDialog();
    }
    private void PettyCash_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmPettyCash _frmPettyCash = new frmPettyCash();
        _frmPettyCash.ShowDialog();
    }
    private void UserRoles_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmUserRoles _frmUserRoles = new frmUserRoles();
        _frmUserRoles.ShowDialog();
    }
    private void JournalEntry_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmJournalEntry _frmJournalEntry = new frmJournalEntry();
        _frmJournalEntry.ShowDialog();
    }
    private void UserGroups_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmUserGroups _frmUserGroups = new frmUserGroups();
        _frmUserGroups.ShowDialog();
    }
    private void User_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmUsers _frmUsers = new frmUsers();
        _frmUsers.ShowDialog();
    }
    private void CostcenterAcess_ItemClick(object sender, ItemClickEventArgs e)
    {

        frmCompanyCostCenterAccess _frmCompanyCostCenterAccess = new frmCompanyCostCenterAccess();
        _frmCompanyCostCenterAccess.ShowDialog();
    }
    private void Roles_ItemClick(object sender, ItemClickEventArgs e)
    {
       
        frmRoles _frmRoles = new frmRoles();
        _frmRoles.ShowDialog();
    }
    public void LoadProcurements(NavBarControl MyNavBarControl)
    {
        MyNavBarControl.Dock = DockStyle.Fill;
        // Apply the "SkinExplorerBarView" style.
        MyNavBarControl.PaintStyleName = "SkinExplorerBarView";
        NavBarGroup Procurement = new NavBarGroup("Procurement");

        NavBarItem Requisition = new NavBarItem("Purchase Requisition");
        Requisition.SmallImageIndex = 72;
        NavBarItem RequisitionReview = new NavBarItem("Requisition Approval");
        RequisitionReview.SmallImageIndex = 73;

        NavBarItem SupplierQuotations = new NavBarItem("Supplier Quotations");
        SupplierQuotations.SmallImageIndex = 74;


        NavBarItem DirectInvoices = new NavBarItem("Direct Invoices");
        DirectInvoices.SmallImageIndex = 59;
        NavBarItem SupplierBalances = new NavBarItem("Supplier Balances");
        SupplierBalances.SmallImageIndex = 20;
        NavBarItem AwardPo = new NavBarItem("Quotations Review");
        AwardPo.SmallImageIndex = 20;
        NavBarItem SupplierPo = new NavBarItem("Purchase Order");
        SupplierPo.SmallImageIndex = 5;
        //NavBarItem PurchaseOrders = new NavBarItem("Purchase Orders");
        //PurchaseOrders.SmallImageIndex = 47;
        NavBarItem POReceipts = new NavBarItem("PO Receipts");
        POReceipts.SmallImageIndex = 77;
        NavBarItem InvoiceMatching = new NavBarItem("Invoice Matching");
        InvoiceMatching.SmallImageIndex = 18;
        NavBarItem SupplierPayments = new NavBarItem("Supplier Payments");
        SupplierPayments.SmallImageIndex = 61;
        NavBarItem ReturnOutWards = new NavBarItem("Return OutWards");
        ReturnOutWards.SmallImageIndex = 76;
       

        MyNavBarControl.BeginUpdate();
        
        
        
        MyNavBarControl.Groups.Add(Procurement);
        Procurement.ItemLinks.Add(Requisition);
        Procurement.ItemLinks.Add(RequisitionReview);
        Procurement.ItemLinks.Add(SupplierQuotations); 
        Procurement.ItemLinks.Add(AwardPo);
        Procurement.ItemLinks.Add(SupplierPo);
       // Procurement.ItemLinks.Add(PurchaseOrders);
        Procurement.ItemLinks.Add(POReceipts);
        Procurement.ItemLinks.Add(InvoiceMatching);
        Procurement.ItemLinks.Add(DirectInvoices);
        Procurement.ItemLinks.Add(SupplierBalances);
        Procurement.ItemLinks.Add(SupplierPayments);
        Procurement.ItemLinks.Add(ReturnOutWards);

       
        NavBarGroup Sales = new NavBarGroup("Sales");
        NavBarItem ReturnInwards = new NavBarItem("Return Inwards");
        ReturnInwards.SmallImageIndex = 17;
        NavBarItem CustomerRefunds = new NavBarItem("Customer Refunds");
        CustomerRefunds.SmallImageIndex = 64;
        NavBarItem Payouts = new NavBarItem("Payouts");
        Payouts.SmallImageIndex = 63;
        NavBarItem CashierChekin = new NavBarItem("Cashier Checkin");
        CashierChekin.SmallImageIndex = 37;
        NavBarItem SalesOrder = new NavBarItem("Sales Order");
        SalesOrder.SmallImageIndex = 15;
       

        MyNavBarControl.Groups.Add(Sales);
        Sales.ItemLinks.Add(CashierChekin);
        Sales.ItemLinks.Add(SalesOrder);
        Sales.ItemLinks.Add(ReturnInwards);
        Sales.ItemLinks.Add(CustomerRefunds);
        Sales.ItemLinks.Add(Payouts);
        Sales.Expanded = true;

        Procurement.Expanded = true;
        NavBarGroup Reports = new NavBarGroup("Reports");
        NavBarItem Quoations = new NavBarItem("Quoations");
        Quoations.SmallImageIndex = 46;
        NavBarItem Requisitions = new NavBarItem("Requisitions");
        Requisitions.SmallImageIndex = 46;
        NavBarItem PoReprint = new NavBarItem("PO Reprint");
        PoReprint.SmallImageIndex = 47;
        NavBarItem SupplierInvoice = new NavBarItem("Customer Invoices");
        SupplierInvoice.SmallImageIndex = 27;
        NavBarItem SupplierBalance = new NavBarItem("Supplier Balance");
        SupplierBalance.SmallImageIndex = 39;
        NavBarItem CustomerBalances = new NavBarItem("Customer Balances");
        CustomerBalances.SmallImageIndex = 39;
        NavBarItem CustomerCreditNote = new NavBarItem("Credit Notes");
        CustomerCreditNote.SmallImageIndex = 28;
        NavBarItem SalesSummary = new NavBarItem("Sales Summary");
        SalesSummary.SmallImageIndex = 15;

        MyNavBarControl.Groups.Add(Reports);
        Reports.ItemLinks.Add(Requisitions);
        Reports.ItemLinks.Add(SalesSummary);
        Reports.ItemLinks.Add(Quoations);
        Reports.ItemLinks.Add(PoReprint);
        Reports.ItemLinks.Add(SupplierInvoice);
        Reports.ItemLinks.Add(SupplierBalance);
        Reports.ItemLinks.Add(CustomerBalances);
        Reports.ItemLinks.Add(CustomerCreditNote);
        Reports.Expanded = true;
        MyNavBarControl.EndUpdate();
    }
    public bool ValidateRight(string Right, string UserGroup,string SecurityModule)
    {
        try
        {
            _Security.SecurityModule = SecurityModule;
            _Security.Right = Right;
            _Security.Usergroup = UserGroup;
            return _Security.ValidatePrivilege();
        }
        catch (Exception )
        {
           
            return false;
        }
    }
    public void LoadTopMenus(RibbonControl iMaster)
    {
       

        RibbonPage pgActions = new RibbonPage("HR & Payroll");
        pgActions.Name = "HR & Payroll";
        RibbonPageGroup grpActions = new RibbonPageGroup("HR & Payroll");

        BarButtonItem EmployeeInfo = new BarButtonItem();
        iMaster.Items.Add(EmployeeInfo);
        EmployeeInfo.Caption = "Employees";
        EmployeeInfo.LargeImageIndex = 9;
        EmployeeInfo.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
       // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        EmployeeInfo.ItemClick += new ItemClickEventHandler(EmployeeInfo_ItemClick);

        BarButtonItem rUsers = new BarButtonItem();
        iMaster.Items.Add(rUsers);
        rUsers.Caption = "Users";
        rUsers.ImageIndex = 19;
        rUsers.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        rUsers.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        rUsers.ItemClick += new ItemClickEventHandler(rUsers_ItemClick);

        BarButtonItem rUsersRoles = new BarButtonItem();
        iMaster.Items.Add(rUsersRoles);
        rUsersRoles.Caption = "Users Roles";
        rUsersRoles.ImageIndex = 21;
        rUsersRoles.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
        rUsersRoles.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        rUsersRoles.ItemClick += new ItemClickEventHandler(rUsersRoles_ItemClick);

        BarButtonItem SalaryAdvance = new BarButtonItem();
        iMaster.Items.Add(SalaryAdvance);
        SalaryAdvance.Caption = "Salary Advance";
        SalaryAdvance.LargeImageIndex = 10;
        SalaryAdvance.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
       // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        SalaryAdvance.ItemClick += new ItemClickEventHandler(SalaryAdvance_ItemClick);

        BarButtonItem ProcessPay = new BarButtonItem();
        iMaster.Items.Add(ProcessPay);
        ProcessPay.Caption = "Payroll";
        ProcessPay.LargeImageIndex = 11;
        ProcessPay.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                        // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        ProcessPay.ItemClick += new ItemClickEventHandler(ProcessPay_ItemClick);

        grpActions.ItemLinks.AddRange(new BarItem[] { EmployeeInfo, rUsers, rUsersRoles, SalaryAdvance, ProcessPay });

        RibbonPageGroup Exit = new RibbonPageGroup("Exit");
        BarButtonItem iExit = new BarButtonItem();
        iMaster.Items.Add(iExit);
        iExit.Caption = "Exit";
        iExit.LargeImageIndex = 12;
        iExit.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        iExit.ItemClick += new ItemClickEventHandler(iExit_ItemClick);
        Exit.ItemLinks.AddRange(new BarItem[] { iExit });



        RibbonPageGroup Accounts = new RibbonPageGroup("Accounts");
        BarButtonItem COA = new BarButtonItem();
        iMaster.Items.Add(COA);
        COA.Caption = "COA";
        COA.LargeImageIndex = 13;
        COA.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                 // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        COA.ItemClick += new ItemClickEventHandler(COA_ItemClick);

        BarButtonItem PostingPeriods = new BarButtonItem();
        iMaster.Items.Add(PostingPeriods);
        PostingPeriods.Caption = "Posting Periods";
        PostingPeriods.LargeImageIndex = 14;
        PostingPeriods.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                            // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        PostingPeriods.ItemClick += new ItemClickEventHandler(PostingPeriods_ItemClick);
        Accounts.ItemLinks.AddRange(new BarItem[] { COA, PostingPeriods });


        RibbonPageGroup Reports = new RibbonPageGroup("Reports");
        BarButtonItem NSSFReturns = new BarButtonItem();
        iMaster.Items.Add(NSSFReturns);
        NSSFReturns.Caption = "NSSF Returns";
        NSSFReturns.LargeImageIndex = 18;
        NSSFReturns.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                         // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        NSSFReturns.ItemClick += new ItemClickEventHandler(NSSFReturns_ItemClick);

        BarButtonItem NHIFReturns = new BarButtonItem();
        iMaster.Items.Add(NHIFReturns);
        NHIFReturns.Caption = "NHIF Returns";
        NHIFReturns.LargeImageIndex = 17;
        NHIFReturns.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                         // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        NHIFReturns.ItemClick += new ItemClickEventHandler(NHIFReturns_ItemClick);

        BarButtonItem PAYEMonthly = new BarButtonItem();
        iMaster.Items.Add(PAYEMonthly);
        PAYEMonthly.Caption = "Monthly PAYE";
        PAYEMonthly.LargeImageIndex = 19;
        PAYEMonthly.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
     //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        PAYEMonthly.ItemClick += new ItemClickEventHandler(PAYEMonthly_ItemClick);

        BarButtonItem EmployeesReport = new BarButtonItem();
        iMaster.Items.Add(EmployeesReport);
        EmployeesReport.Caption = "Employees Report";
        EmployeesReport.LargeImageIndex = 15;
        EmployeesReport.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                             //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        EmployeesReport.ItemClick += new ItemClickEventHandler(EmployeesReport_ItemClick);
        BarButtonItem BeneficiariesReport = new BarButtonItem();
        iMaster.Items.Add(BeneficiariesReport);
        BeneficiariesReport.Caption = "Beneficiaries Report";
        BeneficiariesReport.LargeImageIndex = 16;
        BeneficiariesReport.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                 //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        BeneficiariesReport.ItemClick += new ItemClickEventHandler(BeneficiariesReport_ItemClick);
        EmployeesReport.ItemClick += new ItemClickEventHandler(EmployeesReport_ItemClick);
        BarButtonItem OverTimeReport = new BarButtonItem();
        iMaster.Items.Add(OverTimeReport);
        OverTimeReport.Caption = "OverTime Report";
        OverTimeReport.LargeImageIndex = 20;
        OverTimeReport.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                 //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        OverTimeReport.ItemClick += new ItemClickEventHandler(OverTimeReport_ItemClick);

        BarButtonItem CommissionReport = new BarButtonItem();
        iMaster.Items.Add(CommissionReport);
        CommissionReport.Caption = "Commission Report";
        CommissionReport.LargeImageIndex = 21;
        CommissionReport.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                              //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        CommissionReport.ItemClick += new ItemClickEventHandler(CommissionReport_ItemClick);

        BarButtonItem SalaryAdvanceReport = new BarButtonItem();
        iMaster.Items.Add(SalaryAdvanceReport);
        SalaryAdvanceReport.Caption = "Salary Advance Report";
        SalaryAdvanceReport.LargeImageIndex = 22;
        SalaryAdvanceReport.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                                 //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        SalaryAdvanceReport.ItemClick += new ItemClickEventHandler(SalaryAdvanceReport_ItemClick);
        BarButtonItem DBAsReport = new BarButtonItem();
        iMaster.Items.Add(DBAsReport);
        DBAsReport.Caption = "DBA Report";
        DBAsReport.LargeImageIndex = 23;
        DBAsReport.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                        //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        DBAsReport.ItemClick += new ItemClickEventHandler(DBAsReport_ItemClick);

        BarButtonItem LeaveApplication = new BarButtonItem();
        iMaster.Items.Add(LeaveApplication);
        LeaveApplication.Caption = "Leave Applications";
        LeaveApplication.LargeImageIndex = 23;
        LeaveApplication.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                              //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        LeaveApplication.ItemClick += new ItemClickEventHandler(LeaveApplication_ItemClick);



        BarButtonItem rptremitance = new BarButtonItem();
        iMaster.Items.Add(rptremitance);
        rptremitance.Caption = "Remitance Report";
        rptremitance.LargeImageIndex = 25;
        rptremitance.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                          //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        rptremitance.ItemClick += new ItemClickEventHandler(rptremitance_ItemClick);
        BarButtonItem _paylip = new BarButtonItem();
        iMaster.Items.Add(_paylip);
        _paylip.Caption = "Pay Slips";
        _paylip.LargeImageIndex = 26;
        _paylip.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                     //   PAYEMonthly.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
        _paylip.ItemClick += new ItemClickEventHandler(paylip_ItemClick);

        Reports.ItemLinks.AddRange(new BarItem[] { NSSFReturns, NHIFReturns, PAYEMonthly, EmployeesReport, BeneficiariesReport, OverTimeReport, CommissionReport, SalaryAdvanceReport, DBAsReport, rptremitance, _paylip, LeaveApplication });

        RibbonPageGroup Skins = new RibbonPageGroup();
        RibbonGalleryBarItem rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
       
        rgbiSkins.Caption = "Skins";

        rgbiSkins.Gallery.AllowHoverImages = true;
        rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
        rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
        rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        rgbiSkins.Gallery.ColumnCount = 4;
        rgbiSkins.Gallery.FixedHoverImageSize = false;
        rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
        rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
        rgbiSkins.Gallery.RowCount = 4;
        rgbiSkins.Id = 60;
        rgbiSkins.Name = "rgbiSkins";
        iMaster.Items.AddRange(new DevExpress.XtraBars.BarItem[] { rgbiSkins });
         Skins.ItemLinks.Add(rgbiSkins);
        Skins.Name = "skinsRibbonPageGroup";
        Skins.ShowCaptionButton = false;
        Skins.Text = "Skins";
       SkinHelper.InitSkinGallery(rgbiSkins, true);
       
        pgActions.Groups.Add(grpActions);
        pgActions.Groups.Add(Skins);
        pgActions.Groups.Add(Accounts);
        pgActions.Groups.Add(Reports);
        pgActions.Groups.Add(Exit);
        iMaster.Pages.Add(pgActions);
    }


    private void paylip_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "Pay Slips";
        frmPayslip _frmPayslip = new frmPayslip();
        _frmPayslip.ShowDialog();
    }

    private void rptremitance_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "Remitance Report";
        frmNssfreturns _frmNssfreturns = new frmNssfreturns();
        _frmNssfreturns.ShowDialog();
    }
    private void LeaveApplication_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "Leave Applications";
        frmCommisionReport _frmCommisionReport = new frmCommisionReport();
        _frmCommisionReport.ShowDialog();
    }

    private void DBAsReport_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "DBAs Report";
        frmCommisionReport _frmCommisionReport = new frmCommisionReport();
        _frmCommisionReport.ShowDialog();
    }

    private void SalaryAdvanceReport_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "Salary Advance";
        frmCommisionReport _frmCommisionReport = new frmCommisionReport();
        _frmCommisionReport.ShowDialog();
    }

    private void CommissionReport_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "Commission Report";
        frmCommisionReport _frmCommisionReport = new frmCommisionReport();
        _frmCommisionReport.ShowDialog();
    }

    private void OverTimeReport_ItemClick(object sender, ItemClickEventArgs e)
    {
      
        frmOverTimeLauncher _frmOverTimeLauncher = new frmOverTimeLauncher();
        _frmOverTimeLauncher.ShowDialog();
    }

    private void BeneficiariesReport_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmBeneficiariesReport _frmBeneficiariesReport = new frmBeneficiariesReport();
        _frmBeneficiariesReport.ShowDialog();
    }

    private void EmployeesReport_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmEmployeeLauncher _frmEmployeeLauncher = new frmEmployeeLauncher();
        _frmEmployeeLauncher.ShowDialog();
    }

    private void PAYEMonthly_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmPAYELuncher _frmPAYELuncher = new frmPAYELuncher();
        _frmPAYELuncher.ShowDialog();
    }

    private void NHIFReturns_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "NHIF Returns";
        frmNssfreturns _frmNssfreturns = new frmNssfreturns();
        _frmNssfreturns.ShowDialog();
    }

    private void NSSFReturns_ItemClick(object sender, ItemClickEventArgs e)
    {
        AppConstant.ReportName = "NSSF Returns";
        frmNssfreturns _frmNssfreturns = new frmNssfreturns();
        _frmNssfreturns.ShowDialog();
    }

    private void PostingPeriods_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmPostingPeriods _PostingPeriods = new frmPostingPeriods();
        _PostingPeriods.ShowDialog();
    }

    private void COA_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmCOA _frmCOA = new frmCOA();
        _frmCOA.ShowDialog();
    }

    private void SalaryAdvance_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmSalaryAdvance _frmSalaryAdvance = new frmSalaryAdvance();
        _frmSalaryAdvance.ShowDialog();
    }

    private void iExit_ItemClick(object sender, ItemClickEventArgs e)
    {
        Application.Exit();
    }

    private void ProcessPay_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmPayroll _frmPayroll = new frmPayroll();
        _frmPayroll.ShowDialog();
    }

    private void rUsersRoles_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmUserRoles _frmUserRoles = new frmUserRoles();
        _frmUserRoles.ShowDialog();
    }

    private void rUsers_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            frmUsers _frmUsers = new frmUsers();
            _frmUsers.ShowDialog();
        }
        catch (Exception)
        {

            
        }
    }

    private void EmployeeInfo_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            frmEmployeeMaster _frmEmployeeMaster = new frmEmployeeMaster();
            _frmEmployeeMaster.ShowDialog();
        }
        catch (Exception)
        {
            
        }
    }
    private void NaRv_Test(object sender, LayoutEventArgs e)
    {
        
    }
    
   private void Inquiry_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmstockshettinquiry _frmstockshettinquiry = new frmstockshettinquiry();
                _frmstockshettinquiry.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    
        private void NewItem_ItemClick(object sender, ItemClickEventArgs e)
                {
                    try
                    {
                        frmItems _frmItems = new frmItems();
                        _frmItems.ShowDialog();
                    }
                    catch (Exception)
                    {

                    }
                }
    private void UOM_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmUOM _frmUOM = new frmUOM();
                _frmUOM.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    private void Categories_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            frmItemCategories _frmItemCategories = new frmItemCategories();
            _frmItemCategories.ShowDialog();
        }
        catch (Exception)
        {

        }
    }
    private void Supplier_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            Suppliers _Suppliers = new Suppliers();
            _Suppliers.ShowDialog();
        }
        catch (Exception)
        {

        }
    }
    
    private void CashierCheckin_ItemClick(object sender, ItemClickEventArgs e)
            {
                try
                {
                    frmCashierCheckin _frmCashierCheckin = new frmCashierCheckin();
                    _frmCashierCheckin.ShowDialog();
                }
                catch (Exception)
                {

                }
            }
    private void PurchaseOrders_ItemClick(object sender, ItemClickEventArgs e)
         {
            try
            {
                frmPurchaseOrder _frmPurchaseOrder = new frmPurchaseOrder();
                _frmPurchaseOrder.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    private void SalesOrder_ItemClick(object sender, ItemClickEventArgs e)
         {
        try
        {
            frmSalesOrder _frmSalesOrder = new frmSalesOrder();
            _frmSalesOrder.ShowDialog();
        }
        catch (Exception)
        {

        }
    }
    private void Receive_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            frmInventoryReceipt _frmInventoryReceipt = new frmInventoryReceipt();
            _frmInventoryReceipt.ShowDialog();
        }
        catch (Exception)
        {

        }
    }

    private void OpeningStock_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            frmOpeningStock _frmOpeningStock = new frmOpeningStock();
            _frmOpeningStock.ShowDialog();
        }
        catch (Exception)
        {

        }
    }

    private void itemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception )
            {
                //Security secs = new Security();
                //secs.ErrorDesscription = ex.Message;
                //secs.Terminus = Environment.MachineName;
                //secs.ErrorModule = "Select Amount in Customer ReceiptAmount per Cashier";
                //secs.SaveError();
            }
        }
    private void Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                
            }
        }
    private void itemLoggOff_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
              
               
            }
            catch (Exception )
            {
                
            }
        }

   
    public void LoadInventoryManagement(NavBarControl MyNavBarControl)
    {
        //load menus
       
        MyNavBarControl.Dock = DockStyle.Fill;
        // Apply the "SkinExplorerBarView" style.
        MyNavBarControl.PaintStyleName = "SkinExplorerBarView";
        NavBarGroup SetUps = new NavBarGroup("Settings");
        NavBarGroup Inventory = new NavBarGroup("Inventory Management");
        
        NavBarItem DistributionOrders = new NavBarItem("Distribution Orders");
        DistributionOrders.SmallImageIndex = 21;

        NavBarItem InventoryAdjustment = new NavBarItem("Inventory Adjustment");
        InventoryAdjustment.SmallImageIndex = 58;

        NavBarItem InventoryIssues = new NavBarItem("Inventory Issues");
        InventoryIssues.SmallImageIndex = 56;
        // Create an Outbox item.
        NavBarItem InventoryReceipts = new NavBarItem("Inventory Receipts");
        InventoryReceipts.SmallImageIndex = 55;
        // Create a disabled Sent Items item.
        NavBarItem InventoryTransfers = new NavBarItem("Inventory Transfers");
        InventoryTransfers.SmallImageIndex = 57;
        NavBarItem OpeningStock = new NavBarItem("Opening Stock");
        OpeningStock.SmallImageIndex = 20;
      

        MyNavBarControl.Groups.Add(Inventory);
        Inventory.ItemLinks.Add(OpeningStock);
        Inventory.ItemLinks.Add(InventoryReceipts);
        Inventory.ItemLinks.Add(InventoryIssues);
        Inventory.ItemLinks.Add(InventoryTransfers);
        Inventory.ItemLinks.Add(DistributionOrders);
        Inventory.ItemLinks.Add(InventoryAdjustment);
        Inventory.Expanded = true;

        //setups
        
        NavBarItem Categories = new NavBarItem("Categories");
        Categories.SmallImageIndex = 48;
        NavBarItem Suppliers = new NavBarItem("Suppliers");
        Suppliers.SmallImageIndex = 52;
        NavBarItem Customers = new NavBarItem("Customers");
        Customers.SmallImageIndex = 52;
        NavBarItem Items = new NavBarItem("Item Master");
        Items.SmallImageIndex = 46;
        NavBarItem Warehouses = new NavBarItem("Ware houses");
        Warehouses.SmallImageIndex = 53;
        NavBarItem UOM = new NavBarItem("UOM");
        UOM.SmallImageIndex = 49;
        NavBarItem UomConvertions = new NavBarItem("UOM Convertions");
        UomConvertions.SmallImageIndex = 50;
        NavBarItem PriceBands = new NavBarItem("Price Bands");
        PriceBands.SmallImageIndex = 54;
        NavBarItem CostPrice = new NavBarItem("Cost/Price Revision");
        CostPrice.SmallImageIndex = 51;
        MyNavBarControl.BeginUpdate();
        MyNavBarControl.Groups.Add(SetUps);
        SetUps.ItemLinks.Add(Items);
        SetUps.ItemLinks.Add(Categories);
        SetUps.ItemLinks.Add(UOM);
        SetUps.ItemLinks.Add(UomConvertions);
        SetUps.ItemLinks.Add(PriceBands);
        SetUps.ItemLinks.Add(CostPrice);
        SetUps.ItemLinks.Add(Warehouses);
        SetUps.ItemLinks.Add(Suppliers);
        SetUps.ItemLinks.Add(Customers);
        SetUps.Expanded = true;
        NavBarGroup Reports = new NavBarGroup("Reports & Inquiries");
        NavBarItem StockSheetInquiry = new NavBarItem("Stock Sheet Inquiry");
        StockSheetInquiry.SmallImageIndex = 37;
        MyNavBarControl.Groups.Add(Reports);
        Reports.ItemLinks.Add(StockSheetInquiry);
        Reports.Expanded = true;
        MyNavBarControl.EndUpdate();
       // LoadTopMenus(ima);
    }
   
  
    
    public void LoadPOS(NavBarControl MyNavBarControl)
    {


        //  NavBarControl navBar = new NavBarControl();
        //   this.Controls.Add(navBar);
        MyNavBarControl.Dock = DockStyle.Fill;
        // Apply the "SkinExplorerBarView" style.
        MyNavBarControl.PaintStyleName = "SkinExplorerBarView";
        // Assign the list that stores small images to the control.
        //  MyNavBarControl.SmallImages = imageList1;
        // Create a Local group.
        

        NavBarGroup Processes = new NavBarGroup("Work Flow");
       
        NavBarGroup Sales = new NavBarGroup("Sales");
        NavBarItem ReturnInwards = new NavBarItem("Return Inwards");
        ReturnInwards.SmallImageIndex = 17;
        NavBarItem CustomerRefunds = new NavBarItem("Customer Refunds");
        CustomerRefunds.SmallImageIndex = 17;
        NavBarItem Payouts = new NavBarItem("Payouts");
        
        NavBarItem CashierChekin= new NavBarItem("Cashier Checkin");
        CashierChekin.SmallImageIndex = 37;
        
        NavBarItem SalesOrder = new NavBarItem("Sales Order");
        SalesOrder.SmallImageIndex = 15;
        

        MyNavBarControl.BeginUpdate();


       

        MyNavBarControl.Groups.Add(Sales);
        Sales.ItemLinks.Add(CashierChekin);
        Sales.ItemLinks.Add(SalesOrder);
        Sales.ItemLinks.Add(ReturnInwards);
        Sales.ItemLinks.Add(CustomerRefunds);
        Sales.ItemLinks.Add(Payouts);
        Sales.Expanded = true;

        
        MyNavBarControl.EndUpdate();

     

    }

    private void navBar_POS(object sender, NavBarLinkEventArgs e)
    {
     
    }

    public void LoadNavBar(NavBarControl MyNavBar)
    {


        //  NavBarControl navBar = new NavBarControl();
        //   this.Controls.Add(navBar);
        MyNavBar.Dock = DockStyle.Fill;
        // Apply the "SkinExplorerBarView" style.
        MyNavBar.PaintStyleName = "SkinExplorerBarView";
        // Assign the list that stores small images to the control.
        //  MyNavBarControl.SmallImages = imageList1;
        // Create a Local group.
        NavBarGroup Processes = new NavBarGroup("Work Flow");
        NavBarGroup SetUps = new NavBarGroup("Settings");
        NavBarGroup Performance = new NavBarGroup("Performance Management");
        //   NavBarGroup Performance = new NavBarGroup("");
        NavBarGroup groupLocal = new NavBarGroup("Administrator");
        NavBarGroup Configuration = new NavBarGroup("Configuration");

        NavBarGroup Accounts = new NavBarGroup("Accounts");

        // Create an Inbox item and assign an image from the SmallImages list to the item.
        NavBarItem Companies = new NavBarItem("Companies");
        Companies.SmallImageIndex = 21;
        //NavBarItem COA = new NavBarItem("COA");
        //COA.SmallImageIndex = 21;

        NavBarItem PayrollReverse = new NavBarItem("Payroll Reversal");
        PayrollReverse.SmallImageIndex = 43;

        NavBarItem Beneficiaries = new NavBarItem("Beneficiaries");
        Beneficiaries.SmallImageIndex = 45;

        NavBarItem PayrollReview = new NavBarItem("Payroll Review");
        PayrollReview.SmallImageIndex = 21;
        // Create an Outbox item.
        NavBarItem CostCenters = new NavBarItem("CostCenters");
        CostCenters.SmallImageIndex = 23;
        // Create a disabled Sent Items item.
        NavBarItem CostCenterAccess = new NavBarItem("CostCenter Access");
        CostCenterAccess.SmallImageIndex = 24;
        NavBarItem SecurityGroups = new NavBarItem("Security Groups");
        SecurityGroups.SmallImageIndex = 25;
        NavBarItem Banks = new NavBarItem("Banks");
        Banks.SmallImageIndex = 26;
        NavBarItem BankBranches = new NavBarItem("Bank Branches");
        BankBranches.SmallImageIndex = 32;
        NavBarItem Roles = new NavBarItem("Roles");
        Roles.SmallImageIndex = 26;
        NavBarItem UserRoles = new NavBarItem("User Roles");
        UserRoles.SmallImageIndex = 27;
        NavBarItem Users = new NavBarItem("Users");
        Users.SmallImageIndex = 22;
        NavBarItem UserGroups = new NavBarItem("User Groups");
        UserGroups.SmallImageIndex = 28;
        NavBarItem Currencies = new NavBarItem("Currencies");
        Currencies.SmallImageIndex = 32;
        NavBarItem Countries = new NavBarItem("Countries");
        Countries.SmallImageIndex = 33;
        NavBarItem Counties = new NavBarItem("Counties");
        Counties.SmallImageIndex = 34;
        NavBarItem EmployeeInfo = new NavBarItem("Employeee information");
        EmployeeInfo.SmallImageIndex = 19;
        NavBarItem Approver = new NavBarItem("Approvers");
        Approver.SmallImageIndex = 29;
        NavBarItem CommisionEntry = new NavBarItem("Commission Entry");
        CommisionEntry.SmallImageIndex = 15;
        NavBarItem CommissionRates = new NavBarItem("Commission Tax Rates");
        CommissionRates.SmallImageIndex = 18;
        NavBarItem LeaveManagement = new NavBarItem("Leave Management");
        LeaveManagement.SmallImageIndex = 20;
        NavBarItem LeaveTypes = new NavBarItem("Leave Types");
        LeaveTypes.SmallImageIndex = 17;
        NavBarItem NHIFRates = new NavBarItem("NHIF Rates");
        NHIFRates.SmallImageIndex = 8;
        NavBarItem NSSFRates = new NavBarItem("NSSF Rates");
        NSSFRates.SmallImageIndex = 7;
        NavBarItem OverTime = new NavBarItem("Over Time");
        OverTime.SmallImageIndex = 12;
        NavBarItem OverTimeRates = new NavBarItem("Over Time Rates");
        OverTimeRates.SmallImageIndex = 9;
        NavBarItem SalaryAdvance = new NavBarItem("Salary Advance");
        SalaryAdvance.SmallImageIndex = 13;
        NavBarItem TaxRates = new NavBarItem("Tax Rates");
        TaxRates.SmallImageIndex = 10;
        NavBarItem TaxTables = new NavBarItem("Tax Tables");
        TaxTables.SmallImageIndex = 6;
        NavBarItem UserCodes = new NavBarItem("User Codes");
        UserCodes.SmallImageIndex = 31;
        NavBarItem UserCodeCategories = new NavBarItem("User Code Categories");
        UserCodeCategories.SmallImageIndex = 30;
        NavBarItem DBAs = new NavBarItem("Benefits & Deductions");
        DBAs.SmallImageIndex = 16;
        NavBarItem PostingPeriods = new NavBarItem("Posting Periods");
        PostingPeriods.SmallImageIndex = 11;
        NavBarItem PayrollProcessing = new NavBarItem("Payroll Processing");
        PayrollProcessing.SmallImageIndex = 14;
        //Performance
        NavBarItem Absence = new NavBarItem("Absence Registration");
        Absence.SmallImageIndex = 35;
        NavBarItem KPIs = new NavBarItem("KPIs");
        KPIs.SmallImageIndex = 36;
        NavBarItem kpiEntry = new NavBarItem("KPIs Entry");
        kpiEntry.SmallImageIndex = 37;
        NavBarItem JobRequisition = new NavBarItem("Job Requisition");
        JobRequisition.SmallImageIndex = 38;
        NavBarItem JobDescription = new NavBarItem("Job Description");
        JobDescription.SmallImageIndex = 39;
        NavBarItem RecruitmentParameters = new NavBarItem("Recruitment Parameters");
        RecruitmentParameters.SmallImageIndex = 40;
        NavBarItem JobApplications = new NavBarItem("Job Applications");
        JobApplications.SmallImageIndex = 41;
        NavBarItem JobAppraisals = new NavBarItem("Job Appraisals");
        JobAppraisals.SmallImageIndex = 42;
        //   itemSentItems.Enabled = false;
        // Add the created items to the group and the group to the NavBarControl.
        // Prevent excessive updates using the BeginUpdate and EndUpdate methods.

        MyNavBar.BeginUpdate();


        MyNavBar.Groups.Add(SetUps);

        SetUps.ItemLinks.Add(TaxTables);
        SetUps.ItemLinks.Add(NSSFRates);
        SetUps.ItemLinks.Add(NHIFRates);
        SetUps.ItemLinks.Add(OverTimeRates);
        SetUps.ItemLinks.Add(LeaveTypes);
        SetUps.ItemLinks.Add(TaxRates);
        SetUps.ItemLinks.Add(CommissionRates);
        //   SetUps.ItemLinks.Add(PostingPeriods);
        SetUps.Expanded = true;

        MyNavBar.Groups.Add(Processes);
        Processes.ItemLinks.Add(EmployeeInfo);
        Processes.ItemLinks.Add(Beneficiaries);
        Processes.ItemLinks.Add(OverTime);
        Processes.ItemLinks.Add(LeaveManagement);
        Processes.ItemLinks.Add(CommisionEntry);
        Processes.ItemLinks.Add(SalaryAdvance);
        Processes.ItemLinks.Add(DBAs);
        Processes.ItemLinks.Add(PayrollProcessing);
        Processes.ItemLinks.Add(PayrollReview);
        Processes.ItemLinks.Add(PayrollReverse);
        Processes.Expanded = true;
        //Performance management
        MyNavBar.Groups.Add(Performance);
        Performance.ItemLinks.Add(Absence);
        Performance.ItemLinks.Add(KPIs);
        Performance.ItemLinks.Add(kpiEntry);
        Performance.ItemLinks.Add(JobRequisition);
        Performance.ItemLinks.Add(JobDescription);
        Performance.ItemLinks.Add(JobApplications);
        Performance.ItemLinks.Add(RecruitmentParameters);
        Performance.ItemLinks.Add(JobAppraisals);
        Performance.Expanded = true;

        
        MyNavBar.EndUpdate();


        

    }

  public  void navBar_LinkClicked(object sender, NavBarLinkEventArgs e)
    {
        if (this.ValidateRight("View", AppConstant.UserID, e.Link.Caption))
        {
            
            switch (e.Link.Caption)
           {
                case "Quotations Review":
                frmPOaward _frmPOaward = new frmPOaward();
                _frmPOaward.ShowDialog();
            break;
                    
            case "Purchase Order":
                    frmPurchaseOrder _frmPO = new frmPurchaseOrder();
            _frmPO.ShowDialog();
            break;
                //case "Purchase Order":
                //    frmPO _frmPO = new frmPO();
                //    _frmPO.ShowDialog();
                //    break;
                case "Purchase Requisition":
                    frmRequisition _frmRequisition = new frmRequisition();
                    _frmRequisition.ShowDialog();
                    break;
                case "Requisition Approval":
                    frmRequisitionReview _frmRequisitionReview = new frmRequisitionReview();
                    _frmRequisitionReview.ShowDialog();
                    break;
                case "Supplier Quotations":
                    frmSupplierQuotations _frmSupplierQuotations = new frmSupplierQuotations();
                    _frmSupplierQuotations.ShowDialog();
                    break;
                case "Requisitions":
                    requisitionslauncher _requisitionslauncher = new requisitionslauncher();
                    _requisitionslauncher.ShowDialog();
                    break;
                case "Department Access":
                frmDepartmentAccess _frmDepartmentAccess = new frmDepartmentAccess();
                    _frmDepartmentAccess.ShowDialog();
                    break;
                case "Customers":
                    frmCustomers _frmCustomers = new frmCustomers();
                    _frmCustomers.ShowDialog();
            break;
            case "Return OutWards":
                    frmReturnOutwards _frmReturnOutwards = new frmReturnOutwards();
                    _frmReturnOutwards.ShowDialog();
                    break;
                case "Sales Summary":
            frmSalesSummary _frmSalesSummary = new frmSalesSummary();
             _frmSalesSummary.ShowDialog();
            break;
            case "Stock Sheet Inquiry":
             frmstockshettinquiry _frmstockshettinquiry = new frmstockshettinquiry();
            _frmstockshettinquiry.ShowDialog();
            break;
            case "COA":
                    frmCOA _frmCOA = new frmCOA();
            _frmCOA.ShowDialog();
            break;
            case "PO Reprint":
                    frmPoReprint _frmPoReprint = new frmPoReprint();
            _frmPoReprint.ShowDialog();
            break;
             case "Customer Invoices":
                    frmCustomerInvoiceReprint _frmCustomerInvoiceReprint = new frmCustomerInvoiceReprint();
            _frmCustomerInvoiceReprint.ShowDialog();
            break; 
             case "Supplier Balances":
                    frmSupplierBalances _frmSupplierBalances = new frmSupplierBalances();
                    _frmSupplierBalances.ShowDialog();
            break;
                case "Supplier Balance":
                    frmrptSupplierBalance _frmrptSupplierBalance = new frmrptSupplierBalance();
                    _frmrptSupplierBalance.ShowDialog();
                    break;
                case "Customer Balances":
                    frmCustomerBalanceLauncher _frmCustomerBalanceLauncher = new frmCustomerBalanceLauncher();
                    _frmCustomerBalanceLauncher.ShowDialog();
            break;
             case "Credit Notes":
                    frmcustomercreditnoteLauncher _frmcustomercreditnoteLauncher = new frmcustomercreditnoteLauncher();
            _frmcustomercreditnoteLauncher.ShowDialog();
            break;
                case "Customer Refunds":
                    frmCustomerRefund _frmCustomerRefund = new frmCustomerRefund();
                    _frmCustomerRefund.ShowDialog();
                    break;
                case "Payouts":
                    frmPayOuts _frmPayOuts = new frmPayOuts();
                    _frmPayOuts.ShowDialog();
                    break;
                case "Return Inwards":
                    frmReturnInwards _frmReturnInwards = new frmReturnInwards();
                    _frmReturnInwards.ShowDialog();
                    break;
                case "Supplier Payments":
                    frmSupplierPayment _frmSupplierPayment = new frmSupplierPayment();
                    _frmSupplierPayment.ShowDialog();
                    break;
                case "Bank Accounts":
                    frmBankAccounts _frmBankAccounts = new frmBankAccounts();
                    _frmBankAccounts.ShowDialog();
                    break;
                //case "Supplier Balance":
                //    frmSupplierBalances _frmSupplierBalances = new frmSupplierBalances();
                //    _frmSupplierBalances.ShowDialog();
                //    break;
                case "Direct Invoices":
                    frmDirectSupplierInvoice _frmDirectSupplierInvoice = new frmDirectSupplierInvoice();
                    _frmDirectSupplierInvoice.ShowDialog();
                    break;
                case "Invoice Matching":
                    frmInvoiceMatching _frmInvoiceMatching = new frmInvoiceMatching();
                    _frmInvoiceMatching.ShowDialog();
                    break;
                case "Recruitment Parameters":
                    frmHRRecruitmentParam _frmHRRecruitmentParam = new frmHRRecruitmentParam();
                    _frmHRRecruitmentParam.ShowDialog();
                    break;
                case "Job Applications":
                    frmJobApplications _frmJobApplications = new frmJobApplications();
                    _frmJobApplications.ShowDialog();
                    break;
                case "Job Description":
                    frmJobDescription _frmJobDescription = new frmJobDescription();
                    _frmJobDescription.ShowDialog();
                    break;
                case "Job Requisition":
                    frmJobRequisition _frmJobRequisition = new frmJobRequisition();
                    _frmJobRequisition.ShowDialog();
                    break;
                case "Job Appraisals":
                    frmJobAppraisals _frmJobAppraisals = new frmJobAppraisals();
                    _frmJobAppraisals.ShowDialog();
                    break;
                case "Employeee information":
                    frmEmployeeMaster _frmEmployeeMaster = new frmEmployeeMaster();
                    _frmEmployeeMaster.ShowDialog();
                    break;
                case "Distribution Orders":
                    frmDistributionOders _frmDistributionOders = new frmDistributionOders();
                    _frmDistributionOders.ShowDialog();
                    break;
                case "Inventory Adjustment":
                    frmInventoryAdjustment _frmInventoryAdjustment = new frmInventoryAdjustment();
                    _frmInventoryAdjustment.ShowDialog();
                    break;
                case "Inventory Transfers":
                    frmInventoryTransfer _frmInventoryTransfer = new frmInventoryTransfer();
                    _frmInventoryTransfer.ShowDialog();
                    break;
                case "Inventory Issues":
                    frmInventoryIssues _frmInventoryIssues = new frmInventoryIssues();
                    _frmInventoryIssues.ShowDialog();
                    break;
                case "Inventory Receipts":
                    frmInventoryReceipt _frmInventoryReceipt = new frmInventoryReceipt();
                    _frmInventoryReceipt.ShowDialog();
                    break;
                case "Purchase Orders":
                    frmPurchaseOrder _frmPurchaseOrder = new frmPurchaseOrder();
                    _frmPurchaseOrder.ShowDialog();
                    break;
                case "Ware houses":
                    frmWareHouses _frmWareHouses = new frmWareHouses();
                    _frmWareHouses.ShowDialog();
                    break;
                case "Sales Order":
                    frmSalesOrder _frmSalesOrder = new frmSalesOrder();
                    _frmSalesOrder.ShowDialog();
                    break;
                case "PO Receipts":
                    frmPOReceipt _frmPOReceipt = new frmPOReceipt();
                    _frmPOReceipt.ShowDialog();
                    break;
                case "Opening Stock":
                    frmOpeningStock _frmOpeningStock = new frmOpeningStock();
                    _frmOpeningStock.ShowDialog();
                    break;
                case "Exchange Rates":
                    frmExchangeRates _frmExchangeRates = new frmExchangeRates();
                    _frmExchangeRates.ShowDialog();
                    break;

                case "Payroll Review":
                    frmPayrollReview _frmPayrollReview = new frmPayrollReview();
                    _frmPayrollReview.ShowDialog();
                    break;
                case "Bank Branches":
                    frmBankBranches _frmBankBranches = new frmBankBranches();
                    _frmBankBranches.ShowDialog();
                    break;
                case "Banks":
                    frmbanks _frmbanks = new frmbanks();
                    _frmbanks.ShowDialog();
                    break;
                case "Payroll Processing":
                    frmPayroll _frmPayroll = new frmPayroll();
                    _frmPayroll.ShowDialog();
                    break;
                case "Posting Periods":
                    frmPostingPeriods _frmPostingPeriods = new frmPostingPeriods();
                    _frmPostingPeriods.ShowDialog();
                    break;
                case "Tax Rates":
                    frmTaxRates _frmTaxRates = new frmTaxRates();
                    _frmTaxRates.ShowDialog();
                    break;
                case "Benefits & Deductions":
                    frmDBAs _frmDBAs = new frmDBAs();
                    _frmDBAs.ShowDialog();
                    break;
                case "Approvers":
                    frmApprovers _frmApprovers = new frmApprovers();
                    _frmApprovers.ShowDialog();
                    break;
                case "Commission Entry":
                    frmCommisionEntry _frmCommisionEntry = new frmCommisionEntry();
                    _frmCommisionEntry.ShowDialog();
                    break;
                case "Commission Tax Rates":
                    frmCommisionRates _frmCommisionRates = new frmCommisionRates();
                    _frmCommisionRates.ShowDialog();
                    break;
                case "Leave Management":
                    frmLeaveManagent _frmLeaveManagent = new frmLeaveManagent();
                    _frmLeaveManagent.ShowDialog();
                    break;
                case "Leave Types":
                    frmLeaveTypes _frmLeaveTypes = new frmLeaveTypes();
                    _frmLeaveTypes.ShowDialog();
                    break;
                case "NHIF Rates":
                    frmNHIFRates _frmNHIFRates = new frmNHIFRates();
                    _frmNHIFRates.ShowDialog();
                    break;
                case "NSSF Rates":
                    frmNSSFRates _frmNSSFRates = new frmNSSFRates();
                    _frmNSSFRates.ShowDialog();
                    break;
                case "Over Time":
                    frmOverTime _frmOverTime = new frmOverTime();
                    _frmOverTime.ShowDialog();
                    break;
                case "Over Time Rates":
                    frmOverTimeRates _frmOverTimeRates = new frmOverTimeRates();
                    _frmOverTimeRates.ShowDialog();
                    break;
                case "Salary Advance":
                    frmSalaryAdvance _frmSalaryAdvance = new frmSalaryAdvance();
                    _frmSalaryAdvance.ShowDialog();
                    break;
                case "Tax Tables":
                    frmTaxTables _frmTaxTables = new frmTaxTables();
                    _frmTaxTables.ShowDialog();
                    break;
                case "User Codes":
                    frmUserCodes _frmUserCodes = new frmUserCodes();
                    _frmUserCodes.ShowDialog();
                    break;
                case "Companies":
                    frmCompanies _frmCompanies = new frmCompanies();
                    _frmCompanies.ShowDialog();
                    break;
                case "User Code Categories":
                    frmUserCodeCategories _frmUserCodeCategories = new frmUserCodeCategories();
                    _frmUserCodeCategories.ShowDialog();
                    break;
                case "CostCenters":
                    frmCostCenter _frmCostCenter = new frmCostCenter();
                    _frmCostCenter.ShowDialog();
                    break;
                case "CostCenter Access":
                    frmCompanyCostCenterAccess _frmCompanyCostCenterAccess = new frmCompanyCostCenterAccess();
                    _frmCompanyCostCenterAccess.ShowDialog();
                    break;
                case "Security Groups":
                    frmSecurityGroups _frmSecurityGroups = new frmSecurityGroups();
                    _frmSecurityGroups.ShowDialog();
                    break;
                case "Roles":
                    frmRoles _frmRoles = new frmRoles();
                    _frmRoles.ShowDialog();
                    break;
                case "User Roles":
                    frmUserRoles _frmUserRoles = new frmUserRoles();
                    _frmUserRoles.ShowDialog();
                    break;
                case "Users":
                    frmUsers _frmUsers = new frmUsers();
                    _frmUsers.ShowDialog();
                    break;
                case "User Groups":
                    frmUserGroups _frmUserGroups = new frmUserGroups();
                    _frmUserGroups.ShowDialog();
                    break;
                case "Currencies":
                    frmCurrencies _frmCurrencies = new frmCurrencies();
                    _frmCurrencies.ShowDialog();
                    break;

                case "Countries":
                    frmCountry _frmCountry = new frmCountry();
                    _frmCountry.ShowDialog();
                    break;
                case "UOM Convertions":
                    frmUOMConversions _frmUOMConversions = new frmUOMConversions();
                    _frmUOMConversions.ShowDialog();
                    break;
                case "Counties":
                    frmCounties _frmCounties = new frmCounties();
                    _frmCounties.ShowDialog();
                    break;
                case "Beneficiaries":
                    frmBeneficiaries _frmBeneficiaries = new frmBeneficiaries();
                    _frmBeneficiaries.ShowDialog();
                    break;
                case "Payroll Reversal":
                    frmPayrollReverse _frmPayrollReverse = new frmPayrollReverse();
                    _frmPayrollReverse.ShowDialog();
                    break;
                case "KPIs":
                    frmKPIs _frmKPIs = new frmKPIs();
                    _frmKPIs.ShowDialog();
                    break;
                case "KPIs Entry":
                    frmKPIEntry _frmKPIEntry = new frmKPIEntry();
                    _frmKPIEntry.ShowDialog();
                    break;
                case "Absence Registration":
                    frmAbsenceRegistration _frmAbsenceRegistration = new frmAbsenceRegistration();
                    _frmAbsenceRegistration.ShowDialog();
                    break;
                case "UOM":
                    frmUOM _frmUOM = new frmUOM();
                    _frmUOM.ShowDialog();
                    break;
                case "Categories":
                    frmItemCategories _frmItemCategories = new frmItemCategories();
                    _frmItemCategories.ShowDialog();
                    break;
                case "Suppliers":
                    Suppliers _Suppliers = new Suppliers();
                    _Suppliers.ShowDialog();
                    break;

                case "Journal Entry":
                    frmJournalEntry _frmJournalEntry = new frmJournalEntry();
                    _frmJournalEntry.ShowDialog();
                    break;
                case "Ledgers":
                    frmLedger1 _frmLedger1 = new frmLedger1();
                    _frmLedger1.ShowDialog();
                    break;
                case "Item Master":
                    frmItems _frmItems = new frmItems();
                    _frmItems.ShowDialog();
                    break;
                case "Petty Cash":
                    frmPettyCash _frmPettyCash = new frmPettyCash();
                    _frmPettyCash.ShowDialog();
                    break;
                case "Cheque Books":
                    frmChequeBooks _frmChequeBooks = new frmChequeBooks();
                    _frmChequeBooks.ShowDialog();
                    break;
                case "Cashier Checkin":
                    frmCashierCheckin _frmCashierCheckin = new frmCashierCheckin();
                    _frmCashierCheckin.ShowDialog();
                    break;
                case "Price Bands":
                    frmPriceBands _frmPriceBands = new frmPriceBands();
                    _frmPriceBands.ShowDialog();
                    break;
                case "Cost/Price Revision":
                    frmCostPriceRevisions _frmCostPriceRevisions = new frmCostPriceRevisions();
                    _frmCostPriceRevisions.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        else
        {
            e.Link.Item.Dispose();
            MessageBox.Show("You have insufficient rights to access this page", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }

}


