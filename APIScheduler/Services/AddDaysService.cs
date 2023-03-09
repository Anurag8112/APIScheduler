using APIScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIScheduler.Services
{
    public static class AddDaysService
    {
        public static void AddDays()
        {
            APISchedulerContext Db = new APISchedulerContext();

            foreach(var user in Db.users)
            {
                user.TotalDays++;
            }
            Db.SaveChanges();
        }
    }
}
