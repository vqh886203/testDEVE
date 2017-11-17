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
using System.Windows.Shapes;

namespace testDEVE
{
    /// <summary>
    /// Interaction logic for xam.xaml
    /// </summary>
    public partial class xam : Window
    {
        public xam()
        {
            InitializeComponent();
            Cxulynhanvien xl = new Cxulynhanvien();
            gr.ItemsSource = xl.getDSNhanVien();
        }
    }
}
