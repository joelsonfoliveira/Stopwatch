﻿
namespace Stopwatch
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Start(6);
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      System.Console.WriteLine("S - Segundo");
      System.Console.WriteLine("M - Minuto");
      System.Console.WriteLine("0 -  Sair");
      System.Console.WriteLine("Quanto tempo deseja contar?");
    }

    static void Start(int time)
    {
      int currentTime = 0;
      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        System.Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      System.Console.WriteLine("Stopwatch finalizado.. retornando para o menu!");
      Thread.Sleep(2500);
    }
  }
}