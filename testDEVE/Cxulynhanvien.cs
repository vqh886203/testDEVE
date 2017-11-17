using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDEVE
{
    class Cxulynhanvien
    {
        private dtbbdsDataContext dc = new dtbbdsDataContext();
        private dtbbdsDataContext dcnv = new dtbbdsDataContext();

        public IEnumerable<object> getDSNhanVien()
        {
            dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.NhanViens);
            return dc.NhanViens.Select(x => new grView
            {
                MaNV = x.nvid,
                TenNV = x.tennv,
                NgaySinh = x.ngaysinh.Value,
                GioiTinh = x.gioitinh.Value ? "Nam" : "Nữ",
                email = x.email,
                SDT = x.sdt.ToString()
            });

        }
      
        public NhanVien timnv(int ma)
        {
            foreach (NhanVien a in dcnv.NhanViens.Where(x => x.nvid == ma))
                return a;
            return null;
        }

        public void Xoa(int a)
        {
            foreach (NhanVien x in dc.NhanViens.Where(x => x.nvid == a))
            {
                
                dc.NhanViens.DeleteOnSubmit(x);
                dc.SubmitChanges();
            }
        }
    }
}
