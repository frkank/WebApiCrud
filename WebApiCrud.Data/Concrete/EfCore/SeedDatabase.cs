using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Entity;

namespace WebApiCrud.Data.Concrete.EfCore
{

    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new WebApiCrudContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                if (context.ProductCategories.Count() == 0)
                {
                    context.ProductCategories.AddRange(ProductCategories);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() {CategoryName="Telefon",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryName="Bilgisayar",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryName="Beyaz Eşya",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")}

        };

        private static Product[] Products =
        {
            new Product {ProductName="Samsung S10", ProductPrice=15000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductName="Samsung S11", ProductPrice=16000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductName="Samsung S12", ProductPrice=17000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductName="Samsung S20", ProductPrice=18000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},

            new Product {ProductName="Xaomi Redmi 9 Pro", ProductPrice=13000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
        };

        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory() { Product = Products[0], Category=Categories[0] },
            new ProductCategory() { Product = Products[0], Category=Categories[2] },

            new ProductCategory() { Product = Products[1], Category=Categories[0] },
            new ProductCategory() { Product = Products[1], Category=Categories[2] },

            new ProductCategory() { Product = Products[2], Category=Categories[0] },
            new ProductCategory() { Product = Products[2], Category=Categories[2] },

            new ProductCategory() { Product = Products[3], Category=Categories[0] },
            new ProductCategory() { Product = Products[3], Category=Categories[2] },

            new ProductCategory() { Product = Products[4], Category=Categories[0] },
            new ProductCategory() { Product = Products[4], Category=Categories[2] },

            new ProductCategory() { Product = Products[5], Category=Categories[1] },

        };
    }

}
