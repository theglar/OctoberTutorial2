using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace OctoberTutorial2
{
    class Measurements
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string SessionNumber { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Pressure { get; set; }

        public string Duration { get; set; }
    }
}
