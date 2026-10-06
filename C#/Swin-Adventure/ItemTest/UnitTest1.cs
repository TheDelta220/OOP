using Swin_Adventure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;


namespace ItemTest
{
    public class Tests
    {

        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        public void Setup()
        {
            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");

        }

        [Test]
        public void TestItemIdentifiable()
        {
            var result = shovel.AreYou("sword");
            Assert.IsFalse(result);

            var result2 = shovel.AreYou("shovel");
            Assert.IsTrue(result2);

        }

        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual(shovel.ShortDescription, "a shovel (shovel)");
            Assert.AreNotEqual(shovel.ShortDescription, "This is a shovel");
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual(shovel.FullDescription, "This is a shovel");
            Assert.AreNotEqual(shovel.FullDescription, "a shovel (shovel)");

        }
    }
}