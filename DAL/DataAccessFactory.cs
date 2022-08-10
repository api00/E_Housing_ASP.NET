using DAL.EF;
using DAL.interfaces;
using DAL.Repos;
using DAL.Repos.Buyer_Repos;
using DAL.Repos.Seller_Repos;
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
        public static IRepo<blog, int> GetBlogDataAccess()
        {
            return new BlogRepo(db);
        }
        public static IRepo<s_appartment_details, int> GetAppDataAccess()
        {
            return new App_Details(db);
        }
        public static IRepo<EF.complain, int> GetComDataAccess()
        {
            return new Complain(db);
        }
    }
}
