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
    public class HoaDonBLL
    {
        HoaDonDAL hdDAL = new HoaDonDAL();
        public string TaoMaHDTuDong()
        {
            return hdDAL.TaoMaHDTuDong();   
        }
        public bool InsertHD(HoaDonDTO hdDTO)
        {
            return hdDAL.InsertHD(hdDTO);
        }
        public DataRowCollection GetFullDataRows()
        {
            return hdDAL.GetFullDataRows();
        }
        public void Edit(HoaDonDTO hoaDonDTO)
        {
            hdDAL.UpdateHD(hoaDonDTO);
        }
        public void Delete(string maHD)
        {
            hdDAL.DeleteHD(maHD);
        }
        public DataView GetDataViewFromTimKiem(string searchStr)
        {
            DataView view = hdDAL.GetDataViewFromTimKiem(searchStr);
            return view;
        }
        public void ClearDataSet()
        {
            hdDAL.ClearDataSet();
        }

        public string NewIDHD()
        {
           return hdDAL.NewIDHD();
        }

        public int GetContainVC(string maHD, string maVC)
        {
            return hdDAL.GetContainVC(maHD, maVC);
        }

        public void AddAmount(int v)
        {
            hdDAL.AddAmount(v); ;
        }

        public void InsertCTHD(ChiTietHoaDonDTO chitTietHoaDonDTO)
        {
            hdDAL.InsertCTHD(chitTietHoaDonDTO);
        }

        public void UpdateOrNewCTHD(ChiTietHoaDonDTO chitTietHoaDonDTO)
        {
            hdDAL.UpdateOrNewCTHD(chitTietHoaDonDTO);
        }

        public string LoadVCPrice(string idVC)
        {
           return hdDAL.LoadPriceVC(idVC);
        }


        public DataRowCollection GetAllCTHD(string maHD)
        {
            return hdDAL.GetInvoiceDetails(maHD).Rows;
        }

        public void EditCTHD(ChiTietHoaDonDTO ct)
        {
            hdDAL.UpdateCTHD(ct);
        }

        public void UpdateHD(string maNV)
        {
            hdDAL.UpdateHoaDonByNV(maNV);
        }

        public DataRowCollection GetHDByMaBN(string maBN)
        {
            return hdDAL.GetHDByMaBN(maBN);
        }

        public void DeleteCTHD(string maHD, string maVC)
        {
            hdDAL.DeleteCTHD(maHD, maVC);
        }

        public DataRowCollection GetHDByMaNV(string maNV)
        {
            return hdDAL.GetHDByMaNV(maNV);
        }
    }
}
