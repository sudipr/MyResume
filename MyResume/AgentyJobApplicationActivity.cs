using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiteDB;
using MyResume.Models;

namespace MyResume
{
    public class AgentyJobApplicationActivity : IAgentyJobApplication
    {

        public Models.MyResume GetResume(string id)
        {
            using (var db = new LiteDatabase(@"C:\Users\sudip\source\repos\MyResume\MyResume\MyLiteData.db"))
            {
                var col = db.GetCollection<Models.MyResume>("myresume");
                return col.FindById(id);
            }
        }

        public int InsertResume(Models.MyResume request)
        {
            using (var db = new LiteDatabase(@"C:\Users\sudip\source\repos\MyResume\MyResume\MyLiteData.db"))
            {
                IEnumerable<Models.MyResume> items = new Models.MyResume[] { request };
               // items.Concat<Models.MyResume>(new Models.MyResume[] { request });
                var col = db.GetCollection<Models.MyResume>("myresume");

                int id = col.Insert(items);

                return id;
            }
        }
    }
}