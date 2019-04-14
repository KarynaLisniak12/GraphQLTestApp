using GraphQL.Types;

namespace GraphQLApp.Models.GraphQl
{
    public class RestarauntType : ObjectGraphType<Restaurant>
    {
        public RestarauntType()
        {
            Name = "Restaraunt";

            Field(item => item.Id, type: typeof(IdGraphType)).Description("The ID of the Restaraunt.");
            Field(item => item.Name).Description("The name of the Restaraunt.");
            Field(item => item.Menus, type: typeof(ListGraphType<MenuType>)).Description("The menus of the Restaraunt.");
        }
    }
}
