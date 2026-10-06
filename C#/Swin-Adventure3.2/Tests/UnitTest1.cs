using Swin_Adventure3._2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using NUnit.Framework;

namespace Tests
{

    public class LookCommandTest
    {
        Command look;
        Player player, player1;
        Bag bag;

        Item axe = new Item(new string[] { "axe" }, "a axe", "This is a axe");
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item hoe = new Item(new string[] { "hoe" }, "a hoe", "This is a hoe");
        
        [SetUp]
        public void Setup()
        {
            LookCommand look = new LookCommand();
            player = new Player("Anh", "Anh's Player");
            bag = new Bag(new string[] { "bag" },
                $"Anh's bag",
                $"This is {player.FirstId} bag");
            player.Inventory.Put(bag);


            player1 = new Player("Anh", "Anh's Player");


        }

        [Test]
        public void TestLookAtMe()
        {
            string Output = look.Execute(player, new string[] { "look", "at", "inventory" });
            string exp = $"{player.Name}, you are carrying\n{player.Inventory.ItemList}";

            Assert.That(exp, Is.EqualTo(Output));
        }

        [Test]
        public void TestLookAtGem()
        {
            player.Inventory.Put(axe);

            string Output = look.Execute(player, new string[] { "look", "at", "gem" });
            string exp = $"{axe.FullDescription}";
            Assert.That(exp, Is.EqualTo(Output));

        }

        [Test]
        public void TestLookAtUnk()
        {
            string Output = look.Execute(player, new string[] { "look", "at", "gem" });
            string exp = $"Couldn't find gem";
            Assert.That(exp, Is.EqualTo(Output));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            player.Inventory.Put(axe);
            string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", "me" });
            string exp = $"{axe.FullDescription}";
            Assert.That(exp, Is.EqualTo(Output));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            bag.Inventory.Put(axe);
            string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", $"bag" });
            string exp = $"{axe.FullDescription}";
            Assert.That(exp, Is.EqualTo(Output));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            bag.Inventory.Put(axe);
            string Output = look.Execute(player, new string[] { "look", "at", "iron", "in", $"bag" });
            string exp = $"Couldn't find iron";
            Assert.That(exp, Is.EqualTo(Output));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            bag.Inventory.Put(axe);
            player1.Inventory.Put(bag);
            string Output = look.Execute(player1, new string[] { "look", "at", "gem", "in", $"{player.Name}" });
            string exp = $"Couldn't find gem";
            Assert.That(exp, Is.EqualTo(Output));
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.That(("Error in look input."), Is.EqualTo(look.Execute(player1, new string[] { "look", "around" })));
            Assert.That("Error in look input.", Is.EqualTo(look.Execute(player1, new string[] { "find", "axe" })));
        }

    }
}
