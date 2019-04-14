using System;
using System.Collections.Generic;

namespace GraphQLApp.Models
{
    public class Menu
    {
        public Guid Id { get; set; }
        public Guid RestarauntId { get; set; }
        public string Name { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
}
