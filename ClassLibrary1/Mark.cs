using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Mark
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public int Subject { get; set; }
    }
}
