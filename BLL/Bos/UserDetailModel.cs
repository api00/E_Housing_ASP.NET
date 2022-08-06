using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bos
{
   public class UserDetailModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int user_id { get; set; }
        public string password { get; set; }
        public string rules { get; set; }
        public string status { get; set; }
        public string img { get; set; }
    }
}
