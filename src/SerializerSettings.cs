namespace Linn.Common.Serialization
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;

    public static class SerializerSettings
    {
        public static readonly JsonSerializerSettings CamelCase;
        public static readonly JsonSerializerSettings CaseSensitive;

        static SerializerSettings()
        {
            CamelCase =
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc
                };
            CamelCase.Converters.Add(new IsoDateTimeConverter());

            CaseSensitive =
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc
                };
            CaseSensitive.Converters.Add(new IsoDateTimeConverter());
        }
    }
}
