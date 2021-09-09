using System;
using PrototypeDesignPattern.Interfaces;

namespace PrototypeDesignPattern.Models
{
    public class Product : Interfaces.ICloneable
    {
        public IdInfo IdInfo { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public object ShallowCopy()
        {
            return (Product)this.MemberwiseClone();
        }

        public object DeepCopy()
        {
            Product clone = (Product)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name =  Name; /*String.Copy(Name);*/ 
            clone.Price = Price;
            clone.Description = Description;
            clone.CreatedAt = CreatedAt;
            return clone;
        }
        public override string ToString()
        {
            return $"{IdInfo.IdNumber} | {Name} | {Price} | {CreatedAt.ToString("dd-MM-yyyy HH:mm")} | {Description}";
        }
    }
}