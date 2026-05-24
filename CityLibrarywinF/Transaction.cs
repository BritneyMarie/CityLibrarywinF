using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrarywinF
{
    public  class Transaction
    {
        public static List<Transaction> Transactions = new List<Transaction>();

        public static void Add(Transaction t) => Transactions.Add(t);

        public string ISBN { get; set; }

        public string MemberID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime? ReturnDate { get; set; }



    }
}
