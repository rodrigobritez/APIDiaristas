using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDiaristas.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "api_ediaristas");

            migrationBuilder.CreateTable(
                name: "clients",
                schema: "api_ediaristas",
                columns: table => new
                {
                    id_client = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "(uuid_generate_v4())"),
                    name = table.Column<string>(type: "varchar(60)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "(now() at time zone 'utc')"),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id_client);
                });

            migrationBuilder.CreateTable(
                name: "day_workers",
                schema: "api_ediaristas",
                columns: table => new
                {
                    id_day_worker = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "(uuid_generate_v4())"),
                    name = table.Column<string>(type: "varchar(60)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    region = table.Column<string>(type: "varchar(100)", nullable: false),
                    cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    rg = table.Column<string>(type: "varchar(15)", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    service_value = table.Column<decimal>(type: "decimal", nullable: false),
                    total_stars = table.Column<short>(type: "smallint", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "(now() at time zone 'utc')"),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_day_workers", x => x.id_day_worker);
                });

            migrationBuilder.CreateTable(
                name: "services",
                schema: "api_ediaristas",
                columns: table => new
                {
                    id_service = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "(uuid_generate_v4())"),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    DayWorkerId = table.Column<Guid>(type: "uuid", nullable: false),
                    avaliation = table.Column<string>(type: "varchar(255)", nullable: false),
                    starts = table.Column<short>(type: "smallint", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "(now() at time zone 'utc')"),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.id_service);
                    table.ForeignKey(
                        name: "FK_services_clients_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "api_ediaristas",
                        principalTable: "clients",
                        principalColumn: "id_client",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_day_workers_DayWorkerId",
                        column: x => x.DayWorkerId,
                        principalSchema: "api_ediaristas",
                        principalTable: "day_workers",
                        principalColumn: "id_day_worker",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clients_email",
                schema: "api_ediaristas",
                table: "clients",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_day_workers_cpf",
                schema: "api_ediaristas",
                table: "day_workers",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_day_workers_email",
                schema: "api_ediaristas",
                table: "day_workers",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_services_ClientId",
                schema: "api_ediaristas",
                table: "services",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_services_DayWorkerId",
                schema: "api_ediaristas",
                table: "services",
                column: "DayWorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "services",
                schema: "api_ediaristas");

            migrationBuilder.DropTable(
                name: "clients",
                schema: "api_ediaristas");

            migrationBuilder.DropTable(
                name: "day_workers",
                schema: "api_ediaristas");
        }
    }
}
