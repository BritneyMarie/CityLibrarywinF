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

        public string MemberID { get; set; } = string.Empty;

        public string MemberName { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{MemberName} (ID: {MemberID})";
        }
    }
}
