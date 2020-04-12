using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BFcalcTest_boar_CalculateBoardFootage()
        {
            BFcalc value = new BFcalc();

            decimal BoardFootage = value.CalculateBoardFootage(12, 12, 1);

            Assert.AreEqual(1, BoardFootage);
        }
    }
}
