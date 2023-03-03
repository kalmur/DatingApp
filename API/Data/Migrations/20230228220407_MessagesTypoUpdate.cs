using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessagesTypoUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageSend",
                table: "Messages",
                newName: "MessageSent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageSent",
                table: "Messages",
                newName: "MessageSend");
        }
    }
}
