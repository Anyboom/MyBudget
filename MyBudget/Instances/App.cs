using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget
{
    class App
    {
        private static ApplicationContext _Instance;

        public static ApplicationContext Instance {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new ApplicationContext();
                }

                return _Instance;
            }
        }
        
    }
}
