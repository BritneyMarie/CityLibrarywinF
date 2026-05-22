using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrarywinF
{
     public class Members
    {
        public string MemberID { get; set; }

        public string MemberName { get; set; }

        public override string ToString()
        {
            return $"{MemberName} (ID: {MemberID})";
        }
    }
}
