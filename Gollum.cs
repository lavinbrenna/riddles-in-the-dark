using System;
using cave.gollum;

namespace cave
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Answer Gollum's riddles correctly or Gollum will bash you over the head and eat you like a tasty snack");
      while(Gollum.Questions.Count > 0){
        int randomNumber = Gollum.GetRandomNumber();
        string riddle = Gollum.GetRiddle(randomNumber);
        string answer = Gollum.GetAnswer(randomNumber);
        Console.WriteLine(riddle);
        Console.WriteLine("What is the answer?");
        string userAnswer = Console.ReadLine();
        if(userAnswer.ToLower().Contains(answer)){
          Console.WriteLine("You answered the riddle correctly!");
          Gollum.RemoveRiddle(randomNumber);
        }
        else{
        Console.WriteLine("You have been bashed over the head and eaten by Gollum.");
        break;
        }
      }
    }
  }
}
