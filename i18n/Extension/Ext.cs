using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace i18n.Extension
{
    public static class Ext
    {
        public static bool IsMatchKibanaWord(this string str)
        {
            return Regex.IsMatch(str, @"Kibana", RegexOptions.Compiled);
        }

        public static void RemoveNonKibana ( this DTO.Model model)
        {
            var ret = model.messages.Where(x => x.Value.IsMatchKibanaWord()).ToDictionary(x => x.Key, x => x.Value);
            model.messages = ret;
        }
    }
}
