using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PersonApiController : ApiController
    {
        IEnumerable<Person> personList;
        PersonManager personManager;

        public PersonApiController()
        {
            personList = new List<Person>();
            personManager = new PersonManager();

            personList = personManager.GetPersonList();

        }

        public HttpResponseMessage GetPeopleInfo()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            PersonApiResponse response = personManager.GetPeopleInfo(personList);

            string str = serializer.Serialize(response);
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        } 
    }
}
