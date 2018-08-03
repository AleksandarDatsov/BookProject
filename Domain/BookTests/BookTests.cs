using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Test.BookTests
{
    [TestClass]
    public class BookTests
    {
        private const string Id = "du28289h3212e22d298-d28-h29 ";
        private const string Title = "Gandalf";
        private readonly Book book;
        private DateTime dateOfPublishing = DateTime.Parse("2018-07-11");

        public BookTests()
        {
            this.book = new Book();
        }

        [TestMethod]
        public void TestSetAndGetId()
        {
            this.book.Id = Id;
            Assert.IsTrue(this.book.Id == Id);
        }

        [TestMethod]
        public void TestSetAndGetAuthorName()
        {
            this.book.Title = Title;
            Assert.IsTrue(this.book.Title.Equals(Title));
        }

        [TestMethod]
        public void TestSetAndGetDateOfPublishing()
        {
            this.book.DateOfPublishing = this.dateOfPublishing;
            Assert.IsTrue(DateTime.Compare(this.book.DateOfPublishing, this.dateOfPublishing) == 0);
        }
    }
}
