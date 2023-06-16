using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeanSceneReservationSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SittingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SittingTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sittings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Vacancies = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SittingTypeId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sittings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sittings_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sittings_SittingTypes_SittingTypeId",
                        column: x => x.SittingTypeId,
                        principalTable: "SittingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    PosX = table.Column<double>(type: "float", nullable: true),
                    PosY = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantTables_Areas_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestNumber = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationSourceId = table.Column<int>(type: "int", nullable: false),
                    ReservationStatusId = table.Column<int>(type: "int", nullable: false),
                    SittingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationSources_ReservationSourceId",
                        column: x => x.ReservationSourceId,
                        principalTable: "ReservationSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationStatus_ReservationStatusId",
                        column: x => x.ReservationStatusId,
                        principalTable: "ReservationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Sittings_SittingId",
                        column: x => x.SittingId,
                        principalTable: "Sittings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantTableId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationsTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationsTable_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationsTable_RestaurantTables_RestaurantTableId",
                        column: x => x.RestaurantTableId,
                        principalTable: "RestaurantTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Main", null },
                    { 2, "Outside", null },
                    { 3, "Balcony", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "e31f1a41-daae-4a9d-92b3-7ce7deaf04df", "Manager", "MANAGER" },
                    { "60226d81-1906-41cb-8f00-44e34ee158cd", "35ca6d8b-e428-4a51-98e4-9a90cc002f94", "Staff", "STAFF" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "825abc41-7279-4c08-90e4-3ee32dde7558", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e545865-a24d-4543-a6c6-9443d048cdb9", 0, "b712550c-3bff-42a9-ae0a-c049ef61f297", "Manager@test.com", true, false, null, "MANAGER@TEST.COM", "Manager@test.com", "AQAAAAEAACcQAAAAELS3ag2SoVzUpOCSewohb2q17/U/dNXeOcA7GKR+ZUUGyv3gKt1iEXvoH4pM5F41ig==", null, false, "1e754ed0-ad9b-4744-aa63-78e33eb9f4e8", false, "Tester" },
                    { "8e645865-a24d-4543-a6c6-9443d048cdb9", 0, "fa7bb3db-8997-42de-b36f-ee52450720f6", "Staff@test.com", true, false, null, "STAFF@TEST.COM", "Staff@test.com", "AQAAAAEAACcQAAAAENBYbbh8pmSPjtmyxdyFstgqnXZPyd0y7Po38kCwHE6uXxTJV40MU5r1/zZm1ivcBQ==", null, false, "0c4a5620-dc54-4e80-b00b-66c08bde5187", false, "Staff@test.com" },
                    { "8l645865-a24d-4543-a6c6-9443d048cdb9", 0, "d23bbdd4-a918-4d06-a7f7-d502f0630a3c", "a@a.com", true, false, null, "A@A.COM", "A@A.COM", "AQAAAAEAACcQAAAAECfl51B26g2wyexoDegRQyzSQS2q4d6Ma+7j81XiMXvcZji7oHgBFPf4I00ATVBTPA==", null, false, "bf8e5178-d395-401d-801e-715d2efcbcb8", false, "John" },
                    { "8l645865-b24d-4543-a6c6-9443d048cdb9", 0, "c302715c-dd5a-4d37-a890-79815034be18", "b@b.com", true, false, null, "B@B.COM", "B@B.COM", "AQAAAAEAACcQAAAAECM9xGijF8N6j96pNTedWeJmpAjWXer6zsiwF/3WO7zK7zYCO2B3aDZo2JAs+Z7chQ==", null, false, "31e39839-11e3-4879-921b-75cdcd0cf292", false, "Fred" },
                    { "8l645865-c24d-4543-a6c6-9443d048cdb9", 0, "d2f3b46e-e2ee-472f-9a3f-0caa6d0916d1", "c@c.com", true, false, null, "C@C.COM", "C@C.COM", "AQAAAAEAACcQAAAAEKjfmvW6cTqN3MnGCJHsyJLGnJNjRL7l+IJavPFjNXPAztgH1WFtJsW0tzM/9YguIg==", null, false, "17a6ccc3-2b13-417f-bab1-43e27c2334a8", false, "Sarah" },
                    { "8l645865-d24d-4543-a6c6-9443d048cdb9", 0, "f56554fe-bb94-459e-9e12-55e50cedbbc3", "d@d.com", true, false, null, "D@D.COM", "D@D.COM", "AQAAAAEAACcQAAAAEDX64jwzfUnYWDdi9w9PCHrxVEmY323epxwjd4LE7++V7AAGJ0OrOlAAX7jaY36oCw==", null, false, "899a43b2-96d5-42c7-a74a-5eab7074c40f", false, "Lousie" },
                    { "8l645865-e24d-4543-a6c6-9443d048cdb9", 0, "72ae129a-999f-4e4f-88ef-bffef9821043", "e@e.com", true, false, null, "E@E.COM", "E@E.COM", "AQAAAAEAACcQAAAAEEIQWaLi3xnYVPzEiYKUB2vwyrlZqh0Cem5wRQdKSt/Ata/SOUnXKSkq0Z6gJcTkew==", null, false, "b10d1055-6ec3-4894-8857-554676e527d2", false, "Katie" },
                    { "8l645865-f24d-4543-a6c6-9443d048cdb9", 0, "1ca8254a-2880-4691-b65f-6332bf51d49a", "f@f.com", true, false, null, "F@F.COM", "F@F.COM", "AQAAAAEAACcQAAAAEOmcPL1AY6ZtFdtj1881kvuyDXIi41ggZJQPhYj9mTJ7EQlPM/Xf0g7Rb72xQzscAg==", null, false, "4c988dc8-03f2-4f1a-b94c-0492fccc037d", false, "Ben" },
                    { "8l645865-g24d-4543-a6c6-9443d048cdb9", 0, "c73ccba4-87bf-464e-87f3-72d6842b70c7", "g@g.com", true, false, null, "G@G.COM", "G@G.COM", "AQAAAAEAACcQAAAAEBXRAdGsidSXza/vSpKzOhmwtsT+bTiE6/NKEDhF6wvNtCT2Ss4JkVQmIKzXYrHohA==", null, false, "653abea4-7e16-4b8a-a541-9e11aab7ac22", false, "Lucas" },
                    { "8l645865-h24d-4543-a6c6-9443d048cdb9", 0, "e26b094c-d8d3-4a5f-af1d-516f2c63c6be", "h@h.com", true, false, null, "H@H.COM", "H@H.COM", "AQAAAAEAACcQAAAAEIQCDbFqkcc5ckGWdb0cz1PKlnfFoFZcj5/FX3KgXbmpIHwuMhrXvOFt0wQ+tX0v7A==", null, false, "d875b3d3-4855-4c5c-b9a8-21a0fc532463", false, "Liam" },
                    { "8l645865-i24d-4543-a6c6-9443d048cdb9", 0, "c439e242-f1ba-46bd-9ec0-050bb59456c0", "i@i.com", true, false, null, "I@I.COM", "I@I.COM", "AQAAAAEAACcQAAAAEIrbD5+e0m/2oYF8D8RnYt7V6fhWSmnTUzDA+5Pa6QE8JU9QM+CGk4UkqPjzLAJBTg==", null, false, "371a56d0-da57-4af5-8f66-8c932b4ac6f0", false, "Emma" },
                    { "8l645865-j24d-4543-a6c6-9443d048cdb9", 0, "c7bcbf62-338d-429f-b9d1-dfe7ffe33d8e", "j@j.com", true, false, null, "J@J.COM", "J@J.COM", "AQAAAAEAACcQAAAAEGThr8hW2r/izagPy3wcFlvVRGAPwp02OLUXdpEP+cC3u3HaiqIvKu+CMfqsxOuMgw==", null, false, "7899880d-f470-4445-beb3-c31c80adc50b", false, "Kayla" },
                    { "8l645865-k24d-4543-a6c6-9443d048cdb9", 0, "fc99db7a-2f07-44c1-9012-32a448836793", "k@k.com", true, false, null, "K@K.COM", "K@K.COM", "AQAAAAEAACcQAAAAEAjy6np6U56A9QY7YfyR8RpruI+SrdJMkX/VgQOx2p3Es83kMeLopDJ/ccXO5OrEQA==", null, false, "08daa7ad-c04f-459f-8832-be475994107b", false, "Levi" },
                    { "8l645865-l24d-4543-a6c6-9443d048cdb9", 0, "560108ca-b91a-4efa-b9df-48ce26554329", "l@l.com", true, false, null, "L@L.COM", "L@L.COM", "AQAAAAEAACcQAAAAEOpfejrZE637TpIzc2DPw0tKiOhZR71GFub4hPNWMDrjyyLUH3607kRJwGxbZWIAWw==", null, false, "3508f1f0-7629-408e-94cf-939db77338de", false, "Noah" },
                    { "8l645865-m24d-4543-a6c6-9443d048cdb9", 0, "03322391-7a60-4d4f-ae7d-a04cc30950c3", "m@m.com", true, false, null, "M@M.COM", "M@M.COM", "AQAAAAEAACcQAAAAEIBSscJvc5ErfRlpVHKWIVP2YcS+2mmHibkqGPB70AKr+YhCORvktjDAUzKFv5OTOg==", null, false, "68ae0417-2093-482e-9dc5-34275e60f66b", false, "Oliver" },
                    { "8l645865-n24d-4543-a6c6-9443d048cdb9", 0, "fb1640b5-bdac-4ed4-9689-ce9a6ad9debb", "n@n.com", true, false, null, "N@N.COM", "N@N.COM", "AQAAAAEAACcQAAAAENfOv9Yv5ogLp5gy06O0HspXOcHdAeLOBvUgXaP1fGG2TNWRzwXoUB/o9yOc+r81EA==", null, false, "9c088dcd-d827-46f9-8a68-83b70f98e862", false, "Leo" },
                    { "8l645865-o24d-4543-a6c6-9443d048cdb9", 0, "a1cda3b9-8ebf-449d-ae82-306096ff02e0", "o@o.com", true, false, null, "O@O.COM", "O@O.COM", "AQAAAAEAACcQAAAAEHML8nNwe3QNlrQ5cVldNZeSOpJKTxXA2T5RtVqDeofwVJZjgtPs6cjrLr9klBpYYA==", null, false, "be271ac7-77bf-49b0-9de4-a8270cb69e34", false, "Wyatt" },
                    { "8l645865-p24d-4543-a6c6-9443d048cdb9", 0, "69bf148a-3f81-4a6c-a8bb-9355af217ba3", "p@p.com", true, false, null, "P@P.COM", "P@P.COM", "AQAAAAEAACcQAAAAEKVgKl0i+L9mIRJnkI5b5X/JQ7HgKx2xnsfeUpMdhpKM9ZAOv1UIEdHLe0/6jNlINg==", null, false, "f2ae868f-a6d8-402b-80ff-d447a3c0d104", false, "Scarlett" },
                    { "8l645865-q24d-4543-a6c6-9443d048cdb9", 0, "9337e6c9-2451-416d-b851-1b6719481c43", "q@q.com", true, false, null, "Q@Q.COM", "Q@Q.COM", "AQAAAAEAACcQAAAAEFG+CmmIFutPQEZcZMCUPlb/xYjcce36SWXt0D8vUUapQGFSMW4A6K1H+MEyRR8ZFg==", null, false, "7d09f3c6-dd19-4733-a5f1-0a8c99371f39", false, "Ella" },
                    { "8l645865-r24d-4543-a6c6-9443d048cdb9", 0, "8e468646-fb88-47a5-8991-36d9fe1b31e1", "r@r.com", true, false, null, "R@R.COM", "R@R.COM", "AQAAAAEAACcQAAAAEB+7kyUPIkp7wOkQpfZLP3feOcOHBEfo/abABS0ReHCiOHIeRMK3yIKtqqYD87P0pQ==", null, false, "2e4e483a-ed6c-4f44-8812-80f330b5ac48", false, "Ellie" },
                    { "8l645865-s24d-4543-a6c6-9443d048cdb9", 0, "193d9528-8734-4ce3-a2a1-1f5301142385", "s@s.com", true, false, null, "S@S.COM", "S@S.COM", "AQAAAAEAACcQAAAAEKYk+WnjMwxU/P/NfH3PBAfJSjt1PZPs9ZCuEtuaLL8hJemKKYCvUa+ak57Cg3/ODQ==", null, false, "ac430ca2-b688-45ea-aebf-8356e08109dc", false, "Sofia" },
                    { "8l645865-t24d-4543-a6c6-9443d048cdb9", 0, "203c4250-bf59-4f89-ae1a-dad95d27bb08", "t@t.com", true, false, null, "T@T.COM", "T@T.COM", "AQAAAAEAACcQAAAAEAP8mDpHjdd4j7dd3YxvmEwAE6ky1Q1zX/qNSm2ysd0lOMG+q+FrpOtlCakyXmVUVg==", null, false, "00dd282a-35be-4854-9113-d9640d411da2", false, "Sebastian" },
                    { "8l645865-u24d-4543-a6c6-9443d048cdb9", 0, "fb0fff94-a0d7-433f-940e-7593f567b450", "u@u.com", true, false, null, "U@U.COM", "U@U.COM", "AQAAAAEAACcQAAAAEKU+dqf57Re7NoxLkanvnPy0y57STCrf5PswerneQ+fKAIk9D/Et/j3wHdUXIHsF7w==", null, false, "0349d790-918c-4c6c-bcc5-cec6d1891894", false, "Violet" },
                    { "8l645865-v24d-4543-a6c6-9443d048cdb9", 0, "0d579db1-0fc6-409d-a20c-b0f97f3c77ec", "v@v.com", true, false, null, "V@V.COM", "V@V.COM", "AQAAAAEAACcQAAAAEAntJoNsdCQSFklsbN0l5rSY5YcJ2lHwe+2kYZ1B9NJYbMPsuKwqTAhjBKA/FPZZfQ==", null, false, "23620c9e-4cad-4fab-b788-1f8309274c89", false, "Jack" },
                    { "8l645865-w24d-4543-a6c6-9443d048cdb9", 0, "dc935240-cd61-4971-8495-5c22371e1309", "w@w.com", true, false, null, "W@W.COM", "W@W.COM", "AQAAAAEAACcQAAAAEIKoDMoZrxcGY2Dbe9IvhLQb8ydkeybZUAE3CHp/Z70KCwhJDaO7CfBNkU8eqVk1Tw==", null, false, "8ba291fd-fa81-421c-ad4a-cc9ae5e427e2", false, "Owen" },
                    { "8l645865-x24d-4543-a6c6-9443d048cdb9", 0, "48ed8878-bf3c-4784-b61b-ce18f6fc0ceb", "x@x.com", true, false, null, "X@X.COM", "X@X.COM", "AQAAAAEAACcQAAAAEPyzlFdoRlYBj69s2NCorGG5Anm1gLpipgmIMsxoFYt7S30o2WYxBWDJ9VZah5RWtw==", null, false, "0e108007-0d30-4e40-8957-e2f9efd3438c", false, "Daniel" },
                    { "8l645865-y24d-4543-a6c6-9443d048cdb9", 0, "c70611b9-a09e-4f10-bd6e-a426b218a026", "y@y.com", true, false, null, "Y@Y.COM", "Y@Y.COM", "AQAAAAEAACcQAAAAEITtOWiwOhM5iwXP+/wFSRNzFzSZnkfQn164ZzihgCgL9/51iYdv2tONCJzXB/U8uQ==", null, false, "a867ca4a-ef2f-42ae-b24c-3b1183f6ea49", false, "Layla" },
                    { "8l645865-z24d-4543-a6c6-9443d048cdb9", 0, "df3f86bd-6420-406c-919d-c53d3de95518", "z@z.com", true, false, null, "Z@Z.COM", "Z@Z.COM", "AQAAAAEAACcQAAAAEM1Uv52P44ikBQ1Q27gwm81SLxS0D3CBtRKQqZz98cY4cAgfxvJhCxn7JySdVF0yCA==", null, false, "7dc637c8-9ad5-4167-bd28-2c8fe090f78a", false, "Camila" }
                });

            migrationBuilder.InsertData(
                table: "ReservationSources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Online" },
                    { 2, "Email" },
                    { 3, "In Person" },
                    { 4, "Phone" }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Confirmed" },
                    { 3, "Seated" },
                    { 4, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Cancelled" },
                    { 6, "Altered" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Bean Scene" });

            migrationBuilder.InsertData(
                table: "SittingTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e545865-a24d-4543-a6c6-9443d048cdb9" },
                    { "60226d81-1906-41cb-8f00-44e34ee158cd", "8e645865-a24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-a24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-b24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-c24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-d24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-e24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-f24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-g24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-h24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-i24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-j24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-k24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-l24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-m24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-n24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-o24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-p24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-q24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-r24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-s24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-t24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-u24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-v24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-w24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-x24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-y24d-4543-a6c6-9443d048cdb9" },
                    { "e07d60fb-e2bd-4443-9759-8edc2c65ba17", "8l645865-z24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "AreaID", "Name", "PosX", "PosY" },
                values: new object[,]
                {
                    { 1, 1, "M1", null, null },
                    { 2, 1, "M2", null, null },
                    { 3, 1, "M3", null, null },
                    { 4, 1, "M4", null, null },
                    { 5, 1, "M5", null, null },
                    { 6, 1, "M6", null, null },
                    { 7, 1, "M7", null, null },
                    { 8, 1, "M8", null, null },
                    { 9, 1, "M9", null, null },
                    { 10, 1, "M10", null, null },
                    { 11, 2, "O1", null, null },
                    { 12, 2, "O2", null, null },
                    { 13, 2, "O3", null, null },
                    { 14, 2, "O4", null, null }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "Id", "AreaID", "Name", "PosX", "PosY" },
                values: new object[,]
                {
                    { 15, 2, "O5", null, null },
                    { 16, 2, "O6", null, null },
                    { 17, 2, "O7", null, null },
                    { 18, 2, "O8", null, null },
                    { 19, 2, "O9", null, null },
                    { 20, 2, "O10", null, null },
                    { 21, 3, "B1", null, null },
                    { 22, 3, "B2", null, null },
                    { 23, 3, "B3", null, null },
                    { 24, 3, "B4", null, null },
                    { 25, 3, "B5", null, null },
                    { 26, 3, "B6", null, null },
                    { 27, 3, "B7", null, null },
                    { 28, 3, "B8", null, null },
                    { 29, 3, "B9", null, null },
                    { 30, 3, "B10", null, null }
                });

            migrationBuilder.InsertData(
                table: "Sittings",
                columns: new[] { "Id", "Active", "Capacity", "EndTime", "Name", "RestaurantId", "SittingTypeId", "StartTime", "Vacancies" },
                values: new object[,]
                {
                    { 1, true, 30, new DateTime(2023, 6, 17, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 17, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 2, true, 40, new DateTime(2023, 6, 17, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 17, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 3, true, 50, new DateTime(2023, 6, 17, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 17, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 4, true, 30, new DateTime(2023, 6, 18, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 18, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 5, true, 40, new DateTime(2023, 6, 18, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 18, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 6, true, 50, new DateTime(2023, 6, 18, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 18, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 7, true, 30, new DateTime(2023, 6, 19, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 19, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 8, true, 40, new DateTime(2023, 6, 19, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 19, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 9, true, 50, new DateTime(2023, 6, 19, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 19, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 10, true, 30, new DateTime(2023, 6, 20, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 20, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 11, true, 40, new DateTime(2023, 6, 20, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 20, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 12, true, 50, new DateTime(2023, 6, 20, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 20, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 13, true, 30, new DateTime(2023, 6, 21, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 21, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 14, true, 40, new DateTime(2023, 6, 21, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 21, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 15, true, 50, new DateTime(2023, 6, 21, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 21, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 16, true, 30, new DateTime(2023, 6, 22, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 22, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 17, true, 40, new DateTime(2023, 6, 22, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 22, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 18, true, 50, new DateTime(2023, 6, 22, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 22, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 19, true, 30, new DateTime(2023, 6, 23, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 23, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 20, true, 40, new DateTime(2023, 6, 23, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 23, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 21, true, 50, new DateTime(2023, 6, 23, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 23, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 22, true, 30, new DateTime(2023, 6, 24, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 24, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 23, true, 40, new DateTime(2023, 6, 24, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 24, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 24, true, 50, new DateTime(2023, 6, 24, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 24, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 25, true, 30, new DateTime(2023, 6, 25, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 25, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 26, true, 40, new DateTime(2023, 6, 25, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 25, 12, 0, 0, 0, DateTimeKind.Local), 0 }
                });

            migrationBuilder.InsertData(
                table: "Sittings",
                columns: new[] { "Id", "Active", "Capacity", "EndTime", "Name", "RestaurantId", "SittingTypeId", "StartTime", "Vacancies" },
                values: new object[,]
                {
                    { 27, true, 50, new DateTime(2023, 6, 25, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 28, true, 30, new DateTime(2023, 6, 26, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 26, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 29, true, 40, new DateTime(2023, 6, 26, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 26, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 30, true, 50, new DateTime(2023, 6, 26, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 26, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 31, true, 30, new DateTime(2023, 6, 27, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 27, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 32, true, 40, new DateTime(2023, 6, 27, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 27, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 33, true, 50, new DateTime(2023, 6, 27, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 27, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 34, true, 30, new DateTime(2023, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 28, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 35, true, 40, new DateTime(2023, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 36, true, 50, new DateTime(2023, 6, 28, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 28, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 37, true, 30, new DateTime(2023, 6, 29, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 29, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 38, true, 40, new DateTime(2023, 6, 29, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 29, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 39, true, 50, new DateTime(2023, 6, 29, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 29, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 40, true, 30, new DateTime(2023, 6, 30, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 6, 30, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 41, true, 40, new DateTime(2023, 6, 30, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 6, 30, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 42, true, 50, new DateTime(2023, 6, 30, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 43, true, 30, new DateTime(2023, 7, 1, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 1, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 44, true, 40, new DateTime(2023, 7, 1, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 1, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 45, true, 50, new DateTime(2023, 7, 1, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 1, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 46, true, 30, new DateTime(2023, 7, 2, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 2, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 47, true, 40, new DateTime(2023, 7, 2, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 2, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 48, true, 50, new DateTime(2023, 7, 2, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 2, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 49, true, 30, new DateTime(2023, 7, 3, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 3, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 50, true, 40, new DateTime(2023, 7, 3, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 3, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 51, true, 50, new DateTime(2023, 7, 3, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 3, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 52, true, 30, new DateTime(2023, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 4, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 53, true, 40, new DateTime(2023, 7, 4, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 4, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 54, true, 50, new DateTime(2023, 7, 4, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 4, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 55, true, 30, new DateTime(2023, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 5, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 56, true, 40, new DateTime(2023, 7, 5, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 5, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 57, true, 50, new DateTime(2023, 7, 5, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 5, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 58, true, 30, new DateTime(2023, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 6, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 59, true, 40, new DateTime(2023, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 60, true, 50, new DateTime(2023, 7, 6, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 6, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 61, true, 30, new DateTime(2023, 7, 7, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 7, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 62, true, 40, new DateTime(2023, 7, 7, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 7, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 63, true, 50, new DateTime(2023, 7, 7, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 7, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 64, true, 30, new DateTime(2023, 7, 8, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 8, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 65, true, 40, new DateTime(2023, 7, 8, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 8, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 66, true, 50, new DateTime(2023, 7, 8, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 8, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 67, true, 30, new DateTime(2023, 7, 9, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 9, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 68, true, 40, new DateTime(2023, 7, 9, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 9, 12, 0, 0, 0, DateTimeKind.Local), 0 }
                });

            migrationBuilder.InsertData(
                table: "Sittings",
                columns: new[] { "Id", "Active", "Capacity", "EndTime", "Name", "RestaurantId", "SittingTypeId", "StartTime", "Vacancies" },
                values: new object[,]
                {
                    { 69, true, 50, new DateTime(2023, 7, 9, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 9, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 70, true, 30, new DateTime(2023, 7, 10, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 10, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 71, true, 40, new DateTime(2023, 7, 10, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 10, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 72, true, 50, new DateTime(2023, 7, 10, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 10, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 73, true, 30, new DateTime(2023, 7, 11, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 11, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 74, true, 40, new DateTime(2023, 7, 11, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 11, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 75, true, 50, new DateTime(2023, 7, 11, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 11, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 76, true, 30, new DateTime(2023, 7, 12, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 12, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 77, true, 40, new DateTime(2023, 7, 12, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 12, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 78, true, 50, new DateTime(2023, 7, 12, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 12, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 79, true, 30, new DateTime(2023, 7, 13, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 13, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 80, true, 40, new DateTime(2023, 7, 13, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 13, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 81, true, 50, new DateTime(2023, 7, 13, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 13, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 82, true, 30, new DateTime(2023, 7, 14, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 14, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 83, true, 40, new DateTime(2023, 7, 14, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 14, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 84, true, 50, new DateTime(2023, 7, 14, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 14, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 85, true, 30, new DateTime(2023, 7, 15, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 15, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 86, true, 40, new DateTime(2023, 7, 15, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 15, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 87, true, 50, new DateTime(2023, 7, 15, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 15, 17, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 88, true, 30, new DateTime(2023, 7, 16, 11, 0, 0, 0, DateTimeKind.Local), "Breakfast", 1, 1, new DateTime(2023, 7, 16, 7, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 89, true, 40, new DateTime(2023, 7, 16, 16, 0, 0, 0, DateTimeKind.Local), "Lunch", 1, 2, new DateTime(2023, 7, 16, 12, 0, 0, 0, DateTimeKind.Local), 0 },
                    { 90, true, 50, new DateTime(2023, 7, 16, 21, 0, 0, 0, DateTimeKind.Local), "Dinner", 1, 3, new DateTime(2023, 7, 16, 17, 0, 0, 0, DateTimeKind.Local), 0 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Duration", "Email", "EndTime", "FirstName", "GuestNumber", "LastName", "Note", "PhoneNumber", "ReservationSourceId", "ReservationStatusId", "SittingId", "StartTime", "UserId" },
                values: new object[,]
                {
                    { 1, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 14, 25, 10, 56, DateTimeKind.Local).AddTicks(9504), "Joshua", 1, "Davis", null, "0400213214", 2, 5, 36, new DateTime(2023, 6, 16, 13, 25, 10, 56, DateTimeKind.Local).AddTicks(9503), null },
                    { 2, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 14, 35, 10, 56, DateTimeKind.Local).AddTicks(9512), "Joshua", 3, "Davis", null, "0400213214", 1, 1, 44, new DateTime(2023, 6, 16, 13, 35, 10, 56, DateTimeKind.Local).AddTicks(9512), null },
                    { 3, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 14, 45, 10, 56, DateTimeKind.Local).AddTicks(9545), "Joshua", 3, "Davis", null, "0400213214", 1, 4, 60, new DateTime(2023, 6, 16, 13, 45, 10, 56, DateTimeKind.Local).AddTicks(9544), null },
                    { 4, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 14, 55, 10, 56, DateTimeKind.Local).AddTicks(9550), "Joshua", 1, "Davis", null, "0400213214", 1, 5, 86, new DateTime(2023, 6, 16, 13, 55, 10, 56, DateTimeKind.Local).AddTicks(9549), null },
                    { 5, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 15, 5, 10, 56, DateTimeKind.Local).AddTicks(9555), "Joshua", 1, "Davis", null, "0400213214", 3, 4, 23, new DateTime(2023, 6, 16, 14, 5, 10, 56, DateTimeKind.Local).AddTicks(9554), null },
                    { 6, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 15, 15, 10, 56, DateTimeKind.Local).AddTicks(9560), "Joshua", 3, "Davis", null, "0400213214", 3, 4, 85, new DateTime(2023, 6, 16, 14, 15, 10, 56, DateTimeKind.Local).AddTicks(9560), null },
                    { 7, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 15, 25, 10, 56, DateTimeKind.Local).AddTicks(9565), "Joshua", 2, "Davis", null, "0400213214", 2, 6, 48, new DateTime(2023, 6, 16, 14, 25, 10, 56, DateTimeKind.Local).AddTicks(9564), null },
                    { 8, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 15, 35, 10, 56, DateTimeKind.Local).AddTicks(9570), "Joshua", 2, "Davis", null, "0400213214", 3, 4, 77, new DateTime(2023, 6, 16, 14, 35, 10, 56, DateTimeKind.Local).AddTicks(9569), null },
                    { 9, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 15, 45, 10, 56, DateTimeKind.Local).AddTicks(9575), "Joshua", 3, "Davis", null, "0400213214", 2, 5, 49, new DateTime(2023, 6, 16, 14, 45, 10, 56, DateTimeKind.Local).AddTicks(9574), null },
                    { 10, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 15, 55, 10, 56, DateTimeKind.Local).AddTicks(9580), "Joshua", 1, "Davis", null, "0400213214", 2, 2, 78, new DateTime(2023, 6, 16, 14, 55, 10, 56, DateTimeKind.Local).AddTicks(9579), null },
                    { 11, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 16, 5, 10, 56, DateTimeKind.Local).AddTicks(9585), "Joshua", 5, "Davis", null, "0400213214", 3, 5, 57, new DateTime(2023, 6, 16, 15, 5, 10, 56, DateTimeKind.Local).AddTicks(9584), null },
                    { 12, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 16, 15, 10, 56, DateTimeKind.Local).AddTicks(9589), "Joshua", 2, "Davis", null, "0400213214", 1, 4, 15, new DateTime(2023, 6, 16, 15, 15, 10, 56, DateTimeKind.Local).AddTicks(9588), null },
                    { 13, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 16, 25, 10, 56, DateTimeKind.Local).AddTicks(9594), "Joshua", 2, "Davis", null, "0400213214", 2, 6, 10, new DateTime(2023, 6, 16, 15, 25, 10, 56, DateTimeKind.Local).AddTicks(9593), null },
                    { 14, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 16, 35, 10, 56, DateTimeKind.Local).AddTicks(9598), "Joshua", 2, "Davis", null, "0400213214", 2, 6, 12, new DateTime(2023, 6, 16, 15, 35, 10, 56, DateTimeKind.Local).AddTicks(9597), null },
                    { 15, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 16, 45, 10, 56, DateTimeKind.Local).AddTicks(9603), "Joshua", 4, "Davis", null, "0400213214", 4, 2, 17, new DateTime(2023, 6, 16, 15, 45, 10, 56, DateTimeKind.Local).AddTicks(9602), null },
                    { 16, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 16, 55, 10, 56, DateTimeKind.Local).AddTicks(9607), "Joshua", 4, "Davis", null, "0400213214", 2, 5, 82, new DateTime(2023, 6, 16, 15, 55, 10, 56, DateTimeKind.Local).AddTicks(9606), null },
                    { 17, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 17, 5, 10, 56, DateTimeKind.Local).AddTicks(9611), "Joshua", 2, "Davis", null, "0400213214", 4, 5, 28, new DateTime(2023, 6, 16, 16, 5, 10, 56, DateTimeKind.Local).AddTicks(9611), null },
                    { 18, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 17, 15, 10, 56, DateTimeKind.Local).AddTicks(9617), "Joshua", 3, "Davis", null, "0400213214", 3, 4, 9, new DateTime(2023, 6, 16, 16, 15, 10, 56, DateTimeKind.Local).AddTicks(9616), null },
                    { 19, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 17, 25, 10, 56, DateTimeKind.Local).AddTicks(9621), "Joshua", 5, "Davis", null, "0400213214", 3, 6, 59, new DateTime(2023, 6, 16, 16, 25, 10, 56, DateTimeKind.Local).AddTicks(9620), null },
                    { 20, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 17, 35, 10, 56, DateTimeKind.Local).AddTicks(9625), "Joshua", 2, "Davis", null, "0400213214", 2, 2, 42, new DateTime(2023, 6, 16, 16, 35, 10, 56, DateTimeKind.Local).AddTicks(9624), null },
                    { 21, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 17, 45, 10, 56, DateTimeKind.Local).AddTicks(9630), "Joshua", 5, "Davis", null, "0400213214", 1, 4, 31, new DateTime(2023, 6, 16, 16, 45, 10, 56, DateTimeKind.Local).AddTicks(9629), null },
                    { 22, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 17, 55, 10, 56, DateTimeKind.Local).AddTicks(9634), "Joshua", 5, "Davis", null, "0400213214", 1, 6, 13, new DateTime(2023, 6, 16, 16, 55, 10, 56, DateTimeKind.Local).AddTicks(9634), null },
                    { 23, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 18, 5, 10, 56, DateTimeKind.Local).AddTicks(9639), "Joshua", 1, "Davis", null, "0400213214", 3, 3, 18, new DateTime(2023, 6, 16, 17, 5, 10, 56, DateTimeKind.Local).AddTicks(9638), null },
                    { 24, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 18, 15, 10, 56, DateTimeKind.Local).AddTicks(9644), "Joshua", 4, "Davis", null, "0400213214", 2, 5, 66, new DateTime(2023, 6, 16, 17, 15, 10, 56, DateTimeKind.Local).AddTicks(9643), null },
                    { 25, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 18, 25, 10, 56, DateTimeKind.Local).AddTicks(9670), "Joshua", 1, "Davis", null, "0400213214", 3, 4, 20, new DateTime(2023, 6, 16, 17, 25, 10, 56, DateTimeKind.Local).AddTicks(9668), null },
                    { 26, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 18, 35, 10, 56, DateTimeKind.Local).AddTicks(9675), "Joshua", 5, "Davis", null, "0400213214", 1, 5, 12, new DateTime(2023, 6, 16, 17, 35, 10, 56, DateTimeKind.Local).AddTicks(9674), null },
                    { 27, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 18, 45, 10, 56, DateTimeKind.Local).AddTicks(9680), "Joshua", 4, "Davis", null, "0400213214", 4, 4, 11, new DateTime(2023, 6, 16, 17, 45, 10, 56, DateTimeKind.Local).AddTicks(9679), null },
                    { 28, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 18, 55, 10, 56, DateTimeKind.Local).AddTicks(9684), "Joshua", 5, "Davis", null, "0400213214", 1, 6, 87, new DateTime(2023, 6, 16, 17, 55, 10, 56, DateTimeKind.Local).AddTicks(9684), null },
                    { 29, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 19, 5, 10, 56, DateTimeKind.Local).AddTicks(9689), "Joshua", 1, "Davis", null, "0400213214", 4, 3, 72, new DateTime(2023, 6, 16, 18, 5, 10, 56, DateTimeKind.Local).AddTicks(9689), null },
                    { 30, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 19, 15, 10, 56, DateTimeKind.Local).AddTicks(9694), "Joshua", 3, "Davis", null, "0400213214", 4, 4, 10, new DateTime(2023, 6, 16, 18, 15, 10, 56, DateTimeKind.Local).AddTicks(9694), null },
                    { 31, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 19, 25, 10, 56, DateTimeKind.Local).AddTicks(9699), "Joshua", 5, "Davis", null, "0400213214", 3, 6, 16, new DateTime(2023, 6, 16, 18, 25, 10, 56, DateTimeKind.Local).AddTicks(9698), null },
                    { 32, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 19, 35, 10, 56, DateTimeKind.Local).AddTicks(9704), "Joshua", 2, "Davis", null, "0400213214", 1, 3, 73, new DateTime(2023, 6, 16, 18, 35, 10, 56, DateTimeKind.Local).AddTicks(9703), null },
                    { 33, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 19, 45, 10, 56, DateTimeKind.Local).AddTicks(9709), "Joshua", 2, "Davis", null, "0400213214", 2, 6, 9, new DateTime(2023, 6, 16, 18, 45, 10, 56, DateTimeKind.Local).AddTicks(9708), null },
                    { 34, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 19, 55, 10, 56, DateTimeKind.Local).AddTicks(9714), "Joshua", 2, "Davis", null, "0400213214", 4, 6, 28, new DateTime(2023, 6, 16, 18, 55, 10, 56, DateTimeKind.Local).AddTicks(9713), null },
                    { 35, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 20, 5, 10, 56, DateTimeKind.Local).AddTicks(9719), "Joshua", 4, "Davis", null, "0400213214", 2, 1, 40, new DateTime(2023, 6, 16, 19, 5, 10, 56, DateTimeKind.Local).AddTicks(9718), null },
                    { 36, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 20, 15, 10, 56, DateTimeKind.Local).AddTicks(9723), "Joshua", 3, "Davis", null, "0400213214", 1, 2, 70, new DateTime(2023, 6, 16, 19, 15, 10, 56, DateTimeKind.Local).AddTicks(9723), null },
                    { 37, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 20, 25, 10, 56, DateTimeKind.Local).AddTicks(9728), "Joshua", 1, "Davis", null, "0400213214", 2, 5, 50, new DateTime(2023, 6, 16, 19, 25, 10, 56, DateTimeKind.Local).AddTicks(9727), null },
                    { 38, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 20, 35, 10, 56, DateTimeKind.Local).AddTicks(9733), "Joshua", 4, "Davis", null, "0400213214", 3, 2, 14, new DateTime(2023, 6, 16, 19, 35, 10, 56, DateTimeKind.Local).AddTicks(9732), null },
                    { 39, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 20, 45, 10, 56, DateTimeKind.Local).AddTicks(9737), "Joshua", 1, "Davis", null, "0400213214", 1, 2, 73, new DateTime(2023, 6, 16, 19, 45, 10, 56, DateTimeKind.Local).AddTicks(9736), null },
                    { 40, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 20, 55, 10, 56, DateTimeKind.Local).AddTicks(9741), "Joshua", 1, "Davis", null, "0400213214", 4, 4, 64, new DateTime(2023, 6, 16, 19, 55, 10, 56, DateTimeKind.Local).AddTicks(9740), null },
                    { 41, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 21, 5, 10, 56, DateTimeKind.Local).AddTicks(9746), "Joshua", 1, "Davis", null, "0400213214", 2, 2, 83, new DateTime(2023, 6, 16, 20, 5, 10, 56, DateTimeKind.Local).AddTicks(9745), null },
                    { 42, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 21, 15, 10, 56, DateTimeKind.Local).AddTicks(9750), "Joshua", 2, "Davis", null, "0400213214", 1, 6, 53, new DateTime(2023, 6, 16, 20, 15, 10, 56, DateTimeKind.Local).AddTicks(9750), null }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Duration", "Email", "EndTime", "FirstName", "GuestNumber", "LastName", "Note", "PhoneNumber", "ReservationSourceId", "ReservationStatusId", "SittingId", "StartTime", "UserId" },
                values: new object[,]
                {
                    { 43, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 21, 25, 10, 56, DateTimeKind.Local).AddTicks(9755), "Joshua", 4, "Davis", null, "0400213214", 4, 1, 25, new DateTime(2023, 6, 16, 20, 25, 10, 56, DateTimeKind.Local).AddTicks(9754), null },
                    { 44, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 21, 35, 10, 56, DateTimeKind.Local).AddTicks(9759), "Joshua", 3, "Davis", null, "0400213214", 4, 5, 73, new DateTime(2023, 6, 16, 20, 35, 10, 56, DateTimeKind.Local).AddTicks(9758), null },
                    { 45, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 21, 45, 10, 56, DateTimeKind.Local).AddTicks(9763), "Joshua", 4, "Davis", null, "0400213214", 4, 3, 18, new DateTime(2023, 6, 16, 20, 45, 10, 56, DateTimeKind.Local).AddTicks(9762), null },
                    { 46, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 21, 55, 10, 56, DateTimeKind.Local).AddTicks(9767), "Joshua", 4, "Davis", null, "0400213214", 1, 5, 14, new DateTime(2023, 6, 16, 20, 55, 10, 56, DateTimeKind.Local).AddTicks(9767), null },
                    { 47, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 22, 5, 10, 56, DateTimeKind.Local).AddTicks(9797), "Joshua", 4, "Davis", null, "0400213214", 1, 2, 16, new DateTime(2023, 6, 16, 21, 5, 10, 56, DateTimeKind.Local).AddTicks(9793), null },
                    { 48, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 22, 15, 10, 56, DateTimeKind.Local).AddTicks(9802), "Joshua", 4, "Davis", null, "0400213214", 4, 2, 31, new DateTime(2023, 6, 16, 21, 15, 10, 56, DateTimeKind.Local).AddTicks(9801), null },
                    { 49, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 22, 25, 10, 56, DateTimeKind.Local).AddTicks(9806), "Joshua", 4, "Davis", null, "0400213214", 1, 1, 71, new DateTime(2023, 6, 16, 21, 25, 10, 56, DateTimeKind.Local).AddTicks(9806), null },
                    { 50, 60, "joshua.davis1@studytafensw.edu.au", new DateTime(2023, 6, 16, 22, 35, 10, 56, DateTimeKind.Local).AddTicks(9811), "Joshua", 5, "Davis", null, "0400213214", 3, 1, 84, new DateTime(2023, 6, 16, 21, 35, 10, 56, DateTimeKind.Local).AddTicks(9810), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_RestaurantId",
                table: "Areas",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationSourceId",
                table: "Reservations",
                column: "ReservationSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SittingId",
                table: "Reservations",
                column: "SittingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationsTable_ReservationId",
                table: "ReservationsTable",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationsTable_RestaurantTableId",
                table: "ReservationsTable",
                column: "RestaurantTableId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTables_AreaID",
                table: "RestaurantTables",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sittings_RestaurantId",
                table: "Sittings",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Sittings_SittingTypeId",
                table: "Sittings",
                column: "SittingTypeId");
        }

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
                name: "ReservationsTable");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "RestaurantTables");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ReservationSources");

            migrationBuilder.DropTable(
                name: "ReservationStatus");

            migrationBuilder.DropTable(
                name: "Sittings");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "SittingTypes");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
