using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();
        public int SoLuong()
        {
            return dal.SoLuong();
        }
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable Load()
        {
            return dal.Load();
        }
        public NhanVienDTO CheckUserNameAndPassword(string userName, string password)
        {
           return dal.CheckUserNameAndPassword(userName, password);
        }
        public void Insert(NhanVienDTO nvDTO)
        {
            dal.Insert(nvDTO);
        }
        public bool Delete(string mavc)
        {
            return dal.Delete(mavc);
        }
        public bool Update(NhanVienDTO nvDTO)
        {
            return dal.Update(nvDTO);
        }
        public string TaoMaNVMoi()
        {
            return dal.TaoMaNVMoi();
        }
    }
}
