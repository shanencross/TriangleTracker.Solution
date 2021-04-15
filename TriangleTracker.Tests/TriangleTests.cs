using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests {
  [TestClass]
  public class TriangleTrackerTests {

  private Triangle _testTriangle;

  public TriangleTrackerTests() {
    _testTriangle = new Triangle(3, 4, 5);
  }

  [TestMethod]
  public void Triangle_Side1HasExpectedValue_3() {
    Assert.AreEqual(3, _testTriangle.Side1);
  }
  [TestMethod]
  public void Triangle_Side2HasExpectedValue_4() {
    Assert.AreEqual(4, _testTriangle.Side2);
  }
  [TestMethod]  
  public void Triangle_Side3HasExpectedValue_5() {
    Assert.AreEqual(5, _testTriangle.Side3);
    }
  }
}
