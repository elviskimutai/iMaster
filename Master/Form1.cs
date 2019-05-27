using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraNavBar;

namespace Master
{
    public partial class Form1 : RibbonForm
    {
        Navigator _Navigator = new Navigator();

        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            switchToMonthViewItem1.BindableChecked = true;


        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
     
      

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAppointment.TaskDependencies' table. You can move, or remove it, as needed.
            this.taskDependenciesTableAdapter.Fill(this.dsAppointment.TaskDependencies);
            // TODO: This line of code loads data into the 'dsAppointment.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.dsAppointment.Resources);
            // TODO: This line of code loads data into the 'dsAppointment.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.dsAppointment.Appointments);
            _Navigator.LoadProcurements(this.navBarControl);
            // _Navigator.LoadNavBar(this.navBarControl);
            _Navigator.LoadMenus(this.ribbonControl);
            _Navigator.LoadTopMenus(this.ribbonControl);
            _Navigator.LoadActions(this.ribbonControl);
            navBarControl.LinkClicked += new NavBarLinkEventHandler(_Navigator.navBar_LinkClicked);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
            
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (ribbonControl.SelectedPage.Name == "HR & Payroll")
                {
                    // this.navBarControl.ResetStyles();
                    this.navBarControl.Groups.Clear();                    
                  _Navigator.LoadNavBar(this.navBarControl);             

                }
                if (ribbonControl.SelectedPage.Name == "Sales")
                {
                    // this.navBarControl.ResetStyles();
                    this.navBarControl.Groups.Clear();
                    _Navigator.LoadPOS(this.navBarControl);
                 //   _Navigator.LoadNavBar(this.navBarControl);

                }
                if (ribbonControl.SelectedPage.Name == "Admin")
                {
                    // this.navBarControl.ResetStyles();
                    this.navBarControl.Groups.Clear();
                    _Navigator.LoadSystemAdministration(this.navBarControl);
                    
                }
                if (ribbonControl.SelectedPage.Name == "Inventory")
                {
                    // this.navBarControl.ResetStyles();
                   
                    this.navBarControl.Groups.Clear();
                    _Navigator.LoadInventoryManagement(this.navBarControl);
                    
                }
                if (ribbonControl.SelectedPage.Name == "Finance")
                {
                    // this.navBarControl.ResetStyles();
                    this.navBarControl.Groups.Clear();
                    _Navigator.LoadAccounts(this.navBarControl);

                }
                if (ribbonControl.SelectedPage.Name == "homeRibbonPage1")
                {
                    // this.navBarControl.ResetStyles();
                    this.navBarControl.Groups.Clear();
                    _Navigator.LoadProcurements(this.navBarControl);

                }

            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}