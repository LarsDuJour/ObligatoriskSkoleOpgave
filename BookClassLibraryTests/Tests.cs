using System;
using BookClassLibrary;
using Xunit;

namespace BookClassLibraryTests
{

    public class Tests
    {
  
        [Fact]
        public void TestTitleGood()
        {
        Book testBook1 = new Book();

            Assert.True(testBook1.isTitleValid("Yeet Books"));

       
            
        }


        [Fact]
        public void TestTitleBad()
        {
            Book testBook1 = new Book();

            Assert.False(testBook1.isTitleValid("a"));
        }


        [Fact]
        public void TestPagesGood()
        {
            Book testBook1 = new Book();

            Assert.True(testBook1.isPageNumberValid(555));
        }


        [Fact]
        public void TestPagesBad()
        {
            Book testBook1 = new Book();

            Assert.False(testBook1.isPageNumberValid(1555));

        }



        [Fact]
        public void TestISBNgood()
        {
            Book testBook1 = new Book();

            Assert.True(testBook1.isISBNValid("1234567891234"));

        }

        [Fact]
        public void TestISBNbad()
        {
            Book testBook1 = new Book();

            Assert.False(testBook1.isISBNValid("1"));
        }


        [Fact]
        public void GetStuff()
        {
           Book newBook = new Book("mein tramp", "tramper torben", 200, "1111222233334");

            Assert.IsType<Book>(newBook);
        }


        [Fact]
        public void IsItABook()
        {
            Book blankBook = new Book();

            Assert.IsType<Book>(blankBook);
        }
    }
}
