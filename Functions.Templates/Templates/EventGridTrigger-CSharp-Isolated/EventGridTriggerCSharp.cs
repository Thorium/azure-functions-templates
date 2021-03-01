// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class EventGridTriggerCSharp
    {
        [Function("EventGridTriggerCSharp")]
        public static void Run([EventGridTrigger] MyEvent input, FunctionContext context)
        {
            var logger = context.GetLogger("EventGridTriggerCSharp");
            logger.LogInformation(input.Data.ToString());
        }
    }

    public class MyEvent
    {
        public string Id { get; set; }

        public string Topic { get; set; }

        public string Subject { get; set; }

        public int EventType { get; set; }

        public object Data { get; set; }
    }
}