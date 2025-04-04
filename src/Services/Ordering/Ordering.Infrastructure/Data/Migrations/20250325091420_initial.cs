using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ordering.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingAdress_ZipCode",
                table: "Orders",
                newName: "ShippingAddress_ZipCode");

            migrationBuilder.RenameColumn(
                name: "ShippingAdress_State",
                table: "Orders",
                newName: "ShippingAddress_State");

            migrationBuilder.RenameColumn(
                name: "ShippingAdress_LastName",
                table: "Orders",
                newName: "ShippingAddress_LastName");

            migrationBuilder.RenameColumn(
                name: "ShippingAdress_FirstName",
                table: "Orders",
                newName: "ShippingAddress_FirstName");

            migrationBuilder.RenameColumn(
                name: "ShippingAdress_EmailAddress",
                table: "Orders",
                newName: "ShippingAddress_EmailAddress");

            migrationBuilder.RenameColumn(
                name: "ShippingAdress_Country",
                table: "Orders",
                newName: "ShippingAddress_Country");

            migrationBuilder.RenameColumn(
                name: "ShippingAdress_AddressLine",
                table: "Orders",
                newName: "ShippingAddress_AddressLine");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_ZipCode",
                table: "Orders",
                newName: "BillingAddress_ZipCode");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_State",
                table: "Orders",
                newName: "BillingAddress_State");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_LastName",
                table: "Orders",
                newName: "BillingAddress_LastName");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_FirstName",
                table: "Orders",
                newName: "BillingAddress_FirstName");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_EmailAddress",
                table: "Orders",
                newName: "BillingAddress_EmailAddress");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_Country",
                table: "Orders",
                newName: "BillingAddress_Country");

            migrationBuilder.RenameColumn(
                name: "BillingAdress_AddressLine",
                table: "Orders",
                newName: "BillingAddress_AddressLine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingAddress_ZipCode",
                table: "Orders",
                newName: "ShippingAdress_ZipCode");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_State",
                table: "Orders",
                newName: "ShippingAdress_State");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_LastName",
                table: "Orders",
                newName: "ShippingAdress_LastName");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_FirstName",
                table: "Orders",
                newName: "ShippingAdress_FirstName");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_EmailAddress",
                table: "Orders",
                newName: "ShippingAdress_EmailAddress");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_Country",
                table: "Orders",
                newName: "ShippingAdress_Country");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_AddressLine",
                table: "Orders",
                newName: "ShippingAdress_AddressLine");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_ZipCode",
                table: "Orders",
                newName: "BillingAdress_ZipCode");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_State",
                table: "Orders",
                newName: "BillingAdress_State");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_LastName",
                table: "Orders",
                newName: "BillingAdress_LastName");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_FirstName",
                table: "Orders",
                newName: "BillingAdress_FirstName");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_EmailAddress",
                table: "Orders",
                newName: "BillingAdress_EmailAddress");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_Country",
                table: "Orders",
                newName: "BillingAdress_Country");

            migrationBuilder.RenameColumn(
                name: "BillingAddress_AddressLine",
                table: "Orders",
                newName: "BillingAdress_AddressLine");
        }
    }
}
