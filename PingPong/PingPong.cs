using System;

namespace PingPong
{
  public class PingPong
  {
    static string PlayPingPong(int userInt)
    {
      if (userInt % 3 == 0 && userInt % 5 == 0)
      {
        return "ping-pong";
      }
      else if (userInt % 3 == 0 )
      {
        return "ping";
      }
      else if (userInt % 5 == 0 )
      {
        return "pong";
      }
      else
      {
        return "not-ping-pong";
      }
    }

    static void Main()
    {
      Console.WriteLine("Please enter a positive integer:");
      string stringUserInt = Console.ReadLine();
      int userInt = int.Parse(stringUserInt);

      for (int i = 1; i <= userInt; i++)
      {
        string stringI = i.ToString();
        string response = PlayPingPong(i);

        if (response == "not-ping-pong")
        {
          Console.WriteLine(stringI);
        }
        else
        {
          Console.WriteLine(response);
        }
      }
    }
  }
}
