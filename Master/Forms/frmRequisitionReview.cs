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

namespace Master.Forms
{
    public partial class frmRequisitionReview : DevExpress.XtraEditors.XtraForm
    {
        public frmRequisitionReview()
        {
            InitializeComponent();
           
        }

        private void frmRequisitionReview_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsRequisitionReview.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsRequisitionReview.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
            }
            catch (Exception)
            {

               
            }
        }

        private void glReqNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spSelectReqForApprovalTableAdapter.Fill(dsRequisitionReview.spSelectReqForApproval, glReqNo.EditValue.ToString(), AppConstant.UserID);
            }
            catch (Exception)
            {

               
            }
        }
        public string validateForm()
        {
            try
            {
                string Remarks = mmoRemarks.Text;
                if (Remarks == null || Remarks == "")
                {
                    return "Enter Remarks to proceed";
                }
               
                for (int i = 0; i <= gridView1.DataRowCount; i++)
                {
                    Decimal OrigQty = Convert.ToDecimal(gridView1.GetRowCellValue(i, colQuantity));
                    Decimal ApprovalQuantity = Convert.ToDecimal(gridView1.GetRowCellValue(i, colApprovalQuantity));
                   
                    if (ApprovalQuantity> OrigQty)
                    {
                        return "Amount should be less than original quantity.";
                    }
                    
                }
                return "Success";
            }
            catch (Exception)
            {

                return "Validation failed. Confirm figures and try again.";
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to approve purchase of this items?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (this.validateForm() == "Success")
                    {
                        if (SaveRequisitionReview())
                    {
                        dsRequisitionReview.spSelectReqForApproval.Clear();
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

        public bool SaveRequisitionReview()
        {
            try
            {
             

                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {

                    string itemCode = gridView1.GetRowCellValue(i, colItemCode).ToString();
                    Double Quantity = Convert.ToDouble(gridView1.GetRowCellValue(i, colApprovalQuantity));
                    spSelectReqForApprovalTableAdapter.spapproveRequisitions(AppConstant.CompCode, glReqNo.EditValue.ToString(), itemCode, AppConstant.UserID, mmoRemarks.Text, Environment.MachineName, Quantity);
                   /// spRequisitionBufferTableAdapter.spSaveRequisition(ReqNo, AppConstant.CompCode, glCostCenter.EditValue.ToString(), glDepartment.EditValue.ToString(), i + 1, itemCode, gridView1.GetRowCellValue(i, colItemDescription).ToString(), Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)), gridView1.GetRowCellValue(i, colUOM).ToString(), Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost).ToString()), Convert.ToDecimal(gridView1.GetRowCellValue(i, colExtendedCost).ToString()), Convert.ToDouble(gridView1.GetRowCellValue(i, colTaxRate).ToString()), Convert.ToDecimal(gridView1.GetRowCellValue(i, colTaxAmount).ToString()), Convert.ToDecimal(gridView1.GetRowCellValue(i, colNetAmount)), mmoRemarks.Text, Environment.MachineName, AppConstant.UserID);


                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetRequsitionNoTableAdapter.Fill(dsRequisitionReview.spGetRequsitionNo, AppConstant.CompCode, glCostCenter.EditValue.ToString(), AppConstant.UserID);
            }
            catch (Exception)
            {

               
            }
        }
    }
}