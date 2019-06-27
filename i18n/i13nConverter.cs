using System;
using i18n.DTO;
using i18n.Extension;
using Newtonsoft.Json;

namespace i18n
{

    public static class i13nConverter
    {
        public static string RemoveNoKibana(string input)
        {
            return RemoveNoKibanaAndUpdate(input, null);
        }

        public static string RemoveNoKibanaAndUpdate(string input, string reference)
        {
            Model model = JsonConvert.DeserializeObject<Model>(input);

            model.RemoveNonKibana();





            return JsonConvert.SerializeObject(model, Formatting.Indented);
        }
    }
}
