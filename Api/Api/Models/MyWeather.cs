using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class MyWeather
    {
        [DataContract]
        public class Main
        {
            [DataMember]
            [JsonProperty("temp", Required = Required.Always)]
            public int Temp { get; set; }
            [DataMember]
            [JsonProperty("pressure", Required = Required.Always)]
            public int Pressure { get; set; }
            [DataMember]
            [JsonProperty("humidity", Required = Required.Always)]
            public int Humidity { get; set; }
        }
        [DataContract]
        public class Wind
        {
            [DataMember]
            [JsonProperty("speed", Required = Required.Always)]
            public double Speed { get; set; }
            
        }

        [DataContract]
        public class Clouds
        {
            [DataMember]
            [JsonProperty("all", Required = Required.Always)]
            public int all { get; set; }
        }
        

        [DataContract]
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public class CurrentBunch
        {
            [DataMember]
            [JsonProperty("main", Required = Required.Always)]
            public Main main { get; set; }

            [DataMember]
            [JsonProperty("wind", Required = Required.Always)]
            public Wind wind { get; set; }
            [DataMember]
            [JsonProperty("clouds", Required = Required.Always)]
            public Clouds clouds { get; set; }

            [DataMember]
            [JsonProperty("dt", Required = Required.Always, ItemConverterType = typeof(JavaScriptDateTimeConverter))]
            public double dt { get; set; }

            
        }
    }
}
