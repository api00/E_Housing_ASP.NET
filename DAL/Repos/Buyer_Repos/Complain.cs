using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Buyer_Repos
{
   public class Complain : IRepo<complain, int>
    {
        private FINALEntities db;

        public Complain(FINALEntities db)
        {
            this.db = db;
        }
        public bool Create(complain obj)
        {
            db.complains.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.complains.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<complain> Get()
        {
            return db.complains.ToList();
        }

        public complain Get(int id)
        {
            return db.complains.SingleOrDefault(s => s.c_id == id);
        }

        public bool Update(complain obj)
        {
            var data = db.complains.SingleOrDefault(s => s.c_id == obj.c_id);
            data.c_subject = obj.c_subject;
            data.c_type = obj.c_type;
            data.ctg = obj.ctg;
            data.c_details = obj.c_details;
            data.c_id = obj.c_id;
            db.SaveChanges();

            return true;
        }
    }
}
