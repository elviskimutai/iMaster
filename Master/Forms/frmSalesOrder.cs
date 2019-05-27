using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Master.ReportLaunchers;

namespace Master.Forms
{
    public partial class frmSalesOrder : DevExpress.XtraEditors.XtraForm
    {
        decimal Cash = 0;
       
        Security _Security = new Security();
        string SecurityModule = "Sales Orders";
        public frmSalesOrder()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmSalesOrder_Load(object sender, EventArgs e)
        {
            //if (HasConnection())
            //{
                try
                {
                    this.salesOrdersBufferTableAdapter.Fill(this.dsSalesOrder.SalesOrdersBuffer);
                    spGetWarehousesTableAdapter.Fill(dsSalesOrder.spGetWarehouses, AppConstant.CompCode);
                    spgetCurrenciesTableAdapter.Fill(dsSalesOrder.spgetCurrencies, AppConstant.UserID, Environment.MachineName);
                    this.spGetSalesRepsTableAdapter.Fill(this.dsSalesOrder.spGetSalesReps);
                    this.spGetItemsTableAdapter.Fill(this.dsSalesOrder.spGetItems, AppConstant.CompCode);
                    this.spGetCompanyCostCentersTableAdapter.Fill(this.dsSalesOrder.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                    this.spGetCustomersTableAdapter.Fill(this.dsSalesOrder.spGetCustomers, AppConstant.CompCode);
                    sleCurrency.EditValue = spgetCurrenciesTableAdapter.spGetDefaultCurrency(AppConstant.CompCode);// "KES";// dsSalesOrder.spgetCurrencies.DataSet.Tables["spgetCurrencies"].Rows[0]["CurrDesc"].ToString();
                    sleWarehouse.EditValue = dsSalesOrder.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                    ClearFields();
                }
                catch (Exception)
                {


                }
            //}
            //else
            //{
            //    MessageBox.Show("Sorry, please check you network connection and try again.");
            //}
          
           
      
        }
        public static bool HasConnection()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public String LoadOrderNos()
        {
            try
            {
                spGenerateOrderNosTableAdapter.Fill(dsSalesOrder.spGenerateOrderNos, AppConstant.CompCode);
                return dsSalesOrder.spGenerateOrderNos.DataSet.Tables["spGenerateOrderNos"].Rows[0]["OrderNo"].ToString();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public String LoadQuoteNo()
        {
            try
            {
                spGenerateQNosTableAdapter.Fill(dsSalesOrder.spGenerateQNos, AppConstant.CompCode);
              
                return dsSalesOrder.spGenerateQNos.DataSet.Tables["spGenerateQNos"].Rows[0]["Quotation"].ToString();
            }
            catch (Exception)
            {

                return null;
            }
        }
        private void sleItems_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, sleItems.EditValue.ToString());
                GridLoad();
              
               
            }
            catch (Exception)
            {
            }
            finally
            {
                gridView1.RefreshData();
                lblSalesTotal.Text = String.Format("{0:n2}", TotalSales());
            }
        }

        public void GridLoad()
        {
            try
            {
                this.spGetItemUnitCostTableAdapter.Fill(this.dsSalesOrder.spGetItemUnitCost, sleItems.EditValue.ToString(),sleCurrency.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, sleItems.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemDescription, dsSalesOrder.spGetItemUnitCost.DataSet.Tables["spGetItemUnitCost"].Rows[0]["ItemDescription"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuantity, 1);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitCost, dsSalesOrder.spGetItemUnitCost.DataSet.Tables["spGetItemUnitCost"].Rows[0]["UnitPrice"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsSalesOrder.spGetItemUnitCost.DataSet.Tables["spGetItemUnitCost"].Rows[0]["UOM"].ToString());
              //  gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colExtendedCost, dsSalesOrder.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCurrency, sleCurrency.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDiscount, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTax, dsSalesOrder.spGetItemUnitCost.DataSet.Tables["spGetItemUnitCost"].Rows[0]["TaxRate"]);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNetPrice, 0);
                //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNetAmount, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
               // Saverecord();
            }

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            txtCash.Text = "0";
            txtMobileMoney.Text = "0";
            txtCard.Text = "0";
        }

        public decimal TotalSales()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += Convert.ToDecimal(gridView1.GetRowCellValue(i, colNet));
                }
               
