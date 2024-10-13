using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL nvDAL = new TaiKhoanDAL();
        public bool Insert(TaiKhoanDTO nvDTO)
        {
            if (nvDAL.IsExistsUserName(nvDTO.UserName))
                return false;
            nvDAL.Insert(nvDTO);
            return true;
        }
        public bool CheckUserNameAndPassword(string userName, string password)
        {
            return nvDAL.CheckUserNameAndPassword(userName, password);
        }
    }
}
