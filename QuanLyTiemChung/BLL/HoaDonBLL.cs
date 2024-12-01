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
        public bool Insert(HoaDonDTO hdDTO)
        {
            return hdDAL.AddInvoice(hdDTO);
        }
        public DataRowCollection GetFullDataRows()
        {
            return hdDAL.GetFullDataRows();
        }
        public void Edit(HoaDonDTO hoaDonDTO)
        {
            hdDAL.UpdateInvoice(hoaDonDTO);
        }
        public void Delete(string maHD)
        {
            hdDAL.DeleteHoaDon(maHD);
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

        public string GetLastHDID()
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

        public void AddCTHD(ChitTietHoaDonDTO chitTietHoaDonDTO)
        {
            hdDAL.AddInvoiceDetail(chitTietHoaDonDTO);
        }

        public void UpdateOrNewCTHD(ChitTietHoaDonDTO chitTietHoaDonDTO)
        {
            hdDAL.UpdateOrNewCTHD(chitTietHoaDonDTO);
        }

        public string LoadVCPrice(string idVC)
        {
           return hdDAL.LoadPriceVC(idVC);
        }

        public bool AddHD(HoaDonDTO hoaDon)
        {
           return hdDAL.AddInvoice(hoaDon);
        }

        public DataRowCollection GetAllCTHD(string maHD)
        {
            return hdDAL.GetInvoiceDetails(maHD).Rows;
        }

        public void EditCTHD(ChitTietHoaDonDTO ct)
        {
            hdDAL.UpdateInvoiceDetail(ct);
        }

        public void UpdateHD(string maNV)
        {
            hdDAL.UpdateHoaDonByNV(maNV);
        }

        public DataRowCollection GetHDByMaBN(string maBN)
        {
            return hdDAL.GetHDByMaBN(maBN);
        }

        public void DeleteCTHD(string v)
        {
            hdDAL.DeleteInvoiceDetail(v);
        }

        public DataRowCollection GetHDByMaNV(string maNV)
        {
            return hdDAL.GetHDByMaNV(maNV);
        }
    }
}
