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
    public class UserServices
    {
        public static List<UserDetailModel> Get()
        {
            var data = DataAccessFactory.GetUserDataAccess().Get();
            var rdata = new List<UserDetailModel>();
            foreach (var item in data)
            {
                rdata.Add(new UserDetailModel()
                {
                    id = item.id,
                    name = item.name,
                    email = item.email,
                    user_id = item.user_id,
                    password = item.password,
                    rules = item.rules,
                    status = item.status,
                    img = item.img,
                });
            }
            return rdata;
        }
        public static List<user_details> GetVarStudentCount(int count)
        {
            return DataAccessFactory.GetUserDataAccess().Get().Take(count).ToList();
        }
        public static UserDetailModel GetUser(int id)
        {
            var item = DataAccessFactory.GetUserDataAccess().Get(id);
             
            var d = new UserDetailModel() { id = item.id, name=item.name, email=item.email, user_id =item.user_id, password=item.password, rules =item.rules, status=item.status, img=item.img   };
            return d;
        }
        public static bool Create(UserDetailModel item)
        {
            var student = new user_details()
            {
                id = item.id,
                name = item.name,
                email = item.email,
                user_id = item.user_id,
                password = item.password,
                rules = item.rules,
                status = item.status,
                img = item.img,

            };
            return DataAccessFactory.GetUserDataAccess().Create(student);
        }
        public static bool Update(user_details student)
        {
            return DataAccessFactory.GetUserDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetUserDataAccess().Delete(id);
        }
    }
}
