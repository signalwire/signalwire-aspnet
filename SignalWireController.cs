using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML;

namespace SignalWire.AspNet.Core
{
    /// <summary>
    /// Extends the standard base controller to simplify returning a LaML response
    /// </summary>
	public class SignalWireController : ControllerBase
    {
        /// <summary>
        /// Returns a properly formatted LaML response
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentNaming
        protected LaMLResult LaML(MessagingResponse response)
        {
            return new LaMLResult(response);
        }

        /// <summary>
        /// Returns a properly formatted LaML response
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentNaming
        protected LaMLResult LaML(VoiceResponse response)
        {
            return new LaMLResult(response);
        }
    }
}