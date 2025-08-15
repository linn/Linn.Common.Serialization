namespace Linn.Common.Serialization
{
    using Newtonsoft.Json;

    public class JsonSerializer : ISerializer
    {
        private readonly JsonSerializerSettings settings;

        public JsonSerializer()
        {
            this.settings = SerializerSettings.CamelCase;
        }

        public JsonSerializer(JsonSerializerSettings settings)
        {
            this.settings = settings;
        }

        public T Deserialize<T>(string body)
        {
            return JsonConvert.DeserializeObject<T>(body, this.settings);
        }

        public string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, this.settings);
        }
    }
}
