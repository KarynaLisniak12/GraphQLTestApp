using GraphQL.Types;
using GraphQLApp.Models;
using GraphQLApp.Models.GraphQl;
using System;
using System.Collections.Generic;

namespace GraphQLApp.Query
{
    public class GetOrderQuery : ObjectGraphType
    {
        public GetOrderQuery()
        {
            Field<RestarauntType>(
                "restaraunt",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType>() { Name = "id", Description = "The ID of the Restaraunt." }
                ),
                resolve: context =>
                {
                    Guid id = context.GetArgument<Guid>("id");
                    var restaraunt = new Restaurant()
                    {
                        Id = Guid.NewGuid(),
                        Name = "TestRestaraunt"
                    };
                    return restaraunt;
                }
            );

            Field<ListGraphType<RestarauntType>>(
                "restaurants",
                resolve: context =>
                {
                    var restaurants = new List<Restaurant>()
                    {
                        new Restaurant()
                        {
                            Id = Guid.NewGuid(),
                            Name = "TestRestaraunt1"
                        },
                        new Restaurant()
                        {
                            Id = Guid.NewGuid(),
                            Name = "TestRestaraunt2"
                        }
                    };
                    return restaurants;
                }
            );
        }
    }
}
