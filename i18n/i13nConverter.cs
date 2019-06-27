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
            Model model = input?.JsonTo<Model>();
            Model refModel = reference?.JsonTo<Model>();

            model.RemoveNonKibana();

            model.AddReference(refModel);

            return JsonConvert.SerializeObject(model, Formatting.Indented);
        }
    }
}
