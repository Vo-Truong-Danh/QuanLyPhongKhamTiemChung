﻿using DAL;
using System;
using System.Collections.Generic;
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
    }
}