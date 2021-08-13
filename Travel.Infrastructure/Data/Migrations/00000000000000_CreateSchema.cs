using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Infrastructure.Data.Migrations
{
    public partial class CreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    LastName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editorials",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    Name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Headquarters = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Isbn = table.Column<decimal>(type: "numeric(13,0)", nullable: false),
                    EditorialId = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    Title = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Synopsis = table.Column<string>(type: "text", nullable: false),
                    Pages = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Isbn);
                    table.ForeignKey(
                        name: "FK_Books_Editorials_EditorialId",
                        column: x => x.EditorialId,
                        principalTable: "Editorials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    BooksIsbn = table.Column<decimal>(type: "numeric(13,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksIsbn });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksIsbn",
                        column: x => x.BooksIsbn,
                        principalTable: "Books",
                        principalColumn: "Isbn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1000000000m, "Gabriel", "Garcia Marquez" },
                    { 1000000001m, "Cynthia", "Hand" },
                    { 1000000002m, "Brodi", "Ashton" },
                    { 1000000003m, "Jodi", "Meadows" }
                });

            migrationBuilder.InsertData(
                table: "Editorials",
                columns: new[] { "Id", "Headquarters", "Name" },
                values: new object[,]
                {
                    { 1000000000m, "North", "Harper & Row" },
                    { 1000000001m, "Main", "Vintage" },
                    { 1000000002m, "South", "Harper Teen" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Isbn", "EditorialId", "Pages", "Synopsis", "Title" },
                values: new object[] { 9780060114183m, 1000000000m, "504", "A best seller and critical success in Latin America, Europe, and the United States, One Hundred Years of Solitude tells the story of the rise and fall, birth and death of teh mythical town of Macondo through the history of the Buendia family. It is a rich and billiant chronicle of life and death and the tragicomedy of man. In the noble, ridiculous, beautiful, and tawdry story of the Buendia family one sees all mankind, just as in the history, myths, growth, and decay of Macondo one sees all of Latin America.\nLove and lust, war and revolution, reiches and poverty, youth and senility--the variety of life, the endlessness fo death, the search for peace and truth--these, the universal themes, dominate the novel.Whether he is describing an affair of passion or the voracity of capitalism and the corruption of government, Garcia Marquez always writes with the simplicity, ease, and purity that are the mark fo a master.Inventive, amusing, magnetic, sad, alive with unforgettale men and women, and with a truth and understanding that strike the soul, One Hundred Years of Solitude is a masterpiece of the art of fiction.\n“synopsis” may belong to another edition of this title.", "One Hundred Years of Solitude" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Isbn", "EditorialId", "Pages", "Synopsis", "Title" },
                values: new object[] { 9781400034710m, 1000000001m, "128", "A man returns to the town where a baffling murder took place 27 years earlier, determined to get to the bottom of the story. Just hours after marrying the beautiful Angela Vicario, everyone agrees, Bayardo San Roman returned his bride in disgrace to her parents. Her distraught family forced her to name her first lover; and her twin brothers announced their intention to murder Santiago Nasar for dishonoring their sister.\nYet if everyone knew the murder was going to happen, why did no one intervene to stop it? The more that is learned, the less is understood, and as the story races to its inexplicable conclusion, an entire society--not just a pair of murderers—is put on trial.", "Chronicle of a Death Foretold" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Isbn", "EditorialId", "Pages", "Synopsis", "Title" },
                values: new object[] { 9780062930040m, 1000000002m, "512", "Long live the queen: The authors who brought you the New York Times bestselling My Lady Jane kick off an all-new historical trilogy with the classy, courtly tale of Mary, Queen of Scots.\nWelcome to Renaissance France, a place of poison and plots, of beauties and beasts, of mice and . . . queens?\nMary is the queen of Scotland and the jewel of the French court. Except when she’s a mouse. Yes, reader, Mary is an Eðian (shapeshifter) in a kingdom where Verities rule. It’s a secret that could cost her a head—or a tail.\nLuckily, Mary has a confidant in her betrothed, Francis. But things at the gilded court take a treacherous turn after the king meets a suspicious end. Thrust onto the throne, Mary and Francis face a viper’s nest of conspiracies, traps, and treason. And if Mary’s secret is revealed, heads are bound to roll.\nWith a royally clever sense of humor, Cynthia Hand, Brodi Ashton, and Jodi Meadows continue their campaign to turn history on its head in this YA fantasy that’s perfect for fans of A Gentleman’s Guide to Vice and Virtue.", "My Contrary Mary" });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksIsbn" },
                values: new object[,]
                {
                    { 1000000000m, 9780060114183m },
                    { 1000000000m, 9781400034710m },
                    { 1000000001m, 9780062930040m },
                    { 1000000002m, 9780062930040m },
                    { 1000000003m, 9780062930040m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksIsbn",
                table: "AuthorBook",
                column: "BooksIsbn");

            migrationBuilder.CreateIndex(
                name: "IX_Books_EditorialId",
                table: "Books",
                column: "EditorialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Editorials");
        }
    }
}
