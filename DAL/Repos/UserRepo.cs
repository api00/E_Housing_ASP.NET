using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UserRepo : IRepo<user_details, int>
    {
        private FINALEntities db;

        public UserRepo(FINALEntities db)
        {
            this.db = db;
        }

        public bool Create(user_details obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
           
                db.user_details.Remove(Get(id));
                db.SaveChanges();
                return true;
            
        }

        public List<user_details> Get()
        {
            return db.user_details.ToList();

        }

        public  user_details Get(int id)
        {
            return db.user_details.SingleOrDefault(s => s.id == id);
        }

        public bool Update(user_details obj)
        {
            throw new NotImplementedException();
        }
    }
}
