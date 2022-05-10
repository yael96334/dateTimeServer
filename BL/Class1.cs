using DAL;
using DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Class1
    {
        public static Users_tbl userDTOAndConvert()
        {
            UserDTO userDTO = new UserDTO() { age = 12, height = 15, email = "aa@bb" };
            return Mapper.Map<Users_tbl>(userDTO);
        }
    }
}
