using System.Net;
using System.IO;


namespace Ejhercicio1.Controller
{
    class RestControllers
    {
        [HttpPost]
        public ActionResult getUserById(string Id)
        {
            string receivedData;

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://www.mocky.io/v2/5808862710000087232b75ac");

            req.ContentType = "application/json";
            var response = (HttpWebResponse)req.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                receivedData = sr.ReadToEnd();
            }
        }
    }
}
