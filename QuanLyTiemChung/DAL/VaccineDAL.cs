using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

    namespace DAL
    {
    public class VaccineDAL
    {
        //DataSet ds = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        private static DataTable dt = new DataTable();
        public VaccineDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            conn.Open();
            string truyvansql = "select * from Vaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            if (dt.Rows.Count == 0)
                adap.Fill(dt);
        }

        public DataTable Load()
        {
            adap.Update(dt);

            dt.AcceptChanges();

            dt.Clear();
            adap.Fill(dt);
            return dt;
        }
                public DataTable LayTTVC()
        {
            return SqlCMDLayBang("select * from Vaccine");
        }

        private DataTable SqlCMDLayBang(string truyxuat)
        {
            DataTable tmp = new DataTable();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(truyxuat, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tmp.Load(reader);
                    }
                }
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch 
            {
                return tmp = null;
            }
            return tmp;
        }
        private bool SqlCMD(string truyxuat)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(truyxuat, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Insert(VaccineDTO vcDTO)
        {
           return SqlCMD("EXEC pro_them_vaccine @MaVC = '"+vcDTO.Mavc+"',@MaLoai = '"+vcDTO.Maloai+"',@TenVC = N'"+vcDTO.Tenvc+"',@NgaySX = '"+vcDTO.Ngaysx+"',@HanSuDung = '"+vcDTO.Hansudung+"',@Gia = "+vcDTO.Gia+", @XuatXu = N'"+vcDTO.Xuatxu+"';");
        }

        public bool Delete(string maVC)
        {
            return SqlCMD("EXEC pro_xoa_vaccine '"+maVC+"'");
        }

        public bool Update(VaccineDTO vcDTO)
        {
            return SqlCMD("EXEC pro_capnhat_vaccine @MaVC = '" + vcDTO.Mavc + "',@MaLoai = '" + vcDTO.Maloai + "',@TenVC = N'" + vcDTO.Tenvc + "',@NgaySX = '" + vcDTO.Ngaysx + "',@HanSuDung = '" + vcDTO.Hansudung + "',@Gia = " + vcDTO.Gia + ", @XuatXu = N'" + vcDTO.Xuatxu + "';");
        }
        public void Luu()
        {
            // Cập nhật xuống database
            adap.Update(dt);

            // Sau khi lưu thành công, chấp nhận các thay đổi trong DataTable
            dt.AcceptChanges();
        }
        public DataTable Search(string ndtimkiem)
        {
            DataRow[] dr = dt.Select("MaLoai = '" + ndtimkiem + "' OR XuatXu =  '" + ndtimkiem + "' ");
            DataTable tmp = dt.Clone();
            foreach (DataRow item in dr)
            {
                tmp.ImportRow(item);
            }
            return tmp;
        }
        public DataTable SearchTen(string ndtimkiem)
        {
            DataRow[] dr = dt.Select("TenVC LIKE '%" + ndtimkiem + "%' ");
            DataTable tmp = dt.Clone();
            foreach (DataRow item in dr)
            {
                tmp.ImportRow(item);
            }
            return tmp;
        }
        public VaccineDTO SearchChiTiet(string ndtimkiem)
        {
            if (string.IsNullOrEmpty(ndtimkiem))
            {
                return null;
            }

            DataRow[] dr = dt.Select("MaVC = '" + ndtimkiem + "'");
            if (dr == null || dr.Length == 0)
            {
                return null;
            }

            VaccineDTO vcdto = new VaccineDTO
            {
                Mavc = dr[0][0].ToString(),
                Maloai = dr[0][1].ToString(),
                Tenvc = dr[0][2].ToString(),
                Ngaysx = dr[0][3].ToString(),
                Hansudung = dr[0][4].ToString(),
                Gia = int.TryParse(dr[0][6].ToString(), out int gia) ? gia : 0,
                Xuatxu = dr[0][7].ToString()
            };

            return vcdto;
        }


        public List<string> LoadDSXuatXu()
        {
            DataRow[] dr = dt.Select("");
            List<string> xuatXuList = dr
                .Select(row => row["XuatXu"].ToString())
                .Distinct()
                .ToList();
            return xuatXuList;
        }
        public List<VaccineDTO> LoadDSVaccine()
        {
            DataRow[] dr = dt.Select("");
            List<VaccineDTO> dsVaccine = dr.Select(row => new VaccineDTO
            {
                Mavc = row["MaVC"].ToString(),
                Maloai = row["MaLoai"].ToString(),
                Tenvc = row["TenVC"].ToString(),
                Ngaysx = row["NgaySX"].ToString(),
                Hansudung = row["HanSuDung"].ToString(),
                Gia = int.Parse(row["Gia"].ToString()),
                Xuatxu = row["XuatXu"].ToString()
            }).ToList();
            return dsVaccine;
        }
        private DataTable dtvc = new DataTable();
        public DataTable ThongKeVCDaTiem()
        {
            string query = @"
            select LVC.TenLoai , sum(CTHD.SOLUONG) as SoLuong from VACCINE 
            join CHITIETHOADON CTHD on CTHD.MaVC = VACCINE.MaVC 
            join LOAIVACCINE LVC on LVC.MaLoai= VACCINE.MaLoai Group by LVC.TenLoai
            ";

            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            adap.Fill(dtvc);
            return dtvc;
        }

        public DataTable LayTTVCByLoaiVC(string maLoai)
        {
            DataRow[] dr = dt.Select("MaLoai = '" + maLoai + "'");
            DataTable tmp = dt.Clone();
            foreach (DataRow item in dr)
            {
                tmp.ImportRow(item);
            }
            return tmp;
        }

        public string LoadDGVaccineById(string maVC)
        {
            DataRow[] dr = dt.Select("MaVC = '" + maVC + "'");
            return dr[0]["Gia"].ToString();
        }
    }
}
