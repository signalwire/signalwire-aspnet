using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SignalWire.AspNet.Core
{
    // ReSharper disable once InconsistentNaming
    public class LaMLResult : IActionResult
    {
        public string Data { get; protected set; }

        public LaMLResult()
        {
        }

        public LaMLResult(string LaML)
        {
            Data = LaML;
        }

        public LaMLResult(Twilio.TwiML.TwiML response)
        {
            if (response != null)
                Data = response.ToString();
        }

        public async Task ExecuteResultAsync(ActionContext actionContext)
        {
            var response = actionContext.HttpContext.Response;
            response.ContentType = "application/xml";

            if (Data == null)
            {
                Data = "<Response></Response>";
            }

            await response.WriteAsync(Data);
        }
    }
}