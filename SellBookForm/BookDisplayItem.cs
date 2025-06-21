using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellBookForm;
using BookStoreApp;

namespace BookStoreApp // або твій простір імен
{
    public class BookDisplayItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
