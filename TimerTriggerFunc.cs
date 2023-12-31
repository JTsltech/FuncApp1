using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Timer.Function
{
    public class TimerTriggerFunc
    {
        [FunctionName("TimerTriggerFunc")]
        public void Run([TimerTrigger("*/20 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
