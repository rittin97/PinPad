using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab3
{
    public class Controller
    {
        private String path = @"db.txt";
        public String FilePath
        {
            get { return path; }

            set { path = value; }
        }

        //public String PassCode { get; }

        //public String UserName { get; }

        public static int counter = 0;

    }
}
