using APIScheduler.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIScheduler.Interface
{
    public interface ISchedulerAPI
    {
        public bool AddMe(AddMeModel model);
    }
}
