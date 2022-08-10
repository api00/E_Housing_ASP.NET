using BLL.Bos.BuyerBos;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Buyer_Services
{
   public class ComplainService
    {

        public static List<ComplainModel> Get()
        {
            var data = DataAccessFactory.GetComDataAccess().Get();
            var rdata = new List<ComplainModel>();
            foreach (var item in data)
            {
                rdata.Add(new ComplainModel()
                {
                    c_subject = item.c_subject,
                    c_type = item.c_type,
                    ctg = item.ctg,
                    c_details = item.c_details,
                    c_id = item.c_id
                });
            }
            return rdata;
        }
        public static List<complain> GetVarStudentCount(int count)
        {
            return DataAccessFactory.GetComDataAccess().Get().Take(count).ToList();
        }
        public static ComplainModel GetUser(int id)
        {
            var item = DataAccessFactory.GetComDataAccess().Get(id);

            var d = new ComplainModel() {
                c_subject = item.c_subject,
                c_type = item.c_type,
                ctg = item.ctg,
                c_details = item.c_details,
                c_id = item.c_id
            };
            return d;
        }
        public static bool Create(ComplainModel item)
        {
            var student = new complain()
            {
              c_subject =item.c_subject,
                c_type = item.c_type,
                ctg = item.ctg,
                c_details= item.c_details,
                c_id=item.c_id

            };
            return DataAccessFactory.GetComDataAccess().Create(student);
        }
        public static bool Update(ComplainModel item)
        {
            var student = new complain()
            {
                c_subject = item.c_subject,
                c_type = item.c_type,
                ctg = item.ctg,
                c_details = item.c_details,
                c_id = item.c_id

            };
            return DataAccessFactory.GetComDataAccess().Update(student);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetComDataAccess().Delete(id);
        }
    }
}
