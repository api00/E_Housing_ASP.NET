using BLL.Bos.SellerBos;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Seller_Services
{
   public class App_Services
    {

        public static List<App_DetilModel> Get()
        {
            var data = DataAccessFactory.GetAppDataAccess().Get();
            var rdata = new List<App_DetilModel>();
            foreach (var item in data)
            {
                rdata.Add(new App_DetilModel()
                {
                    id=item.id,
                    a_size = item.a_size,
                    s_id = item.s_id,
                    s_name = item.s_name,
                    a_id = item.a_id,
                    location = item.location,
                    s_nid = item.s_nid,
                    s_email = item.s_email,
                    s_num = item.s_num,
                    s_address = item.s_address,
                    h_register_n = item.h_register_n,
                    price = item.price,
                    img = item.img,
                    bed = item.bed,
                    bath = item.bath,
                    a_title = item.a_title,
                    country = item.country,
                });
            }
            return rdata;
        }
        public static List<s_appartment_details> GetVarAppCount(int count)
        {
            return DataAccessFactory.GetAppDataAccess().Get().Take(count).ToList();
        }
        public static App_DetilModel GetBlog(int id)
        {
            var item = DataAccessFactory.GetAppDataAccess().Get(id);

            var d = new App_DetilModel()
            {
                id = item.id,
                a_size = item.a_size,
                s_id = item.s_id,
                s_name = item.s_name,
                a_id = item.a_id,
                location = item.location,
                s_nid = item.s_nid,
                s_email = item.s_email,
                s_num = item.s_num,
                s_address = item.s_address,
                h_register_n = item.h_register_n,
                price = item.price,
                img = item.img,
                bed = item.bed,
                bath = item.bath,
                a_title = item.a_title,
                country = item.country,

            };
            return d;
        }
        public static bool Create(App_DetilModel item)
        {
            var student = new s_appartment_details()
            {
                id = item.id,
                a_size = item.a_size,
                s_id = item.s_id,
                s_name = item.s_name,
                a_id = item.a_id,
                location = item.location,
                s_nid = item.s_nid,
                s_email = item.s_email,
                s_num = item.s_num,
                s_address = item.s_address,
                h_register_n = item.h_register_n,
                price = item.price,
                img = item.img,
                bed = item.bed,
                bath = item.bath,
                a_title = item.a_title,
                country = item.country,

            };
            return DataAccessFactory.GetAppDataAccess().Create(student);
        }
        public static bool Update(s_appartment_details s1)
        {
            return DataAccessFactory.GetAppDataAccess().Update(s1);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetAppDataAccess().Delete(id);
        }
    }
}
