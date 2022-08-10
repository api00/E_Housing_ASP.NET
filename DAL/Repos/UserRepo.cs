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

        public bool Create(user_details s1)
        {
            db.user_details.Add(s1);
            var res = db.SaveChanges();
            if (res != 0)
            {
                if (s1.rules.Equals("Seller"))
                {
                    //adv_details ad = new adv_details();
                    s_profile sp = new s_profile();
                    sp.s_id = s1.user_id;
                    sp.s_email = s1.email;
                    sp.s_name = s1.name;
                    sp.s_img = s1.img;
                    //ad.user_id = s1.user_id;
                    db.s_profile.Add(sp);
                    //db.adv_details.Add(ad);
                    db.SaveChanges();
                }
                if (s1.rules.Equals("Buyer"))
                {
                    b_profile p = new b_profile();
                    p.b_id = s1.user_id;
                    p.b_email = s1.email;
                    p.b_name = s1.name;
                    p.b_img = s1.img;
                    db.b_profile.Add(p);
                    db.SaveChanges();
                }
                if (s1.rules.Equals("Tenant"))
                {
                    t_profile t = new t_profile();
                    t.t_id = s1.user_id;
                    t.t_email = s1.email;
                    t.t_name = s1.name;
                    t.t_img = s1.img;
                    db.t_profile.Add(t);
                    db.SaveChanges();
                }
                if (s1.rules.Equals("Admin"))
                {
                    //blog b = new blog();
                    a_profile t = new a_profile();
                    t.a_id = s1.user_id;
                    t.a_email = s1.email;
                    t.a_name = s1.name;
                    t.a_img = s1.img;
                    //b.a_id = s1.user_id;
                    db.a_profile.Add(t);
                    //db.blogs.Add(b);
                    db.SaveChanges();
                }
                
                return true;
            }
            return false;
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
