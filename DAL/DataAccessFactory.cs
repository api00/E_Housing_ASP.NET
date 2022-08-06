using DAL.EF;
using DAL.interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DataAccessFactory
    {
        static FINALEntities db = new FINALEntities();
        public static IRepo<user_details, int> GetUserDataAccess()
        {
            return new UserRepo(db);
        }
    }
}
