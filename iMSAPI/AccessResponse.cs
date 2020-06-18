namespace iMSAPI
{
    public class AccessResponse
    {
        /// <summary>
        /// DateTime in ISO8601
        /// </summary>
        /// <example>2020-06-18T17:11:05+00:00</example>
        public string Data { set; get; }
        public Status Status { set; get; }
        public string Message { set; get; }
        public string DateTime { set; get; }
    }
}
