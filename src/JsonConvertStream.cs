namespace Linn.Common.Serialization
{
    using System.IO;
    using System.Text;

    using Newtonsoft.Json;

    public static class JsonConvertStream
    {
        public static T DeserializeObject<T>(Stream stream, JsonSerializerSettings settings)
        {
            var serializer = Newtonsoft.Json.JsonSerializer.Create(settings);

            using (var sr = new StreamReader(stream))
            using (var reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<T>(reader);
            }
        }

        public static Stream SerializeObject(object value, JsonSerializerSettings settings)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value, settings)));
        }
    }
}
