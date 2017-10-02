using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using ProtoBuf;
namespace Serialization
{
    [ProtoContract]
    [Serializable]
    [DataContract]
    public class Book
    {

        public Book()
        {
   
        }
        public Book(string name)
        {
            Name = name;
        }
        [DataMember]
        [ProtoMember(1)]
        public string Name { get; set; }
    }
}