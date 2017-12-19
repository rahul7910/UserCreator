using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Runtime.Serialization.Json;
//using System.Object;

namespace Girlboss.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db; // Just for me , only assigned once 

        public CreateModel(AppDbContext db)
        {
            _db = db; 

        }
        [BindProperty]
        public Customer Customer { get; set;  }

       public async Task<IActionResult> OnPostAsync()
        {

            // Code here

            if (!ModelState.IsValid)
            {
                return Page(); 
            }
            //Customer.Email;


            //////////////////
            /// METHOD 1 /////
            //////////////////
            /*
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://apilayer.net/api/check?access_key=44a6065b4b870f2a86c79cd7eaa42611&email=" + Customer.Email + "&smtp=1&format=1");//
            request.Method = "Get";
            request.KeepAlive = true;
            request.ContentType = "appication/json";
            request.Headers.Add("Content-Type", "appication/json");
            //request.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string myResponse = "";
            using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream()))
            {
                myResponse = sr.ReadToEnd();
            }

            //Code to print to web app
         */
  /*
            myResponse.ToJSON();
            if (myResponse.smtp_check != true)
            {
                correct = true;
            }

             */


            //String attr = myResponse;
            // System.Diagnostics.Debug.WriteLine("///// RESPONSE BELOW:");
            // System.Diagnostics.Debug.WriteLine(myResponse);
            // System.Diagnostics.Debug.WriteLine("////// RESPONSE ABOVE");



            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index"); 

        }

    }
}