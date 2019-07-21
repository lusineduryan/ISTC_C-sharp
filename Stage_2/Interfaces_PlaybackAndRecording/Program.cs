using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PlaybackAndRecording
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player1 = new Player();
            IRecordable player2 = new Player();

            Console.WriteLine("Please select one of the available commands: play, pause, stop or record!");
            string action = Console.ReadLine();
            switch (action)
            {
                case "play": player1.Play(); break;
                case "record": player2.Record(); break;
                case "pause":
                    Console.WriteLine("Please specifiy if you want to play or record!");
                    string details = Console.ReadLine();
                    if (details == "play") player1.Pause();
                    else if (details == "record") player2.Pause();
                    else Console.WriteLine("Please select a valid command!");
                    break;
                case "stop":
                    Console.WriteLine("Please specifiy if you want to play or record!");
                    string detailedcommand = Console.ReadLine();
                    if (detailedcommand == "play") player1.Stop();
                    else if (detailedcommand == "record") player2.Stop();
                    else Console.WriteLine("Please select a valid command!");
                    break;
                default: break;
            }

            Console.ReadKey();

        }
    }
}
