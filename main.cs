//Nicolas Espel
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Welcome to Twitter Beta Version! Make sure your post doesn't exceed 140 characters: ");
    string userPost = Console.ReadLine();

    if (userPost.Length <= 140) {
      Console.WriteLine("Posted");
    } else {
      Console.WriteLine("Rejected");
    }
  }
}