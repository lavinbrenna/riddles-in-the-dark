using System;
using System.Collections.Generic;

namespace cave.gollum 
{
    public class Gollum
  {
    public static List<string> Questions = new List<string> {"A box without hinges, key or lid, yet golden treasure inside is hid", "What has roots as nobody sees, is taller than trees, up, up, up it goes and yet, never grows", "Thirty white horses on a red hill, first they champ, they they stamp, they the stand still", "Voiceless it cries, wingless flutters, toothless bites, mouthless mutters", "An eye in a blue face saw an eye in a green face. 'That eye is like to this eye' said the first eye, 'But in low place not in high place'", "It cannot be seen, cannot be felt, cannot be heard, cannot be smelt. It lies behind stars and under hills, and and empty holes it fills. It comes first and follows after, ends life, kills laughter", "Alive without breath, as cold as death; never thirsty, ever drinking, all in mail never clinking", "This thing all things devours: birds, beasts, trees, flowers; gnaws irons, bites steel; grinds hard stones to meal; slays king, ruins town, and beats high mountain down."};
    public static List<string> Answers = new List<string> {"egg","mountain","teeth", "wind","sun shining on daisies", "darkness", "fish", "time"};

    public static int GetRandomNumber()
    {
      Random num = new Random();
      int randomNumber = num.Next(0, Questions.Count);
      return randomNumber;
    }
    public static string GetRiddle(int number)
    {
      return Questions[number];
    }
    public static string GetAnswer(int number)
    {
      return Answers[number];
    }
    public static void RemoveRiddle(int number)
    {
      Questions.Remove(Questions[number]);
      Answers.Remove(Answers[number]);
    }
  }
}


