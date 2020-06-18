
using Swashbuckle.AspNetCore.Annotations;

namespace iMSAPI
{
    [SwaggerSchema(Required = new[] { "Group Data Description" })]
    public class GroupData
    {
        [SwaggerSchema("Access Group Id")]
        public int Id { set; get; }
        [SwaggerSchema("Description of the group")]
        public string Description { set; get; }
    }
}
