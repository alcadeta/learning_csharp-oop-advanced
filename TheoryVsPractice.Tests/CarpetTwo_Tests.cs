using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheoryVsPractice
{
    [TestClass]
    public class CarpetTwo_Tests
    {
        [TestMethod]
        public void TestCarpet()
        {
            var sweeper = new Sweepable();
            var gallery = new ArtExhibit();

            var wallart = new CarpetTwo(sweeper, gallery);
        }
    }
}