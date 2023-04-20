using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", null, "Admin", null },
                    { "customer", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Featured" },
                    { 3, "Popular" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "The EchoWave 2000 is a powerful vintage-style synthesizer with unique oscillators, customizable filters, and a built-in sequencer, arpeggiator, and modulation matrix. Whether you're a professional musician or a beginner, the EchoWave 2000 is the perfect tool for unleashing your creativity and exploring new sonic territories.", "product1.jpg", "EchoWave 2000", 899m },
                    { 2, "The Neptune Starlight is a compact yet powerful synthesizer that offers a wide range of sounds and features. With its advanced synthesis engine, intuitive interface, and onboard effects, you can easily create anything from classic analog tones to cutting-edge digital textures. Whether you're performing on stage or producing in the studio, the Neptune Starlight is an essential tool for any musician.", "product2.jpg", "Neptune Starlight", 499m },
                    { 3, "The Cosmic Voyager is a stunning analog synthesizer with a classic design that harkens back to the golden age of electronic music. Featuring a full-size keyboard, vintage-style filters, and a powerful modulation matrix, the Cosmic Voyager is a must-have for any synth enthusiast. Whether you're creating soaring lead lines, funky bass grooves, or complex soundscapes, the Cosmic Voyager has you covered.", "product3.jpg", "Cosmic Voyager", 1199m },
                    { 4, "The Nova Synth 2000 is a powerful virtual analog synthesizer that combines cutting-edge digital technology with classic analog sound. With its intuitive interface, advanced synthesis engine, and onboard effects, you can easily create anything from warm pads and strings to aggressive leads and basses. Whether you're a professional musician or a bedroom producer, the Nova Synth 2000 is the ultimate tool for sound design and music production.", "product4.jpg", "Nova Synth 2000", 699m },
                    { 5, "The Jupiter Station is a stunning digital synthesizer with a classic design that harkens back to the glory days of synth-pop. Featuring a massive sound engine, intuitive controls, and a sleek user interface, the Jupiter Station is the perfect tool for creating anything from lush pads and ambient textures to powerful leads and basses. Whether you're a professional musician or a hobbyist, the Jupiter Station is a must-have for any synth lover.", "product5.jpg", "Jupiter Station", 999m },
                    { 6, "The Solaris Synth x2 is a cutting-edge digital synthesizer that combines advanced sound design capabilities with intuitive performance features. With its modular architecture, extensive modulation options, and powerful effects, the Solaris Synth x2 is the ultimate tool for creating complex and evolving soundscapes. Whether you're a sound designer, film composer, or electronic musician, the Solaris Synth x2 is the perfect choice for exploring new sonic frontiers.", "product6.jpg", "Solaris Synth x2", 1799m },
                    { 7, "The Analog Dream 8 is a powerful analog synthesizer with a modern twist. Featuring classic oscillators, a versatile filter section, and a built-in sequencer, the Analog Dream 8 is the perfect tool for creating anything from fat bass lines to soaring leads. Whether you're a seasoned synth pro or a beginner, the Analog Dream 8 is an essential addition to your studio setup.", "product7.jpg", "Analog Dream 8", 799m },
                    { 8, "The Matrix Tribe is a groundbreaking digital synthesizer that offers unparalleled sound design capabilities. With its advanced modulation matrix, unique waveshaping algorithms, and built-in effects, the Matrix Tribe is the ultimate tool for creating complex and evolving textures. Whether you're a sound designer, experimental musician, or electronic artist, the Matrix Tribe is the perfect choice for pushing the boundaries of sound.", "product8.jpg", "Matrix Tribe", 1499m },
                    { 9, "The MicroDoser XXL is a compact synthesizer that packs a punch. Featuring a powerful synthesis engine, a wide range of sounds, and an intuitive interface, the MicroDoser XXL is the perfect tool for creating anything from vintage-style analog tones to modern digital textures. Whether you're performing live or producing in the studio, the MicroDoser XXL is a versatile and essential tool for any musician.", "product9.jpg", "MicroDoser XXL", 599m },
                    { 10, "The Solar Flax is a stunning digital synthesizer with a sleek and modern design. Featuring a powerful sound engine, intuitive controls, and a built-in arpeggiator, the Solar Flax is the perfect tool for creating anything from classic analog sounds to cutting-edge digital textures. Whether you're a professional musician or a hobbyist, the Solar Flax is a must-have for any synth lover.", "product10.jpg", "Solar Flax", 899m },
                    { 11, "The Neon Pulse 5 is a legendary analog synthesizer that has been used on countless classic recordings. With its warm and rich sound, versatile filter section, and intuitive interface, the Neon Pulse 5 is still the standard by which all other synthesizers are judged. Whether you're a professional musician or a vintage synth collector, the Neon Pulse 5 is an essential addition to your studio setup.", "product11.jpg", "Neon Pulse 5", 3999m },
                    { 12, "The Velocity Drive is a powerful digital synthesizer that offers a wide range of sounds and features. With its advanced sound engine, intuitive interface, and onboard effects, you can easily create anything from classic analog tones to cutting-edge digital textures. Whether you're performing live or producing in the studio, the Velocity Drive is an essential tool for any musician.", "product12.jpg", "Velocity Drive", 499m },
                    { 13, "The Modular Madness 88 is a customizable and expandable digital synthesizer that allows you to create your own unique sound. Featuring a modular design, you can add and remove modules to create a synth that is tailored to your specific needs. With its advanced modulation capabilities, built-in effects, and intuitive interface, the Modular Madness 88 is the ultimate tool for sound design and experimentation.", "product13.jpg", "Modular Madness 88", 1999m },
                    { 14, "The Quantum Wave Z is a powerful and versatile digital synthesizer that offers a wide range of sounds and features. With its advanced sound engine, intuitive interface, and built-in effects, you can easily create anything from classic analog tones to modern digital textures. Whether you're performing live or producing in the studio, the Quantum Wave Z is an essential tool for any musician.", "product14.jpg", "Quantum Wave Z", 899m },
                    { 15, "The InfinityX 888 is a modern analog synthesizer that builds upon the classic sound of the Prophet 5. Featuring a rich and warm sound, versatile filter section, and intuitive interface, the InfinityX 888 is the perfect tool for creating anything from fat bass lines to soaring leads. Whether you're a seasoned synth pro or a beginner, the InfinityX 888 is an essential addition to your studio setup.", "product15.jpg", "InfinityX 888", 2999m },
                    { 16, "The MicroQuantum 420 is a cutting-edge digital synthesizer that offers unparalleled sound design capabilities. Featuring advanced wavetable algorithms, a versatile filter section, and a built-in arpeggiator, the MicroQuantum 420 is the perfect tool for creating complex and evolving textures. Whether you're a sound designer, experimental musician, or electronic artist, the MicroQuantum 420 is the ultimate choice for pushing the boundaries of sound.", "product16.jpg", "MicroQuantum 420", 1299m },
                    { 17, "The Moonbox Charger is a vintage analog synthesizer that has been used on countless classic recordings. With its warm and rich sound, versatile filter section, and intuitive interface, the Moonbox Charger is still a favorite among synth enthusiasts. Whether you're a vintage synth collector or a modern musician looking for classic tones, the Moonbox Charger is an essential addition to your studio setup.", "product17.jpg", "Moonbox Charger", 2499m },
                    { 18, "The ScreamR is a versatile digital synthesizer with a sleek and modern design. Featuring advanced sound synthesis algorithms, a wide range of sounds, and a built-in sequencer, the ScreamR is the perfect tool for creating anything from classic analog tones to cutting-edge digital textures. Whether you're a professional musician or a hobbyist, the ScreamR is a must-have for any synth lover.", "product18.jpg", "ScreamR", 999m },
                    { 19, "The MiniMono Galactic is a powerful analog synthesizer with a classic sound. Featuring a versatile filter section, a built-in sequencer, and an intuitive interface, the MiniMono Galactic is perfect for creating everything from deep bass lines to soaring leads. With its compact size and rugged construction, the MiniMono Galactic is perfect for both live performance and studio use.", "product19.jpg", "MiniMono Galactic", 599m },
                    { 20, "The FM Galaxy Brain is a powerful digital synthesizer that uses frequency modulation to create complex and evolving sounds. Featuring advanced algorithms, a wide range of sounds, and a built-in effects section, the FM Galaxy Brain is the perfect tool for sound design and experimentation. Whether you're a synth enthusiast or a professional musician, the FM Galaxy Brain is an essential addition to your studio setup.", "product20.jpg", "FM Galaxy Brain", 1499m }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
