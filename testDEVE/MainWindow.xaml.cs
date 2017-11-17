using System.Windows;

namespace testDEVE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cxulynhanvien xl = new Cxulynhanvien();
        private USNV a = new USNV();
        public MainWindow()
        {
            InitializeComponent();
            
            usnv.Content = a;
            biNV.IsEnabled = false;
            nbiList.IsEnabled = true;

        }

      

        private void biNV_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            USNV a = new USNV();
            usnv.Content = a;
            biNV.IsEnabled = false;
            nbiList.IsEnabled = true;
            biKH.IsEnabled = true;
        }

        private void biKH_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            usnv.Content = null;
            biNV.IsEnabled = true;
            biKH.IsEnabled = false;
            nbiDetail.IsEnabled = false;
            nbiList.IsEnabled = false;
        }

        private void nbiDetail_Click(object sender, System.EventArgs e)
        {
            USNV a = new USNV();
            usnv.Content = a;
            biNV.IsEnabled = false;
            nbiDetail.IsEnabled = false;
            nbiList.IsEnabled = true;
        }

        private void nbiList_Click(object sender, System.EventArgs e)
        {
            UCNVList ucList = new UCNVList();
            usnv.Content = ucList;
            nbiList.IsEnabled = false;
            nbiDetail.IsEnabled = true;
            
        }

        private void bithoat_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Close();
        }

        private void bixoa_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
             MessageBox.Show("Bạn có đồng ý xóa không ?", "Thông Báo ", MessageBoxButton.OK, MessageBoxImage.Question);
             a.xoanv();
        }
    }
}
