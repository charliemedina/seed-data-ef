using System;
using System.Collections.Generic;

namespace AXPE_SQL.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        public int Extension { get; set; }

        public string Photo { get; set; }

        public string Notes { get; set; }

        public string ReportsTo { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
