using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageV3.Migrations
{
    /// <inheritdoc />
    public partial class AddParkingSessionVehicleSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingSessions_Vehicles_VehicleId",
                table: "ParkingSessions");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "ParkingSessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BrandAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModelAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfWheelsAtCheckIn",
                table: "ParkingSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OwnerEmailAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerIdAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumberAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RequiredSpotsAtCheckIn",
                table: "ParkingSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VehicleTypeIconAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleTypeNameAtCheckIn",
                table: "ParkingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            migrationBuilder.Sql("""
                UPDATE ps
                SET
                    ps.RegistrationNumberAtCheckIn = v.RegistrationNumber,
                    ps.BrandAtCheckIn = v.Brand,
                    ps.ModelAtCheckIn = v.Model,
                    ps.ColorAtCheckIn = v.Color,
                    ps.NumberOfWheelsAtCheckIn = v.NumberOfWheels,
                    ps.OwnerIdAtCheckIn = v.OwnerId,
                    ps.OwnerEmailAtCheckIn = ISNULL(u.Email, ''),
                    ps.VehicleTypeNameAtCheckIn = ISNULL(vt.Name, ''),
                    ps.VehicleTypeIconAtCheckIn = ISNULL(vt.Icon, ''),
                    ps.RequiredSpotsAtCheckIn = ISNULL(vt.RequiredSpots, 0)
                FROM ParkingSessions ps
                INNER JOIN Vehicles v ON ps.VehicleId = v.Id
                LEFT JOIN AspNetUsers u ON v.OwnerId = u.Id
                LEFT JOIN VehicleTypes vt ON v.VehicleTypeRefId = vt.Id;
                """);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingSessions_Vehicles_VehicleId",
                table: "ParkingSessions",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingSessions_Vehicles_VehicleId",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "BrandAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "ColorAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "ModelAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "NumberOfWheelsAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "OwnerEmailAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "OwnerIdAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "RegistrationNumberAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "RequiredSpotsAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "VehicleTypeIconAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.DropColumn(
                name: "VehicleTypeNameAtCheckIn",
                table: "ParkingSessions");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "ParkingSessions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingSessions_Vehicles_VehicleId",
                table: "ParkingSessions",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
