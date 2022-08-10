using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Seller_Repos
{
   public class App_Details : IRepo<s_appartment_details, int>
    {
        private FINALEntities db;

        public App_Details(FINALEntities db)
        {
            this.db = db;
        }
        public bool Create(s_appartment_details obj)
        {
            db.s_appartment_details.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.s_appartment_details.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<s_appartment_details> Get()
        {
            return db.s_appartment_details.ToList();
        }

        public s_appartment_details Get(int id)
        {
            return db.s_appartment_details.SingleOrDefault(s => s.id == id);
        }

        public bool Update(s_appartment_details obj)
        {
            throw new NotImplementedException();
        }
    }
}
