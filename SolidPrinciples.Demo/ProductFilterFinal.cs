using System.Collections.Generic;

namespace SolidPrinciples.Demo.OCP
{
    public class ProductFilterFinal
    {
        public IEnumerable<Product> By(IList<Product> products, ProductFilterSpecification filterSpecification)
        {
            return filterSpecification.Filter(products);
        }
    }
}
