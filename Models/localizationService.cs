using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DataTableWebAPI.Models
{
    public class localizationService
    {
        private readonly Dictionary<string, Dictionary<string, string>> _resources;

        public localizationService()
        {
            _resources = new Dictionary<string, Dictionary<string, string>>
            {
                { "en", LoadJson("Resources/Resource.en.json") },
                { "ar", LoadJson("Resources/Resource.ar.json") }
            };
        }

        private Dictionary<string, string> LoadJson(string path)
        {
            string fullPath = HttpContext.Current.Server.MapPath("~/" + path);
            using (StreamReader r = new StreamReader(fullPath))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
        }


        public string GetValue(string key, string culture)
        {
            if (_resources.ContainsKey(culture) && _resources[culture].ContainsKey(key))
            {
                return _resources[culture][key];
            }

            return key;
        }
    }
}
