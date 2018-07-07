using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class ForecastBase
    {
        public class Main
        {
            [DataMember]
            [JsonProperty("temp", Required = Required.Always)]
            public double temp { get; set; }

            [DataMember]
            [JsonProperty("pressure", Required = Required.Always)]
            public double pressure { get; set; }

            [DataMember]
            [JsonProperty("humidity", Required = Required.Always)]
            public int humidity { get; set; }
           
        }
        [DataContract]
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public class Clouds
        {
            [DataMember]
            [JsonProperty("all", Required = Required.Always)]
            public int all { get; set; }
        }
        [DataContract]
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public class Wind
        {
            [DataMember]
            [JsonProperty("speed", Required = Required.Always)]
            public double speed { get; set; }
        }
        [DataContract]
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public class MyList
        {

            [DataMember]
            [JsonProperty("main", Required = Required.Always)]
            public Main main { get; set; }
            [DataMember]
            [JsonProperty("clouds", Required = Required.Always)]
            public Clouds clouds { get; set; }
            [DataMember]
            [JsonProperty("wind", Required = Required.Always)]
            public Wind wind { get; set; }

            [DataMember]
            [JsonProperty("dt_txt", Required = Required.Always)]
            public string dt_txt { get; set; }
        }
        [DataContract]
        [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
        public class Example
        {
            [DataMember]
            [JsonProperty("list", Required = Required.Always)]
            public IList<MyList> list { get; set; }
            
        }

    }
}
