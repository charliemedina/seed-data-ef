using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXPE_SQL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    TitleOfCourtesy = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    Extension = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ReportsTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ShipperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ShipperId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    HomePage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    ShipVia = table.Column<string>(nullable: true),
                    Freight = table.Column<double>(nullable: false),
                    ShipName = table.Column<string>(nullable: true),
                    ShipAddress = table.Column<string>(nullable: true),
                    ShipCity = table.Column<string>(nullable: true),
                    ShipRegion = table.Column<string>(nullable: true),
                    ShipPostalCode = table.Column<string>(nullable: true),
                    ShipCountry = table.Column<string>(nullable: true),
                    ShipperId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippers_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shippers",
                        principalColumn: "ShipperId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    QuantiryPerUnit = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<int>(nullable: false),
                    UnitsInStock = table.Column<int>(nullable: false),
                    UnitsOnOrder = table.Column<int>(nullable: false),
                    ReorderLevel = table.Column<int>(nullable: false),
                    Discontinued = table.Column<bool>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description", "Picture" },
                values: new object[,]
                {
                    { 1, "Kids", "aut", "https://placeimg.com/640/480/any" },
                    { 30, "Kids", "Et maiores eos saepe molestiae.", "https://placeimg.com/640/480/any" },
                    { 29, "Baby", "Aut reprehenderit sequi.", "https://placeimg.com/640/480/any" },
                    { 28, "Sports", "Voluptas magnam laudantium. Ipsum voluptas magnam consequatur pariatur sint esse voluptate et sit. Repellendus sapiente eveniet. Nobis sunt rerum ea. Aut iure fugiat aut similique necessitatibus nobis nesciunt dolores repudiandae. Facilis quia eos explicabo maxime.", "https://placeimg.com/640/480/any" },
                    { 27, "Health", @"Dolores voluptatibus quis.
                Distinctio et omnis distinctio ad unde rerum.
                Ratione sunt nisi qui eum modi delectus sunt quo.
                Non praesentium quos qui.", "https://placeimg.com/640/480/any" },
                    { 26, "Electronics", "Dicta repellendus repudiandae consequuntur cumque.", "https://placeimg.com/640/480/any" },
                    { 25, "Jewelery", "Consequatur neque quo aut rem quae. Nemo saepe ducimus sed qui dolorem libero et est. Id cum exercitationem.", "https://placeimg.com/640/480/any" },
                    { 24, "Clothing", "Laborum aliquid et sed corporis expedita minima. Asperiores omnis autem ab dolor. Sit eaque aut. Consequatur rerum quis. Autem et aliquam sed in eveniet sapiente.", "https://placeimg.com/640/480/any" },
                    { 23, "Jewelery", @"Perferendis quidem asperiores accusamus non.
                Aut autem est accusamus perspiciatis facere tempora.
                Vitae quasi debitis omnis.
                Ab enim id enim exercitationem fugiat saepe.
                Magnam necessitatibus assumenda.
                Debitis incidunt laborum.", "https://placeimg.com/640/480/any" },
                    { 22, "Industrial", "dolores", "https://placeimg.com/640/480/any" },
                    { 20, "Shoes", "Dolor laborum qui.", "https://placeimg.com/640/480/any" },
                    { 19, "Books", "consequatur", "https://placeimg.com/640/480/any" },
                    { 18, "Shoes", "Aut tempora hic asperiores animi. In vel labore ab velit repellendus. Ut molestiae incidunt ut dolore. Rerum sunt magnam quo sint sit tenetur facilis.", "https://placeimg.com/640/480/any" },
                    { 17, "Home", "necessitatibus", "https://placeimg.com/640/480/any" },
                    { 16, "Home", "ea", "https://placeimg.com/640/480/any" },
                    { 21, "Automotive", "Voluptatem nulla quia et. Maiores quod autem dolore dolores qui quos officia et. Ex necessitatibus rerum quae debitis rerum velit quasi illum est. Voluptates et consectetur molestiae in laborum eum. Et alias eius. Ut accusantium iste nostrum optio quis consequatur rerum non dolorem.", "https://placeimg.com/640/480/any" },
                    { 14, "Industrial", @"Ullam sed odit.
                Iste nesciunt et qui.
                Fuga beatae cum qui sunt molestias dolorem.", "https://placeimg.com/640/480/any" },
                    { 2, "Music", "recusandae", "https://placeimg.com/640/480/any" },
                    { 15, "Beauty", @"Unde ut consequatur nihil dicta.
                Culpa asperiores consequatur aperiam culpa possimus error doloremque natus sed.", "https://placeimg.com/640/480/any" },
                    { 4, "Tools", "Accusamus voluptatem et quia maiores omnis omnis.", "https://placeimg.com/640/480/any" },
                    { 5, "Toys", "adipisci", "https://placeimg.com/640/480/any" },
                    { 6, "Toys", "Et aut voluptatem sint in modi est. Commodi explicabo eos praesentium. Pariatur eveniet veritatis magni harum accusamus corrupti. Distinctio consequuntur autem tenetur quisquam dolorem reprehenderit ipsam est soluta. Deserunt eius explicabo ea id inventore dicta aut.", "https://placeimg.com/640/480/any" },
                    { 7, "Clothing", "Unde assumenda reiciendis.", "https://placeimg.com/640/480/any" },
                    { 3, "Home", "Eligendi doloribus sequi.", "https://placeimg.com/640/480/any" },
                    { 9, "Movies", @"Ipsa quae consequatur molestiae occaecati suscipit dolorem nam.
                Nihil quis nostrum et aliquam sint suscipit veniam modi.
                Saepe illo minima vel non et esse.
                Quos animi animi totam consectetur eos ea.
                Quisquam ut ratione.
                Non non tenetur.", "https://placeimg.com/640/480/any" },
                    { 10, "Tools", "in", "https://placeimg.com/640/480/any" },
                    { 11, "Industrial", "Perspiciatis qui in aperiam. Alias fuga nobis. Quis et quaerat ratione. Delectus corrupti doloribus nemo et quam sequi a ipsum non.", "https://placeimg.com/640/480/any" },
                    { 12, "Kids", "qui", "https://placeimg.com/640/480/any" },
                    { 13, "Computers", "qui", "https://placeimg.com/640/480/any" },
                    { 8, "Music", "Enim veniam quos ex dolorem nesciunt dolore tempore nam.", "https://placeimg.com/640/480/any" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 16, "North", "Claudinefort", "Lakin, Hudson and Mante", "Edwin Kihn", "District Quality Developer", "Mayotte", "Edwin58", "462.239.4802", "46843", "Alaska" },
                    { 17, "Northwest", "East Rosalindaborough", "Bernier, Kub and Kreiger", "Rhonda Thompson", "Senior Assurance Orchestrator", "Italy", "Rhonda_Thompson", "(952) 333-4527", "07035", "Delaware" },
                    { 18, "West", "Vladimirmouth", "Boehm, Schmeler and Cruickshank", "Lucas Gerlach", "Future Implementation Strategist", "Mozambique", "Lucas7", "269-662-7050 x018", "49690", "Tennessee" },
                    { 19, "Northeast", "South Kamronstad", "Swift Group", "Russell Dach", "Forward Optimization Director", "Malta", "Russell.Dach86", "547.296.0039", "13942", "Maine" },
                    { 20, "South", "Owentown", "Barrows LLC", "Evelyn Robel", "Chief Operations Representative", "Maldives", "Evelyn13", "939.425.0488 x27938", "76148-5649", "Maine" },
                    { 23, "South", "Bergefort", "Huels, Kuhn and Abbott", "Willie Aufderhar", "Product Communications Analyst", "Albania", "Willie.Aufderhar", "810.981.7191 x57523", "63240-2148", "Arkansas" },
                    { 22, "Southwest", "Grantbury", "Buckridge, Bernhard and King", "Claude Kozey", "Internal Metrics Liaison", "Latvia", "Claude_Kozey83", "1-468-956-4214 x24033", "45504-5844", "Minnesota" },
                    { 24, "East", "Lake Guiseppefort", "Berge - Deckow", "Ashley Kling", "Global Data Architect", "Cuba", "Ashley.Kling", "(253) 554-6157 x91366", "91627-0792", "Maryland" },
                    { 25, "East", "Ulisesville", "Osinski - Ebert", "Katie Rice", "Legacy Security Developer", "Palestinian Territory", "Katie.Rice", "702.896.7693 x42878", "06302-7937", "Minnesota" },
                    { 15, "Southwest", "Champlinton", "Schaefer - Sawayn", "Domingo Tremblay", "International Directives Administrator", "Germany", "Domingo31", "1-564-464-3390 x6524", "24524", "Virginia" },
                    { 21, "East", "New Sidhaven", "Kuhn - Lind", "Gordon Heaney", "Legacy Factors Developer", "Zimbabwe", "Gordon.Heaney74", "263.734.9936", "97859", "Colorado" },
                    { 14, "Northeast", "Torpshire", "Koch - Flatley", "Audrey Koelpin", "Senior Assurance Consultant", "Saint Lucia", "Audrey_Koelpin12", "(335) 325-6379", "14104", "Minnesota" },
                    { 10, "Northwest", "New Macland", "O'Connell - Friesen", "Gene Buckridge", "Dynamic Communications Specialist", "Saudi Arabia", "Gene.Buckridge89", "587.784.2216 x5826", "89811", "Oregon" },
                    { 12, "Northwest", "Beahanchester", "Klocko and Sons", "Maxine Anderson", "Product Integration Liaison", "Sri Lanka", "Maxine.Anderson60", "830-558-3438", "40601-2605", "Virginia" },
                    { 13, "Southwest", "Angelburgh", "Nienow - Bins", "Misty Gislason", "Forward Communications Representative", "Lao People's Democratic Republic", "Misty94", "926.678.5506 x131", "42633-9642", "Delaware" },
                    { 2, "Southwest", "North Jack", "Harvey Group", "Fernando Parker", "Regional Brand Consultant", "Ethiopia", "Fernando_Parker7", "1-573-523-6005", "52761", "Alaska" },
                    { 3, "East", "South Ned", "Lowe - Grant", "Irene Weissnat", "Central Interactions Strategist", "Cuba", "Irene_Weissnat", "202.811.1991 x07988", "05454", "Colorado" },
                    { 4, "West", "Williamsonside", "Abshire - Koch", "Lila Konopelski", "Investor Program Coordinator", "Moldova", "Lila.Konopelski", "541.268.0138 x67404", "85667-7613", "Alaska" },
                    { 5, "Northwest", "Turcotteview", "Berge, Sawayn and Rolfson", "Toby White", "Customer Assurance Producer", "Israel", "Toby53", "510-966-9882", "96376", "Oregon" },
                    { 1, "Northwest", "West Ovahaven", "Kuhlman - Bergnaum", "Laverne Boehm", "Corporate Assurance Orchestrator", "Kazakhstan", "Laverne.Boehm", "(390) 865-0716 x402", "82350-4768", "New Mexico" },
                    { 7, "East", "Towneberg", "Abshire and Sons", "Cameron Mante", "Customer Factors Planner", "Romania", "Cameron_Mante", "728.944.5858 x064", "08654-3379", "Colorado" },
                    { 8, "North", "Lake Emmanuelbury", "Hahn, Goyette and Homenick", "Clay Rolfson", "Global Marketing Strategist", "Netherlands", "Clay42", "1-599-808-9347 x0321", "72578", "New Jersey" },
                    { 9, "East", "Tobinstad", "Romaguera - Weimann", "Antonia Gutkowski", "Product Security Officer", "Sudan", "Antonia41", "498.930.7221", "69901-9546", "Ohio" },
                    { 11, "East", "Jonatanfurt", "Hoppe, Hintz and Harvey", "Irvin Gibson", "Customer Quality Technician", "Guyana", "Irvin_Gibson46", "(895) 641-1616", "22062-8163", "Washington" },
                    { 6, "East", "South Emory", "Block - Rowe", "Ray Veum", "National Operations Analyst", "Italy", "Ray53", "591-902-1058", "05699", "Washington" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "BirthDate", "City", "Country", "Extension", "FirstName", "HireDate", "HomePhone", "LastName", "Notes", "Photo", "PostalCode", "Region", "ReportsTo", "Title", "TitleOfCourtesy" },
                values: new object[,]
                {
                    { 28, "West", new DateTime(1958, 7, 3, 17, 45, 11, 673, DateTimeKind.Local).AddTicks(9938), "Leannamouth", "Indonesia", 304, "Kelvin", new DateTime(2020, 8, 23, 19, 24, 33, 383, DateTimeKind.Local).AddTicks(9765), "1-994-545-9020 x3158", "Morissette", @"Quo nulla ea repudiandae.
                Cupiditate odio sunt facilis blanditiis illo iusto est quia.
                Deleniti eum exercitationem necessitatibus similique placeat quam enim.
                Reprehenderit quam ipsam nobis praesentium esse aut dolor.", "https://placeimg.com/640/480/any", "48597-9398", "Tennessee", "Kelvin Morissette", "Principal Applications Architect", "Kelvin_Morissette75" },
                    { 37, "Northeast", new DateTime(1960, 11, 1, 1, 54, 19, 733, DateTimeKind.Local).AddTicks(1721), "New Marley", "Jersey", 591, "Jerome", new DateTime(2020, 8, 23, 21, 16, 50, 144, DateTimeKind.Local).AddTicks(5296), "(711) 651-0304 x853", "Schiller", @"Corporis eos et et accusamus et rerum et.
                Quae ipsa distinctio velit sit voluptas quis repellendus.
                Perspiciatis voluptatem libero ea eum tempora voluptatem est.
                Dolor ipsa eaque libero quaerat sequi facilis quis.
                Facilis libero id et facere harum ex.", "https://placeimg.com/640/480/any", "44611", "California", "Jerome Schiller", "Senior Accountability Consultant", "Jerome0" },
                    { 29, "West", new DateTime(1980, 4, 5, 21, 6, 50, 82, DateTimeKind.Local).AddTicks(380), "Elizamouth", "Montserrat", 419, "Beth", new DateTime(2020, 8, 23, 16, 53, 44, 48, DateTimeKind.Local).AddTicks(7915), "(944) 612-9133 x833", "Shanahan", @"Harum itaque dolores possimus sit reiciendis ut non ab ullam.
                Molestiae eum nobis et est explicabo commodi est tempora quae.
                Porro soluta consequatur totam.
                Ut voluptas reiciendis dicta.", "https://placeimg.com/640/480/any", "87664", "North Dakota", "Beth Shanahan", "Legacy Optimization Technician", "Beth.Shanahan0" },
                    { 30, "North", new DateTime(1977, 9, 7, 3, 21, 54, 182, DateTimeKind.Local).AddTicks(7427), "New Kaitlyn", "Greenland", 432, "Jimmy", new DateTime(2020, 8, 24, 5, 2, 42, 804, DateTimeKind.Local).AddTicks(8927), "(979) 751-9078 x19128", "Connelly", @"Excepturi quis sunt nemo.
                Velit sed aspernatur ut sit iure tempore molestias.
                Harum nihil natus saepe molestias cumque aspernatur vel accusantium.
                Quia natus atque eum ducimus odit possimus mollitia.", "https://placeimg.com/640/480/any", "38075", "Georgia", "Jimmy Connelly", "Product Directives Assistant", "Jimmy.Connelly41" },
                    { 31, "Northeast", new DateTime(1996, 12, 3, 11, 11, 19, 529, DateTimeKind.Local).AddTicks(5333), "Marcelinaton", "Honduras", 790, "Claire", new DateTime(2020, 8, 24, 3, 55, 57, 963, DateTimeKind.Local).AddTicks(3348), "784.437.3145", "Huels", @"Eos vero iste est pariatur.
                Sed aut accusamus.
                Et nostrum iste commodi doloremque.
                Quo numquam quo et commodi cupiditate eos nesciunt sed itaque.
                In eum aspernatur.", "https://placeimg.com/640/480/any", "12509", "Alabama", "Claire Huels", "Principal Integration Specialist", "Claire98" },
                    { 32, "Northwest", new DateTime(1958, 8, 6, 2, 0, 59, 879, DateTimeKind.Local).AddTicks(5771), "South Skye", "Saint Martin", 704, "Ronnie", new DateTime(2020, 8, 24, 2, 30, 0, 892, DateTimeKind.Local).AddTicks(7037), "1-458-519-4889 x0619", "Jacobson", @"Qui cupiditate voluptas ex.
                Expedita quasi officiis rerum.
                Laboriosam officia labore ipsum minima a facilis accusamus.", "https://placeimg.com/640/480/any", "83762-1643", "Vermont", "Ronnie Jacobson", "Forward Markets Administrator", "Ronnie52" },
                    { 33, "Southeast", new DateTime(1956, 11, 16, 7, 39, 44, 609, DateTimeKind.Local).AddTicks(1810), "East Monserrat", "Bhutan", 526, "Kurt", new DateTime(2020, 8, 24, 11, 44, 28, 59, DateTimeKind.Local).AddTicks(4917), "291-512-1789 x4301", "Feil", "Minus deserunt maxime pariatur.", "https://placeimg.com/640/480/any", "57368-9199", "Florida", "Kurt Feil", "Investor Data Supervisor", "Kurt.Feil51" },
                    { 34, "Northwest", new DateTime(1969, 4, 28, 8, 46, 5, 2, DateTimeKind.Local).AddTicks(1903), "Lake Jaymestad", "American Samoa", 599, "Jesse", new DateTime(2020, 8, 24, 11, 38, 29, 853, DateTimeKind.Local).AddTicks(2217), "(998) 267-7907", "Bahringer", @"Asperiores aut reiciendis earum voluptates exercitationem accusantium commodi modi.
                Voluptates natus labore sed omnis ab quasi laborum.", "https://placeimg.com/640/480/any", "19667", "Ohio", "Jesse Bahringer", "Future Intranet Strategist", "Jesse4" },
                    { 35, "Southwest", new DateTime(1971, 12, 30, 0, 46, 52, 647, DateTimeKind.Local).AddTicks(9222), "West Gregburgh", "Cyprus", 456, "Traci", new DateTime(2020, 8, 23, 13, 27, 39, 548, DateTimeKind.Local).AddTicks(8554), "555-544-7069", "Bartoletti", @"Illo incidunt fugit quas sed nulla qui.
                Ipsum porro magnam.
                Assumenda fugit neque tempora aut enim ab quia labore.
                Qui numquam aut aliquam sint debitis officia cupiditate officiis.
                Et odio blanditiis hic ut.", "https://placeimg.com/640/480/any", "13680-6167", "Kansas", "Traci Bartoletti", "Product Infrastructure Executive", "Traci.Bartoletti" },
                    { 36, "West", new DateTime(1968, 4, 14, 19, 21, 40, 339, DateTimeKind.Local).AddTicks(5183), "West Ewell", "Lao People's Democratic Republic", 214, "Adrienne", new DateTime(2020, 8, 24, 2, 47, 45, 752, DateTimeKind.Local).AddTicks(9088), "546-368-7281 x3293", "Hamill", "Non rem quam sequi vitae et modi est quaerat sint.", "https://placeimg.com/640/480/any", "91381-4532", "Georgia", "Adrienne Hamill", "Regional Interactions Manager", "Adrienne40" },
                    { 38, "Northwest", new DateTime(1961, 6, 21, 15, 20, 13, 435, DateTimeKind.Local).AddTicks(9927), "Eddton", "Burkina Faso", 549, "Moses", new DateTime(2020, 8, 24, 10, 16, 35, 20, DateTimeKind.Local).AddTicks(6976), "(309) 423-9071 x2750", "Hagenes", @"Ut facilis voluptate rerum incidunt et molestiae magni aperiam.
                Sint qui nihil eveniet maxime est consequatur porro quisquam.
                Omnis minima nihil in et vel vel.
                Id consequatur ea est assumenda et fugiat quos qui quam.
                Quam itaque delectus necessitatibus blanditiis dignissimos.", "https://placeimg.com/640/480/any", "58459-8322", "West Virginia", "Moses Hagenes", "Chief Creative Supervisor", "Moses_Hagenes" },
                    { 44, "West", new DateTime(1958, 2, 2, 15, 33, 46, 848, DateTimeKind.Local).AddTicks(8055), "Marianahaven", "Niger", 945, "Eleanor", new DateTime(2020, 8, 23, 21, 11, 7, 203, DateTimeKind.Local).AddTicks(4852), "768.435.0464 x88596", "Emard", @"Ipsam debitis error nobis.
                Illo voluptate maxime quam rerum labore maiores sunt maiores.", "https://placeimg.com/640/480/any", "47121", "Alaska", "Eleanor Emard", "Corporate Configuration Specialist", "Eleanor.Emard" },
                    { 40, "Northeast", new DateTime(1968, 10, 20, 5, 27, 34, 661, DateTimeKind.Local).AddTicks(9915), "Julienberg", "Ukraine", 81, "Marc", new DateTime(2020, 8, 23, 15, 18, 23, 409, DateTimeKind.Local).AddTicks(2139), "1-802-660-4239", "Emmerich", "Tenetur odio est nemo aliquam odio explicabo omnis.", "https://placeimg.com/640/480/any", "24304", "Illinois", "Marc Emmerich", "Corporate Response Coordinator", "Marc_Emmerich" },
                    { 41, "West", new DateTime(1991, 4, 3, 20, 59, 40, 456, DateTimeKind.Local).AddTicks(7008), "Schmittview", "Tonga", 173, "Guy", new DateTime(2020, 8, 23, 23, 57, 14, 780, DateTimeKind.Local).AddTicks(2405), "(461) 629-1450", "Satterfield", @"Suscipit impedit iste inventore aut debitis rerum.
                Est sapiente veritatis aut expedita tempora.
                Molestiae quo laboriosam nobis.", "https://placeimg.com/640/480/any", "02101-1748", "Ohio", "Guy Satterfield", "International Program Coordinator", "Guy.Satterfield" },
                    { 42, "West", new DateTime(1975, 4, 28, 18, 28, 52, 239, DateTimeKind.Local).AddTicks(8344), "North Justyntown", "Grenada", 202, "Francis", new DateTime(2020, 8, 23, 13, 46, 6, 970, DateTimeKind.Local).AddTicks(3569), "(874) 441-8041 x3551", "Heaney", @"Sint qui culpa amet ut nesciunt.
                Id delectus error quisquam.
                Earum praesentium sit sint placeat odio dolores.
                Et enim unde qui.", "https://placeimg.com/640/480/any", "73558-9031", "Colorado", "Francis Heaney", "Dynamic Web Producer", "Francis.Heaney2" },
                    { 43, "West", new DateTime(1962, 3, 29, 5, 6, 2, 869, DateTimeKind.Local).AddTicks(8390), "New Mafalda", "Virgin Islands, British", 747, "Katherine", new DateTime(2020, 8, 24, 11, 5, 59, 645, DateTimeKind.Local).AddTicks(4404), "1-589-676-8385 x086", "Zemlak", @"Accusamus sed impedit est.
                Est mollitia aut ut.
                Tenetur id ut placeat aspernatur impedit.", "https://placeimg.com/640/480/any", "85306", "North Carolina", "Katherine Zemlak", "Central Accounts Supervisor", "Katherine_Zemlak" },
                    { 45, "Northwest", new DateTime(1998, 8, 7, 16, 44, 57, 965, DateTimeKind.Local).AddTicks(493), "New Jesschester", "Austria", 575, "Olivia", new DateTime(2020, 8, 24, 7, 48, 20, 58, DateTimeKind.Local).AddTicks(3640), "869-457-0177", "Rodriguez", @"Repellat molestiae ex ea ducimus ea amet hic accusamus.
                Quisquam molestias vitae exercitationem ut modi sunt nihil harum.", "https://placeimg.com/640/480/any", "43617", "Alaska", "Olivia Rodriguez", "Product Integration Manager", "Olivia.Rodriguez" },
                    { 46, "North", new DateTime(1989, 11, 12, 15, 4, 38, 742, DateTimeKind.Local).AddTicks(918), "Lake Liliana", "Israel", 479, "Nina", new DateTime(2020, 8, 24, 3, 40, 46, 756, DateTimeKind.Local).AddTicks(948), "523-238-0110", "Jerde", "Soluta distinctio eaque numquam aut velit nemo.", "https://placeimg.com/640/480/any", "57632-2753", "Kansas", "Nina Jerde", "Central Data Assistant", "Nina.Jerde" },
                    { 47, "Northeast", new DateTime(1992, 5, 29, 17, 26, 56, 429, DateTimeKind.Local).AddTicks(3864), "South Kelsie", "Indonesia", 805, "Perry", new DateTime(2020, 8, 23, 12, 28, 2, 19, DateTimeKind.Local).AddTicks(9119), "1-293-904-3631 x161", "Willms", @"Quia dolores veritatis commodi mollitia ex quae aut ullam.
                Vitae ea iure vel.
                Vitae molestiae incidunt deleniti illo quia eius.
                Repellendus dolor modi eligendi expedita.
                Doloribus praesentium ut et sed.", "https://placeimg.com/640/480/any", "43431", "Alabama", "Perry Willms", "Principal Web Manager", "Perry.Willms" },
                    { 48, "Southwest", new DateTime(1971, 8, 23, 12, 2, 32, 102, DateTimeKind.Local).AddTicks(9736), "Lake Concepcion", "Macao", 782, "Richard", new DateTime(2020, 8, 24, 1, 36, 28, 968, DateTimeKind.Local).AddTicks(516), "353-306-2481 x56187", "Gaylord", @"Quaerat molestias quod distinctio quae reprehenderit magni delectus deleniti atque.
                Eligendi aut unde aut.
                Perferendis quo quis quasi explicabo quaerat repudiandae rerum.", "https://placeimg.com/640/480/any", "39166-7542", "Illinois", "Richard Gaylord", "Product Quality Officer", "Richard.Gaylord74" },
                    { 49, "North", new DateTime(1999, 10, 7, 11, 44, 59, 886, DateTimeKind.Local).AddTicks(8978), "East Eleanoraton", "Paraguay", 75, "Natalie", new DateTime(2020, 8, 24, 3, 45, 29, 144, DateTimeKind.Local).AddTicks(1193), "941-256-3051 x00816", "Hauck", @"Adipisci porro sint.
                Corrupti velit quibusdam consequatur amet mollitia.", "https://placeimg.com/640/480/any", "30439", "Texas", "Natalie Hauck", "Internal Brand Strategist", "Natalie.Hauck" },
                    { 50, "East", new DateTime(1952, 3, 28, 23, 55, 59, 378, DateTimeKind.Local).AddTicks(8630), "Alexanderstad", "Algeria", 161, "Beth", new DateTime(2020, 8, 24, 10, 49, 44, 184, DateTimeKind.Local).AddTicks(2673), "1-562-845-3424 x77669", "Kilback", @"Sapiente necessitatibus ut.
                Et voluptate eum.", "https://placeimg.com/640/480/any", "54068-0795", "Alabama", "Beth Kilback", "Global Assurance Executive", "Beth81" },
                    { 27, "East", new DateTime(1959, 7, 3, 0, 49, 52, 402, DateTimeKind.Local).AddTicks(2688), "Helenetown", "France", 852, "Johnnie", new DateTime(2020, 8, 24, 11, 19, 19, 784, DateTimeKind.Local).AddTicks(2366), "848.641.1320 x2971", "Quitzon", @"Asperiores in ut autem porro laborum et consequatur repellendus.
                Labore quae id fuga sint et maxime nisi ipsa.
                Dolores ratione quisquam voluptatem harum quis ex vel velit consequatur.
                Ut consequatur libero sit quo hic tempora architecto velit optio.", "https://placeimg.com/640/480/any", "06907", "New Mexico", "Johnnie Quitzon", "Central Intranet Engineer", "Johnnie_Quitzon" },
                    { 39, "West", new DateTime(1981, 3, 2, 7, 38, 21, 669, DateTimeKind.Local).AddTicks(1199), "Larsonborough", "Uzbekistan", 864, "Claude", new DateTime(2020, 8, 23, 15, 37, 16, 552, DateTimeKind.Local).AddTicks(939), "(329) 723-1172 x93683", "Leffler", @"Earum ut delectus quam ipsam.
                Et voluptatem consequatur magni similique et voluptatem eaque ut.
                Maxime sunt rem illum unde veniam quo.
                Error nulla molestiae assumenda sint deserunt.
                Sed natus perferendis.", "https://placeimg.com/640/480/any", "58488", "New Mexico", "Claude Leffler", "Internal Applications Officer", "Claude46" },
                    { 26, "South", new DateTime(1958, 2, 1, 12, 11, 5, 192, DateTimeKind.Local).AddTicks(4060), "Kirlinbury", "Samoa", 299, "Jesse", new DateTime(2020, 8, 24, 10, 36, 18, 256, DateTimeKind.Local).AddTicks(1593), "762-605-3240 x4620", "Gulgowski", @"Cupiditate ab voluptas alias omnis sequi velit facilis totam necessitatibus.
                Voluptatem voluptas in placeat.", "https://placeimg.com/640/480/any", "85338-3732", "Kansas", "Jesse Gulgowski", "Investor Solutions Architect", "Jesse.Gulgowski" },
                    { 23, "South", new DateTime(1974, 3, 9, 10, 47, 50, 209, DateTimeKind.Local).AddTicks(6236), "New Alvatown", "Chad", 136, "Olga", new DateTime(2020, 8, 24, 9, 38, 55, 425, DateTimeKind.Local).AddTicks(197), "(467) 680-7292", "Corkery", "Illo minima aliquid.", "https://placeimg.com/640/480/any", "77219-9480", "Maine", "Olga Corkery", "Customer Usability Agent", "Olga65" },
                    { 24, "West", new DateTime(1963, 4, 9, 15, 46, 42, 895, DateTimeKind.Local).AddTicks(1312), "East Hector", "Mongolia", 438, "Lisa", new DateTime(2020, 8, 23, 23, 32, 20, 741, DateTimeKind.Local).AddTicks(743), "1-708-300-6452 x0497", "Boyer", @"Nulla voluptatem temporibus voluptate et et eum incidunt.
                Numquam eveniet velit illum molestiae.
                Aut qui in.
                Pariatur possimus id fuga dolores.", "https://placeimg.com/640/480/any", "75823", "Colorado", "Lisa Boyer", "Legacy Communications Designer", "Lisa.Boyer" },
                    { 25, "Northeast", new DateTime(1968, 4, 29, 2, 47, 16, 619, DateTimeKind.Local).AddTicks(7322), "Waldobury", "Gibraltar", 295, "Kenny", new DateTime(2020, 8, 24, 0, 19, 36, 442, DateTimeKind.Local).AddTicks(3933), "(683) 599-7965", "Brakus", @"Quasi ducimus cupiditate autem beatae.
                Rerum omnis aut nesciunt cupiditate dicta adipisci magni.
                Beatae in non repellendus officia sed.", "https://placeimg.com/640/480/any", "81546-5145", "Alabama", "Kenny Brakus", "Chief Solutions Producer", "Kenny81" },
                    { 1, "Southeast", new DateTime(1974, 1, 7, 1, 45, 53, 433, DateTimeKind.Local).AddTicks(9204), "Schoenport", "Bosnia and Herzegovina", 700, "Mary", new DateTime(2020, 8, 23, 23, 37, 4, 22, DateTimeKind.Local).AddTicks(1140), "(201) 434-1109", "Bartoletti", @"Nemo doloremque laudantium blanditiis aliquid modi rerum.
                Repellendus nostrum velit ut non quasi deleniti.
                Et natus nam facilis deleniti molestiae.
                Sit et impedit assumenda ipsa ut hic quas.", "https://placeimg.com/640/480/any", "46624-3188", "Vermont", "Mary Bartoletti", "Central Accounts Representative", "Mary70" },
                    { 2, "Southeast", new DateTime(1973, 10, 29, 4, 38, 52, 435, DateTimeKind.Local).AddTicks(4141), "South Vanport", "Saint Lucia", 433, "Randall", new DateTime(2020, 8, 24, 7, 28, 8, 652, DateTimeKind.Local).AddTicks(5181), "847.973.7637 x49380", "Wuckert", @"Voluptas illo molestias harum voluptatem est dolorem reiciendis sequi aliquam.
                Illum sit non.", "https://placeimg.com/640/480/any", "34162", "Idaho", "Randall Wuckert", "Forward Mobility Manager", "Randall_Wuckert48" },
                    { 3, "East", new DateTime(1967, 3, 26, 0, 37, 24, 705, DateTimeKind.Local).AddTicks(8613), "Wilfordhaven", "Bangladesh", 362, "Matthew", new DateTime(2020, 8, 23, 14, 1, 3, 64, DateTimeKind.Local).AddTicks(5431), "1-586-911-7350 x079", "Schneider", @"Eius vel et fugiat illo rerum consequatur harum odio optio.
                Atque blanditiis porro id.
                Ad modi eius consequatur eos perspiciatis fuga perspiciatis nostrum libero.
                Exercitationem distinctio iusto occaecati id ratione soluta omnis veritatis qui.
                Pariatur accusamus libero dolore blanditiis ut molestiae.", "https://placeimg.com/640/480/any", "26817-5798", "North Dakota", "Matthew Schneider", "Dynamic Brand Designer", "Matthew17" },
                    { 4, "West", new DateTime(1963, 6, 7, 23, 17, 8, 705, DateTimeKind.Local).AddTicks(6997), "West Coleman", "Kyrgyz Republic", 98, "Marsha", new DateTime(2020, 8, 23, 12, 53, 36, 745, DateTimeKind.Local).AddTicks(2946), "(879) 211-6691 x29638", "Wisozk", @"Rerum distinctio at quas velit molestiae eaque et quo.
                Dolorem eos cupiditate.
                Ut occaecati illum commodi error ut aliquam numquam qui ex.
                Rem ut est sit porro maxime deserunt id iure quo.", "https://placeimg.com/640/480/any", "03317", "Massachusetts", "Marsha Wisozk", "National Brand Consultant", "Marsha17" },
                    { 6, "East", new DateTime(1956, 3, 15, 10, 7, 33, 190, DateTimeKind.Local).AddTicks(2765), "South Novella", "Virgin Islands, U.S.", 104, "Stacey", new DateTime(2020, 8, 24, 2, 15, 6, 298, DateTimeKind.Local).AddTicks(9197), "1-974-490-2150", "Cummerata", "Ea sunt sapiente atque consequatur temporibus unde qui cum.", "https://placeimg.com/640/480/any", "22767-2281", "North Carolina", "Stacey Cummerata", "Global Mobility Director", "Stacey2" },
                    { 7, "Southeast", new DateTime(1952, 2, 21, 13, 51, 8, 438, DateTimeKind.Local).AddTicks(7269), "Port Kavonchester", "New Caledonia", 6, "Harvey", new DateTime(2020, 8, 24, 2, 36, 52, 942, DateTimeKind.Local).AddTicks(2109), "312-744-6954", "Steuber", "Rem aspernatur minus unde asperiores quam dolorum.", "https://placeimg.com/640/480/any", "75873", "Wisconsin", "Harvey Steuber", "Corporate Factors Assistant", "Harvey.Steuber" },
                    { 8, "Southwest", new DateTime(1994, 4, 14, 22, 46, 8, 393, DateTimeKind.Local).AddTicks(7919), "East Melbaview", "Saint Vincent and the Grenadines", 174, "Roland", new DateTime(2020, 8, 23, 12, 26, 50, 42, DateTimeKind.Local).AddTicks(1651), "(819) 577-7934", "Goldner", @"Ea rerum neque.
                Autem rerum consectetur enim.
                Ut atque quo tempore vitae id consectetur deleniti ratione.", "https://placeimg.com/640/480/any", "53509-5154", "Illinois", "Roland Goldner", "Forward Group Producer", "Roland_Goldner" },
                    { 9, "Southeast", new DateTime(1988, 6, 9, 11, 33, 42, 390, DateTimeKind.Local).AddTicks(3457), "Lake Grace", "Mayotte", 193, "Levi", new DateTime(2020, 8, 23, 23, 43, 22, 178, DateTimeKind.Local).AddTicks(6131), "902-552-0237", "Labadie", @"Hic dolore ut commodi velit consequatur nesciunt sit ipsam perferendis.
                Aut nobis et voluptas officia.
                Quaerat placeat doloribus sit nihil odio est.
                Quos suscipit fuga reiciendis aperiam corporis ea et sit.", "https://placeimg.com/640/480/any", "31495-0199", "Colorado", "Levi Labadie", "Senior Communications Executive", "Levi_Labadie9" },
                    { 10, "Southwest", new DateTime(1983, 1, 6, 10, 56, 39, 19, DateTimeKind.Local).AddTicks(1982), "Baileyview", "Swaziland", 881, "Sandy", new DateTime(2020, 8, 23, 14, 26, 56, 947, DateTimeKind.Local).AddTicks(8641), "1-665-349-2234 x312", "Brown", @"Est inventore nihil quam ut ex omnis voluptatem ipsam.
                Dolore vel sapiente ipsa praesentium est itaque voluptas impedit officia.", "https://placeimg.com/640/480/any", "66512-6530", "Louisiana", "Sandy Brown", "Lead Data Executive", "Sandy_Brown58" },
                    { 11, "West", new DateTime(1992, 5, 15, 13, 24, 48, 383, DateTimeKind.Local).AddTicks(181), "Hackettside", "Micronesia", 17, "Louis", new DateTime(2020, 8, 24, 7, 16, 41, 408, DateTimeKind.Local).AddTicks(6569), "(777) 582-3355", "Koepp", @"At ullam dolores dolores voluptas quos sed.
                Eos ad debitis et omnis nihil sapiente.
                Modi voluptas quam odio et possimus nihil omnis ut quis.
                Neque culpa in sed officia consectetur.", "https://placeimg.com/640/480/any", "61685", "California", "Louis Koepp", "Human Communications Coordinator", "Louis.Koepp2" },
                    { 5, "Northeast", new DateTime(1975, 8, 2, 1, 17, 42, 153, DateTimeKind.Local).AddTicks(9928), "Tremblayshire", "Poland", 530, "Norman", new DateTime(2020, 8, 23, 13, 13, 11, 190, DateTimeKind.Local).AddTicks(9311), "1-365-982-5943 x76865", "Willms", @"Repudiandae eligendi dolorum.
                Praesentium distinctio earum.
                Qui non quo voluptate sit quia aut ut.
                Expedita quas eveniet at eaque reiciendis qui dolorum.
                Eaque qui voluptatum dolor nihil iusto aut.", "https://placeimg.com/640/480/any", "78396-2693", "Ohio", "Norman Willms", "International Operations Manager", "Norman_Willms" },
                    { 13, "Southeast", new DateTime(1953, 5, 18, 10, 28, 23, 38, DateTimeKind.Local).AddTicks(6273), "Vivianborough", "Ghana", 242, "Nick", new DateTime(2020, 8, 24, 8, 32, 17, 999, DateTimeKind.Local).AddTicks(4303), "237-730-1063", "Sanford", @"Nam omnis quisquam voluptas molestias voluptas.
                Vitae quis neque odio deserunt consectetur blanditiis excepturi magni.
                Architecto sed voluptatum ea quia.", "https://placeimg.com/640/480/any", "60643", "Missouri", "Nick Sanford", "National Creative Manager", "Nick_Sanford" },
                    { 12, "West", new DateTime(1995, 10, 10, 10, 32, 5, 362, DateTimeKind.Local).AddTicks(1077), "Lake Dylan", "Martinique", 363, "Regina", new DateTime(2020, 8, 23, 16, 11, 13, 95, DateTimeKind.Local).AddTicks(7238), "1-289-983-3312 x85266", "Fahey", @"Dolor consequatur sit occaecati ipsam et est nesciunt.
                Sunt quis est quia atque sit qui eos.", "https://placeimg.com/640/480/any", "62647-8239", "Vermont", "Regina Fahey", "Senior Operations Officer", "Regina.Fahey" },
                    { 22, "West", new DateTime(1992, 9, 16, 12, 6, 18, 854, DateTimeKind.Local).AddTicks(3730), "Lake Alden", "Antigua and Barbuda", 200, "Cassandra", new DateTime(2020, 8, 24, 3, 19, 1, 85, DateTimeKind.Local).AddTicks(9164), "(352) 765-7335 x706", "Lynch", "Nostrum id autem fugiat aut tempora optio sed.", "https://placeimg.com/640/480/any", "48159-2350", "South Dakota", "Cassandra Lynch", "Direct Research Consultant", "Cassandra_Lynch" },
                    { 21, "South", new DateTime(1992, 8, 5, 6, 24, 4, 910, DateTimeKind.Local).AddTicks(3367), "East Angie", "Vietnam", 609, "Jasmine", new DateTime(2020, 8, 24, 6, 2, 2, 574, DateTimeKind.Local).AddTicks(8755), "323-289-8496 x7014", "Langworth", @"Laudantium voluptate dolorem molestiae.
                Quidem odio et.
                Nihil quia voluptatem dolorem facere occaecati molestiae cumque.
                Harum consequatur delectus incidunt.", "https://placeimg.com/640/480/any", "62569-7626", "North Carolina", "Jasmine Langworth", "Chief Communications Planner", "Jasmine.Langworth76" },
                    { 19, "Southwest", new DateTime(1964, 5, 8, 10, 38, 41, 956, DateTimeKind.Local).AddTicks(5193), "Justenshire", "Chad", 670, "Paulette", new DateTime(2020, 8, 23, 16, 46, 56, 40, DateTimeKind.Local).AddTicks(6760), "852-256-7705 x8254", "Heidenreich", @"Unde earum unde nihil laborum sapiente.
                Explicabo dolor natus natus dolor cupiditate laborum eveniet.
                Itaque aut autem quasi fugiat.", "https://placeimg.com/640/480/any", "32505-4267", "Massachusetts", "Paulette Heidenreich", "Corporate Security Architect", "Paulette35" },
                    { 20, "East", new DateTime(1966, 3, 7, 15, 44, 2, 821, DateTimeKind.Local).AddTicks(6206), "Gerlachtown", "Djibouti", 471, "Peter", new DateTime(2020, 8, 24, 2, 45, 40, 294, DateTimeKind.Local).AddTicks(7114), "(851) 312-6240 x1532", "Aufderhar", @"Repellat molestiae a qui occaecati sint illum accusamus.
                Non consequatur accusantium aut.
                Cupiditate ut et ratione maiores ad voluptates atque est.
                Qui quia impedit quas atque impedit et exercitationem.
                Ut voluptatem consequatur excepturi temporibus eos labore iure libero.", "https://placeimg.com/640/480/any", "98636", "Nevada", "Peter Aufderhar", "Dynamic Intranet Officer", "Peter.Aufderhar42" },
                    { 17, "East", new DateTime(1990, 4, 9, 20, 18, 42, 553, DateTimeKind.Local).AddTicks(2153), "Lake Hillaryfurt", "Czech Republic", 609, "Marilyn", new DateTime(2020, 8, 24, 3, 5, 5, 150, DateTimeKind.Local).AddTicks(5692), "709.433.9681 x21524", "Yost", "Nihil ex harum reprehenderit dolorem similique et error sit.", "https://placeimg.com/640/480/any", "96991-9303", "Oklahoma", "Marilyn Yost", "Principal Program Liaison", "Marilyn_Yost35" },
                    { 16, "North", new DateTime(1995, 8, 4, 8, 16, 19, 349, DateTimeKind.Local).AddTicks(1929), "East Jovanburgh", "Tanzania", 970, "Susie", new DateTime(2020, 8, 24, 11, 15, 28, 335, DateTimeKind.Local).AddTicks(698), "832.661.0352 x442", "Fritsch", @"Tempora ut qui.
                Vel eaque quia quia id qui.", "https://placeimg.com/640/480/any", "53912-9521", "Hawaii", "Susie Fritsch", "Customer Applications Designer", "Susie33" },
                    { 15, "Southwest", new DateTime(1973, 9, 19, 13, 8, 13, 381, DateTimeKind.Local).AddTicks(1627), "Flatleyshire", "Burkina Faso", 391, "Clyde", new DateTime(2020, 8, 23, 12, 9, 41, 978, DateTimeKind.Local).AddTicks(7996), "300.504.6662 x52235", "Toy", @"Ab impedit rerum tempora libero aut odit.
                Distinctio quo animi.
                Sint hic corporis et minus aut maiores non voluptatem.
                Est modi non dolore ipsa distinctio saepe consectetur.", "https://placeimg.com/640/480/any", "46306-0756", "Wyoming", "Clyde Toy", "Lead Group Consultant", "Clyde.Toy" },
                    { 14, "Northeast", new DateTime(1988, 8, 3, 9, 49, 32, 594, DateTimeKind.Local).AddTicks(98), "Lake Kaleigh", "Antigua and Barbuda", 806, "Clayton", new DateTime(2020, 8, 23, 16, 33, 42, 342, DateTimeKind.Local).AddTicks(1863), "1-963-979-6015 x56861", "Walsh", @"Repellendus rem quaerat.
                Inventore voluptatem soluta quia voluptatibus neque saepe culpa minus voluptate.", "https://placeimg.com/640/480/any", "35960", "Utah", "Clayton Walsh", "Dynamic Operations Assistant", "Clayton20" },
                    { 18, "Northeast", new DateTime(1964, 2, 18, 4, 39, 46, 442, DateTimeKind.Local).AddTicks(9700), "New Gordonville", "Palestinian Territory", 887, "Sheldon", new DateTime(2020, 8, 23, 15, 30, 55, 149, DateTimeKind.Local).AddTicks(2418), "1-277-501-9456 x213", "Kulas", @"Hic voluptatem aut velit est qui.
                Quos dolores sapiente.
                Officiis error autem in vero nesciunt autem corrupti.
                Explicabo atque modi velit.
                Delectus dolorem dolorem dolores quo tenetur.", "https://placeimg.com/640/480/any", "02498", "Ohio", "Sheldon Kulas", "Future Assurance Supervisor", "Sheldon.Kulas" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ShipperId", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 30, "Williamson, Streich and Smitham", "(418) 282-4286 x88754" },
                    { 21, "D'Amore, Halvorson and Cassin", "828-787-1263 x996" },
                    { 18, "Adams - Wisoky", "612-645-2004" },
                    { 19, "Ortiz - Borer", "631-223-7673 x11980" },
                    { 20, "Schiller Group", "707-306-5825 x1811" },
                    { 22, "Balistreri, Hayes and Parker", "1-447-445-0559 x907" },
                    { 28, "Walter - White", "1-394-245-8421 x9996" },
                    { 24, "Beier - Swift", "278-322-1256" },
                    { 25, "Bahringer and Sons", "(243) 823-9702 x4137" },
                    { 26, "Runolfsdottir Inc", "1-298-474-9771 x3705" },
                    { 27, "Kling Inc", "885.402.0431 x83085" },
                    { 29, "Watsica Group", "(667) 431-7940 x52662" },
                    { 17, "Hackett, Carroll and Conn", "1-463-782-7734" },
                    { 23, "Wisozk, Hilpert and Bailey", "510.494.9425 x41182" },
                    { 16, "Rodriguez Group", "745.737.6765" },
                    { 13, "Zulauf - McKenzie", "610.275.4859 x4073" },
                    { 14, "Nienow - Collins", "(430) 973-3088" },
                    { 15, "Fisher, Schinner and Hansen", "1-572-728-4196 x23403" },
                    { 1, "Walter Inc", "656-475-9466" },
                    { 3, "Shields LLC", "289.385.7782" },
                    { 4, "Welch - Hand", "209.315.4420 x3424" },
                    { 5, "Stehr Inc", "339-898-0207 x95197" },
                    { 6, "Daugherty - Conroy", "(407) 769-8542" },
                    { 2, "Kuphal Inc", "887.957.7590 x3231" },
                    { 8, "Little, Sawayn and Von", "720-779-1117 x902" },
                    { 9, "Abshire - Rogahn", "951.531.9894" },
                    { 10, "Langosh, Bernier and Botsford", "1-975-305-2146" },
                    { 11, "Mohr Inc", "887-356-2323" },
                    { 12, "Gottlieb - Fahey", "560-468-1184 x76731" },
                    { 7, "McClure Group", "643-813-1884" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "HomePage", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 11, "South", "Oranburgh", "Cronin LLC", "Alex Hodkiewicz", "Legacy Creative Liaison", "British Indian Ocean Territory (Chagos Archipelago)", "Alex14", "angelica.org", "1-630-381-9650", "25037-9640", "Montana" },
                    { 18, "West", "Abbottberg", "Lowe Inc", "Kelly Jaskolski", "Central Markets Director", "Sudan", "Kelly95", "brady.biz", "(223) 556-8144", "30512", "West Virginia" },
                    { 17, "Northeast", "Maximilianburgh", "Corwin - Beier", "Ernest Heidenreich", "Future Intranet Officer", "Saint Barthelemy", "Ernest.Heidenreich21", "suzanne.biz", "415-359-1711 x705", "13331-1248", "Kansas" },
                    { 16, "Southeast", "Stokestown", "Lakin, Graham and Reichert", "Craig Kohler", "International Markets Director", "Saint Vincent and the Grenadines", "Craig_Kohler", "dawson.org", "400-615-2594 x247", "40371", "Minnesota" },
                    { 15, "Northeast", "Keelington", "Boyer, Lind and Weber", "Hector Kub", "Product Security Planner", "Pitcairn Islands", "Hector55", "ruby.net", "558.871.6242 x89210", "01777-4026", "Oklahoma" },
                    { 14, "North", "West Collinshire", "Jast Group", "Stuart Pollich", "Future Brand Orchestrator", "Cameroon", "Stuart_Pollich94", "princess.org", "1-332-737-9191", "66398", "Maryland" },
                    { 13, "Southwest", "Vandervortland", "Schmitt, Beatty and Fritsch", "Jon Prohaska", "Principal Paradigm Specialist", "United Arab Emirates", "Jon.Prohaska9", "liliane.org", "313.574.9853", "03625", "Illinois" },
                    { 12, "South", "Stokesside", "Purdy, Ortiz and Leffler", "Jordan Goodwin", "Human Web Architect", "Sweden", "Jordan.Goodwin91", "madilyn.name", "1-290-499-9437 x829", "64758-8123", "Kansas" },
                    { 10, "West", "Olinhaven", "Gorczany, Hamill and Kshlerin", "Camille Howe", "Global Program Developer", "Albania", "Camille67", "lamar.info", "1-631-368-0033 x100", "05853", "Colorado" },
                    { 3, "Northeast", "West Laronmouth", "Ullrich LLC", "Fred Schinner", "Dynamic Brand Planner", "Moldova", "Fred_Schinner67", "hillard.com", "736.766.9267 x1731", "52566", "South Dakota" },
                    { 8, "Northwest", "Wittingburgh", "Bernier - Deckow", "Ella Lindgren", "Principal Identity Associate", "Vanuatu", "Ella_Lindgren29", "nathen.com", "789.538.9808 x14703", "84137-8819", "New Jersey" },
                    { 7, "West", "Hyattview", "Kuphal Inc", "Homer Jacobs", "District Directives Consultant", "Syrian Arab Republic", "Homer73", "gabriella.name", "812-247-8277", "02920", "Virginia" },
                    { 6, "Southeast", "Raynorville", "Upton and Sons", "Dora Schowalter", "District Program Assistant", "Suriname", "Dora16", "lavina.com", "245.976.9720", "62960", "Ohio" },
                    { 5, "Northeast", "Mariamfort", "Kohler - Glover", "May Howe", "Human Optimization Technician", "Belize", "May_Howe", "trevor.org", "751.644.9681", "85213", "Rhode Island" },
                    { 4, "West", "Marshallbury", "Maggio, Altenwerth and Nicolas", "Jennie Kshlerin", "Future Operations Orchestrator", "Belgium", "Jennie.Kshlerin", "kayley.info", "283-889-7627", "97670-6953", "Nevada" },
                    { 2, "Southwest", "Sybleton", "Mann - Senger", "Loren Paucek", "Legacy Accountability Designer", "Gibraltar", "Loren.Paucek", "waldo.net", "923-328-3943", "35199-9451", "Nevada" },
                    { 1, "West", "Bauchview", "Ebert Inc", "Darren Pagac", "International Communications Assistant", "Afghanistan", "Darren_Pagac68", "aron.info", "334-892-8690 x149", "42998-5262", "Utah" },
                    { 19, "West", "Konopelskibury", "Hoppe, Marvin and Legros", "Jamie Roob", "International Integration Developer", "Democratic People's Republic of Korea", "Jamie19", "connie.name", "866.609.0427", "84287", "Virginia" },
                    { 9, "North", "West Rebeccashire", "Beier, Blanda and Sawayn", "Irving Conn", "District Factors Strategist", "Somalia", "Irving_Conn77", "skyla.com", "227-655-3107", "11305", "Illinois" },
                    { 20, "Northwest", "Jacobsonview", "Schaefer, Hagenes and Runolfsdottir", "Carolyn Weimann", "Investor Division Designer", "Costa Rica", "Carolyn_Weimann49", "douglas.net", "(646) 968-8362 x1213", "78667", "Hawaii" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "Freight", "OrderDate", "RequiredDate", "ShipAddress", "ShipCity", "ShipCountry", "ShipName", "ShipPostalCode", "ShipRegion", "ShipVia", "ShippedDate", "ShipperId" },
                values: new object[,]
                {
                    { 12, 23, 23, 5.0, new DateTime(2020, 8, 24, 9, 24, 58, 108, DateTimeKind.Local).AddTicks(1010), new DateTime(2020, 8, 25, 10, 37, 18, 391, DateTimeKind.Local).AddTicks(3055), "West", "Lake Forestmouth", "Svalbard & Jan Mayen Islands", "Lauren Wintheiser", "78367-0963", "Virginia", "Dibbert Street", new DateTime(2020, 8, 24, 11, 40, 35, 431, DateTimeKind.Local).AddTicks(7905), 8 },
                    { 6, 14, 49, 92.0, new DateTime(2020, 8, 23, 15, 29, 21, 553, DateTimeKind.Local).AddTicks(6235), new DateTime(2020, 8, 25, 1, 50, 8, 36, DateTimeKind.Local).AddTicks(5119), "Southeast", "East Leonel", "Zambia", "Miranda Hayes", "11861-3460", "Wyoming", "Jerod Stravenue", new DateTime(2020, 8, 24, 11, 23, 59, 494, DateTimeKind.Local).AddTicks(4236), 24 },
                    { 3, 17, 5, 88.0, new DateTime(2020, 8, 23, 16, 47, 5, 878, DateTimeKind.Local).AddTicks(8742), new DateTime(2020, 8, 24, 14, 17, 49, 117, DateTimeKind.Local).AddTicks(8014), "East", "South Golden", "Lithuania", "June Jakubowski", "26614", "Rhode Island", "Langosh Extensions", new DateTime(2020, 8, 24, 9, 31, 14, 552, DateTimeKind.Local).AddTicks(3566), 24 },
                    { 15, 10, 9, 59.0, new DateTime(2020, 8, 23, 13, 52, 48, 25, DateTimeKind.Local).AddTicks(167), new DateTime(2020, 8, 24, 23, 9, 30, 951, DateTimeKind.Local).AddTicks(7639), "North", "Weldonfurt", "Nicaragua", "Robert Kihn", "37292-8666", "Georgia", "Hermiston Flat", new DateTime(2020, 8, 24, 5, 59, 17, 239, DateTimeKind.Local).AddTicks(6155), 20 },
                    { 10, 11, 36, 93.0, new DateTime(2020, 8, 24, 2, 21, 37, 517, DateTimeKind.Local).AddTicks(6273), new DateTime(2020, 8, 25, 0, 56, 43, 280, DateTimeKind.Local).AddTicks(2848), "Northeast", "South Karianne", "Ecuador", "Shari Lowe", "51042", "Pennsylvania", "Weissnat Avenue", new DateTime(2020, 8, 24, 4, 45, 51, 24, DateTimeKind.Local).AddTicks(7481), 20 },
                    { 14, 6, 6, 55.0, new DateTime(2020, 8, 23, 12, 2, 27, 277, DateTimeKind.Local).AddTicks(9035), new DateTime(2020, 8, 24, 12, 12, 55, 420, DateTimeKind.Local).AddTicks(1870), "Southwest", "Reynoldsside", "Monaco", "Jamie Wilkinson", "71933", "Washington", "McLaughlin Village", new DateTime(2020, 8, 23, 13, 10, 6, 333, DateTimeKind.Local).AddTicks(2740), 19 },
                    { 13, 10, 2, 21.0, new DateTime(2020, 8, 23, 19, 3, 27, 903, DateTimeKind.Local).AddTicks(7133), new DateTime(2020, 8, 25, 8, 53, 44, 164, DateTimeKind.Local).AddTicks(8573), "West", "Adelleshire", "Gibraltar", "Crystal Keebler", "63621", "New Hampshire", "Keeling Lakes", new DateTime(2020, 8, 23, 17, 52, 52, 50, DateTimeKind.Local).AddTicks(3301), 19 },
                    { 1, 8, 9, 31.0, new DateTime(2020, 8, 24, 8, 13, 40, 80, DateTimeKind.Local).AddTicks(1572), new DateTime(2020, 8, 24, 16, 0, 3, 548, DateTimeKind.Local).AddTicks(4717), "Southwest", "Herthaside", "Republic of Korea", "Stuart Kulas", "95476-2075", "Idaho", "Dariana Square", new DateTime(2020, 8, 23, 18, 35, 41, 47, DateTimeKind.Local).AddTicks(5061), 19 },
                    { 8, 14, 42, 55.0, new DateTime(2020, 8, 23, 17, 12, 25, 470, DateTimeKind.Local).AddTicks(6773), new DateTime(2020, 8, 25, 0, 27, 31, 273, DateTimeKind.Local).AddTicks(907), "Southwest", "Adrianahaven", "Puerto Rico", "Fannie Wolf", "57286-0591", "Alaska", "Don Trail", new DateTime(2020, 8, 23, 12, 10, 28, 483, DateTimeKind.Local).AddTicks(2823), 16 },
                    { 7, 11, 34, 17.0, new DateTime(2020, 8, 23, 13, 15, 28, 383, DateTimeKind.Local).AddTicks(7227), new DateTime(2020, 8, 24, 14, 14, 14, 341, DateTimeKind.Local).AddTicks(1087), "Northwest", "East Gerardland", "Hong Kong", "Joanna McClure", "15071", "Maine", "Labadie Port", new DateTime(2020, 8, 23, 17, 38, 8, 642, DateTimeKind.Local).AddTicks(99), 16 },
                    { 9, 18, 17, 91.0, new DateTime(2020, 8, 23, 19, 21, 49, 896, DateTimeKind.Local).AddTicks(5568), new DateTime(2020, 8, 24, 14, 48, 25, 833, DateTimeKind.Local).AddTicks(464), "North", "Hayestown", "Nauru", "Gregg Cummings", "92265-0183", "Vermont", "Chris Manor", new DateTime(2020, 8, 23, 21, 16, 35, 645, DateTimeKind.Local).AddTicks(9383), 25 },
                    { 18, 12, 11, 92.0, new DateTime(2020, 8, 23, 20, 1, 31, 930, DateTimeKind.Local).AddTicks(6613), new DateTime(2020, 8, 24, 12, 27, 58, 602, DateTimeKind.Local).AddTicks(5815), "West", "Murazikhaven", "Egypt", "Nichole Hintz", "85986", "Vermont", "Marion Ville", new DateTime(2020, 8, 23, 17, 47, 25, 257, DateTimeKind.Local).AddTicks(3875), 15 },
                    { 2, 3, 31, 7.0, new DateTime(2020, 8, 23, 16, 35, 10, 570, DateTimeKind.Local).AddTicks(8060), new DateTime(2020, 8, 24, 15, 27, 13, 333, DateTimeKind.Local).AddTicks(615), "Northwest", "New Joannie", "Mongolia", "Troy Bode", "79634-8802", "Pennsylvania", "Mayert Estates", new DateTime(2020, 8, 23, 17, 43, 8, 621, DateTimeKind.Local).AddTicks(3753), 14 },
                    { 20, 6, 27, 0.0, new DateTime(2020, 8, 23, 20, 49, 32, 76, DateTimeKind.Local).AddTicks(4717), new DateTime(2020, 8, 25, 10, 7, 33, 169, DateTimeKind.Local).AddTicks(2764), "North", "Donbury", "Madagascar", "Amber Bednar", "64379-2140", "South Dakota", "Gorczany Shoals", new DateTime(2020, 8, 23, 12, 13, 30, 655, DateTimeKind.Local).AddTicks(2226), 13 },
                    { 11, 6, 19, 6.0, new DateTime(2020, 8, 24, 1, 12, 43, 475, DateTimeKind.Local).AddTicks(9153), new DateTime(2020, 8, 24, 12, 50, 47, 936, DateTimeKind.Local).AddTicks(1030), "North", "East Emilia", "Aruba", "Freda Cremin", "31412", "Indiana", "Vella Views", new DateTime(2020, 8, 24, 10, 36, 24, 367, DateTimeKind.Local).AddTicks(8435), 12 },
                    { 17, 3, 14, 14.0, new DateTime(2020, 8, 23, 17, 32, 10, 509, DateTimeKind.Local).AddTicks(1645), new DateTime(2020, 8, 24, 19, 37, 0, 247, DateTimeKind.Local).AddTicks(4664), "South", "South Clement", "Montserrat", "Trevor Boehm", "18356-4798", "Massachusetts", "Dena Pass", new DateTime(2020, 8, 23, 13, 12, 5, 339, DateTimeKind.Local).AddTicks(7384), 11 },
                    { 16, 8, 15, 85.0, new DateTime(2020, 8, 23, 15, 30, 48, 527, DateTimeKind.Local).AddTicks(9264), new DateTime(2020, 8, 25, 3, 29, 15, 458, DateTimeKind.Local).AddTicks(1286), "Northwest", "New Oran", "French Polynesia", "Jackie Osinski", "77331", "Delaware", "Bernhard Manor", new DateTime(2020, 8, 23, 12, 27, 30, 526, DateTimeKind.Local).AddTicks(9454), 10 },
                    { 5, 24, 20, 18.0, new DateTime(2020, 8, 24, 2, 14, 25, 541, DateTimeKind.Local).AddTicks(5466), new DateTime(2020, 8, 25, 1, 57, 10, 287, DateTimeKind.Local).AddTicks(6619), "Northwest", "New Palma", "Niger", "Edmond Kunde", "69096-0146", "Wisconsin", "McKenzie Island", new DateTime(2020, 8, 23, 15, 11, 2, 672, DateTimeKind.Local).AddTicks(2164), 9 },
                    { 4, 3, 50, 88.0, new DateTime(2020, 8, 24, 7, 21, 33, 434, DateTimeKind.Local).AddTicks(3792), new DateTime(2020, 8, 25, 11, 12, 40, 823, DateTimeKind.Local).AddTicks(2658), "North", "Lowellbury", "Tuvalu", "Sandy Deckow", "67565", "Texas", "Schulist Knolls", new DateTime(2020, 8, 24, 11, 10, 2, 118, DateTimeKind.Local).AddTicks(8787), 9 },
                    { 19, 6, 45, 50.0, new DateTime(2020, 8, 24, 8, 40, 6, 25, DateTimeKind.Local).AddTicks(8939), new DateTime(2020, 8, 25, 11, 2, 15, 202, DateTimeKind.Local).AddTicks(1308), "West", "Quitzonshire", "South Africa", "Mack Cummings", "15250-4167", "Delaware", "Molly Vista", new DateTime(2020, 8, 23, 20, 34, 3, 736, DateTimeKind.Local).AddTicks(5492), 15 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Discontinued", "ProductName", "QuantiryPerUnit", "ReorderLevel", "SupplierId", "UnitPrice", "UnitsInStock", "UnitsOnOrder" },
                values: new object[,]
                {
                    { 7, 8, true, "Refined Concrete Hat", 0, 2, 13, 284, 142, 0 },
                    { 10, 8, true, "Gorgeous Frozen Pants", 0, 7, 13, 563, 100, 0 },
                    { 17, 25, true, "Ergonomic Fresh Soap", 1, 6, 13, 602, 52, 0 },
                    { 8, 1, true, "Handmade Metal Cheese", 1, 8, 17, 839, 77, 0 },
                    { 3, 1, false, "Refined Wooden Ball", 1, 5, 16, 442, 7, 0 },
                    { 15, 13, true, "Small Cotton Shoes", 1, 10, 16, 407, 162, 0 },
                    { 1, 22, false, "Refined Frozen Chips", 0, 8, 12, 868, 191, 0 },
                    { 11, 25, false, "Sleek Cotton Bike", 1, 10, 14, 445, 63, 0 },
                    { 13, 3, false, "Intelligent Cotton Salad", 1, 9, 10, 806, 67, 0 },
                    { 16, 30, true, "Intelligent Plastic Chair", 0, 4, 6, 103, 99, 0 },
                    { 2, 9, false, "Licensed Rubber Car", 0, 1, 9, 860, 175, 0 },
                    { 9, 23, true, "Practical Rubber Pizza", 0, 5, 7, 353, 15, 0 },
                    { 19, 6, true, "Tasty Rubber Car", 1, 10, 5, 35, 151, 0 },
                    { 12, 19, false, "Fantastic Fresh Keyboard", 1, 9, 5, 283, 68, 0 },
                    { 6, 26, false, "Rustic Wooden Table", 1, 7, 4, 749, 142, 0 },
                    { 4, 20, false, "Practical Granite Salad", 0, 1, 4, 980, 21, 0 },
                    { 14, 12, true, "Incredible Soft Soap", 1, 8, 1, 62, 62, 0 },
                    { 20, 13, false, "Awesome Steel Car", 0, 10, 18, 204, 154, 0 },
                    { 5, 27, false, "Handmade Steel Fish", 0, 8, 10, 202, 0, 0 },
                    { 18, 2, false, "Tasty Plastic Bacon", 1, 8, 20, 817, 180, 0 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailsId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 20, 11, 14, 0, 727 },
                    { 8, 6, 10, 0, 328 },
                    { 4, 3, 10, 0, 394 },
                    { 16, 6, 2, 1, 960 },
                    { 9, 8, 2, 0, 716 },
                    { 2, 12, 2, 1, 604 },
                    { 19, 5, 16, 0, 798 },
                    { 13, 17, 16, 0, 707 },
                    { 18, 12, 19, 0, 68 },
                    { 17, 9, 19, 0, 982 },
                    { 10, 1, 19, 0, 952 },
                    { 7, 3, 19, 0, 764 },
                    { 15, 20, 12, 1, 175 },
                    { 14, 20, 12, 1, 116 },
                    { 12, 14, 6, 1, 930 },
                    { 3, 6, 6, 1, 537 },
                    { 11, 9, 4, 0, 746 },
                    { 6, 13, 4, 1, 501 },
                    { 1, 1, 17, 0, 85 },
                    { 5, 2, 17, 1, 931 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
