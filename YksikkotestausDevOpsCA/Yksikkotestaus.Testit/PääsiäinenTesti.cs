using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yksikkötestaus;

namespace Yksikkotestaus.Testit
{
    [TestClass] //Attribuutti
    public class PääsiäinenTesti
    {
        [TestMethod] //Attribuutti
        public void VarmistaPääsiäissunnuntainLaskenta()
        {
            //throw new Exception("Pöö!");
            //uusi instanssi objektista:
            Pääsiäinen pääsiäinen = new Pääsiäinen();
            DateTime sunnuntai = pääsiäinen.GetEasterSunday(2018);

            //Vaihtoehtoinen tapa kirjoittaa testausta:
            //! = negaatio operaattori
            //if (!(sunnuntai.Date == new DateTime(2018, 4, 1)))
            //{
            //    throw new Exception("Pääsiäinen laskettu väärin!");
            //}
            Assert.AreEqual(new DateTime(2018, 4, 1), sunnuntai.Date); 
        }
    }
}
