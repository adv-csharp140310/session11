using DAL;
using DomainModel;
using Dto.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProductService
    {
        public void Create(ProductCreateInput model)
        {
            /**
             * Validate Data 
             * Business logic
             * Log
             */

            var repo = new ProductRepo();

            //Mapping
            var productModel = new Product { 
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
            };
            //https://mapperly.riok.app/

            repo.Create(productModel);


        }
    }
}
