using AXPE_SQL.Entities;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AXPE_SQL.Helpers
{
    public class FakeGenerator
    {
        private const int NumOfCategories = 30;
        private const int NumOfProducts = 20;
        private const int NumOfSuppliers = 20;
        private const int NumOfShippers = 30;
        private const int NumOfOrders = 20;
        private const int NumOfEmployees = 50;
        private const int NumOfCustomers = 25;

        public static IEnumerable<Category> GetCategories =>
            Enumerable.Range(1, NumOfCategories).Select(_ => CreateCategory(_)).ToList();

        public static IEnumerable<Shipper> GetShippers =>
            Enumerable.Range(1, NumOfShippers).Select(_ => CreateShipper(_)).ToList();

        public static IEnumerable<Supplier> GetSuppliers =>
            Enumerable.Range(1, NumOfSuppliers).Select(_ => CreateSupplier(_)).ToList();

        public static IEnumerable<Customer> GetCustomers =>
            Enumerable.Range(1, NumOfCustomers).Select(_ => CreateCutomer(_)).ToList();

        public static IEnumerable<Employee> GetEmployees =>
            Enumerable.Range(1, NumOfEmployees).Select(_ => CreateEmployee(_)).ToList();

        public static IEnumerable<Product> GetProducts =>
            Enumerable.Range(1, NumOfProducts).Select(_ => CreateProduct(_)).ToList();

        public static IEnumerable<Order> GetOrders =>
            Enumerable.Range(1, NumOfOrders).Select(_ => CreateOrder(_)).ToList();

        public static IEnumerable<OrderDetails> GetOrderDetails =>
            Enumerable.Range(1, NumOfOrders).Select(_ => CreateOrderDetails(_)).ToList();

        private static Category CreateCategory(int index)
        {
            var category = new Faker<Category>()
                .RuleFor(u => u.CategoryId, f => index)
                .RuleFor(u => u.CategoryName, (f, u) => f.Commerce.Categories(NumOfCategories)[index - 1])
                .RuleFor(u => u.Description, (f, u) => f.Lorem.Text())
                .RuleFor(u => u.Picture, (f, u) => f.Image.PlaceImgUrl());

            return category.Generate();
        }

        private static Shipper CreateShipper(int index)
        {
            var shipper = new Faker<Shipper>()
                .RuleFor(u => u.ShipperId, f => index)
                .RuleFor(u => u.CompanyName, (f, u) => f.Company.CompanyName())
                .RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber());

            return shipper.Generate();
        }

        private static Employee CreateEmployee(int index)
        {
            var shipper = new Faker<Employee>()
                .RuleFor(u => u.EmployeeId, f => index)
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

            return shipper.Generate();
        }

        private static Customer CreateCutomer(int index)
        {
            var shipper = new Faker<Customer>()
                .RuleFor(u => u.CustomerId, f => index)
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

            return shipper.Generate();
        }

        private static Supplier CreateSupplier(int index)
        {
            var shipper = new Faker<Supplier>()
                .RuleFor(u => u.SupplierId, f => index)
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

            return shipper.Generate();
        }

        private static Product CreateProduct(int index)
        {
            var shipper = new Faker<Product>()
                .RuleFor(u => u.ProductId, f => index)
                .RuleFor(u => u.Discontinued, (f, u) => f.Random.Bool())
                .RuleFor(u => u.ProductName, (f, u) => f.Commerce.ProductName())
                .RuleFor(u => u.QuantiryPerUnit, (f, u) => f.Random.Number())
                .RuleFor(u => u.ReorderLevel, (f, u) => f.Name.Random.Number(1, 10))
                .RuleFor(u => u.UnitPrice, (f, u) => f.Random.Number(1000))
                .RuleFor(u => u.UnitsInStock, (f, u) => f.Random.Number(200))
                .RuleFor(u => u.ProductName, (f, u) => f.Commerce.ProductName())
                .RuleFor(u => u.SupplierId, (f, u) => f.Random.Number(1, NumOfSuppliers))
                .RuleFor(u => u.CategoryId, (f, u) => f.Random.Number(1, NumOfCategories));

            return shipper.Generate();
        }

        private static OrderDetails CreateOrderDetails(int index)
        {
            var shipper = new Faker<OrderDetails>()
                .RuleFor(u => u.OrderDetailsId, f => index)
                .RuleFor(u => u.Quantity, (f, u) => f.Random.Number(1, 100))
                .RuleFor(u => u.UnitPrice, (f, u) => f.Random.Number(1000))
                .RuleFor(u => u.ProductId, (f, u) => f.Random.Number(1, NumOfProducts))
                .RuleFor(u => u.OrderId, (f, u) => f.Random.Number(1, NumOfOrders));

            return shipper.Generate();
        }

        private static Order CreateOrder(int index)
        {
            var shipper = new Faker<Order>()
                .RuleFor(u => u.OrderId, f => index)
                .RuleFor(u => u.Freight, (f, u) => f.Random.Number(100))
                .RuleFor(u => u.OrderDate, (f, u) => f.Date.Recent())
                .RuleFor(u => u.RequiredDate, (f, u) => f.Date.Soon())
                .RuleFor(u => u.ShipAddress, (f, u) => f.Address.Direction())
                .RuleFor(u => u.ShipCity, (f, u) => f.Address.City())
                .RuleFor(u => u.ShipCountry, (f, u) => f.Address.Country())
                .RuleFor(u => u.ShipName, (f, u) => f.Person.FullName)
                .RuleFor(u => u.ShippedDate, (f, u) => f.Date.Between(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10)))
                .RuleFor(u => u.ShipPostalCode, (f, u) => f.Address.ZipCode())
                .RuleFor(u => u.ShipRegion, (f, u) => f.Address.State())
                .RuleFor(u => u.ShipVia, (f, u) => f.Address.StreetName())
                .RuleFor(u => u.ShipperId, (f, u) => f.Random.Number(1, NumOfShippers))
                .RuleFor(u => u.CustomerId, (f, u) => f.Random.Number(1, NumOfCustomers))
                .RuleFor(u => u.EmployeeId, (f, u) => f.Random.Number(1, NumOfEmployees));

            return shipper.Generate();
        }
    }
}
