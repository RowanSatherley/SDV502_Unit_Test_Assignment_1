using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace SDV502UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string[] pinkZone = new string[11] { "Nelson", "Motueka", "Mapua", "Atawhai", "Matai", "Hope", "Brightwater", "Wakefield", "Renwick", "Picton", "Blenheim" };

            //arrange
            ParcelQuoteFromNelson quoteNelson = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteNelson.GetDestinationZone("Nelson"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            ParcelQuoteFromNelson quoteBlenheim = new ParcelQuoteFromNelson();
            //act
            string ticketColour = quoteBlenheim.GetDestinationZone("Blenheim"); //town name 
            //assert
            Assert.AreEqual("Pink", ticketColour); //ticket colour
        }

        [TestMethod]
        public void TestMethod3()
        {
            ParcelQuoteFromNelson quoteFromNelson = new ParcelQuoteFromNelson();
            string[] pinkZones = new string[] { "Nelson", "Motueka", "Mapua", "Atawhai", "Matai", "Hope", "Brightwater", "Wakefield", "Renwick", "Picton", "Blenheim" };

            foreach (string towns in pinkZones)
            {
                string ticketColour = quoteFromNelson.GetDestinationZone(towns);
                Assert.AreEqual("Pink", ticketColour);
            }
        }


    }
}
