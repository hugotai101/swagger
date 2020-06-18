using System;
using Swashbuckle.AspNetCore.Annotations;

namespace iMSAPI
{
    public class AesKeyUpdateRequest
    {
        [SwaggerSchema("New AES Key")]
        public string Key { get; set; }
    }
}
