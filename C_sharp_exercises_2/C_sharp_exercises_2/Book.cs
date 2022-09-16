using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_exercises_2
{
      public  class Book
        {
        public string author { get; set; }
        public string title { get; set; }
        public string BookDta { get; set; }
        public Book(string name, string title, string BookDta)
            {
                this.author = name;
                this.title = title;
                this.BookDta = BookDta;
            }
        }
}
