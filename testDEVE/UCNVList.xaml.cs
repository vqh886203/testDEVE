using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testDEVE
{
    /// <summary>
    /// Interaction logic for UCNVList.xaml
    /// </summary>
    public partial class UCNVList : UserControl
    {
        dtbbdsDataContext dc = new dtbbdsDataContext();
        public UCNVList()
        {
            InitializeComponent();
         
        }

        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid.BeginSelection();
            grid.UnselectAll();
            for (int i = 0; i < grid.VisibleRowCount; i++)
            {
                int row = grid.GetRowHandleByVisibleIndex(i);
                if (!grid.IsGroupRowHandle(row))
                {
                    NhanVien a = (NhanVien)grid.GetGroupRowValue(row);
                    //biDelete.IsEnabled = true;
                    grid.SelectItem(row);
                }
            }
            grid.EndSelection();

        }
        
        private void tableView_RowUpdated(object sender, RowEventArgs e)
        {
            NhanVien row = (NhanVien)grid.SelectedItem;
            grid.RefreshData();
            foreach(NhanVien i in dc.NhanViens.Where(x => x.nvid == row.nvid)){
                i.tennv = row.tennv;
                i.gioitinh = row.gioitinh;
                i.hinh = row.hinh;
                i.diachi = row.diachi;
                i.doanhthu = row.doanhthu;
                i.ngaysinh = row.ngaysinh;
                i.matkhau = row.matkhau;
                i.email = row.email;
                i.sdt = row.sdt;
                i.quyen = row.quyen;
                dc.SubmitChanges();
            }
        }
    }
}
