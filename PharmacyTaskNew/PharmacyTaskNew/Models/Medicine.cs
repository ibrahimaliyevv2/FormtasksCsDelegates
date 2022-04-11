using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyTaskNew.Models
{
    public class Medicine
    {
        private static int _id;

        public Medicine()
        {
            _id++;
            Id = _id;
        }

        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; } = false;
        public void Sell()
        {
            Count--;
        }
        public void ShowInfo()
        {
            Console.WriteLine($" Name: { Name}, Price: { Price}, Count: {Count}, Is deleted: {IsDeleted}");
        }
    }
}
