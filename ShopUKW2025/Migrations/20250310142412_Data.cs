using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopUKW2025.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Filmy pełne dynamicznych scen i emocjonujących pościgów.", "Akcja" },
                    { 2, "Filmy, które rozbawią Cię do łez.", "Komedia" },
                    { 3, "Opowieści pełne emocji i głębokich przeżyć.", "Dramat" },
                    { 4, "Filmy o przyszłości, technologii i podróżach kosmicznych.", "Science Fiction" },
                    { 5, "Produkcje wywołujące strach i dreszcze.", "Horror" },
                    { 6, "Filmy o magicznych światach i niezwykłych stworzeniach.", "Fantasy" },
                    { 7, "Napięcie i zaskakujące zwroty akcji.", "Thriller" },
                    { 8, "Filmy animowane dla dzieci i dorosłych.", "Animacja" },
                    { 9, "Filmy oparte na faktach, edukacyjne i inspirujące.", "Dokumentalny" },
                    { 10, "Historie miłosne pełne wzruszeń i emocji.", "Romans" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Postapokaliptyczna akcja pełna pościgów.", "George Miller", 29.99m, "Mad Max: Fury Road" },
                    { 2, 2, "Grupa przyjaciół wpada w kłopoty po wieczorze kawalerskim.", "Todd Phillips", 19.99m, "The Hangover" },
                    { 3, 3, "Historia nadziei i przyjaźni w więzieniu.", "Frank Darabont", 24.99m, "The Shawshank Redemption" },
                    { 4, 4, "Podróż w głąb kosmosu w poszukiwaniu nowego domu dla ludzkości.", "Christopher Nolan", 34.99m, "Interstellar" },
                    { 5, 5, "Przerażająca historia nawiedzonego domu.", "James Wan", 22.99m, "The Conjuring" },
                    { 6, 6, "Początek epickiej podróży w świecie Śródziemia.", "Peter Jackson", 39.99m, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 7, 7, "Detektywi ścigają seryjnego mordercę inspirowanego siedmioma grzechami głównymi.", "David Fincher", 27.99m, "Se7en" },
                    { 8, 8, "Przygody ożywionych zabawek.", "John Lasseter", 14.99m, "Toy Story" },
                    { 9, 9, "Spektakularna podróż przez najpiękniejsze zakątki Ziemi.", "Alastair Fothergill", 44.99m, "Planet Earth" },
                    { 10, 10, "Poruszająca historia miłosna na przestrzeni lat.", "Nick Cassavetes", 19.99m, "The Notebook" },
                    { 11, 1, "Zemsta zabójcy na przestępczym świecie.", "Chad Stahelski", 32.99m, "John Wick" },
                    { 12, 2, "Nastoletnie przygody pełne humoru.", "Greg Mottola", 16.99m, "Superbad" },
                    { 13, 3, "Historia niezwykłego życia Forresta.", "Robert Zemeckis", 26.99m, "Forrest Gump" },
                    { 14, 4, "Kontynuacja kultowego sci-fi.", "Denis Villeneuve", 37.99m, "Blade Runner 2049" },
                    { 15, 5, "Mrożący krew w żyłach horror o Pennywise.", "Andy Muschietti", 23.99m, "It" },
                    { 16, 6, "Początek magicznej przygody Harry'ego Pottera.", "Chris Columbus", 35.99m, "Harry Potter and the Sorcerer's Stone" },
                    { 17, 7, "Zniknięcie żony prowadzi do mrocznych tajemnic.", "David Fincher", 28.99m, "Gone Girl" },
                    { 18, 8, "Przygody zielonego ogra.", "Andrew Adamson, Vicky Jenson", 18.99m, "Shrek" },
                    { 19, 9, "Dokument o wędrówce pingwinów cesarskich.", "Luc Jacquet", 21.99m, "March of the Penguins" },
                    { 20, 10, "Miłość i marzenia w świecie muzyki.", "Damien Chazelle", 24.99m, "La La Land" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}
