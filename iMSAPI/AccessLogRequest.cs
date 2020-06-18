using System;
namespace iMSAPI
{
    public class AccessLogRequest
    {
        /// <summary>
        /// ResidentID
        /// </summary>
        /// <example>123455</example>
        public string ResidentID { set; get; }
        public string From { set; get; }
        public string To { set; get; }
    }
}
