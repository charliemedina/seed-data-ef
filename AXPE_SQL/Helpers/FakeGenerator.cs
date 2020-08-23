using AXPE_SQL.Entities;
using Bogus;
using System;

namespace AXPE_SQL.Helpers
{
    public static class FakeGenerator
    {
        public static Category CreateCategory(int categoryType)
        {
            var category = new Faker<Category>()
                .RuleFor(u => u.CategoryId, f => Guid.NewGuid())
                .RuleFor(u => u.CategoryName, (f, u) => f.Commerce.Price())
                .RuleFor(u => u.Description, (f, u) => f.Commerce.Categories(categoryType).ToString())
                .RuleFor(u => u.Picture, (f, u) => f.Image.PlaceImgUrl());
            // ICollection<Product> Products

            return category.Generate();
        }

        public static Shipper CreateShipper()
        {
            var shipper = new Faker<Shipper>()
                .RuleFor(u => u.ShipperId, f => Guid.NewGuid())
                .RuleFor(u => u.CompanyName, (f, u) => f.Company.CompanyName())
                .RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber());

            // ICollection<Order> Orders

            return shipper.Generate();
        }

        public static Employee CreateEmployee()
        {
            var shipper = new Faker<Employee>()
                .RuleFor(u => u.EmployeeId, f => Guid.NewGuid())
                .RuleFor(u => u.Address, (f, u) => f.Address.Direction())
                .RuleFor(u => u.BirthDate, (f, u) => f.Person.DateOfBirth)
                .RuleFor(u => u.City, (f, u) => f.Address.City())
                .RuleFor(u => u.Country, (f, u) => f.Address.Country())
                .RuleFor(u => u.Extension, (f, u) => f.Random.Number(1000))
                .RuleFor(u => u.FirstName, (f, u) => f.Person.FirstName)
                .RuleFor(u => u.HireDate, (f, u) => f.Date.Recent())
                .RuleFor(u => u.HomePhone, (f, u) => f.Phone.PhoneNumber())
                .RuleFor(u => u.LastName, (f, u) => f.Person.LastName)
                .RuleFor(u => u.Notes, (f, u) => f.Lorem.Lines())
                .RuleFor(u => u.Photo, (f, u) => f.Image.PlaceImgUrl())
                .RuleFor(u => u.PostalCode, (f, u) => f.Address.ZipCode())
                .RuleFor(u => u.Region, (f, u) => f.Address.State())
                .RuleFor(u => u.ReportsTo, (f, u) => f.Person.FullName)
                .RuleFor(u => u.Title, (f, u) => f.Name.JobTitle())
                .RuleFor(u => u.TitleOfCourtesy, (f, u) => f.Person.UserName);

            // ICollection<Order> Orders

            return shipper.Generate();
        }

        public static Customer CreateCutomer()
        {
            var shipper = new Faker<Customer>()
                .RuleFor(u => u.CustomerId, f => Guid.NewGuid())
                .RuleFor(u => u.Address, (f, u) => f.Address.Direction())
                .RuleFor(u => u.City, (f, u) => f.Address.City())
                .RuleFor(u => u.CompanyName, (f, u) => f.Company.CompanyName())
                .RuleFor(u => u.ContactName, (f, u) => f.Person.FullName)
                .RuleFor(u => u.ContactTitle, (f, u) => f.Name.JobTitle())
                .RuleFor(u => u.Country, (f, u) => f.Address.Country())
                .RuleFor(u => u.Fax, (f, u) => f.Person.UserName)
                .RuleFor(u => u.Phone, (f, u) => f.Person.Phone)
                .RuleFor(u => u.PostalCode, (f, u) => f.Address.ZipCode())
                .RuleFor(u => u.Region, (f, u) => f.Address.State());

                // ICollection<Order> Orders

            return shipper.Generate();
        }

        public static Supplier CreateSupplier()
        {
            var shipper = new Faker<Supplier>()
                .RuleFor(u => u.SupplierId, f => Guid.NewGuid())
                .RuleFor(u => u.Address, (f, u) => f.Address.Direction())
                .RuleFor(u => u.City, (f, u) => f.Address.City())
                .RuleFor(u => u.CompanyName, (f, u) => f.Company.CompanyName())
                .RuleFor(u => u.ContactName, (f, u) => f.Person.FullName)
                .RuleFor(u => u.ContactTitle, (f, u) => f.Name.JobTitle())
                .RuleFor(u => u.Country, (f, u) => f.Address.Country())
                .RuleFor(u => u.Fax, (f, u) => f.Person.UserName)
                .RuleFor(u => u.HomePage, (f, u) => f.Person.Website)
                .RuleFor(u => u.Phone, (f, u) => f.Person.Phone)
                .RuleFor(u => u.PostalCode, (f, u) => f.Address.ZipCode())
                .RuleFor(u => u.Region, (f, u) => f.Address.State());

            // ICollection<Order> Orders

            return shipper.Generate();
        }

        public static Product CreateProduct()
        {
            var shipper = new Faker<Product>()
                .RuleFor(u => u.ProductId, f => Guid.NewGuid())
                .RuleFor(u => u.Discontinued, (f, u) => f.Random.Bool())
                .RuleFor(u => u.ProductName, (f, u) => f.Commerce.ProductName())
                .RuleFor(u => u.QuantiryPerUnit, (f, u) => f.Random.Number())
                .RuleFor(u => u.ReorderLevel, (f, u) => f.Name.Random.Number(1, 10))
                .RuleFor(u => u.UnitPrice, (f, u) => f.Random.Number(1000))
                .RuleFor(u => u.UnitsInStock, (f, u) => f.Random.Number(200))
                .RuleFor(u => u.ProductName, (f, u) => f.Commerce.ProductName());

            // Guid SupplierId
            // Guid CategoryId
            // ICollection<Order> Orders

            return shipper.Generate();
        }

        public static OrderDetails CreateOrderDetails()
        {
            var shipper = new Faker<OrderDetails>()
                .RuleFor(u => u.OrderDetailsId, f => Guid.NewGuid())
                .RuleFor(u => u.Quantity, (f, u) => f.Random.Number())
                .RuleFor(u => u.UnitPrice, (f, u) => f.Random.Number(1000));

            // Guid ProductId
            // Guid OrderId

            return shipper.Generate();
        }

        public static Order CreateOrder()
        {
            var shipper = new Faker<Order>()
                .RuleFor(u => u.OrderId, f => Guid.NewGuid())
                .RuleFor(u => u.Freight, (f, u) => f.Random.Number(100))
                .RuleFor(u => u.OrderDate, (f, u) => f.Date.Recent())
                .RuleFor(u => u.RequiredDate, (f, u) => f.Date.Soon())
                .RuleFor(u => u.ShipAddress, (f, u) => f.Address.Direction())
                .RuleFor(u => u.ShipCity, (f, u) => f.Address.City())
                .RuleFor(u => u.ShipCountry, (f, u) => f.Address.Country())
                .RuleFor(u => u.ShipName, (f, u) => f.Person.FullName)
                .RuleFor(u => u.ShippedDate, (f, u) => f.Date.Recent())
                .RuleFor(u => u.ShipPostalCode, (f, u) => f.Address.ZipCode())
                .RuleFor(u => u.ShipRegion, (f, u) => f.Address.State())
                .RuleFor(u => u.ShipVia, (f, u) => f.Address.StreetName());

            // Guid ShipperId
            // Guid CustomerId
            // Guid EmployeeId
            // ICollection<OrderDetails> OrdersDetails

            return shipper.Generate();
        }
    }
}
