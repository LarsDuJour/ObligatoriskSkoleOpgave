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
                if (isTitleValid(Title))
                {
                    _title = value;
                }
                else
                {
                    throw new NotImplementedException();
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
                if (isPageNumberValid(Pages))
                {
                    _pages = value;
                }
                else
                {
                    throw new NotImplementedException();
                }
                
            }
        }

        public string Isbn
        {
            get { return ISBN; }
            set
            {
                if (isISBNValid(ISBN))
                {
                    ISBN = value;
                }
                else
                {
                    throw new NotImplementedException();
                }
                
            }
        }
        #endregion


        #region verificationmethods

        private bool isTitleValid(string input)
        {
            if (input.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isPageNumberValid(int input)
        {
            if (input > 9 && input < 1001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isISBNValid(string input)
        {
            if (input.Length == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
