using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dekerf_steve_Project.Models
{
    public class VraagService
    {
        public int GetTopID()
        {
            using (var db = new project())
            {
                return  db.Vraags.OrderByDescending(x => x.Id).First().Id+1;
            }
        }




    }
}