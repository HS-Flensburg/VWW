using System;
using System.Runtime.Serialization;

namespace VWW_V4_WCF
{
    [DataContract]
    //[KnownType(typeof(Guid))] nur bei eigenen klassen
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }

        public void print(string text)
        {
            Console.WriteLine(text);
        }
    }
}