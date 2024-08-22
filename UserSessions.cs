using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapDeals.comLTD
{
    
        public static class UserSession
        {
            public static string CurrentUserEmail { get; set; }
            public static string CurrentUsername { get; set; } // Optional, if needed
        }

    
}
