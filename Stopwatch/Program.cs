﻿
namespace Stopwatch
{
  class Program
  {
    public static void Main(string[] args)
    {
      Start();
    }

    static void Start()
    {
      int time = 10;
      int currentTime = 0;
      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        System.Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }
    }
  }
}