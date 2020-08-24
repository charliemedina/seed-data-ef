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
                    { 1, "Jewelery", @"Quia est molestias non.
                Praesentium non eaque assumenda sequi explicabo est quos.
                Quas repudiandae qui.
                Enim ut veniam natus pariatur voluptas.
                Optio voluptatem et et.
                Placeat et aut rerum autem minus recusandae aspernatur vel.", "https://placeimg.com/640/480/any" },
                    { 30, "Tools", @"Quia aut asperiores laudantium.
                Velit pariatur ratione provident.", "https://placeimg.com/640/480/any" },
                    { 29, "Jewelery", "Est consequatur ut nemo ut maiores occaecati.", "https://placeimg.com/640/480/any" },
                    { 28, "Clothing", "Nobis molestiae architecto fugit placeat consequatur quibusdam incidunt beatae. Ea ullam totam est est. In veritatis nihil reiciendis ab dolor aspernatur. Id quia dignissimos voluptatem modi.", "https://placeimg.com/640/480/any" },
                    { 27, "Kids", "occaecati", "https://placeimg.com/640/480/any" },
                    { 26, "Clothing", "Tenetur dolorem voluptatem quod velit.", "https://placeimg.com/640/480/any" },
                    { 25, "Shoes", "velit", "https://placeimg.com/640/480/any" },
                    { 24, "Outdoors", "velit", "https://placeimg.com/640/480/any" },
                    { 23, "Automotive", "Dolor sunt iste illum cupiditate mollitia libero in exercitationem. Perspiciatis qui quia dolor consequatur. Enim debitis ipsam recusandae assumenda quis rerum libero.", "https://placeimg.com/640/480/any" },
                    { 22, "Jewelery", "dolor", "https://placeimg.com/640/480/any" },
                    { 20, "Baby", "id", "https://placeimg.com/640/480/any" },
                    { 19, "Computers", @"Nobis dolorem omnis deserunt quos.
                Ex perferendis alias natus ipsam et quam.
                Neque eveniet sed minima qui rerum beatae rerum officiis quam.", "https://placeimg.com/640/480/any" },
                    { 18, "Sports", "Qui omnis qui qui. Doloremque ad enim consequuntur. Similique quos velit omnis. Ea ad voluptatem repellendus explicabo velit cum quas. Consectetur rerum nisi.", "https://placeimg.com/640/480/any" },
                    { 17, "Computers", "ex", "https://placeimg.com/640/480/any" },
                    { 16, "Jewelery", "blanditiis", "https://placeimg.com/640/480/any" },
                    { 21, "Toys", @"Consequatur voluptatum vel similique dolorem.
                Quaerat commodi aspernatur sint delectus.
                Molestiae non eos.", "https://placeimg.com/640/480/any" },
                    { 14, "Tools", "totam", "https://placeimg.com/640/480/any" },
                    { 2, "Music", "Inventore dolores aut. Sit beatae et minus hic. Et quod repellendus dolor incidunt ut ipsa. Recusandae facere dicta ut. Est officia ut consequatur quos placeat sed praesentium distinctio eveniet. Voluptates dolores harum harum veniam quisquam itaque minima beatae quidem.", "https://placeimg.com/640/480/any" },
                    { 15, "Clothing", "Vero voluptatem est beatae laboriosam iste sunt commodi deleniti aliquid. Consequatur deserunt molestiae alias. Officia debitis reprehenderit aut laboriosam sit. Molestiae id sequi id at voluptates id aut.", "https://placeimg.com/640/480/any" },
                    { 4, "Sports", "similique", "https://placeimg.com/640/480/any" },
                    { 5, "Baby", "Ratione inventore ut expedita ut quas in.", "https://placeimg.com/640/480/any" },
                    { 6, "Jewelery", "Enim ullam architecto aperiam quia. Nobis ut esse vel distinctio repellendus. Fugiat molestiae architecto labore et vel.", "https://placeimg.com/640/480/any" },
                    { 7, "Books", "atque", "https://placeimg.com/640/480/any" },
                    { 3, "Electronics", "Nisi vero et voluptatem maxime. Ullam cumque qui dolorem. Doloribus velit voluptatibus ullam hic sit perferendis amet. Sit sed ratione quo quis. Voluptatem illum explicabo neque fuga voluptate voluptatem dignissimos vel. Omnis architecto sapiente dolorum nobis ab.", "https://placeimg.com/640/480/any" },
                    { 9, "Baby", "Eligendi quo sit autem consequuntur necessitatibus delectus beatae.", "https://placeimg.com/640/480/any" },
                    { 10, "Toys", "quis", "https://placeimg.com/640/480/any" },
                    { 11, "Sports", @"Culpa provident at porro quia.
                Velit et inventore facilis repellendus aliquam.
                Voluptatem minus ut deleniti quia vel sed iure.", "https://placeimg.com/640/480/any" },
                    { 12, "Toys", @"Sapiente sit occaecati.
                Quaerat dolores quidem recusandae.
                Autem vero nisi est ut nihil nesciunt quasi illum labore.
                Corrupti sed sit officiis.
                Error totam numquam pariatur.
                Magni numquam error excepturi aut veniam illo ut ea odio.", "https://placeimg.com/640/480/any" },
                    { 13, "Garden", "aspernatur", "https://placeimg.com/640/480/any" },
                    { 8, "Beauty", "accusantium", "https://placeimg.com/640/480/any" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 16, "West", "Heaneytown", "Franecki - Rolfson", "Lois Marquardt", "Customer Paradigm Designer", "Norway", "Lois_Marquardt", "(462) 807-3205", "37777-3343", "South Carolina" },
                    { 17, "South", "South Americo", "Turner - Keebler", "Jim Morar", "International Creative Designer", "Andorra", "Jim35", "1-973-754-7535", "10476", "Mississippi" },
                    { 18, "Northeast", "Samsonport", "Willms Inc", "Bruce McClure", "Future Accountability Engineer", "Equatorial Guinea", "Bruce_McClure99", "(990) 974-8872 x85066", "02108", "Nevada" },
                    { 19, "South", "Swiftview", "Anderson Inc", "Amos Rath", "Product Marketing Architect", "Singapore", "Amos_Rath", "914-872-3832 x32570", "86154-4459", "New York" },
                    { 20, "Northeast", "South Cletaport", "Willms Group", "Tommy Reinger", "Lead Accounts Executive", "Vanuatu", "Tommy.Reinger", "1-577-468-2327", "23500-9147", "Washington" },
                    { 23, "North", "Port Amelyhaven", "Kuhic and Sons", "Johnnie Roob", "Investor Security Designer", "Hungary", "Johnnie_Roob", "(366) 653-4220 x33804", "58313", "Washington" },
                    { 22, "East", "West Marilouborough", "Schroeder - Olson", "Dale Robel", "International Quality Developer", "Senegal", "Dale_Robel74", "679-420-2652 x5208", "70232-9761", "Minnesota" },
                    { 24, "Northwest", "Destiniton", "Dickinson, Gibson and Lockman", "Antonio Boehm", "District Factors Strategist", "Hong Kong", "Antonio.Boehm", "1-580-988-8760 x086", "50543", "Maryland" },
                    { 25, "Northwest", "West Brigitte", "Kunze - Koepp", "Antonio Kreiger", "Principal Infrastructure Producer", "Northern Mariana Islands", "Antonio58", "917-427-5056 x89810", "46361-0670", "Kentucky" },
                    { 15, "Southeast", "Dickihaven", "O'Reilly and Sons", "Terri Nicolas", "Investor Division Specialist", "Kazakhstan", "Terri87", "918.760.3595 x3151", "26910-0531", "Nebraska" },
                    { 21, "Southwest", "Juanabury", "Bruen, Turcotte and Funk", "Lee Kautzer", "Future Response Coordinator", "Chad", "Lee88", "491-715-0556", "54857-0186", "Maryland" },
                    { 14, "Northwest", "Alfonsohaven", "Klein - Hand", "Rex Dibbert", "Central Functionality Technician", "Denmark", "Rex.Dibbert", "(684) 790-0830 x77748", "48170", "Louisiana" },
                    { 10, "Southeast", "Janelleborough", "Schulist Inc", "Lola Roberts", "Corporate Communications Developer", "Kyrgyz Republic", "Lola_Roberts", "(301) 454-6582 x1940", "86427", "New Hampshire" },
                    { 12, "Northeast", "Miketown", "Rippin, Senger and Halvorson", "Mona D'Amore", "Dynamic Program Planner", "Gambia", "Mona71", "892-566-9542 x714", "25321", "Maryland" },
                    { 13, "Southwest", "Hartmannland", "Heathcote, Graham and Franecki", "Rickey Glover", "District Division Liaison", "Iran", "Rickey39", "1-845-288-7919 x5928", "91530-3778", "Vermont" },
                    { 2, "Northwest", "Jacquestown", "Ullrich, Adams and Lakin", "Leigh Kshlerin", "Investor Web Officer", "Singapore", "Leigh80", "1-440-215-8483 x2178", "17828", "Pennsylvania" },
                    { 3, "Southeast", "West Jessyshire", "Ferry - Waters", "Gertrude Wunsch", "Legacy Implementation Supervisor", "Venezuela", "Gertrude_Wunsch", "(920) 355-3827", "57846-8934", "Rhode Island" },
                    { 4, "Southwest", "Maggiofurt", "Hodkiewicz, Murphy and Schroeder", "Sheri Beer", "Global Infrastructure Supervisor", "Papua New Guinea", "Sheri.Beer", "(491) 879-4454 x75376", "41642", "Mississippi" },
                    { 5, "Northeast", "Muellerchester", "Cremin and Sons", "Walter Kreiger", "Internal Infrastructure Officer", "Bahamas", "Walter.Kreiger38", "1-224-482-4551 x2582", "77810", "Alaska" },
                    { 1, "Southeast", "South Eddie", "Bogan and Sons", "Margarita Champlin", "Dynamic Program Specialist", "Qatar", "Margarita_Champlin", "584.551.9223 x74803", "30650-2489", "Minnesota" },
                    { 7, "Southeast", "Bergnaumton", "Gorczany Group", "Roman Littel", "Customer Metrics Specialist", "Democratic People's Republic of Korea", "Roman31", "528-766-7527 x748", "67694-2975", "Virginia" },
                    { 8, "Southeast", "Lake Aurelieton", "Klocko LLC", "Gary Dietrich", "Human Optimization Consultant", "Germany", "Gary.Dietrich", "837-269-3498", "96776", "Nevada" },
                    { 9, "Northeast", "Grahamside", "McClure, Jacobi and Ledner", "Alexander Cormier", "Dynamic Paradigm Consultant", "Zimbabwe", "Alexander73", "797.700.5292 x287", "95695-7643", "Pennsylvania" },
                    { 11, "West", "Carmineland", "Strosin, Gerlach and Rohan", "Courtney Koch", "Dynamic Marketing Executive", "Vanuatu", "Courtney39", "384.488.3113 x8732", "41964", "Colorado" },
                    { 6, "Southeast", "Pacochaburgh", "Friesen, Johnson and Hand", "Laverne Trantow", "Principal Functionality Facilitator", "Bermuda", "Laverne.Trantow", "1-267-369-8684 x895", "77587", "New Mexico" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "BirthDate", "City", "Country", "Extension", "FirstName", "HireDate", "HomePhone", "LastName", "Notes", "Photo", "PostalCode", "Region", "ReportsTo", "Title", "TitleOfCourtesy" },
                values: new object[,]
                {
                    { 28, "North", new DateTime(1997, 12, 10, 2, 34, 9, 46, DateTimeKind.Local).AddTicks(3506), "Huelberg", "Kiribati", 529, "Dexter", new DateTime(2020, 8, 24, 17, 11, 28, 424, DateTimeKind.Local).AddTicks(6668), "683-918-6345", "Crona", "Sint dolor sapiente minus quaerat tenetur et ut similique.", "https://placeimg.com/640/480/any", "39510", "Washington", "Dexter Crona", "Future Marketing Coordinator", "Dexter_Crona" },
                    { 37, "North", new DateTime(1997, 8, 19, 16, 10, 39, 749, DateTimeKind.Local).AddTicks(4863), "New Brenna", "Norfolk Island", 805, "Nora", new DateTime(2020, 8, 24, 5, 14, 4, 315, DateTimeKind.Local).AddTicks(4406), "1-598-453-7746", "Zemlak", @"Culpa aliquam aliquid delectus debitis.
                Officia sapiente excepturi nisi.", "https://placeimg.com/640/480/any", "29513", "Ohio", "Nora Zemlak", "Corporate Markets Director", "Nora.Zemlak21" },
                    { 29, "Northwest", new DateTime(1988, 5, 4, 10, 5, 6, 400, DateTimeKind.Local).AddTicks(2867), "Port Ora", "Saint Vincent and the Grenadines", 729, "Lori", new DateTime(2020, 8, 24, 10, 56, 39, 961, DateTimeKind.Local).AddTicks(6596), "524.322.9164", "Raynor", "Provident animi minima dolorem non.", "https://placeimg.com/640/480/any", "02115-4274", "New York", "Lori Raynor", "Internal Functionality Assistant", "Lori_Raynor0" },
                    { 30, "West", new DateTime(1976, 3, 24, 21, 13, 18, 468, DateTimeKind.Local).AddTicks(6606), "Makaylamouth", "Martinique", 166, "Delores", new DateTime(2020, 8, 24, 15, 30, 48, 457, DateTimeKind.Local).AddTicks(4071), "984.382.7156 x457", "Schoen", @"Et sunt error accusantium repellendus eum occaecati aut deserunt.
                Molestiae at veniam corporis necessitatibus et sed voluptates et aspernatur.", "https://placeimg.com/640/480/any", "17712", "Maine", "Delores Schoen", "Dynamic Mobility Technician", "Delores37" },
                    { 31, "East", new DateTime(1988, 7, 25, 7, 59, 47, 956, DateTimeKind.Local).AddTicks(5445), "East Eduardohaven", "Eritrea", 36, "Susan", new DateTime(2020, 8, 24, 19, 11, 49, 426, DateTimeKind.Local).AddTicks(6507), "1-858-658-3118", "Pouros", @"Praesentium fuga vel explicabo nihil rerum nulla quas.
                Sit quia hic quos et quod.", "https://placeimg.com/640/480/any", "76869", "North Carolina", "Susan Pouros", "District Creative Officer", "Susan98" },
                    { 32, "Southwest", new DateTime(1990, 12, 6, 3, 54, 52, 319, DateTimeKind.Local).AddTicks(8777), "Swaniawskifurt", "Serbia", 728, "Sonya", new DateTime(2020, 8, 24, 11, 50, 56, 279, DateTimeKind.Local).AddTicks(4225), "1-443-403-7881", "Hammes", @"Eos ea repellendus fugit id adipisci.
                Voluptatem in aut laboriosam sunt.", "https://placeimg.com/640/480/any", "58188", "North Dakota", "Sonya Hammes", "Product Research Facilitator", "Sonya41" },
                    { 33, "South", new DateTime(1953, 10, 18, 16, 3, 31, 121, DateTimeKind.Local).AddTicks(6952), "Hageneston", "Saint Vincent and the Grenadines", 835, "Van", new DateTime(2020, 8, 24, 3, 52, 26, 419, DateTimeKind.Local).AddTicks(9524), "603-946-0566 x6572", "Dibbert", @"Id eaque reiciendis.
                Omnis corrupti eligendi voluptas.
                In voluptatibus eaque laudantium rem aperiam.", "https://placeimg.com/640/480/any", "35219", "Maryland", "Van Dibbert", "District Applications Director", "Van.Dibbert" },
                    { 34, "Southwest", new DateTime(1974, 1, 16, 20, 59, 14, 263, DateTimeKind.Local).AddTicks(7163), "Harveyville", "Belize", 266, "Lewis", new DateTime(2020, 8, 24, 16, 53, 11, 864, DateTimeKind.Local).AddTicks(7267), "788.526.9039", "Turner", @"Nemo dignissimos repellendus repudiandae minima.
                Quo et cumque rem optio ut.", "https://placeimg.com/640/480/any", "56133-1718", "Arkansas", "Lewis Turner", "Principal Implementation Liaison", "Lewis23" },
                    { 35, "West", new DateTime(1967, 2, 15, 21, 25, 28, 797, DateTimeKind.Local).AddTicks(5911), "Howechester", "Saint Martin", 750, "Eileen", new DateTime(2020, 8, 24, 11, 38, 9, 362, DateTimeKind.Local).AddTicks(1254), "(701) 701-7785", "Sawayn", @"Ut tempora provident et.
                Veniam aut nemo.", "https://placeimg.com/640/480/any", "85519", "Texas", "Eileen Sawayn", "Product Communications Officer", "Eileen_Sawayn77" },
                    { 36, "Northwest", new DateTime(1987, 8, 6, 17, 16, 0, 902, DateTimeKind.Local).AddTicks(2698), "Parisianbury", "Paraguay", 277, "Patti", new DateTime(2020, 8, 24, 6, 13, 22, 265, DateTimeKind.Local).AddTicks(5596), "627-666-0280 x17639", "Dickinson", @"Excepturi aut iste enim vitae officia sint nihil esse.
                Iusto autem quia omnis.
                Cumque odio delectus in.
                Quam delectus quibusdam vero omnis est.", "https://placeimg.com/640/480/any", "91629", "West Virginia", "Patti Dickinson", "Customer Directives Coordinator", "Patti.Dickinson" },
                    { 38, "West", new DateTime(1986, 8, 21, 6, 45, 14, 553, DateTimeKind.Local).AddTicks(9138), "Willmsburgh", "Tunisia", 159, "Genevieve", new DateTime(2020, 8, 23, 23, 49, 32, 48, DateTimeKind.Local).AddTicks(8672), "(245) 566-2220 x8204", "Carroll", @"Voluptatem autem ut quia in enim doloribus beatae repellendus.
                Fugiat sed ducimus commodi quae consectetur commodi.", "https://placeimg.com/640/480/any", "75617", "Alabama", "Genevieve Carroll", "Dynamic Directives Technician", "Genevieve74" },
                    { 44, "Southwest", new DateTime(1970, 8, 15, 2, 49, 27, 629, DateTimeKind.Local).AddTicks(817), "Lake Darwin", "Central African Republic", 603, "Cornelius", new DateTime(2020, 8, 24, 16, 0, 8, 700, DateTimeKind.Local).AddTicks(4001), "1-271-710-7773 x94170", "Rath", @"Eum minus et blanditiis nobis optio est est possimus.
                Et quidem quidem qui.
                Voluptas et atque et est aut quos modi nihil quaerat.
                Dignissimos ipsum sed est.
                Et maiores velit laboriosam accusamus.", "https://placeimg.com/640/480/any", "43004", "Maryland", "Cornelius Rath", "Human Brand Liaison", "Cornelius11" },
                    { 40, "Southwest", new DateTime(1989, 3, 21, 20, 20, 6, 184, DateTimeKind.Local).AddTicks(5931), "South Ceceliabury", "Malta", 228, "Willie", new DateTime(2020, 8, 24, 18, 23, 29, 578, DateTimeKind.Local).AddTicks(2797), "413-517-9814", "Miller", @"Ut non ipsa.
                Ipsa est nemo.
                Enim aliquid voluptatem consequatur voluptatum consequuntur labore et.
                Voluptatum expedita in voluptatibus architecto aliquid praesentium molestiae.
                Possimus accusantium laudantium soluta odio aut.", "https://placeimg.com/640/480/any", "33140", "Louisiana", "Willie Miller", "Internal Factors Administrator", "Willie6" },
                    { 41, "Northwest", new DateTime(1977, 5, 12, 22, 12, 44, 607, DateTimeKind.Local).AddTicks(2454), "Kattieside", "Saint Kitts and Nevis", 551, "Beverly", new DateTime(2020, 8, 24, 17, 2, 39, 916, DateTimeKind.Local).AddTicks(4714), "422.271.0112", "Schumm", @"Sint neque voluptas quam aut voluptatem ad quia quis excepturi.
                Eligendi nihil quae est aut eius.
                Consequuntur est quo in animi.
                Quos culpa nulla ratione odit necessitatibus et cupiditate et.
                Non quia voluptas dolores ut.", "https://placeimg.com/640/480/any", "29877-5874", "Alaska", "Beverly Schumm", "Chief Interactions Executive", "Beverly.Schumm53" },
                    { 42, "East", new DateTime(1958, 2, 15, 1, 42, 27, 833, DateTimeKind.Local).AddTicks(6535), "West Ricoport", "Tanzania", 706, "Gerald", new DateTime(2020, 8, 23, 23, 58, 53, 885, DateTimeKind.Local).AddTicks(158), "(891) 429-4721", "Macejkovic", "At perspiciatis nostrum non vel aliquam et rem est.", "https://placeimg.com/640/480/any", "87456-3139", "Virginia", "Gerald Macejkovic", "Internal Operations Technician", "Gerald92" },
                    { 43, "East", new DateTime(2000, 3, 2, 13, 28, 12, 302, DateTimeKind.Local).AddTicks(6748), "Moisesshire", "Nigeria", 967, "Erma", new DateTime(2020, 8, 24, 2, 16, 10, 668, DateTimeKind.Local).AddTicks(2489), "254-670-3962 x8438", "O'Conner", "Ex adipisci voluptatem cupiditate aut maxime.", "https://placeimg.com/640/480/any", "30410-0143", "Mississippi", "Erma O'Conner", "Lead Paradigm Designer", "Erma_OConner65" },
                    { 45, "East", new DateTime(1990, 10, 22, 11, 32, 52, 261, DateTimeKind.Local).AddTicks(238), "Halvorsonfurt", "Dominica", 164, "Lisa", new DateTime(2020, 8, 24, 7, 26, 7, 564, DateTimeKind.Local).AddTicks(8076), "(641) 696-0782", "O'Reilly", @"Ab vel non consequatur dolores.
                Ut non est explicabo aut sequi ut nesciunt ipsa.
                Qui qui omnis adipisci et.
                Tempora sed tenetur optio.", "https://placeimg.com/640/480/any", "45703", "Kentucky", "Lisa O'Reilly", "Chief Solutions Developer", "Lisa.OReilly" },
                    { 46, "Northwest", new DateTime(1962, 8, 18, 14, 2, 8, 874, DateTimeKind.Local).AddTicks(6736), "Lilyanburgh", "Cape Verde", 528, "Wanda", new DateTime(2020, 8, 24, 7, 21, 33, 844, DateTimeKind.Local).AddTicks(6099), "1-313-737-0994", "Huel", @"Ut a vitae.
                Dolor officiis aspernatur.", "https://placeimg.com/640/480/any", "51703", "Alabama", "Wanda Huel", "Corporate Directives Representative", "Wanda_Huel48" },
                    { 47, "Northeast", new DateTime(1987, 10, 22, 6, 7, 30, 591, DateTimeKind.Local).AddTicks(4726), "Wintheiserland", "Spain", 479, "Brenda", new DateTime(2020, 8, 24, 15, 13, 9, 703, DateTimeKind.Local).AddTicks(5003), "681.859.2931 x09171", "Kilback", @"Dolores magni facere ut aut molestias enim.
                Corporis aut eveniet.
                In architecto quibusdam qui tempore impedit labore unde sint iste.", "https://placeimg.com/640/480/any", "26591", "Iowa", "Brenda Kilback", "National Brand Producer", "Brenda_Kilback56" },
                    { 48, "Northeast", new DateTime(1982, 8, 22, 5, 18, 10, 96, DateTimeKind.Local).AddTicks(3900), "Hayesville", "Ethiopia", 427, "Erica", new DateTime(2020, 8, 24, 15, 16, 36, 573, DateTimeKind.Local).AddTicks(4185), "874.498.0856 x956", "Heller", @"Corporis alias aspernatur nihil commodi repellendus dolores laboriosam.
                Doloribus omnis nostrum.
                Tempore ut illo.
                Est et sit occaecati fugit ex earum.", "https://placeimg.com/640/480/any", "77973", "Mississippi", "Erica Heller", "Corporate Marketing Executive", "Erica.Heller" },
                    { 49, "North", new DateTime(1990, 11, 19, 21, 46, 9, 833, DateTimeKind.Local).AddTicks(96), "South Adolphuschester", "Moldova", 923, "Todd", new DateTime(2020, 8, 24, 13, 29, 20, 657, DateTimeKind.Local).AddTicks(4810), "773-889-3737", "Reilly", @"Quisquam ipsa quibusdam nam vero est nobis sint perferendis et.
                Ut tempora ad soluta illo possimus.
                Reprehenderit possimus enim ea enim quasi maxime.
                Esse et qui aut aut corporis qui sunt.
                Voluptatibus possimus ut dolorem ut labore assumenda doloribus.", "https://placeimg.com/640/480/any", "38152-3083", "Arkansas", "Todd Reilly", "Dynamic Paradigm Consultant", "Todd_Reilly26" },
                    { 50, "Northwest", new DateTime(1985, 10, 7, 18, 1, 51, 290, DateTimeKind.Local).AddTicks(9610), "New Bethanychester", "Saint Vincent and the Grenadines", 227, "Gladys", new DateTime(2020, 8, 24, 8, 36, 33, 878, DateTimeKind.Local).AddTicks(2077), "(967) 284-0470", "Dickinson", @"Accusantium quis numquam dicta occaecati placeat.
                Aut repellat reprehenderit non blanditiis sit.
                Aut maiores dolorem nihil quo porro dicta.
                Dolorum alias dolore dolorem dolore dignissimos inventore dolorum ad.
                Iure et aperiam optio iusto doloremque dolorem voluptatem.", "https://placeimg.com/640/480/any", "32511-3350", "Illinois", "Gladys Dickinson", "National Paradigm Manager", "Gladys.Dickinson" },
                    { 27, "Southwest", new DateTime(1953, 9, 19, 2, 34, 2, 93, DateTimeKind.Local).AddTicks(9547), "Elzashire", "Nigeria", 697, "Jeff", new DateTime(2020, 8, 24, 17, 29, 7, 872, DateTimeKind.Local).AddTicks(843), "1-498-950-7709 x94342", "Bauch", "Quam provident dolorem et fugiat dolorum sint velit molestias non.", "https://placeimg.com/640/480/any", "41647", "Texas", "Jeff Bauch", "Human Identity Administrator", "Jeff77" },
                    { 39, "North", new DateTime(1958, 2, 24, 13, 16, 51, 57, DateTimeKind.Local).AddTicks(6058), "Streichberg", "Tajikistan", 707, "Virginia", new DateTime(2020, 8, 24, 14, 45, 57, 637, DateTimeKind.Local).AddTicks(8135), "381-244-5560 x477", "Hermann", @"Doloribus nihil aut alias illum reiciendis qui iste.
                Inventore quae voluptas autem facilis assumenda a.
                Nobis facilis vitae iure accusamus odit et.
                Minima quos voluptatum vitae ipsum nulla illum asperiores quis debitis.
                Assumenda nihil esse totam doloribus deleniti ut.", "https://placeimg.com/640/480/any", "41188", "Colorado", "Virginia Hermann", "Chief Program Liaison", "Virginia47" },
                    { 26, "Southwest", new DateTime(1979, 8, 22, 8, 54, 47, 434, DateTimeKind.Local).AddTicks(8747), "Armandoside", "Eritrea", 912, "Melvin", new DateTime(2020, 8, 24, 4, 34, 54, 823, DateTimeKind.Local).AddTicks(7235), "(383) 746-1019 x914", "Terry", @"Voluptas necessitatibus itaque eos voluptates.
                Consequatur perspiciatis consequatur laudantium totam commodi.
                Voluptates error ut sint eveniet minima suscipit doloribus voluptas.", "https://placeimg.com/640/480/any", "26115", "Montana", "Melvin Terry", "Legacy Factors Designer", "Melvin74" },
                    { 23, "Southwest", new DateTime(1998, 8, 21, 17, 30, 43, 999, DateTimeKind.Local).AddTicks(3156), "Ebonyshire", "Barbados", 8, "Amy", new DateTime(2020, 8, 24, 4, 23, 12, 192, DateTimeKind.Local).AddTicks(980), "768.969.1369", "Kihn", @"Cumque omnis eligendi animi illum sequi sed ullam qui.
                Dolore mollitia tenetur.
                Tempora nam recusandae facere fugiat.
                Dolor modi qui recusandae.
                Delectus laudantium et sequi aliquid.", "https://placeimg.com/640/480/any", "80322-8619", "South Dakota", "Amy Kihn", "Regional Identity Orchestrator", "Amy87" },
                    { 24, "Southeast", new DateTime(1962, 8, 30, 20, 1, 11, 836, DateTimeKind.Local).AddTicks(1129), "West Odastad", "India", 577, "Amos", new DateTime(2020, 8, 23, 22, 6, 6, 546, DateTimeKind.Local).AddTicks(6530), "555-996-3739 x68262", "Frami", @"Sed quo vero et sunt reiciendis saepe est vero molestias.
                Aperiam voluptatem tempore ut occaecati corrupti placeat ratione impedit voluptas.
                Expedita voluptatem id repellendus at veritatis in.", "https://placeimg.com/640/480/any", "51162-7013", "Wisconsin", "Amos Frami", "Investor Accountability Executive", "Amos_Frami45" },
                    { 25, "East", new DateTime(1991, 7, 4, 20, 18, 45, 33, DateTimeKind.Local).AddTicks(8204), "Dickensland", "Pitcairn Islands", 958, "Garry", new DateTime(2020, 8, 24, 16, 1, 18, 252, DateTimeKind.Local).AddTicks(4913), "1-616-947-5482 x0123", "Dickinson", @"Ut quis odit repellat rerum pariatur deserunt ad facere.
                Aut corrupti voluptas.", "https://placeimg.com/640/480/any", "84933", "Vermont", "Garry Dickinson", "District Communications Consultant", "Garry13" },
                    { 1, "Southeast", new DateTime(1999, 6, 9, 15, 7, 48, 847, DateTimeKind.Local).AddTicks(3217), "Vivienneport", "Virgin Islands, U.S.", 389, "Tracy", new DateTime(2020, 8, 24, 10, 35, 23, 553, DateTimeKind.Local).AddTicks(6309), "(680) 200-8554 x606", "Schuppe", @"Quia provident aspernatur aut assumenda optio ut sequi.
                Dolores non est.
                Et molestiae vel.
                Ipsam quaerat doloribus quibusdam corrupti incidunt quibusdam animi libero libero.", "https://placeimg.com/640/480/any", "87779", "Arizona", "Tracy Schuppe", "Forward Metrics Facilitator", "Tracy43" },
                    { 2, "West", new DateTime(1964, 10, 11, 22, 34, 53, 512, DateTimeKind.Local).AddTicks(6472), "Macmouth", "Burkina Faso", 40, "Bernadette", new DateTime(2020, 8, 23, 22, 42, 39, 882, DateTimeKind.Local).AddTicks(3646), "1-250-921-9842", "O'Connell", @"Dignissimos officiis repellat ut non est.
                Est enim tempora corporis.
                Unde totam velit iste beatae nostrum rerum repellat qui hic.
                Neque dicta provident placeat.", "https://placeimg.com/640/480/any", "82110", "Illinois", "Bernadette O'Connell", "Product Configuration Analyst", "Bernadette_OConnell52" },
                    { 3, "West", new DateTime(1980, 1, 8, 6, 12, 27, 77, DateTimeKind.Local).AddTicks(9808), "Lomaborough", "Bangladesh", 497, "Nora", new DateTime(2020, 8, 24, 18, 49, 24, 495, DateTimeKind.Local).AddTicks(9458), "833-673-8445 x0440", "Tromp", @"Eum corrupti voluptatum cum.
                Sint et rerum ab sunt voluptas iusto qui doloremque qui.
                Expedita temporibus qui velit est ex.", "https://placeimg.com/640/480/any", "88684", "North Carolina", "Nora Tromp", "Lead Markets Liaison", "Nora3" },
                    { 4, "East", new DateTime(1979, 5, 28, 12, 29, 45, 374, DateTimeKind.Local).AddTicks(4103), "Lake Danatown", "Sierra Leone", 135, "Courtney", new DateTime(2020, 8, 24, 11, 24, 50, 531, DateTimeKind.Local).AddTicks(385), "454-206-3983 x437", "McCullough", @"Eum et eius ex ea aut minima vitae facere necessitatibus.
                Eum ut accusamus incidunt cupiditate magnam animi rerum eos.", "https://placeimg.com/640/480/any", "62425-0700", "West Virginia", "Courtney McCullough", "Lead Accountability Assistant", "Courtney38" },
                    { 6, "North", new DateTime(1981, 11, 9, 11, 39, 48, 540, DateTimeKind.Local).AddTicks(8973), "West Daltonport", "Madagascar", 938, "Sally", new DateTime(2020, 8, 24, 16, 30, 20, 367, DateTimeKind.Local).AddTicks(4134), "972-835-7274 x286", "Marquardt", @"Dolor consequatur illum quia laborum est consequuntur natus excepturi.
                Architecto dolores ex recusandae.
                Et tempora aut quia omnis quia.", "https://placeimg.com/640/480/any", "10182-8103", "Maine", "Sally Marquardt", "Customer Intranet Associate", "Sally.Marquardt15" },
                    { 7, "West", new DateTime(1983, 7, 7, 6, 13, 32, 744, DateTimeKind.Local).AddTicks(4913), "Brakusmouth", "Slovenia", 797, "Jacquelyn", new DateTime(2020, 8, 24, 15, 37, 0, 213, DateTimeKind.Local).AddTicks(9550), "244.635.8083 x989", "Little", @"Facilis possimus omnis nihil.
                Vel neque rerum exercitationem corporis ut quisquam.
                Vel aliquid corporis tempore eos quia.
                Itaque odio quae.
                Voluptatum voluptatum accusamus earum fugiat.", "https://placeimg.com/640/480/any", "79864-8035", "Rhode Island", "Jacquelyn Little", "Chief Factors Liaison", "Jacquelyn_Little" },
                    { 8, "East", new DateTime(1990, 6, 22, 14, 27, 16, 401, DateTimeKind.Local).AddTicks(7332), "Erickahaven", "Faroe Islands", 922, "Lionel", new DateTime(2020, 8, 24, 0, 50, 46, 165, DateTimeKind.Local).AddTicks(6371), "(477) 293-6095", "Hermiston", @"Minus accusamus quibusdam et ut et.
                Quaerat nihil est id cupiditate quos dicta nostrum nesciunt.
                Et ab suscipit ullam ut quia laudantium sed rerum ratione.
                Reiciendis est aut.", "https://placeimg.com/640/480/any", "05018-7541", "Nevada", "Lionel Hermiston", "Human Communications Administrator", "Lionel.Hermiston" },
                    { 9, "East", new DateTime(1984, 1, 20, 0, 47, 39, 890, DateTimeKind.Local).AddTicks(830), "West Brooklynberg", "Ethiopia", 559, "Santiago", new DateTime(2020, 8, 24, 2, 43, 4, 212, DateTimeKind.Local).AddTicks(8982), "(726) 807-5577 x949", "Botsford", @"Non id quaerat tempora laboriosam molestiae.
                Tempora iusto est.
                Fuga aperiam consequatur voluptatem quis expedita quis non.
                Blanditiis eveniet dolore est ut temporibus dolore amet.
                Dicta aut aut voluptatem ut non quidem.", "https://placeimg.com/640/480/any", "33065", "South Dakota", "Santiago Botsford", "Chief Identity Liaison", "Santiago.Botsford" },
                    { 10, "Northeast", new DateTime(1987, 10, 12, 17, 26, 46, 995, DateTimeKind.Local).AddTicks(7113), "North Chazbury", "Estonia", 133, "Fredrick", new DateTime(2020, 8, 24, 13, 42, 54, 456, DateTimeKind.Local).AddTicks(520), "662.228.2721 x219", "Johnston", @"Et dicta sint minima.
                Ut consequatur soluta sunt vero est.
                Et corporis nam in id iste.
                Ut aperiam debitis deleniti aut.", "https://placeimg.com/640/480/any", "83792-0167", "Maine", "Fredrick Johnston", "National Tactics Facilitator", "Fredrick8" },
                    { 11, "Southeast", new DateTime(1973, 1, 12, 19, 25, 25, 628, DateTimeKind.Local).AddTicks(1957), "Kariannemouth", "Dominica", 338, "Lynne", new DateTime(2020, 8, 24, 4, 17, 3, 380, DateTimeKind.Local).AddTicks(6798), "951-652-8779 x25208", "Hilpert", @"Dolorum soluta consequatur fuga quo totam.
                Tenetur velit deserunt fugiat voluptas ullam repudiandae beatae veritatis optio.
                Quia illo exercitationem dolor ipsam nobis eum.
                Possimus vel quaerat eum.
                Quibusdam eligendi sunt et distinctio ullam sit labore aut unde.", "https://placeimg.com/640/480/any", "16044", "Alabama", "Lynne Hilpert", "Dynamic Optimization Planner", "Lynne42" },
                    { 5, "West", new DateTime(1972, 1, 11, 21, 8, 58, 591, DateTimeKind.Local).AddTicks(2760), "Huldamouth", "Liechtenstein", 599, "Misty", new DateTime(2020, 8, 23, 22, 5, 58, 162, DateTimeKind.Local).AddTicks(3857), "816-202-4413 x13787", "Sauer", @"Optio modi tempora.
                Dolor provident ducimus.
                Ut voluptas quae illum.", "https://placeimg.com/640/480/any", "93240", "Arkansas", "Misty Sauer", "Direct Creative Assistant", "Misty.Sauer9" },
                    { 13, "West", new DateTime(1971, 1, 10, 21, 11, 28, 505, DateTimeKind.Local).AddTicks(6560), "North Danikamouth", "Hungary", 713, "Jimmie", new DateTime(2020, 8, 24, 4, 53, 52, 627, DateTimeKind.Local).AddTicks(6819), "(484) 853-4002", "Lesch", @"Consequatur facere ipsam amet ut pariatur sed animi ut a.
                Aut quis voluptatum consequatur.", "https://placeimg.com/640/480/any", "27044", "Georgia", "Jimmie Lesch", "Chief Tactics Liaison", "Jimmie.Lesch39" },
                    { 12, "West", new DateTime(1999, 4, 6, 11, 27, 58, 798, DateTimeKind.Local).AddTicks(7229), "Port Cristobal", "Central African Republic", 793, "Brooke", new DateTime(2020, 8, 24, 2, 46, 51, 821, DateTimeKind.Local).AddTicks(3356), "(315) 258-5596", "Davis", @"Perspiciatis ipsa autem doloremque.
                Laboriosam voluptates et qui est id laborum facilis sunt.
                Corrupti sunt necessitatibus eum ipsum beatae.
                Qui libero qui atque qui molestias impedit quas laudantium alias.", "https://placeimg.com/640/480/any", "11909", "Minnesota", "Brooke Davis", "Internal Accountability Executive", "Brooke.Davis" },
                    { 22, "Northwest", new DateTime(1974, 5, 7, 11, 31, 29, 948, DateTimeKind.Local).AddTicks(2057), "Port Lazaro", "Azerbaijan", 650, "Velma", new DateTime(2020, 8, 24, 2, 48, 12, 607, DateTimeKind.Local).AddTicks(3577), "657-451-5876 x97582", "Kunze", @"Nihil minus quasi ut facere veniam aut deserunt porro.
                Eius dolor ea sint error cumque esse.
                Autem laudantium quam aspernatur reprehenderit quia vero ratione ipsum.", "https://placeimg.com/640/480/any", "91894", "Rhode Island", "Velma Kunze", "National Interactions Technician", "Velma_Kunze" },
                    { 21, "East", new DateTime(1992, 10, 16, 10, 3, 47, 452, DateTimeKind.Local).AddTicks(8529), "Luettgenfort", "Montserrat", 365, "Gertrude", new DateTime(2020, 8, 24, 18, 13, 43, 513, DateTimeKind.Local).AddTicks(4529), "1-362-653-0353", "Gutkowski", "Sapiente consectetur qui eos consequatur culpa et.", "https://placeimg.com/640/480/any", "19741", "Alaska", "Gertrude Gutkowski", "Product Branding Strategist", "Gertrude.Gutkowski55" },
                    { 19, "North", new DateTime(1994, 12, 28, 21, 43, 50, 323, DateTimeKind.Local).AddTicks(8049), "Weimannhaven", "South Georgia and the South Sandwich Islands", 583, "Eula", new DateTime(2020, 8, 24, 13, 41, 49, 958, DateTimeKind.Local).AddTicks(696), "1-617-591-0668", "Gerhold", @"Odit qui nobis eos.
                Commodi sint rem enim repellat id.
                Provident optio laboriosam asperiores quod qui.", "https://placeimg.com/640/480/any", "33525", "Hawaii", "Eula Gerhold", "Central Factors Strategist", "Eula16" },
                    { 20, "Southeast", new DateTime(1997, 4, 22, 2, 36, 7, 883, DateTimeKind.Local).AddTicks(3832), "South Barrettmouth", "Antigua and Barbuda", 308, "Bessie", new DateTime(2020, 8, 24, 11, 14, 7, 64, DateTimeKind.Local).AddTicks(6526), "729-256-8208", "Hilll", @"Repellendus omnis autem voluptatibus iste asperiores.
                Eius neque dolor mollitia placeat quasi aut.", "https://placeimg.com/640/480/any", "74965-1000", "Minnesota", "Bessie Hilll", "Chief Program Liaison", "Bessie57" },
                    { 17, "Northwest", new DateTime(1964, 5, 25, 3, 12, 5, 758, DateTimeKind.Local).AddTicks(6252), "South Wadeburgh", "Argentina", 237, "Shaun", new DateTime(2020, 8, 24, 14, 23, 56, 376, DateTimeKind.Local).AddTicks(5279), "710.756.8971", "Fisher", @"Ipsum porro et reprehenderit voluptas.
                In nobis hic odit commodi et nam itaque.
                Optio amet animi velit.
                Corrupti et repellendus et eum officiis molestias ad.", "https://placeimg.com/640/480/any", "13592-8495", "Michigan", "Shaun Fisher", "Product Branding Planner", "Shaun66" },
                    { 16, "East", new DateTime(1963, 2, 9, 11, 20, 42, 317, DateTimeKind.Local).AddTicks(154), "Hettingerberg", "Uganda", 227, "Joann", new DateTime(2020, 8, 24, 5, 32, 31, 281, DateTimeKind.Local).AddTicks(884), "(847) 880-9033", "Murazik", @"Et nemo ratione explicabo perspiciatis perferendis enim.
                Quas repellendus ut nesciunt explicabo qui quod et asperiores quis.
                Qui tempore necessitatibus sunt.
                At quia aliquid ut omnis asperiores.
                Eveniet sit quis eaque veniam quibusdam ut cumque repudiandae a.", "https://placeimg.com/640/480/any", "79826-2230", "Arkansas", "Joann Murazik", "Corporate Infrastructure Agent", "Joann43" },
                    { 15, "South", new DateTime(1960, 10, 31, 0, 57, 1, 619, DateTimeKind.Local).AddTicks(2697), "Lake Lou", "Denmark", 49, "Theodore", new DateTime(2020, 8, 24, 3, 29, 20, 72, DateTimeKind.Local).AddTicks(3739), "473-967-8794", "Lakin", @"Esse quae placeat officiis perferendis fuga dolores qui quasi cum.
                Quos totam consequuntur reiciendis adipisci eligendi voluptatibus ex ducimus porro.
                Soluta repellendus magni aut voluptate officia illum dignissimos ut molestias.
                Maxime magni non maxime et.
                Id omnis iste dolor animi reiciendis voluptatem.", "https://placeimg.com/640/480/any", "47709-1424", "Maine", "Theodore Lakin", "Principal Mobility Manager", "Theodore2" },
                    { 14, "West", new DateTime(1973, 6, 2, 20, 29, 59, 169, DateTimeKind.Local).AddTicks(3758), "Lake Jordon", "Solomon Islands", 5, "Angela", new DateTime(2020, 8, 24, 7, 26, 47, 57, DateTimeKind.Local).AddTicks(8749), "1-669-666-8073", "Brakus", @"Facilis eveniet sed atque eius enim ut excepturi possimus.
                Vel reprehenderit perferendis beatae at earum.
                Voluptatem consequatur consectetur earum.
                Aliquid quo corrupti quidem.", "https://placeimg.com/640/480/any", "44397", "Maryland", "Angela Brakus", "Customer Paradigm Developer", "Angela_Brakus11" },
                    { 18, "West", new DateTime(1957, 12, 19, 15, 20, 7, 744, DateTimeKind.Local).AddTicks(6841), "Wardmouth", "Saint Lucia", 743, "Dolores", new DateTime(2020, 8, 24, 0, 36, 2, 662, DateTimeKind.Local).AddTicks(7459), "433-560-0092 x807", "Dietrich", "Ullam voluptas vel possimus asperiores officia qui consequuntur.", "https://placeimg.com/640/480/any", "21204", "Maine", "Dolores Dietrich", "Legacy Directives Producer", "Dolores_Dietrich" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ShipperId", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 30, "Terry, Hammes and Heidenreich", "558.869.8817 x016" },
                    { 21, "Heidenreich - Willms", "900-513-0072" },
                    { 18, "Langworth - Howell", "589.959.9765" },
                    { 19, "Koss, Moore and Keeling", "(944) 547-3976 x49157" },
                    { 20, "Schoen, Toy and Marks", "415-963-0885 x7306" },
                    { 22, "Sawayn, Von and Mayer", "892-688-0750" },
                    { 28, "Bergstrom - Lebsack", "248-906-8701 x6622" },
                    { 24, "Bednar LLC", "415.400.2965" },
                    { 25, "Abbott, Kohler and Walker", "339.316.8221" },
                    { 26, "Kautzer - Crist", "905-568-5343 x759" },
                    { 27, "Witting - Gusikowski", "444.666.1454 x0946" },
                    { 29, "Harvey, Bauch and Torphy", "(988) 401-4549 x6144" },
                    { 17, "Beier LLC", "(742) 629-5547" },
                    { 23, "Sporer Inc", "648-279-1528 x84668" },
                    { 16, "Paucek and Sons", "1-483-947-9513 x27138" },
                    { 13, "Carter - Sawayn", "934-467-8999" },
                    { 14, "Parisian - Feeney", "1-908-412-8506" },
                    { 15, "Hayes - Stoltenberg", "966.517.0735 x2744" },
                    { 1, "Rolfson, Lowe and Blick", "1-682-859-1332 x42953" },
                    { 3, "Beatty - Ondricka", "1-919-611-1096" },
                    { 4, "Becker, Welch and Kulas", "1-703-248-7671" },
                    { 5, "Dietrich - VonRueden", "717-980-9256 x191" },
                    { 6, "Heller Inc", "979-853-6151 x9376" },
                    { 2, "Renner - Hickle", "(390) 368-3076" },
                    { 8, "Mante - Harvey", "565.353.8088" },
                    { 9, "Ernser, O'Connell and Larkin", "1-738-633-4084 x68558" },
                    { 10, "Bradtke LLC", "(301) 276-5357" },
                    { 11, "Witting - Walker", "1-782-679-8907" },
                    { 12, "Weimann LLC", "568.255.2865" },
                    { 7, "Funk, O'Reilly and Frami", "(604) 434-5415 x6535" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "HomePage", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 11, "West", "East Mozellshire", "Kling - Bosco", "Candice Bergstrom", "Customer Program Manager", "South Africa", "Candice53", "anastasia.info", "(948) 832-5427", "87146-3037", "Minnesota" },
                    { 18, "West", "West Chris", "Connelly Group", "Jordan Roob", "Internal Group Liaison", "South Georgia and the South Sandwich Islands", "Jordan45", "kitty.net", "1-617-925-1002 x227", "28315", "Wyoming" },
                    { 17, "East", "Aydenside", "Feeney - Stiedemann", "Priscilla Rodriguez", "International Security Developer", "Lao People's Democratic Republic", "Priscilla40", "shanelle.info", "(290) 858-9600 x3716", "21811-8210", "Missouri" },
                    { 16, "Southwest", "North Arielleview", "Collins Group", "Lynette Rippin", "Central Tactics Facilitator", "Cayman Islands", "Lynette.Rippin", "ian.name", "693-884-6487 x8929", "87340-1353", "Maryland" },
                    { 15, "Southeast", "New Horacio", "Mueller and Sons", "Krystal Kilback", "Corporate Implementation Designer", "Guyana", "Krystal_Kilback", "billie.name", "216-308-3072 x402", "05817", "Connecticut" },
                    { 14, "Northeast", "Rodrickstad", "Kemmer and Sons", "Gordon Schulist", "Lead Interactions Engineer", "Eritrea", "Gordon_Schulist", "macey.org", "580.796.0205 x9195", "27923-7857", "New Mexico" },
                    { 13, "South", "South Devynmouth", "Turner, Brekke and Nader", "Rosemarie Morar", "Central Markets Strategist", "Spain", "Rosemarie_Morar", "jonatan.com", "303.349.9694 x397", "18372", "Minnesota" },
                    { 12, "Northeast", "Juliannefort", "Stokes, Howell and Casper", "Meredith Hintz", "Dynamic Factors Engineer", "Cyprus", "Meredith_Hintz20", "ole.biz", "1-762-971-5582", "50013-1982", "New Mexico" },
                    { 10, "Southeast", "Mariloumouth", "Predovic - Mueller", "Louis Collins", "Corporate Web Technician", "Australia", "Louis_Collins", "destany.com", "650.993.1099", "57209-7492", "New York" },
                    { 3, "East", "Wiegandfort", "Renner, Armstrong and Leannon", "Rose Cummerata", "Product Tactics Producer", "Antigua and Barbuda", "Rose97", "olin.com", "961-706-0249", "78099-6194", "Arkansas" },
                    { 8, "Northeast", "East Ella", "Keebler Inc", "Kenny Marvin", "Global Web Engineer", "Liechtenstein", "Kenny28", "laila.biz", "1-490-437-8177", "24724", "Tennessee" },
                    { 7, "South", "North Ruthie", "Hahn - Prosacco", "Natasha Leannon", "District Tactics Orchestrator", "Malaysia", "Natasha45", "jameson.org", "1-510-692-2205", "12880-8086", "Minnesota" },
                    { 6, "Northeast", "Lake Armandborough", "Swift, Hoppe and Graham", "Chris Hilpert", "District Division Technician", "Antigua and Barbuda", "Chris.Hilpert93", "keira.com", "595-648-0659 x7315", "10861", "New Jersey" },
                    { 5, "Southwest", "Emmetshire", "Johnson - Witting", "Doyle Larkin", "Legacy Program Strategist", "Vietnam", "Doyle13", "lottie.name", "816.200.8534 x75777", "67767-4476", "North Dakota" },
                    { 4, "East", "Port Helene", "Bradtke - Wunsch", "Bertha Borer", "Investor Research Architect", "Albania", "Bertha_Borer13", "rosamond.info", "(682) 522-3307 x15188", "05645", "Colorado" },
                    { 2, "South", "North Nonamouth", "Stamm - Anderson", "Jerome Kreiger", "Human Web Facilitator", "Bulgaria", "Jerome.Kreiger", "cale.com", "354.545.8534 x062", "60546", "Kentucky" },
                    { 1, "West", "Lake Consueloport", "Ortiz Inc", "Janis Reichel", "Human Directives Producer", "Jersey", "Janis.Reichel57", "cydney.net", "497-441-0516", "96548-4021", "North Carolina" },
                    { 19, "East", "Coraliemouth", "Schaden, White and Ferry", "Lila Swift", "Investor Metrics Designer", "Venezuela", "Lila6", "maude.biz", "1-981-268-8142 x6359", "27150-0275", "Pennsylvania" },
                    { 9, "South", "Port Kellie", "Crist - Mosciski", "Warren Denesik", "Dynamic Accountability Officer", "Antigua and Barbuda", "Warren.Denesik", "shanel.name", "(548) 250-9598", "75245", "New Mexico" },
                    { 20, "South", "Bartolettitown", "Johnston - Runte", "Salvador Rohan", "National Mobility Specialist", "Guyana", "Salvador_Rohan", "georgiana.org", "786.528.9251 x87272", "18365", "South Carolina" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "Freight", "OrderDate", "RequiredDate", "ShipAddress", "ShipCity", "ShipCountry", "ShipName", "ShipPostalCode", "ShipRegion", "ShipVia", "ShippedDate", "ShipperId" },
                values: new object[,]
                {
                    { 8, 5, 4, 8.0, new DateTime(2020, 8, 23, 21, 39, 48, 25, DateTimeKind.Local).AddTicks(1541), new DateTime(2020, 8, 25, 14, 12, 42, 217, DateTimeKind.Local).AddTicks(3224), "South", "East Ruby", "Bahamas", "Curtis Mitchell", "20231", "Nevada", "Jaylon Ports", new DateTime(2020, 8, 25, 7, 47, 13, 92, DateTimeKind.Local).AddTicks(1482), 1 },
                    { 2, 19, 28, 69.0, new DateTime(2020, 8, 23, 21, 29, 44, 420, DateTimeKind.Local).AddTicks(9906), new DateTime(2020, 8, 25, 13, 16, 26, 736, DateTimeKind.Local).AddTicks(5049), "Southeast", "Streichton", "Central African Republic", "Ebony Schmidt", "30537-7613", "Illinois", "Wilkinson Wall", new DateTime(2020, 8, 29, 2, 46, 34, 814, DateTimeKind.Local).AddTicks(612), 30 },
                    { 13, 12, 31, 48.0, new DateTime(2020, 8, 24, 17, 19, 31, 435, DateTimeKind.Local).AddTicks(2809), new DateTime(2020, 8, 25, 5, 33, 47, 936, DateTimeKind.Local).AddTicks(724), "Southwest", "Minervaport", "Chile", "Eddie Koss", "13544", "Maryland", "Ratke Circles", new DateTime(2020, 8, 16, 4, 54, 23, 500, DateTimeKind.Local).AddTicks(860), 29 },
                    { 10, 1, 21, 14.0, new DateTime(2020, 8, 24, 4, 55, 8, 333, DateTimeKind.Local).AddTicks(236), new DateTime(2020, 8, 24, 21, 27, 57, 85, DateTimeKind.Local).AddTicks(1085), "South", "Vergiebury", "Taiwan", "Audrey Wunsch", "82298-3862", "Virginia", "Padberg Turnpike", new DateTime(2020, 8, 16, 21, 18, 58, 135, DateTimeKind.Local).AddTicks(2626), 28 },
                    { 11, 9, 38, 47.0, new DateTime(2020, 8, 24, 18, 30, 25, 444, DateTimeKind.Local).AddTicks(6802), new DateTime(2020, 8, 25, 6, 58, 28, 484, DateTimeKind.Local).AddTicks(3001), "Southeast", "South Wilford", "Bhutan", "Rogelio Murazik", "42393-4834", "North Carolina", "Morissette Circle", new DateTime(2020, 8, 29, 4, 30, 54, 625, DateTimeKind.Local).AddTicks(5368), 25 },
                    { 5, 23, 25, 48.0, new DateTime(2020, 8, 23, 21, 44, 58, 994, DateTimeKind.Local).AddTicks(878), new DateTime(2020, 8, 25, 7, 12, 9, 803, DateTimeKind.Local).AddTicks(62), "Northeast", "Lake Gwendolynhaven", "Myanmar", "Roman Mayer", "92037-5088", "Oklahoma", "Hoppe Corners", new DateTime(2020, 8, 16, 17, 47, 37, 401, DateTimeKind.Local).AddTicks(8081), 25 },
                    { 18, 18, 36, 71.0, new DateTime(2020, 8, 24, 4, 53, 5, 224, DateTimeKind.Local).AddTicks(4804), new DateTime(2020, 8, 25, 19, 1, 18, 914, DateTimeKind.Local).AddTicks(4219), "Southeast", "West Rhodaview", "Tanzania", "Lester Gislason", "34782", "Utah", "Emma Field", new DateTime(2020, 8, 31, 11, 0, 50, 237, DateTimeKind.Local).AddTicks(1812), 24 },
                    { 4, 17, 43, 49.0, new DateTime(2020, 8, 23, 23, 36, 14, 144, DateTimeKind.Local).AddTicks(8933), new DateTime(2020, 8, 25, 2, 18, 34, 965, DateTimeKind.Local).AddTicks(8566), "West", "Framiborough", "Norfolk Island", "Willard Purdy", "95282-4394", "Illinois", "Carlotta Crest", new DateTime(2020, 8, 29, 20, 45, 28, 185, DateTimeKind.Local).AddTicks(3797), 24 },
                    { 14, 20, 20, 48.0, new DateTime(2020, 8, 24, 0, 12, 6, 548, DateTimeKind.Local).AddTicks(6053), new DateTime(2020, 8, 25, 7, 31, 51, 787, DateTimeKind.Local).AddTicks(7649), "Southeast", "Port Mattmouth", "United States Minor Outlying Islands", "Roland Herman", "28710", "Hawaii", "Boyle Highway", new DateTime(2020, 8, 20, 11, 48, 24, 156, DateTimeKind.Local).AddTicks(1784), 22 },
                    { 17, 12, 37, 77.0, new DateTime(2020, 8, 24, 10, 28, 14, 375, DateTimeKind.Local).AddTicks(7048), new DateTime(2020, 8, 25, 9, 29, 23, 22, DateTimeKind.Local).AddTicks(9051), "West", "Marjolainetown", "Wallis and Futuna", "Lucas Kertzmann", "96991", "Oklahoma", "Mraz Flats", new DateTime(2020, 8, 17, 0, 44, 47, 373, DateTimeKind.Local).AddTicks(2530), 19 },
                    { 15, 19, 37, 10.0, new DateTime(2020, 8, 23, 21, 19, 23, 215, DateTimeKind.Local).AddTicks(9535), new DateTime(2020, 8, 24, 21, 36, 21, 501, DateTimeKind.Local).AddTicks(5645), "Southwest", "New Anthonyfurt", "Sudan", "Gretchen Lowe", "26626", "Kentucky", "Cathrine Tunnel", new DateTime(2020, 8, 22, 10, 3, 29, 982, DateTimeKind.Local).AddTicks(7138), 30 },
                    { 20, 23, 36, 48.0, new DateTime(2020, 8, 24, 0, 28, 31, 214, DateTimeKind.Local).AddTicks(6851), new DateTime(2020, 8, 24, 20, 38, 9, 437, DateTimeKind.Local).AddTicks(6733), "East", "Taliaville", "Barbados", "Rachel Schamberger", "37393", "Vermont", "Kaylin Motorway", new DateTime(2020, 8, 25, 17, 58, 48, 790, DateTimeKind.Local).AddTicks(7950), 18 },
                    { 6, 19, 21, 16.0, new DateTime(2020, 8, 24, 0, 58, 15, 840, DateTimeKind.Local).AddTicks(5151), new DateTime(2020, 8, 25, 8, 56, 18, 821, DateTimeKind.Local).AddTicks(7495), "South", "East Delmerfort", "French Southern Territories", "Chris Mitchell", "86695", "Pennsylvania", "Zemlak Way", new DateTime(2020, 8, 18, 4, 44, 17, 473, DateTimeKind.Local).AddTicks(6210), 17 },
                    { 16, 10, 18, 25.0, new DateTime(2020, 8, 24, 16, 14, 8, 582, DateTimeKind.Local).AddTicks(1079), new DateTime(2020, 8, 25, 3, 38, 27, 660, DateTimeKind.Local).AddTicks(9744), "North", "Lake Macey", "Virgin Islands, British", "Eric Kunde", "98033-0336", "Alabama", "Gabriella Islands", new DateTime(2020, 9, 1, 18, 1, 52, 203, DateTimeKind.Local).AddTicks(7776), 16 },
                    { 19, 4, 45, 76.0, new DateTime(2020, 8, 24, 8, 57, 59, 583, DateTimeKind.Local).AddTicks(1476), new DateTime(2020, 8, 25, 3, 9, 54, 63, DateTimeKind.Local).AddTicks(5967), "East", "North Doraton", "Belgium", "Jesus Windler", "46326-9391", "New Mexico", "Lydia Port", new DateTime(2020, 8, 31, 10, 15, 2, 168, DateTimeKind.Local).AddTicks(5395), 11 },
                    { 3, 5, 27, 15.0, new DateTime(2020, 8, 24, 0, 14, 3, 647, DateTimeKind.Local).AddTicks(1599), new DateTime(2020, 8, 25, 11, 47, 29, 583, DateTimeKind.Local).AddTicks(4107), "Southwest", "Reingerhaven", "Saint Vincent and the Grenadines", "Franklin Schiller", "85691", "Connecticut", "Corkery Greens", new DateTime(2020, 8, 24, 22, 9, 24, 93, DateTimeKind.Local).AddTicks(2402), 10 },
                    { 12, 24, 12, 91.0, new DateTime(2020, 8, 24, 1, 50, 31, 568, DateTimeKind.Local).AddTicks(1039), new DateTime(2020, 8, 25, 12, 52, 9, 0, DateTimeKind.Local).AddTicks(7649), "Southwest", "Okunevaborough", "Burundi", "Rick Funk", "87620-1818", "North Carolina", "Remington Plains", new DateTime(2020, 9, 3, 8, 5, 34, 844, DateTimeKind.Local).AddTicks(9879), 8 },
                    { 7, 22, 23, 15.0, new DateTime(2020, 8, 24, 2, 23, 56, 449, DateTimeKind.Local).AddTicks(6121), new DateTime(2020, 8, 24, 21, 59, 11, 17, DateTimeKind.Local).AddTicks(447), "Southwest", "Isabelltown", "Samoa", "Silvia Streich", "27974", "Wyoming", "Veum Haven", new DateTime(2020, 8, 30, 13, 47, 1, 919, DateTimeKind.Local).AddTicks(8176), 8 },
                    { 9, 19, 33, 8.0, new DateTime(2020, 8, 23, 20, 39, 49, 793, DateTimeKind.Local).AddTicks(6087), new DateTime(2020, 8, 25, 11, 16, 21, 724, DateTimeKind.Local).AddTicks(9130), "Southwest", "East Lornachester", "Qatar", "Mario Yost", "76568-6159", "New Hampshire", "Ocie Ports", new DateTime(2020, 8, 25, 7, 18, 27, 249, DateTimeKind.Local).AddTicks(3213), 4 },
                    { 1, 7, 26, 43.0, new DateTime(2020, 8, 24, 14, 59, 41, 467, DateTimeKind.Local).AddTicks(9965), new DateTime(2020, 8, 24, 22, 25, 25, 204, DateTimeKind.Local).AddTicks(6525), "South", "Kiehnport", "Marshall Islands", "Theresa Padberg", "79044-0723", "Nebraska", "Junius Highway", new DateTime(2020, 9, 1, 19, 51, 15, 579, DateTimeKind.Local).AddTicks(7430), 19 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Discontinued", "ProductName", "QuantiryPerUnit", "ReorderLevel", "SupplierId", "UnitPrice", "UnitsInStock", "UnitsOnOrder" },
                values: new object[,]
                {
                    { 7, 24, true, "Awesome Wooden Car", 0, 2, 11, 946, 178, 0 },
                    { 12, 23, true, "Rustic Wooden Shirt", 1, 10, 11, 366, 139, 0 },
                    { 15, 8, true, "Awesome Concrete Pizza", 1, 9, 11, 80, 91, 0 },
                    { 3, 1, false, "Handmade Granite Chair", 1, 1, 18, 433, 189, 0 },
                    { 13, 7, true, "Gorgeous Frozen Shirt", 1, 1, 12, 473, 109, 0 },
                    { 5, 12, false, "Handmade Plastic Salad", 0, 9, 16, 128, 25, 0 },
                    { 18, 27, true, "Rustic Cotton Mouse", 1, 8, 10, 12, 20, 0 },
                    { 8, 29, true, "Incredible Frozen Cheese", 0, 3, 12, 379, 121, 0 },
                    { 11, 2, false, "Gorgeous Rubber Chips", 0, 2, 10, 161, 59, 0 },
                    { 6, 24, false, "Ergonomic Steel Tuna", 0, 7, 8, 758, 144, 0 },
                    { 19, 11, false, "Small Steel Gloves", 1, 8, 8, 341, 115, 0 },
                    { 17, 6, false, "Generic Metal Ball", 0, 2, 8, 434, 172, 0 },
                    { 14, 11, false, "Ergonomic Metal Ball", 0, 7, 6, 694, 42, 0 },
                    { 2, 21, true, "Gorgeous Steel Ball", 1, 2, 6, 552, 27, 0 },
                    { 16, 5, false, "Unbranded Soft Keyboard", 1, 7, 5, 272, 47, 0 },
                    { 4, 15, true, "Unbranded Plastic Mouse", 1, 8, 4, 946, 44, 0 },
                    { 1, 12, true, "Gorgeous Soft Bike", 1, 7, 1, 501, 3, 0 },
                    { 10, 9, true, "Intelligent Fresh Shirt", 0, 10, 18, 589, 57, 0 },
                    { 20, 24, true, "Practical Frozen Keyboard", 1, 5, 9, 831, 197, 0 },
                    { 9, 5, false, "Incredible Concrete Shoes", 1, 3, 19, 846, 140, 0 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailsId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 6, 5, 4, 9, 493 },
                    { 13, 3, 10, 75, 660 },
                    { 4, 17, 3, 24, 729 },
                    { 2, 15, 3, 14, 312 },
                    { 20, 7, 5, 73, 881 },
                    { 16, 10, 13, 46, 917 },
                    { 14, 13, 13, 18, 331 },
                    { 8, 4, 13, 9, 206 },
                    { 1, 3, 13, 14, 781 },
                    { 18, 10, 8, 96, 4 },
                    { 3, 1, 15, 69, 7 },
                    { 10, 16, 12, 46, 620 },
                    { 7, 5, 18, 62, 388 },
                    { 15, 16, 11, 59, 399 },
                    { 12, 13, 16, 1, 311 },
                    { 11, 7, 16, 39, 817 },
                    { 9, 3, 16, 56, 589 },
                    { 19, 6, 4, 85, 619 },
                    { 5, 12, 9, 9, 404 },
                    { 17, 13, 9, 37, 535 }
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
