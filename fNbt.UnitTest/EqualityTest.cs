using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fNbt.UnitTest
{
    public class EqualityTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.IsTrue((new NbtInt(1)).IsSameContentWith(new NbtInt(1)));
            Assert.IsFalse((new NbtInt(1)).IsSameContentWith(new NbtInt(2)));

            Assert.IsTrue((new NbtShort(1)).IsSameContentWith(new NbtShort(1)));
            Assert.IsFalse((new NbtShort(1)).IsSameContentWith(new NbtShort(2)));

            Assert.IsTrue((new NbtByte(1)).IsSameContentWith(new NbtByte(1)));
            Assert.IsFalse((new NbtByte(1)).IsSameContentWith(new NbtByte(2)));

            Assert.IsTrue((new NbtDouble(1)).IsSameContentWith(new NbtDouble(1)));
            Assert.IsFalse((new NbtDouble(1)).IsSameContentWith(new NbtDouble(2)));

            Assert.IsTrue((new NbtFloat(1)).IsSameContentWith(new NbtFloat(1)));
            Assert.IsFalse((new NbtFloat(1)).IsSameContentWith(new NbtFloat(2)));

            Assert.IsTrue((new NbtString("1")).IsSameContentWith(new NbtString("1")));
            Assert.IsFalse((new NbtString("1")).IsSameContentWith(new NbtString("2")));

            Assert.IsTrue((new NbtList() { new NbtInt(2), new NbtInt(3) }).IsSameContentWith(new NbtList() { new NbtInt(2), new NbtInt(3) }));
            Assert.IsFalse((new NbtList() { new NbtInt(2), new NbtInt(3) }).IsSameContentWith(new NbtList() { new NbtInt(2), new NbtInt(1) }));
            Assert.IsFalse((new NbtList() { new NbtInt(2), new NbtInt(3) }).IsSameContentWith(new NbtList() { new NbtInt(1) }));

            Assert.IsTrue((new NbtCompound() { new NbtInt("t1", 2), new NbtInt("t2", 3) }).IsSameContentWith(new NbtCompound() { new NbtInt("t2", 3), new NbtInt("t1", 2) }));
            Assert.IsFalse((new NbtCompound() { new NbtInt("t1", 2), new NbtInt("t2", 3) }).IsSameContentWith(new NbtCompound() { new NbtString("t2", "3"), new NbtInt("t1", 2) }));
        }
    }
}
