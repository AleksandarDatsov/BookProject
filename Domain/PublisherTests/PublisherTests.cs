using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Test.PublisherTests
{
    [TestClass]
    public class PublisherTests
    {
        private const int Id = 100;
        private const string PublisherName = "Gandalf";

        private readonly Publisher publisher;

        public PublisherTests()
        {
            this.publisher = new Publisher();
        }

        [TestMethod]
        public void TestSetAndGetId()
        {
            this.publisher.Id = Id;
            Assert.IsTrue(this.publisher.Id == Id);
        }

        [TestMethod]
        public void TestSetAndGetAuthorName()
        {
            this.publisher.Name = PublisherName;
            Assert.IsTrue(this.publisher.Name.Equals(PublisherName));
        }
    }
}
