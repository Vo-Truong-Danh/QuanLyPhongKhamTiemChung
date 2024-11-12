using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class VaccineBLL 
    {

        VaccineDAL vcbll = new VaccineDAL();
        public DataTable LayTTVC()
        {
            return vcbll.LayTTVC();
        }
        public DataTable Load()
        {
            return vcbll.Load();
        }
        public DataTable SearchTen(string nd)
        {
            return vcbll.SearchTen(nd);
        }
        public void Insert(VaccineDTO vaccineDTO)
        {
            vcbll.Insert(vaccineDTO);
        }
        public bool Delete(string mavc)
        {
            return vcbll.Delete(mavc);
        }
        public bool Update(VaccineDTO vaccineDTO)
        {
            return vcbll.Update(vaccineDTO);
        }
        public DataTable Search(string ndtimkiem)
        {
            return vcbll.Search(ndtimkiem);
        }
        public List<string> LoadDSXuatXu()
        {
            return vcbll.LoadDSXuatXu();
        }
        public void Luu()
        {
            vcbll.Luu(); 
        }

        public VaccineDTO SearchChiTiet(string mavc)
        {
            return  vcbll.SearchChiTiet(mavc);
        }
    }
}
