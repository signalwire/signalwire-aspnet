# signalwire-dotnet-aspnet
MVC helper library for .NET Core

Example
namespace MVC_Sandbox.Controllers
{
    public class LamlController : SignalWireController
    {
        public LaMLResult Sms(SmsRequest request)
        {
            var response = new MessagingResponse();
            response.Message(
                $"Hey there {request.From}! " +
                "How 'bout those Yankees?"
            );
            return LaML(response);
        }

        public LaMLResult Voice(VoiceRequest request)
        {
            var response = new VoiceResponse();
            response.Say($"Welcome. Are you from {request.FromCity}?");
            return LaML(response);
        }
    }
}
