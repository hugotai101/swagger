using System;
using System.Collections.Generic;

namespace iMSAPI
{
    public class AccessLogResponse
    {
        public IList<LogData> Data { set; get; }
        public Status Status { set; get; }
        public string Message { set; get; }
        public string DateTime { set; get; }
    }
}
