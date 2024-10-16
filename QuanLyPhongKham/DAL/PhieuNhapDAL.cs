﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuNhapDAL
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();


        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        //string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True;";
        SqlConnection conn;

        public PhieuNhapDAL()
        {
            conn = new SqlConnection(connectStr);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        }

        public DataSet GetData()
        {
            conn.Open();
            string truyvansql = "select * from PhieuNhap";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "PhieuNhap");
            conn.Close();
            return ds;
        }
        public bool Insert(PhieuNhapDTO tmp)
        {
            try
            {
                if (ds.Tables["PhieuNhap"] == null)
                {
                    GetData();
                }

                DataRow newRow = ds.Tables["PhieuNhap"].NewRow();
                newRow["NgayNhap"] = tmp.Ngaynhap;
                newRow["MaNCC"] = tmp.Mancc;


                ds.Tables["PhieuNhap"].Rows.Add(newRow);

                // Cập nhật csdl
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                adap.Update(ds, "PhieuNhap");
                GetData();

                return true;
            }
            catch
            { return false; }
        }
        public bool Delete(string tmp)
        {
            try
            {
                if (ds.Tables["PhieuNhap"] == null)
                {
                    GetData();
                }
                DataRow[] rowDeXoa = ds.Tables["PhieuNhap"].Select($"MaPN = '{tmp}'");
                foreach (DataRow row in rowDeXoa)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(ds, "PhieuNhap");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(PhieuNhapDTO tmp)
        {
            try
            {
                if (ds.Tables["PhieuNhap"] == null)
                {
                    GetData();
                }

                DataRow[] rowDeUPD = ds.Tables["PhieuNhap"].Select("MaPN = '" + tmp.Mapn + "'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
                    row["NgayNhap"] = tmp.Ngaynhap;
                    row["MaNCC"] = tmp.Mancc;

                    // Cập nhật csdl
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                    adap.Update(ds, "PhieuNhap");

                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
