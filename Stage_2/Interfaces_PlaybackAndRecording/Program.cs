using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PlaybackAndRecording
{
    class Program
    {
        public static void RecordFunc(IPlayable player1, IRecordable player2)
        {
            player2.Record();
            Console.WriteLine("Please select the next command: pause or stop!");
            string action = Console.ReadLine();
            switch (action)
            {
                case "pause": player2.Pause();
                    Console.WriteLine("Please select your next step: stop or record again!");
                    string actionNext = Console.ReadLine();
                    switch (actionNext)
                    {
                        case "stop": player2.Stop(); break;
                        case "record": RecordFunc(player1, player2); break;
                        default: Console.WriteLine("Please select a valid command!"); break;
                    }
                    break;
                case "stop": player2.Stop(); break;
                default: Console.WriteLine("Please select a valid command!"); break;
            }
        }
        public static void PlayFunc(IPlayable player1, IRecordable player2)
        {
            player1.Play();
            Console.WriteLine("Please select the next command: record, pause or stop!");
            string action = Console.ReadLine();
            switch (action)
            {
                case "record": player2.Record(); RecordFunc(player1, player2); break;
                case "pause": player1.Pause();
                    Console.WriteLine("Please select your next step: stop or play again!");
                    string actionNext = Console.ReadLine();
                    switch (actionNext)
                    {
                        case "stop": player1.Stop(); break;
                        case "play": PlayFunc(player1, player2); break;
                        default: Console.WriteLine("Please select a valid command!"); break;
                    }
                    break;
                case "stop": player1.Stop(); break;
                default: Console.WriteLine("Please select a valid command!"); break;
            }
        }

        static void Main(string[] args)
        {

            IPlayable player1 = new Player();
            IRecordable player2 = new Player();

            Console.WriteLine("Please select play to start!");
            string select = Console.ReadLine();
            while (select != "play")
            {
                Console.WriteLine("Please select play to start!");
                select = Console.ReadLine();
            }

            PlayFunc(player1, player2);

            Console.ReadKey();
        }
    }
}
