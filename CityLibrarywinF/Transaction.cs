using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrarywinF
{
    public class Transaction
    {
        public static List<Transaction> Transactions = new List<Transaction>();

        public static void Add(Transaction t) => Transactions.Add(t);

        public string ISBN { get; set; } = string.Empty;

        public string MemberID { get; set; } = string.Empty;

        public DateTime IssueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public override string ToString()
        {
            if (ReturnDate.HasValue)
                return $"Returned: {ISBN} by Member {MemberID} on {ReturnDate.Value:dd/MM/yyyy}";
            else
                return $"Issued: {ISBN} to Member {MemberID} on {IssueDate:dd/MM/yyyy}";
        }
    }
}
