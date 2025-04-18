﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChitTietHoaDonDTO
    {
		public string MaHD { get; set; }
		public string MaVC { get; set; }
		public int SoLuong { get; set; }
		public float DonGia { get; set; }

		public ChitTietHoaDonDTO(string maHD, string maVC, int soLuong, float donGia)
		{
			MaHD = maHD;
			MaVC = maVC;
			SoLuong = soLuong;
			DonGia = donGia;
		}
	}
}
