using GraphQL;
using GraphQL.Types;
using GraphQLApp.Query;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GraphQLApp.Controllers
{
    [Route("graphql")]
    public class GraphQlController : Controller
    {
        public async Task<IActionResult> Post([FromBody] QraphQlQuery query)
        {
            Schema schema = new Schema()
            {
                Query = new GetOrderQuery()
            };

            var inputs = query.Variables.ToInputs();

            var result = await new DocumentExecuter().ExecuteAsync(context =>
            {
                context.Schema = schema;
                context.Query = query.Query;
                context.Inputs = inputs;
                context.OperationName = query.OperatingName;
            }).ConfigureAwait(false);

            return Ok(result); 
        }
    }
}