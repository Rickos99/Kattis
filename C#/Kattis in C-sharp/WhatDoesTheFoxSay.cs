using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/whatdoesthefoxsay
    class WhatDoesTheFoxSay
    {

        private readonly int nTestCasesLeft;

        public WhatDoesTheFoxSay()
        {
            nTestCasesLeft = int.Parse(Console.ReadLine());

            for (; nTestCasesLeft > 0; nTestCasesLeft--)
            {
                string line = Console.ReadLine();
                List<string> audioRecording = line.Split(new char[] { ' ' }).ToList();
                List<string> knwonSounds = new List<string>();
                string soundOfFox = string.Empty;

                while ((line = Console.ReadLine()) != "what does the fox say?")
                {
                    knwonSounds.Add(line.Split(new char[] { ' ' })[2]);
                }

                foreach (var sound in audioRecording)
                {
                    if (!knwonSounds.Contains(sound))
                    {
                        soundOfFox += sound + ' ';
                    }
                }
                Console.WriteLine(soundOfFox.Substring(0, soundOfFox.Length - 1));
            }
        }
    }
}
