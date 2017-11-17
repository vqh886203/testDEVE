using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDEVE.Model
{
    class NhanVienModelView
    {
        public List<NhanVien> DSNV { get; set; }
        dtbbdsDataContext dc = new dtbbdsDataContext();
        public NhanVienModelView()
        {
            this.DSNV = dc.NhanViens.ToList();

        }
        
    }

}
