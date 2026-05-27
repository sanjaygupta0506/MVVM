using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM._6._API.Rest_API.Model
{
    class PostModel
    {
        public int UserID { get; set; }
        public int ID { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
    }
}
