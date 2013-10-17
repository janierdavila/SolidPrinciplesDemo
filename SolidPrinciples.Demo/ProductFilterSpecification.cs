using System.Collections.Generic;

namespace SolidPrinciples.Demo.OCP
{
    public abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IList<Product> products)
        {
            return ApplyFilter(products);
        }

        protected abstract IEnumerable<Product> ApplyFilter(IList<Product> products);
    }
}