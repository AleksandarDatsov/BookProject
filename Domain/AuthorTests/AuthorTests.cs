using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Test.AuthorTests
{
    [TestClass]
    public class AuthorTests
    {
        private const int Id = 100;
        private const string AuthorName = "Gandalf";
        private readonly Author author;

        public AuthorTests()
        {
            this.author = new Author();
        }

        [TestMethod]
        public void TestSetAndGetId()
        {
            this.author.Id = Id;
            Assert.IsTrue(this.author.Id == Id);
        }

        [TestMethod]
        public void TestSetAndGetAuthorName()
        {
            this.author.Name = AuthorName;
            Assert.IsTrue(this.author.Name.Equals(AuthorName));
        }
    }
}
