using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDeposit2
{
    class BDController
    {
        DataBaseManger dbm = new DataBaseManger();
        public void InsertRPGBook(string title, string author, string genre, int pages, int isbn)
        {
            RPGBook r = new RPGBook(title, author, genre, pages, isbn);
            dbm.InsertRPGBOOK(r);
        }
    }
}
