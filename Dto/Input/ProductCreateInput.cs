using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.Input
{
    public class ProductCreateInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
