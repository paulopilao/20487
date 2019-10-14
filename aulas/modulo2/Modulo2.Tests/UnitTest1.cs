using modulo2.DAL.Contexts;
using modulo2.DAL.Domain;
using modulo2.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modulo2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private  ClienteRepository _repo;

        private DbContextOptions<Modulo2Context> _options =
            new DbContextOptionsBuilder<Modulo2Context>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

        
        public UnitTest1()
        {
            _repo = new ClienteRepository(new Modulo2Context(_options));
        }
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "Paulo";
            _repo.Add(new Cliente(1,"Paulo","123"));
            var value = _repo.GetById(1).Nome;

            Assert.AreEqual(expected,value);
        }
    }
}
