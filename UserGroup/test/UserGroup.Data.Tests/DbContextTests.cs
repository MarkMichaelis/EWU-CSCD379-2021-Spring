using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserGroup.Data.Tests
{
    [TestClass]
    public class DbContextTests
    {
        [TestMethod]
        public void DbContext()
        {
            using DbContext dbContext = new DbContext();
            int countBefore = dbContext.Events.Count();
            dbContext.Events.Add(new Event() { Name = "Inigo Montoya" + Guid.NewGuid().ToString() });
            dbContext.SaveChanges();
            Assert.AreEqual(countBefore + 1, dbContext.Events.Count());
        }
    }
}
