using APIScheduler.Services;
using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIScheduler.SchedulerService
{
    public class APISchedulerService : Registry
    {
        public APISchedulerService()
        {
            Schedule<Task>().ToRunEvery(1).Days().At(11,59);
        }
    }

    public class Task : IJob
    {
        public void Execute()
        {
            AddDaysService.AddDays();
        }
    }
}
