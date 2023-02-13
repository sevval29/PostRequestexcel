using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Nancy;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Json;
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace PostRequest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody]  dynamic jsonx)
        {


            //  var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExpandoObject>>(new ExpandoObject());
          //  string jsona = System.Text.Json.JsonSerializer.Serialize(jsonx);

           Data dataa = JsonConvert.DeserializeObject<Data>(jsonx.ToString());

            var x = dataa;
            return Ok(dataa);
           


            // var userDetails = GetJsonGenericType<dynamic>(jsonx);

            // var data = JsonSerializer.Deserialize(jsonx.ToString());

            //var Data = JsonSerializer.Deserialize(jsonx);
            //var datas = JsonConvert.DeserializeObject<dynamic>(data.ToString());

            //  Employee employee = JsonConvert.DeserializeObject<Employee>(jsonx.ToString());
            //dynamic jsonObj = JsonConvert.DeserializeObject(jsonx);

            //  var jsonString = ((System.Text.Json.JsonDocument)jsonx).RootElement.GetRawText();
            ///  return JsonConvert.DeserializeObject<Data>(jsonString);

            // Data datax = JsonConvert.DeserializeObject<Data>(jsonx.ToString());
            //
            // var objDeserializeObject = JsonConvert.DeserializeObject<Data>(jsonx.ToString());

            //  var person = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonx.ToString());

            // dynamic deserializedObject = JsonConvert.DeserializeObject(jsonx.ToString());

            //  Console.WriteLine(data);

        }

        


    }

   
}

