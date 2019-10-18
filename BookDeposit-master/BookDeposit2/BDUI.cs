using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDeposit2
{
    public class BDUI
    {
        BDController bdc = new BDController();

        public void InsertRPGBOOK(string title, string author, string genre, int pages, int isbn)
        {
            
            bdc.InsertRPGBook(title, author, genre, pages, isbn);

        }
    }
}
