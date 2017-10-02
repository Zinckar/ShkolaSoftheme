using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Serialization
{
    public static class SerializationTime
    {
        public static void TestSpeed()
        {
            var toSerializeList = new List<Book>();
            for (int i = 0; i < 100000; i++)
            {
                toSerializeList.Add(new Book($"Book {i}"));
            
            }

            var binaryWatch = Stopwatch.StartNew();
            new BinarySerialization<Book>().Serialize(toSerializeList);
            binaryWatch.Stop();
            Console.WriteLine("Binary serialization 100000 books : {0} ms", binaryWatch.ElapsedMilliseconds);

            var xmlWatch = Stopwatch.StartNew();
            new XmlSerialization<Book>().Serialize(toSerializeList);
            xmlWatch.Stop();
            Console.WriteLine("XML serialization 100000 books : {0} ms", xmlWatch.ElapsedMilliseconds);

            var jsonWatch = Stopwatch.StartNew();
            new JsonSerialization<Book>().Serialize(toSerializeList);
            jsonWatch.Stop();
            Console.WriteLine("JSON serialization 100000 books : {0} ms", jsonWatch.ElapsedMilliseconds);

            var protoBufWatch = Stopwatch.StartNew();
            new ProtoBufSerialization<Book>().Serialize(toSerializeList);
            protoBufWatch.Stop();
            Console.WriteLine("Protobuf serialization 100000 books : {0} ms", protoBufWatch.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine();
     

   

        }
    }
}