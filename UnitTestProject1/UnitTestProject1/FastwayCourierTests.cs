using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDV502_UnitTestAss1
{
    [TestClass]
    public class GettingDestinationZone_Should
    {
        [TestMethod]
        public void ReturnPink_WhenPinkZonePlacesEntered()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            // Act
            Dictionary<string, string> Places = new Dictionary<string, string>()
            {
                {"Motueka","Pink"},
                {"Mapua","Pink"},
                {"Atawhai","Pink"},
                {"Nelson","Pink"},
                {"Maitai","Pink"},
                {"Hope","Pink"},
                {"Brightwater","Pink"},
                {"Wakefield","Pink"},
                {"Renwick","Pink"},
                {"Picton","Pink"},
                {"Blenheim","Pink"}
            };

            //Assert

            //var GetZone = Fastway.GetDestinationZone("Motueka");
            //Assert.AreEqual(Places(Word2), GetZone);
            foreach (var item in Places)
            {
                Assert.AreEqual(Fastway.GetDestinationZone(item.Key), item.Value);
            };
        }

        [TestMethod]
        public void ReturnBlue_WhenBlueZonePlacesEntered()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            // Act
            Dictionary<string, string> Places = new Dictionary<string, string>()
            {
                {"Takaka","Blue"},
                {"Havelock","Blue"},
                {"Seddon","Blue"},
                {"Ward","Blue"},
                {"Waihopai Valley","Blue"},
                {"Riwaka","Blue" }

            };

            //Assert

            foreach (var item in Places)
            {
                Assert.AreEqual(Fastway.GetDestinationZone(item.Key), item.Value);
            };
        }

        [TestMethod]
        public void ReturnLime_WhenLimeZonePlacesEntered()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            // Act
            Dictionary<string, string> Places = new Dictionary<string, string>()
            {
                {"Murchison","Lime"},
                {"Nelson Lakes National Park","Lime"}
            };

            //Assert

            foreach (var item in Places)
            {
                Assert.AreEqual(Fastway.GetDestinationZone(item.Key), item.Value);
            };
        }

        [TestMethod]
        public void ReturnOrange_WhenOrangeZonePlacesEntered()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            // Act
            Dictionary<string, string> Places = new Dictionary<string, string>()
            {
                {"Reefton","Orange"},
                {"Hanmer Springs","Orange"},
                {"Kaikoura","Orange"}
            };

            //Assert

            foreach (var item in Places)
            {
                Assert.AreEqual(Fastway.GetDestinationZone(item.Key), item.Value);
            };

        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ThrowException_WhenRandomStringEntered()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            // Act
            Dictionary<string, string> Places = new Dictionary<string, string>()
            {
                {"Cat","Orange"}
            };

            //Assert

            foreach (var item in Places)
            {
                Fastway.GetDestinationZone(item.Key);
            };

        }

    }

    [TestClass]
    public class GettingParcelQuoteFromNelson_Should
    {
        // Pink
        [TestMethod]
        public void Return4_15_When1or25WithPinkEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal lowsetAcceptededWeight = 1m;
            decimal HighestAcceptedWeight = 25m;

            //Assert
            Assert.AreEqual(4.15m, Fastway.CalculateQuote(lowsetAcceptededWeight, "Pink").Price);
            Assert.AreEqual(4.15m, Fastway.CalculateQuote(HighestAcceptedWeight, "Pink").Price);
        }

        //Blue
        [TestMethod]
        public void Return6_95_When1or25WithBlueEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal lowsetAcceptededWeight = 1m;
            decimal HighestAcceptedWeight = 25m;

            //Assert
            Assert.AreEqual(6.95m, Fastway.CalculateQuote(lowsetAcceptededWeight, "Blue").Price);
            Assert.AreEqual(6.95m, Fastway.CalculateQuote(HighestAcceptedWeight, "Blue").Price);

        }

        //Lime
        [TestMethod]
        public void Return8_70_When1or15WithLimeEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal lowsetAcceptededWeight = 1m;
            decimal HighestAcceptedWeight = 15m;

            //Assert
            Assert.AreEqual(8.70m, Fastway.CalculateQuote(lowsetAcceptededWeight, "Lime").Price);
            Assert.AreEqual(8.70m, Fastway.CalculateQuote(HighestAcceptedWeight, "Lime").Price);

        }

        [TestMethod]
        public void Return6_20And1ExtraTicket_When16or25WithLimeEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal LowestExtraWeightfor1Ticket = 16m;
            decimal HighestExtraWeightfor1Ticket = 25m;

            //Assert
            var LowestReturn = Fastway.CalculateQuote(LowestExtraWeightfor1Ticket, "Lime");
            Assert.AreEqual(8.70m + 6.20m, LowestReturn.Price);
            Assert.AreEqual(1, LowestReturn.ExcessTickets);

            var HighestReturn = Fastway.CalculateQuote(HighestExtraWeightfor1Ticket, "Lime");
            Assert.AreEqual(8.70m + 6.20m, LowestReturn.Price);
            Assert.AreEqual(1, LowestReturn.ExcessTickets);

        }

        //Orange
        [TestMethod]
        public void Return12_95_When1Or15WithOrangeEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal lowsetAcceptededWeight = 1m;
            decimal HighestAcceptedWeight = 15m;

            //Assert
            Assert.AreEqual(12.95m, Fastway.CalculateQuote(lowsetAcceptededWeight, "Orange").Price);
            Assert.AreEqual(12.95m, Fastway.CalculateQuote(HighestAcceptedWeight, "Orange").Price);
        }

        [TestMethod]
        public void Return19_15And1ExtraTicket_When16or19WithOrangeEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal LowestExtraWeightfor1Ticket = 16m;
            decimal HighestExtraWeightfor1Ticket = 19m;

            //Assert
            var LowestReturn = Fastway.CalculateQuote(LowestExtraWeightfor1Ticket, "Orange");
            Assert.AreEqual(12.95m + 6.20m, LowestReturn.Price);
            Assert.AreEqual(1, LowestReturn.ExcessTickets);

            var HighestReturn = Fastway.CalculateQuote(HighestExtraWeightfor1Ticket, "Orange");
            Assert.AreEqual(12.95m + 6.20m, LowestReturn.Price);
            Assert.AreEqual(1, LowestReturn.ExcessTickets);

        }

        [TestMethod]
        public void Return25_35And2ExtraTicket_When20or25WithOrangeEntered()
        {
            //Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();

            //Act
            decimal LowestExtraWeightfor2Ticket = 20m;
            decimal HighestExtraWeightfor2Ticket = 25m;

            //Assert
            var LowestReturn = Fastway.CalculateQuote(LowestExtraWeightfor2Ticket, "Orange");
            Assert.AreEqual(12.95m + (2 * 6.20m), LowestReturn.Price);
            Assert.AreEqual(2, LowestReturn.ExcessTickets);

            var HighestReturn = Fastway.CalculateQuote(HighestExtraWeightfor2Ticket, "Orange");
            Assert.AreEqual(12.95m + (2 * 6.20m), LowestReturn.Price);
            Assert.AreEqual(2, LowestReturn.ExcessTickets);

        }

        //Pink Outside
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When0EnteredforPink()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(0m, "Pink");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When26EnteredforPink()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(26m, "Pink");
        }

        //BlueOutside
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When0EnteredforBlue()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(0m, "Blue");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When26EnteredforBlue()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(26m, "Blue");
        }


        //LimeOutside
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When0EnteredforLime()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(0m, "Lime");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When26EnteredforLime()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(26m, "Lime");
        }

        //OrangeOutside
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When0EnteredforOrange()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(0m, "Orange");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowException_When26EnteredforOrange()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(26m, "Orange");
        }

        //InvalidZone
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ThrowException_InvalidZoneEntered()
        {
            // Arrage
            var Fastway = new FastwayCourier.ParcelQuoteFromNelson();
            //Assert
            Fastway.CalculateQuote(10m, "Potato");
        }

    }
}