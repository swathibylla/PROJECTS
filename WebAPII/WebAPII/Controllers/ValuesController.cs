using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;


namespace WebAPII.Controllers
{
    public class ValuesController : ApiController
    {

        SqlConnection con = new SqlConnection("server=SWATHI\\SQLEXPRESS02;database=Rainbows;Integrated Security=true");
        // GET api/values
       // public IEnumerable<string> Get()
       public string Get()
        {
            //return new string[] { "value1", "value2" };
            SqlDataAdapter d = new SqlDataAdapter("Select *from Student", con);
            DataTable dt = new DataTable();
            d.Fill(dt);
            if(dt.Rows.Count>0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No Data Found";
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            SqlCommand cmd = new SqlCommand("Insert into student(Name) values()", con);
            con.Open();
             int i =cmd.ExecuteNonQuery();
            con.Close();
            if(i == 1)
            {
                return "Record inserted with value as " + value; 
            }
            else
            {
                return "Try again";
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
