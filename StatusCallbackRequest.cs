namespace SignalWire.AspNet.Common
{
    /// <summary>
    /// This class can be used as the parameter on your StatusCallback action. Incoming parameters will be bound here.
    /// </summary>
    /// <remarks>http://www.SignalWire.com/docs/api/twiml/SignalWire_request#asynchronous</remarks>
    public class StatusCallbackRequest : VoiceRequest
    {
        /// <summary>
        /// The duration in seconds of the just-completed call.
        /// </summary>
        public float CallDuration { get; set; }

        public string Called { get; set; }
        public string Caller { get; set; }
        public float Duration { get; set; }
    }
}