using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrarywinF
{
    public class books
    {
        public string ISBN { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Authour { get; set; } = string.Empty;

        public string Edition { get; set; } = string.Empty;

        public bool IsAvailabe { get; set; } = true;

        public override string ToString()
        {
            string status = IsAvailabe ? "Available" : "Issued";
            return $"{ISBN} - {Title} by {Authour} (Edition: {Edition}) [{status}]";
        }
    }
}
