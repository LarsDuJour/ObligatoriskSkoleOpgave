using System;
using Xunit;
using BookClassLibrary;

namespace BookClassLibraryTests
{
    public class Tests
    {
        private Book worldsbestbook = new Book("The Old Man And The Codebase", "Bearest Honningway", 555, "123412341234a");
        private Book badbook = new Book("a", "Bearest Honningway", 2000, "aaa");


        [Fact]
        public void TestTitleGood()
        {
            Assert.Equal("The Old Man And The Codebase", worldsbestbook.Title);
        }


        [Fact]
        public void TestTitleBad()
        {
           
        }


        [Fact]
        public void TestPagesGood()
        {
            Assert.Equal(555, worldsbestbook.Pages);
        }


        [Fact]
        public void TestPagesBad()
        {

        }



        [Fact]
        public void TestISBNgood()
        {
            worldsbestbook.Isbn = "123412341234b";
            Assert.Equal("123412341234b", worldsbestbook.Isbn);
        }

        [Fact]
        public void TestISBNbad()
        {

        }
    }
}
