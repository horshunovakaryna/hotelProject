using Quartz;
using Quartz.Impl;

namespace hotel.Trigger
{
    class Remover
    {
        public static async void StartNow()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<RemoveSomeReservings>().Build();

            ITrigger trigger = TriggerBuilder.Create()  
                .WithIdentity("trigger1", "group1")    
                .StartNow()                           
                .WithSimpleSchedule(x => x
                .WithIntervalInHours(24)     
                .RepeatForever())                  
                .Build(); 

            await scheduler.ScheduleJob(job, trigger);      
        }
    }
}
