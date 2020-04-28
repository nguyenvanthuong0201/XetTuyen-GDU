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
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace XetTuyen_GDU.View
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();
            setVisibleTuyenSinh(false);
            setVisibleDaoTao(false);
            setVisibleKeToan(false);
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
            if(navigationFrame.SelectedPageIndex == 0)
            {
                setVisibleAdmin(true);
                setVisibleTuyenSinh(false);
                setVisibleDaoTao(false);
                setVisibleKeToan(false);
            }
            else if (navigationFrame.SelectedPageIndex == 1)
            {  
                setVisibleTuyenSinh(true);
                setVisibleDaoTao(false);
                setVisibleKeToan(false);
                setVisibleAdmin(false);
            }
            else if (navigationFrame.SelectedPageIndex == 2)
            {
                setVisibleAdmin(false);
                setVisibleTuyenSinh(false);
                setVisibleDaoTao(true);
                setVisibleKeToan(false);
                
            }
            else if (navigationFrame.SelectedPageIndex == 3)
            {
                setVisibleAdmin(false);
                setVisibleTuyenSinh(false);
                setVisibleDaoTao(false);
                setVisibleKeToan(true);
            }
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }
        public void setVisibleAdmin(bool status)
        {
            AdminAbout.Visible = status;
            AdminHome.Visible = status;
            AdminManage.Visible = status;
        }
        public void setVisibleTuyenSinh(bool status)
        {
            PageCategoryPhongTuyenSinh.Visible = status;
        }
        public void setVisibleDaoTao(bool status)
        {
            PageCategoryPhongKeToan.Visible = status;
        }
        public void setVisibleKeToan(bool status)
        {
            PageCategoryPhongDaoTao.Visible = status;
        }


        private void btnXuatFileExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportExcel("");
        }

        private bool ExportExcel(string filename)
        {
            try
            {
                if (gridViewKeToan.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = filename;
                    dialog.Filter = @"Microsoft Excel|.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gridViewKeToan.ColumnPanelRowHeight = 40;
                        gridViewKeToan.OptionsPrint.AutoWidth = AutoSize;
                        gridViewKeToan.OptionsPrint.ShowPrintExportProgress = true;
                        gridViewKeToan.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gridViewKeToan.ExportToXlsx(dialog.FileName, options);
                        XtraMessageBox.Show("Thành Công !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi: " + e, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void btnDongKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDongDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}