using APIScheduler.DAL;
using APIScheduler.DAL.Tables;
using APIScheduler.Interface;
using APIScheduler.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIScheduler.Repository
{
    public class SchedulerAPIRepo : ISchedulerAPI
    {
        public bool AddMe(AddMeModel model)
        {
            try
            {
                APISchedulerContext Db = new APISchedulerContext();
                var member = new User(){ Name=model.Name};
                Db.users.Add(member);
                Db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
