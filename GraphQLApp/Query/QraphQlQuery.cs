using Newtonsoft.Json.Linq;

namespace GraphQLApp.Query
{
    public class QraphQlQuery
    {
        public string OperatingName { get; set; }
        public string QueryName { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
