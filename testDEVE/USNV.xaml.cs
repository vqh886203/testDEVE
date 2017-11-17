using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Xpf.Grid;


namespace testDEVE
{
    /// <summary>
    /// Interaction logic for USNV.xaml
    /// </summary>
    public partial class USNV : UserControl
    {
        private Cxulynhanvien xl = new Cxulynhanvien();
        public USNV()
        {
            InitializeComponent();
            gridControl.ItemsSource = xl.getDSNhanVien();        
            
        }

        private void gridControl_SelectionChanged(object sender, DevExpress.Xpf.Grid.GridSelectionChangedEventArgs e)
        {
            //try
            //{
            //     object row = gridControl.GetRow(gridControl.GetSelectedRowHandles()[0]);

            //    NhanVien a = xl.timnv(row);
            //    if (a != null)
            //    {
            //        lbtennv.Content = a.tennv;
            //        lbns.Content = a.ngaysinh.ToString();
            //        if (a.gioitinh == true)
            //            lbgt.Content = "Nam";
            //        lbgt.Content = "Nữ";
            //        lbdt.Content = a.doanhthu.ToString();
            //        lbsdt.Content = a.sdt.ToString();
            //        lbmail.Content = a.email;
            //    }
            //}
            //catch { return; }
            
        }

        private void gridControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gridControl.BeginSelection();
            gridControl.UnselectAll();
            grView a = new grView();
            DataViewBase view = gridControl.View;
            a = (grView)gridControl.GetRow(gridControl.GetSelectedRowHandles()[0]);
            NhanVien aa = xl.timnv(a.MaNV);
            if(aa!=null)
            { 
            lbtennv.Content = aa.tennv;
            lbns.Content = aa.ngaysinh.ToString();
            if (aa.gioitinh == true)
                lbgt.Content = "Nam";
            else
                lbgt.Content = "Nữ";
            lbdt.Content = aa.doanhthu.ToString();
            lbsdt.Content = aa.sdt.ToString();
            lbmail.Content = aa.email;
            lbtdiachi.Content = aa.diachi;
            }
        }

       public void xoanv()
        {
            gridControl.BeginSelection();
            gridControl.UnselectAll();
            grView a = new grView();
            DataViewBase view = gridControl.View;
            a = (grView)gridControl.GetRow(gridControl.GetSelectedRowHandles()[0]);

            xl.Xoa(a.MaNV);
            gridControl.ItemsSource = xl.getDSNhanVien();       
        }

        //private void biPaste_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        //{
        //    gridControl.BeginSelection();
        //    gridControl.UnselectAll();
        //    grView a = new grView();
        //    DataViewBase view = gridControl.View;
        //    a = (grView)gridControl.GetRow(gridControl.GetSelectedRowHandles()[0]);
            
        //    xl.Xoa(a.MaNV);
        //}
       
    }
}
