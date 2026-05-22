using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrarywinF
{
    public class books
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Authour { get; set; }


        public string Edition { get; set; }

        public override string ToString()
        {
            return $"{ISBN} - {Title} by {Authour} (Edition : {Edition})";
        }

        internal void Add(books books)
        {
            throw new NotImplementedException();
        }
    }
}
