using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COID_System.Entity
{
    public class DAOuser
    { 
        public static user LoginCheck(string username, string pass)
        {
            user output = null;
            OrderSystemEntities db = new OrderSystemEntities();
            user temp = db.users.FirstOrDefault(x => x.password == pass && x.is_active == true && x.username == username);
            if (temp != null)
            {
                output = new user();
                output.name = temp.name;
                output.role = temp.role;

            }
            return output;

        }
    }
}
