﻿    using System;
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
                return dt;
            }
            public void Insert(VaccineDTO vcDTO)
            {
                DataRow newrow = dt.NewRow();
                newrow["MaVC"] = vcDTO.Mavc;
                newrow["MaLoai"] = vcDTO.Maloai;
                newrow["TenVC"] = vcDTO.Tenvc;
                newrow["NgaySX"] = vcDTO.Ngaysx;
                newrow["HanSuDung"] = vcDTO.Hansudung;
                newrow["SoLuongTon"] = 0;
                newrow["Gia"] = vcDTO.Gia;
                newrow["XuatXu"] = vcDTO.Xuatxu;

                dt.Rows.Add(newrow);
            }

            public bool Delete(string maVC)
            {
                try
                {
                    DataRow[] rowDeXoa = dt.Select("MaVC = '"+maVC+"'");
                    if (rowDeXoa.Length > 0)
                    {
                        //dt.Rows.Remove(rowDeXoa[0]);
                        rowDeXoa[0].Delete();
                        return true;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }

            public bool Update(VaccineDTO vcDTO)
            {
                try
                {
                    DataRow[] rowDeUPD = dt.Select("MaVC = '" + vcDTO.Mavc + "'");

                    if (rowDeUPD.Length > 0)
                    {
                        DataRow row = rowDeUPD[0];
                        row["MaLoai"] = vcDTO.Maloai;
                        row["TenVC"] = vcDTO.Tenvc;
                        row["NgaySX"] = vcDTO.Ngaysx;
                        row["HanSuDung"] = vcDTO.Hansudung;
                        row["Gia"] = vcDTO.Gia;
                        row["XuatXu"] = vcDTO.Xuatxu;

                        dt.Rows.Add (row);

                        return true;
                    }
                    else return false;
                }
                catch
                {
                    return false;
                }
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
                DataRow[] dr = dt.Select("MaLoai = '"+ndtimkiem+"' OR XuatXu =  '"+ndtimkiem+"' ");
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
                DataRow[] dr = dt.Select("MaVC = '"+ndtimkiem+"' ");
                VaccineDTO vcdto = new VaccineDTO()
                {
                    Mavc = dr[0][0].ToString(),
                    Maloai = dr[0][1].ToString(),
                    Tenvc = dr[0][2].ToString(),
                    Ngaysx = dr[0][3].ToString(),
                    Hansudung = dr[0][4].ToString(),
                    Gia = int.Parse(dr[0][6].ToString()),
                    Xuatxu = dr[0][7].ToString(),

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


        }
    }