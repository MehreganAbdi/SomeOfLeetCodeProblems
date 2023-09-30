using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AdminManagment
    {
        public static bool CanChangeSiteColorBG(User user)
        {
            return (user.IsAdmin);
        }
    }
}
