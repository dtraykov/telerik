namespace CompanyProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Product : IComparable<Product>
    {
        private string barcode;
        private string vendor;
        private string title;

        public Product(string barcode, string vendor, string title)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
        }

        public string Barcode
        {
            get
            {
                return this.barcode;
            }

            set
            {
                this.barcode = value;
            }
        }

        public string Vendor
        {
            get
            {
                return this.vendor;
            }

            set
            {
                this.vendor = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        public int CompareTo(Product otherProduct)
        {
            return this.Barcode.CompareTo(otherProduct.Barcode);
        }

        public override string ToString()
        {
            string product = string.Format("{0} - {1} - {2}", this.Barcode, this.Vendor, this.Title);

            return product;
        }
    }
}
