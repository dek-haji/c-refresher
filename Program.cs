using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            MooseSays("I really am enthusiastico");
            DietQuestions();
            ExerciseQuestions();
        }
       

        static void MooseSays(string messages)
        {
            Console.WriteLine($@"
                                    _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |   {messages}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
");
        }
        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void DietQuestions()
        {
            bool isTrue = MooseAsks("You like chocolate?");
            if (isTrue)
            {
                MooseSays("Really who don't!!");
            }
            else
            {
                MooseSays("On diet baby");
            }
        }
        static void ExerciseQuestions()
        {
            bool isTrue = MooseAsks("So you workout?");
            if (isTrue)
            {
                MooseSays("Yeah 3 days a week!!");
            }
            else
            {
                MooseSays("am on my quarantine lazy schedule!!");
            }
        }

    }
   
}
