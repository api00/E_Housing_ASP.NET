using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
   public class BlogRepo : IRepo<blog, int>
    {
        private FINALEntities db;

        public BlogRepo(FINALEntities db)
        {
            this.db = db;
        }

        public bool Create(blog obj)
        {
            db.blogs.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            db.blogs.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<blog> Get()
        {
            return db.blogs.ToList();
        }

        public blog Get(int id)
        {
            return db.blogs.Find(id);
        }

        public bool Update(blog item)
        {
            var data = db.blogs.SingleOrDefault(s => s.id == item.id);
            data.id = item.id;
            data.a_id = item.a_id;
            data.title = item.title;
            data.date = item.date;
            data.details = item.details;

            data.img = item.img;
            db.SaveChanges();

            return true;
        }
    }
}
