using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
namespace WebAPI.Controllers
{
    public class HomeController : ApiController
    {

        [HttpGet]
        public User Getinfo(string username, string password)
        {
            var obj = new User();
            if (username == "Admin" && password == "Admin")
            {
                obj.Status = 200;
                obj.Result = "Valid User info";
            }
            else
            {
                obj.Status = 205;
                obj.Result = "Invalid User";
            }

            return obj;
        }


        [HttpPost]
        public User AddUser()
        {
            String ContentType = Request.Content.Headers.ContentType == null ? "application/json" : Request.Content.Headers.ContentType.MediaType;

            HttpContent requestContent = Request.Content;
            string jsonContent = requestContent.ReadAsStringAsync().Result;
            var obj = new User();
            UserRegistration entityChannel = null;
            if (requestContent != null)
            {
                if (ContentType.Contains("application/xml"))
                {
                    ICEXMLSerializer objSer = new ICEXMLSerializer();
                    entityChannel = objSer.Deserialize<UserRegistration>(jsonContent, "Channel");
                }
                else
                    entityChannel = JsonConvert.DeserializeObject<UserRegistration>(jsonContent);

            }
            if (entityChannel == null)
            {
                obj.Status = 400;
                obj.Result = "User information missing";
                return obj;
            }


            obj.Status = 200;
            obj.Result = "User addedd successfuully";
            return obj;
        }
    }
}
