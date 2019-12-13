using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using IdentityModel.Client;
using System.Windows.Forms;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json;

namespace ApplicationLourde
{
    class AppelAPI
    {
               class Person
                {
                    public string User { get; set; }
                    public string Password { get; set; }

                    public override string ToString()
                    {
                        return $"{User}: {Password}";
                    }
                }
/* 
                public static async void Testc(string user, string password)
                {
                    var person = new Person();
                    person.User = user;
                    person.Password = password;

                    var json = JsonConvert.SerializeObject(person);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var url = "https://localhost:3000/test";
                    var client = new HttpClient();

                    var response = await client.PostAsync(url, data);

                    string result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(result);
                }
                */

        public static string Testc(string user, string password)
        {
            var person = new Person();
            person.User = user;
            person.Password = password;

            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create("http://localhost:3000/test");
            // Set the Method property of the request to POST.  
            request.Method = "POST";
            
            // Create POST data and convert it to a byte array.  
            string postData = JsonConvert.SerializeObject(person);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            
            // Get the stream containing content returned by the server.  
            // The using block ensures the stream is automatically closed.
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
            }
            
            // Close the response.  
            response.Close();

            return "";
        }
    }
}
