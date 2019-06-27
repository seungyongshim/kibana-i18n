using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using i18n.DTO;
using Newtonsoft.Json;

namespace i18n.Extension
{
    public static class Ext
    {
        public static T JsonTo<T>(this string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        public static bool IsMatchKibanaWord(this string str)
        {
            return Regex.IsMatch(str, @"Kibana", RegexOptions.Compiled);
        }

        public static string ReadAllFileText(this string filepath)
        {
            return File.ReadAllText(filepath);
        }

        public static void RemoveNonKibana(this Model model)
        {
            if (model == null) return;

            var ret = model.messages.Where(x => x.Value.IsMatchKibanaWord()).ToDictionary(x => x.Key, x => x.Value);
            model.messages = ret;
        }

        public static void AddModel(this Model model, Model reference)
        {
            if (reference == null) return;

            foreach (var item in reference.messages)
            {
                model.messages[item.Key] = item.Value;
            }
        }
    }
}
