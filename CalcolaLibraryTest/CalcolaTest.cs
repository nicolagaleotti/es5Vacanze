using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolaLibrary;

namespace CalcolaLibraryTest
{
    [TestClass]
    public class CalcolaTest
    {
        [TestMethod]
        public void TestRaddoppia()
        {
            double num = 3;
            double asp = 6;
            double resp = Calcola.Raddoppia(num);
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(3, 6)]
        public void DataTestRaddoppia(double num, double asp)
        {
            double resp = Calcola.Raddoppia(num);
            Assert.AreEqual(asp, resp);
        }

        [TestMethod]
        public void TestSommaMonete()
        {
            double[] monete = new double[] { 2, 5, 6, 18, 3 };
            double asp = 34;
            double resp = Calcola.SommaMonete(monete);
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(new double[] { 2, 5, 6, 18, 3 }, 34)]
        public void DataTestSommaMonete(double[] monete, double asp)
        {
            double resp = Calcola.SommaMonete(monete);
            Assert.AreEqual(asp, resp);
        }
    }
}
