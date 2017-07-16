using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsgPack.Serialization;

namespace LevelUp.Serializer.MsgPackCli
{
    public class MsgPackCliSerializer : SerializerBase
    {
        public override void SerializeToStream<T>(T obj, Stream stream, bool enableCompress = false)
        {
            var serializer = SerializationContext.Default.GetSerializer<T>();
            serializer.Pack(stream, obj);
        }

        public override T DeSerializeFromStream<T>(Stream stream, bool enableDecompress = false)
        {
            var serializer = SerializationContext.Default.GetSerializer<T>();
            return serializer.Unpack(stream);
        }
    }
}
