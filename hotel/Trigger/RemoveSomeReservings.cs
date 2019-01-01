using System;
using System.Collections.Generic;
using Quartz;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using hotel.DataBase;
using hotel.Component;

namespace hotel.Trigger
{
    class RemoveSomeReservings : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            DBWorker.RemoveReservings();
        }
    }
}
