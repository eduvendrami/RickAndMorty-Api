using Newtonsoft.Json;

namespace RickAndMorty.Service.Essential.Service
{
    public static class SerializationExtension
    {
        public static T DeserializeJson<T>(this string json)
        {
            if (json == null)
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
