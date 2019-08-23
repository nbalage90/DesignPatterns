using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }

        public void EndOperations()
        {
            product.Add(string.Format($"Motorcycle Model name: {this.brandName}"));
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
