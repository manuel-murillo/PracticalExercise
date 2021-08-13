using System.Linq;
using NUnit.Framework;
using Travel.Infrastructure.Data;

namespace Travel.UnitTests
{
    public class Tests
    {
        private ApplicationDbContext _context;

        [SetUp]
        public void Setup()
        {
            ApplicationDbContextFactory factory = new ApplicationDbContextFactory();

            _context = factory.CreateDbContext("UseInMemoryDatabase");
        }

        [Test]
        public void ContextIsWorking()
        {
            _context.Books.AddRange(SeedData.GetBooks());

            var result = _context.SaveChanges();

            var actual = _context.Books.Count();

            Assert.AreEqual(3, actual);
        }
    }
}