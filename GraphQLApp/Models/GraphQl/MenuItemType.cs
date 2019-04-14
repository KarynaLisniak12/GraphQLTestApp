using GraphQL.Types;

namespace GraphQLApp.Models.GraphQl
{
    public class MenuItemType : ObjectGraphType<MenuItem>
    {
        public MenuItemType()
        {
            Name = "MenuItem";

            Field(item => item.Id, type: typeof(IdGraphType)).Description("The ID of the menu item.");
            Field(item => item.Name).Description("The name of the menu item.");
            Field(item => item.Description).Description("The description of the menu item.");
            Field(item => item.Price).Description("The price of the menu item.");
            Field(item => item.SuitableForVegetarian).Description("Is this suitable for vegetarian?");
        }
    }
}
