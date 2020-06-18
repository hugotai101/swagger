using System;
using Swashbuckle.AspNetCore.Annotations;

namespace iMSAPI
{
    public class AesKeyUpdateRequest
    {
        /// <summary>
        /// Temperature in celcius
        /// </summary>
        /// <example>25</example>
        public string Key { get; set; }
    }
}
