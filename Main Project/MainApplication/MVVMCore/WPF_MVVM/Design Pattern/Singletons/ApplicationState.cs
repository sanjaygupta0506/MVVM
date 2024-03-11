using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.Design_Pattern.Singletons
{
    public class ApplicationState
    {
        private static ApplicationState instance = null;
        public string LoginID { get; set; }
        public string RoleId { get; set; }

        public ApplicationState()
        {

        }

        //Lock Object
        private static object lockthis = new object();
        public static ApplicationState GetState()
        {
            lock (lockthis)
            {
                if (ApplicationState.instance == null)
                    instance = new ApplicationState();
            }
            return instance;
        }
    }
}
