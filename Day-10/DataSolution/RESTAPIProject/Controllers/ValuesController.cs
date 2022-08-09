using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTAPIProject.Controllers
{
   // [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Infosys", "Wipro", "Accenture", "HCL" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string result =string.Empty;
            switch (id)
            {
                case 1:
                    result = "Transflower";
                    break;

                case 2:
                    result = "Microsoft";
                    break;
                case 3:
                    result = "Oracle";
                    break;

                case 4:
                    result = "Google";
                    break;

            }
            return result;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

            string dataTobeInserted = value;
            // access database and insert data 


        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            //Updata data into database
            //

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            //remove data

        }
    }
}
