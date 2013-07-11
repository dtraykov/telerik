namespace LargeCollectionOfProducts
{
    using System;

    public class Product : IComparable<Product>
    {
        private double price;
        private string name;

        public Product(double price)
            : this(null, price)
        {
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public double Price
        {
            get
            {
                return this.price;
            }

             set
            {
                this.price = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int CompareTo(Product otherProduct)
        {
            return this.Price.CompareTo(otherProduct.Price);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1:C2}", this.name, this.price);
        }
    }
}
