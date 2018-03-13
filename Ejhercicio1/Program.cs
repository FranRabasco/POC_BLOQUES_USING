using System.IO;
using System.Net;
using System.Configuration;
using Newtonsoft.Json;
using Ejhercicio1.Model;

namespace Ejhercicio1s
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStr = ConfigurationManager.AppSettings["file"];
            var jsonStr = ConfigurationManager.AppSettings["jsonSrc"];
            //Obtenemos Json
            var json = new WebClient().DownloadString(jsonStr);
            var data = JsonConvert.DeserializeObject<User.RootObject>(json);



            //Creamos ficheros
            string outCsvFile = string.Format(fileStr);

            //Libera de memoria el objeto stream
            using (var stream = File.CreateText(outCsvFile))
            {
                stream.WriteLine(json);
                //siempre tienes que cerrar
                stream.Close();
               
            }


            //Antigua forma
            //try
            //{

            //}
            //finally
            //{
            //    stream.Dispose();
            //}
          


        }
    }


}
