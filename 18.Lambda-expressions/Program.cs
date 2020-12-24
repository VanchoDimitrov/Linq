using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lambda_expressions
{
    class Program
    {
        delegate void SaveAnonymous(string name);
        delegate void SaveLambda(string name);

        delegate bool CheckIt(double you, double yourFriend);
        delegate bool CheckItLambda(double you, double yourFriend);
        static void Main(string[] args)
        {
            SaveAnonymous saveAnonymus = delegate (string name)
              {
                  Console.WriteLine($"Hi {name} from the Anonymous method");
              };

            saveAnonymus("John");

            SaveLambda saveLambda = yourName => Console.WriteLine($"Hi {yourName} from the Anonymous method");

            saveLambda("John");

            ///////////////////////////////////

            CheckIt checkIt = delegate (double you, double yourFriend)
              {
                  if (you > yourFriend)
                      return true;
                  return false;

              };

            Console.WriteLine($"You are toller {checkIt(3, 2)}");

            CheckItLambda checkItLambda = (you, yourFriend) => you > yourFriend;

            Console.WriteLine($"You are toller {checkItLambda(1.5, 2)}");
        }

    }
}

