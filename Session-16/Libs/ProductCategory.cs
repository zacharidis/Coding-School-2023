using Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    [Serializable]
    public class ProductCategory
    {
        
        public Guid ProductCategoryID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ProductType ProductType { get; set; }


        public ProductCategory()
        {
            ProductCategoryID = Guid.NewGuid();
        }

    }
}