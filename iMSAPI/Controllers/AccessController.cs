using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace iMSAPI.Controllers
{
    [ApiController]
    [Route("accesscontroller")]
    public class AccessContorller : ControllerBase
    {
        private readonly ILogger<AccessContorller> _logger;

        public AccessContorller(ILogger<AccessContorller> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("Groups")]

        [SwaggerOperation(
            Summary = "Get Access Groups for Access API",
            Description = "Get Access Groups for Access API",
            OperationId = "Access",
            Tags = new[] { "Access", }
        )]
        [Produces("application/json")]
        public GroupRes GetGroups()
        {
            GroupRes groupRes = new GroupRes();
            groupRes.Data = new List<GroupData>() { new GroupData()
            {
                Description = "NO Des",
                Id = 777
            } ,};
            return groupRes;
        }

        [HttpPost]
        [Route("Access")]
        [SwaggerOperation(
            Summary = "Create or Update Access Right of Resident or Visitor",
            Description = "Create or Update Access Right of Resident or Visitor",
            OperationId = "Access",
            Tags = new[] { "Create Update", }
        )]
        [SwaggerResponse(200, "Success", typeof(AccessResponse))]
        [SwaggerResponse(400, "Failed", typeof(AccessResponse))]
        public AccessResponse CreateUpdate([FromBody] AccessRequest accessRequest)
        {
            AccessResponse accessResponse = new AccessResponse();
            return accessResponse;
        }

        [HttpPost]
        [Route("DeleteAccess")]
        [SwaggerOperation(
            Summary = "Delete Access Right",
            Description = "Delete Access Right",
            OperationId = "Delete",
            Tags = new[] { "Delete", }
        )]
        [SwaggerResponse(200, "Success", typeof(AccessResponse))]
        [SwaggerResponse(400, "Failed", typeof(AccessResponse))]
        public AccessResponse Delete([FromBody] DeleteAccessRequest deleteAccessRequest)
        {
            AccessResponse accessResponse = new AccessResponse();
            return accessResponse;
        }

        [HttpGet]
        [Route("AccessLog")]
        [SwaggerOperation(
            Summary = "Get Access Log of a Visitor or Resident",
            Description = "Get Access Log of a Visitor or Resident",
            OperationId = "Get Access Log",
            Tags = new[] { "Get Access Log", }
        )]
        [SwaggerResponse(200, "Success", typeof(AccessResponse))]
        public AccessResponse GetLog([FromBody] AccessLogRequest accessLogRequest)
        {
            AccessResponse accessResponse = new AccessResponse();
            return accessResponse;
        }

        [HttpPost]
        [Route("AesKeyUpdate")]
        [SwaggerOperation(
            Summary = "For updating AES Key for qrcode encryption",
            Description = "For updating AES Key for qrcode encryption",
            OperationId = "Update AES",
            Tags = new[] { "Update AES", }
        )]
        [SwaggerResponse(200, "Success", typeof(AccessResponse))]
        public AccessResponse UpdateAES([FromBody] AesKeyUpdateRequest aesKeyUpdateRequest)
        {
            AccessResponse accessResponse = new AccessResponse();
            return accessResponse;
        }
    }
}
