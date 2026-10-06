using Swin_Adventure3._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    class BagTest
    {
        Bag bag;
        Bag bag1;
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        Item pickaxe = new Item(new string[] { "pickaxe" }, "a pickaxe", "This is a pickaxe");
        Item axe = new Item(new string[] { "axe" }, "a axe", "This is a axe");
        Item hoe = new Item(new string[] { "hoe" }, "a hoe", "This is a hoe");
        Item bow = new Item(new string[] { "bow" }, "a bow", "This is a bow");

        [SetUp]
        public void Setup()
        {
            bag = new Bag(new string[] { "bag" }, "a bag", "This is a bag");
            bag1 = new Bag(new string[] { "bag1" }, "a bag1", "This is a bag1");
            bag.Inventory.Put(sword);
            bag.Inventory.Put(axe);
            bag.Inventory.Put(bow);
            bag1.Inventory.Put(shovel);
            bag1.Inventory.Put(hoe);
            bag1.Inventory.Put(pickaxe);
        }
        [Test]
        public void TestBagLocatesItems()
        {
            Assert.IsTrue(bag.Inventory.HasItem("sword"));
            Assert.IsTrue(bag.Inventory.HasItem("axe"));
            Assert.IsTrue(bag.Locate(sword.FirstId) == sword);
            Assert.IsTrue(bag.Locate(axe.FirstId) == axe);
        }
        [Test]
        public void TestBagLocatesItself()
        {
            Assert.IsTrue(bag.Locate(bag.FirstId) == bag);
            Assert.IsTrue(bag.Locate("bag") == bag);
        }
        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.IsTrue(bag.Locate(hoe.FirstId) == null);
        }
        [Test]
        public void TestBagFullDescription()
        {
            Assert.AreEqual(bag.FullDescription, "a bag, containing:\na sword (sword)\na axe (axe)\na bow (bow)\n");
        }
        [Test]
        public void TestBagInBag()
        {
            bag.Inventory.Put(bag1);
            Assert.IsTrue(bag.Locate(bag1.FirstId) == bag1);
            Assert.IsTrue(bag.Locate(sword.FirstId) == sword);
            Assert.IsTrue(bag.Locate(axe.FirstId) == axe);
        }
    }
}
