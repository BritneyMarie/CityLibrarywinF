using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrarywinF
{
     public class Members
    {
        public static List<Members> members = new List<Members>();

        public string MemberID { get; set; }

        public string MemberName { get; set; }

        public override string ToString()
        {
            return $"{MemberName} (ID: {MemberID})";
        }
    }
}
