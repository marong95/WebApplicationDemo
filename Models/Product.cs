using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplicationDemo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Productname { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public int Storage { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ApplicationDemos") { }
        public DbSet<Product> Products { get; set; }
    }


}