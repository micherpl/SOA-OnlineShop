using Gateway.Models;
using Gateway.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Collections.Specialized;

namespace Gateway.Controllers
{
    public class UserController : ApiController
    {
        static string url = "http://127.0.0.1:8080/api/users";

        [HttpGet]
        [Route("api/Login/{username}/{password}")]
        public bool Login(string username, string password)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url + "/" + username + "/password");
            request.Method = "GET";
            String result = String.Empty;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    result = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            if (password.Equals(JsonConvert.DeserializeObject<string>(result)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // add to header Content-Type: application/json
        [Route("api/RegisterUser/")]
        public User RegisterUser([FromBody]User user)
        {

            User newUser = new User();
            string result = "";
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                try
                {
                    result = client.UploadString(url, "POST", JsonConvert.SerializeObject(user));
                }
                catch (Exception e)
                {
                    return null;
                }

            }
            newUser = JsonConvert.DeserializeObject<User>(result);
            return newUser;
        }

        [HttpDelete]
        [Route("api/UnRegister/{username}")]
        public bool UnRegister(string username)
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.UploadValues(url + "/" + username, "DELETE", new NameValueCollection());
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }


        [HttpGet]
        [Route("api/GetAllUsers/")]
        public IEnumerable<User> GetAllUsers()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            List<User> listUsers = new List<User>();
            String result = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            listUsers = JsonConvert.DeserializeObject<List<User>>(result);
            return listUsers;
        }
    }
}
