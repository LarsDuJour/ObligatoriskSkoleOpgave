using System;

namespace BookClassLibrary
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pages;
        private string ISBN;

        #region constructors

        //blank constructor for JSON
        public Book()
        {
            
        }


        //non blank constructor for everyone else
        public Book(string inputtitle, string inputauthor, int inputpages, string inputisbn)
        {
            Title = inputtitle;
            Author = inputauthor;
            Pages = inputpages;
            ISBN = inputisbn;
        }
        

        #endregion


        #region getterssetters
        public string Title
        {
            get { return _title; }
            set
            {
                if (isTitleValid(value))
                {
                    _title = value;
                }


            }
            
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Pages
        {
            get { return _pages; }
            set
            {
                if (isPageNumberValid(value))
                {
                    _pages = value;
                }
               
                
            }
        }

        public string Isbn
        {
            get { return ISBN; }
            set
            {
                if (isISBNValid(value))
                {
                    ISBN = value;
                }
               
                
            }
        }
        #endregion


        #region verificationmethods

        public bool isTitleValid(string input) => input.Length > 2;

        public bool isPageNumberValid(int input) => input > 9 && input < 1001;

        public bool isISBNValid(string input) => input.Length == 13;

        #endregion
    }
}
