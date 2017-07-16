using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

namespace LevelUp.Serializer.MsgPackCli.Test
{
    [TestClass()]
    public class MsgPackCliSerializerTest
    {
        [TestMethod()]
        public void SerializeDeSerializeTest()
        {
            var larry = new Person("Larry Nung", 35);
            var target = new MsgPackCliSerializer();
            var expected = larry.ToExpectedObject();
            var actual = target.DeSerializeFromBytes<Person>(target.SerializeToBytes(larry));

            expected.ShouldEqual(actual);
        }
    }
}