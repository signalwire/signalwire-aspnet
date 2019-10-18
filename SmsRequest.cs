﻿namespace SignalWire.AspNet.Common
{
    /// <summary>
    /// This class can be used as the parameter on your SMS action. Incoming parameters will be bound here.
    /// </summary>
    /// <remarks>http://www.SignalWire.com/docs/api/twiml/sms/SignalWire_request</remarks>
    public class SmsRequest : SignalWireRequest
    {
        /// <summary>
        /// A 34 character unique identifier for the message. May be used to later retrieve this message from the REST API
        /// </summary>
        public string SmsSid { get; set; }

        /// <summary>
        /// The text body of the SMS message. Up to 160 characters long
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The status of the message
        /// </summary>
        public string MessageStatus { get; set; }
    }
}