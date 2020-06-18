using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;

namespace iMSAPI
{
    public class AccessRequest
    {
        [SwaggerSchema("for update or delete access right")]
        public string ResidentId { set; get; }
        [SwaggerSchema("unit ID from SINO unit standard scheme(CDB)")]
        public int UnitId { set; get; }
        [SwaggerSchema("true: the user is resident, false: the user is visitor")]
        public bool IsResident { set; get; }
        [SwaggerSchema("true: cardId is octopus card, false: cardId is user identifier")]
        public bool IsOctopus { set; get; }
        [SwaggerSchema("octopus card number or user identifier")]
        public string CardId { set; get; }
        [SwaggerSchema("display name of the user")]
        public string Name { set; get; }
        [SwaggerSchema("gender of the user")]
        public string Gender { set; get; }
        [SwaggerSchema("the photo of the resident")]
        public string PhotoUrl { set; get; }
        [SwaggerSchema("(for visitor only) the user can only access in this period")]
        public string ValidFrom { set; get; }
        [SwaggerSchema("(for visitor only) the user can only access in this period")]
        public string ValidTo { set; get; }
        [SwaggerSchema("of integer IDs of access group the user can access. The IDs are provide by AST via API")]
        public IList<int> AccessGroups { set; get; }
    }
}



