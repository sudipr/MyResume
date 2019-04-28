using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Models
{
    public class MyResume
    {
        public string Email { get; set; }

        public string Experience { get; set; }

        // public int ID { get; set; }

        public string Location { get; set; }

        [BsonId]
        public string Name { get; set; }

        public string Phone { get; set; }

        public string[] Skills { get; set; }


    }
}