                return Total;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            lblSalesTotal.Text =String.Format("{0:n2}", TotalSales());
        }
        private void gridView1_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            lblSalesTotal.Text = String.Format("{0:n2}", TotalSales());
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            lblSalesTotal.Text = String.Format("{0:n2}", TotalSales());
        }
        public bool SalesOrder()
         {
            try
            {
                string orderNo = LoadOrderNos();
                AppConstant.OrderNo = orderNo;
                AppConstant.ReportName = "Receipt";
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    salesOrdersBufferTableAdapter.spSaveSalesOrders(
                       orderNo,
                        AppConstant.CompCode,
                        glCostCenter.EditValue.ToString(),
                        sleCustomers.EditValue.ToString(),
                        i+1,
                      Convert.ToString(gridView1.GetRowCellValue(i, colItemCode)),
                       Convert.ToString(gridView1.GetRowCellValue(i, colItemDescription)),
                       Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                       Convert.ToString(gridView1.GetRowCellValue(i, colUOM)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colTotalCost)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colTotalCost)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colDiscount)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colVAt)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colNet)),
                       "0",
                       sleWarehouse.EditValue.ToString(),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colNet)),
                       Convert.ToDecimal(lblSalesTotal.Text),
                        sleCurrency.EditValue.ToString(),
                        1,
                      sleSalesPerson.EditValue.ToString(),
                        "A",
                        Convert.ToDecimal(lblPaid.Text),
                        Convert.ToDecimal(lblChange.Text),
                        "Sold",
                       txtNarration.Text.ToString(),
                        Environment.MachineName,
                        AppConstant.UserID
                        );
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool SalesQuotation()
        {
            try
            {
                string orderNo = LoadQuoteNo();
                AppConstant.Quotation = orderNo;
               
                
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    salesOrdersBufferTableAdapter.spSaveSalesQuotation(
                       orderNo,
                        AppConstant.CompCode,
                        glCostCenter.EditValue.ToString(),
                        sleCustomers.EditValue.ToString(),
                        i + 1,
                      Convert.ToString(gridView1.GetRowCellValue(i, colItemCode)),
                       Convert.ToString(gridView1.GetRowCellValue(i, colItemDescription)),
                       Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                       Convert.ToString(gridView1.GetRowCellValue(i, colUOM)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colTotalCost)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colTotalCost)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colDiscount)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colVAt)),
                       Convert.ToDecimal(gridView1.GetRowCellValue(i, colNet)),
                       Convert.ToDecimal(lblSalesTotal.Text),
                        sleCurrency.EditValue.ToString(),
                        0,
                      sleSalesPerson.EditValue.ToString(),
                        "Sales quotation",
                        Environment.MachineName,
                        AppConstant.UserID
                        );
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public string validateForm()
        {
            try
            {
                string CostCenter = glCostCenter.EditValue.ToString();
                if (CostCenter == null || CostCenter == "")
                {
                    return "Enter CostCenter to proceed";
                }
                string Customers = sleCustomers.EditValue.ToString();
                if (Customers == null || Customers == "")
                {
                    return "Enter Customers to proceed";
                }
                string Warehouse = sleWarehouse.EditValue.ToString();
                if (Warehouse == null || Warehouse == "")
                {
                    return "Enter Warehouse to proceed";
                }
                if (((GridView)gridControl1.MainView).RowCount==0)
                {
                    return "Add some items in the cart.";
                }
               
                return "Success";
            }
            catch (Exception)
            {

                return "Validation failed. Confirm figures and try again.";
            }
        }
        private void sbSave_Click(object sender, EventArgs e)
        {

            try
            {
                Cash = Convert.ToDecimal(txtCash.Text) + Convert.ToDecimal(txtMobileMoney.Text) + Convert.ToDecimal(txtCard.Text);
                Decimal OrderAmount = Convert.ToDecimal(lblSalesTotal.Text);
                if (OrderAmount > Cash)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to make this sale on credit?", "Confirm!", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        if (this.validateForm() == "Success")
                        {
                            if (this.SalesOrder())
                            {
                                ClearFields();
                                MessageBox.Show("Record saved successfully.");
                            }

                            //rptSalesInvoice report = new rptSalesInvoice();
                            //using (ReportPrintTool printTool = new ReportPrintTool(report))
                            //{
                            //    printTool.Print();
                            //}
                            //}
                        
                        }
                        else
                        {
                            MessageBox.Show(this.validateForm(), "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                   

                }
                else
                {
                    if (this.validateForm() == "Success")
                    {
                        if (this.SalesOrder())
                    {
                            frmCustomerReceit _frmCustomerReceit = new frmCustomerReceit();
                            _frmCustomerReceit.ShowDialog();
                        MessageBox.Show("Record saved successfully");
                            ClearFields();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this.validateForm(), "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
       
        private void sbQuotation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validateForm() == "Success")
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to generate quotation for this items?", "Confirm!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    
                        if (SalesQuotation())
                    {
                            AppConstant.ReportName = "Quotation";
                            frmCustomerReceit _frmCustomerReceit = new frmCustomerReceit();
                            _frmCustomerReceit.ShowDialog();
                            MessageBox.Show("Quotation saved successfully");
                    }
                  
                }
                }
                else
                {
                    MessageBox.Show(this.validateForm(), "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                ClearFields();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sbSave_Click(sender, e);
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txtCash_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cash = Convert.ToDecimal(txtCash.Text) + Convert.ToDecimal(txtMobileMoney.Text) + Convert.ToDecimal(txtCard.Text);
                lblPaid.Text = Convert.ToString(Cash);
            }
            catch (Exception)
            {


            }
            finally
            {
                if (Convert.ToDecimal(lblSalesTotal.Text) < Convert.ToDecimal(lblPaid.Text))
                {
                    lblChange.Text = (Convert.ToDecimal(lblPaid.Text) - Convert.ToDecimal(lblSalesTotal.Text)).ToString();
                }
                else
                {
                    lblChange.Text = "0";
                }
            }
        }

        private void txtCard_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cash = Convert.ToDecimal(txtCash.Text) + Convert.ToDecimal(txtMobileMoney.Text) + Convert.ToDecimal(txtCard.Text);
                lblPaid.Text = Convert.ToString(Cash);
            }
            catch (Exception)
            {


            }
            finally
            {
                if (Convert.ToDecimal(lblSalesTotal.Text) < Convert.ToDecimal(lblPaid.Text))
                {
                    lblChange.Text = (Convert.ToDecimal(lblPaid.Text) - Convert.ToDecimal(lblSalesTotal.Text)).ToString();
                }
                else
                {
                    lblChange.Text = "0";
                }
            }
        }

        private void txtMobileMoney_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cash = Convert.ToDecimal(txtCash.Text) + Convert.ToDecimal(txtMobileMoney.Text) + Convert.ToDecimal(txtCard.Text);
                lblPaid.Text = Convert.ToString(Cash);
            }
            catch (Exception)
            {


            }
            finally
            {
                if (Convert.ToDecimal(lblSalesTotal.Text) < Convert.ToDecimal(lblPaid.Text))
                {
                    lblChange.Text = (Convert.ToDecimal(lblPaid.Text) - Convert.ToDecimal(lblSalesTotal.Text)).ToString();
                }
                else
                {
                    lblChange.Text = "0";
                }
            }
        }

        private void lblSalesTotal_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblSalesTotal.Text)< Convert.ToDecimal(lblPaid.Text))
            {
                lblChange.Text = (Convert.ToDecimal(lblPaid.Text) - Convert.ToDecimal(lblSalesTotal.Text)).ToString();
            }
            else
            {
                lblChange.Text = "0";
            }
        }

        private void lblChange_Click(object sender, EventArgs e)
        {

        }

        private void lblPaid_Click(object sender, EventArgs e)
        {
            
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cash = Convert.ToDecimal(txtCash.Text) + Convert.ToDecimal(txtMobileMoney.Text) + Convert.ToDecimal(txtCard.Text);
                lblPaid.Text = Convert.ToString(Cash);
                txtCash.Text = "0";
                txtMobileMoney.Text = "0";
                txtCard.Text = "0";
                
            }
            catch (Exception)
            {


            }
            finally
            {
                if (Convert.ToDecimal(lblSalesTotal.Text) < Convert.ToDecimal(lblPaid.Text))
                {
                    lblChange.Text = (Convert.ToDecimal(lblPaid.Text) - Convert.ToDecimal(lblSalesTotal.Text)).ToString();
                }
                else
                {
                    lblChange.Text = "0.00";
                }
            }
        }

        public void ClearFields()
        {
            try
            {
                sleCustomers.EditValue = dsSalesOrder.spGetCustomers.DataSet.Tables["spGetCustomers"].Rows[0]["CustCode"].ToString();
                glCostCenter.EditValue = "001";
                sleSalesPerson.EditValue = dsSalesOrder.spGetSalesReps.DataSet.Tables["spGetSalesReps"].Rows[0]["RepNo"].ToString();
                txtCash.Text = "0";
                txtMobileMoney.Text = "0";
                txtCard.Text = "0";
                lblSalesTotal.Text = "0.00";
                
                dsSalesOrder.SalesOrdersBuffer.Clear();
            }
            catch (Exception)
            {

               
            }
        }

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            lblSalesTotal.Text = String.Format("{0:n2}", TotalSales());
        }
    }
}