using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class ShowTableViewModel
    {
        public IEnumerable<Person> PersonList {get;set;}
    }
}