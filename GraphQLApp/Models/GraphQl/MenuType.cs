using GraphQL.Types;

namespace GraphQLApp.Models.GraphQl
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Name = "Menu";

            Field(item => item.Id, type: typeof(IdGraphType)).Description("The ID of the menu.");
            Field(item => item.Name).Description("The name of the menu.");
            Field(item => item.MenuItems, type: typeof(ListGraphType<MenuItemType>)).Description("The menu items of the menu.");
        }
    }
}
