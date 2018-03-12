using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Business
{
    public class Instructor : BusinessBase
    {
        public string Name { get; set; }

        public List<string> Compententies { get; set; }
    }
}
