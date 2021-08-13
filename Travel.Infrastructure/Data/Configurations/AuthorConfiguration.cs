using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Travel.Core.Entities;

namespace Travel.Infrastructure.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(SeedData.GetAuthors());

            builder.HasMany(a => a.Books)
                .WithMany(b => b.Authors)
                .UsingEntity<Dictionary<string, object>>(
                    "AuthorBook",
                    r => r.HasOne<Book>()
                        .WithMany()
                        .HasForeignKey("BooksIsbn"),
                    l => l.HasOne<Author>()
                        .WithMany()
                        .HasForeignKey("AuthorsId"),
                    j =>
                    {
                        j.HasKey("AuthorsId", "BooksIsbn");
                        j.HasData(SeedData.GetAuthorsBooks());
                    });
        }
    }
}
