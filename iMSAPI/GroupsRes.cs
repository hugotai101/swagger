using System;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;

namespace iMSAPI
{
    [SwaggerSchema(Required = new[] { "Group Data Description" })]
    public class GroupRes
    {
        [SwaggerSchema("Group Data List")]
        public IList<GroupData> Data { set; get; }
        public Status Status { set; get; }
        public string Message { set; get; }
        public string DateTime { set; get; }
    }
}
