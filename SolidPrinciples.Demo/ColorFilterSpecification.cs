using System.Collections.Generic;

namespace SolidPrinciples.Demo.OCP
{
    public class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly ProductColor productColor;

        public ColorFilterSpecification(ProductColor productColor)
        {
            this.productColor = productColor;
        }

        protected override IEnumerable<Product> ApplyFilter(IList<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor)
                    yield return product;
            }
        }
    }
}