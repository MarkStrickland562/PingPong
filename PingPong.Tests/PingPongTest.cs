using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThreeAndFive_pingpong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("ping-pong", testPingPong.PlayPingPong(15));
    }
    [TestMethod]
    public void IsPingPong_NotNumberDivisibleByThreeAndFive_pingpong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("not-ping-pong", testPingPong.PlayPingPong(14));
    }
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThree_ping()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("ping", testPingPong.PlayPingPong(9));
    }
    [TestMethod]
    public void IsPingPong_NotNumberDivisibleByThree_ping()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("not-ping-pong", testPingPong.PlayPingPong(8));
    }
    public void IsPingPong_NumberDivisibleByFive_pong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("pong", testPingPong.PlayPingPong(10));
    }
    public void IsPingPong_NotNumberDivisibleByFive_pong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("not-ping-pong", testPingPong.PlayPingPong(11));
    }
  }
}
