using System;

namespace TestProject1.Models
{
    public class Search
    {
        public String _searchString;

        public Search(string searchString)
        {
            _searchString = searchString;
        }
        public String SearchString
        {
            get { return _searchString; }
            set { _searchString = value; }
        }
        
        
    }
}