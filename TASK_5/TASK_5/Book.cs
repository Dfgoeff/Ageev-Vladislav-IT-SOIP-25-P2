using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Book
    {
        string Title;
        string Author;
        int Year;

        public Book(string title,string author,int year)
        {
            Title=title;
            Author=author;
            Year=year;
        }
        public override string ToString()
        {
            return $"{Title} - {Author} ({Year})";
        }
    }
}
