using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Mark: ATable
    {

        public int Value { get; set; }
        public int Weight { get; set; }
        public int SubjectID { get; set; }
    }
}
