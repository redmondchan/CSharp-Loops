using System;

class MainClass {
  public static void Main (string[] args) {

    //for loop with other arthimetic operators
    for (int x = 10; x >= 0 ; x-=2) {
      Console.WriteLine($"I have {x} days left to study.");
      if (x == 0) {
        Console.WriteLine("My test is today, I'm going to fail.");
      };
    }
    
    // basic for loop
    // for (int x = 1; x < 6; x++) {
    //   Console.WriteLine($"Loop {x}");
    // }
  }
}