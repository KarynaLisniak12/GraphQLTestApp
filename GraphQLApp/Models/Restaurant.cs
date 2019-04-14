using System;
using System.Collections.Generic;

namespace GraphQLApp.Models
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Menu> Menus { get; set; }
    }
}
