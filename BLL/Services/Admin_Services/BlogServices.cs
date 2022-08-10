using BLL.Bos;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
   public class BlogServices
    {
        public static List<BlogModel> Get()
        {
            var data = DataAccessFactory.GetBlogDataAccess().Get();
            var rdata = new List<BlogModel>();
            foreach (var item in data)
            {
                rdata.Add(new BlogModel()
                {
                    id = item.id,
                    a_id = item.a_id,
                    title=item.title,
                    date=item.date,
                    details=item.details,

                    img = item.img,
                });
            }
            return rdata;
        }
        public static List<blog> GetVarStudentCount(int count)
        {
            return DataAccessFactory.GetBlogDataAccess().Get().Take(count).ToList();
        }
        public static BlogModel GetBlog(int id)
        {
            var item = DataAccessFactory.GetBlogDataAccess().Get(id);

            var d = new BlogModel() {
                id = item.id,
                a_id = item.a_id,
                title = item.title,
                date = item.date,
                details = item.details,

                img = item.img,
            };
            return d;
        }
        public static bool Create(BlogModel item)
        {
            var student = new blog()
            {
                id = item.id,
                a_id = item.a_id,
                title = item.title,
                date = item.date,
                details = item.details,

                img = item.img,

            };
            return DataAccessFactory.GetBlogDataAccess().Create(student);
        }
        public static bool Update(BlogModel item)
        {
            var student = new blog()
            {
                id = item.id,
                a_id = item.a_id,
                title = item.title,
                date = item.date,
                details = item.details,

                img = item.img,

            };
            return DataAccessFactory.GetBlogDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetBlogDataAccess().Delete(id);
        }
    }
}
