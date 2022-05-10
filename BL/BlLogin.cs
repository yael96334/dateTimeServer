using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class BlLogin
    {
        public static bool Login(string username,string password,weighing weighing)
        {
            using(YaelAndEstiProjectEntities ctx = new YaelAndEstiProjectEntities())
            {
                User  user = ctx.Users.FirstOrDefault(u => u.tz == password && u.userName == username);
                return user == null ? false : true;
            }
        }
        public static bool AddUserToGroup(User user)
        {
           
        }

    }
}
