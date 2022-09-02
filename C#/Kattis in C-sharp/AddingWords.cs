using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/addingwords
    class AddingWords
    {
        //public static void Main(string[] args)
        //{
        //    new CommandHandler().Listen();
        //}
    }

    class CommandHandler
    {

        private Dictionary<string, int> ValueStore { get; }

        public CommandHandler()
        {
            ValueStore = new Dictionary<string, int>();
        }

        public void Listen()
        {
            string input;
            while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
            {
                var inputArr = input.Split(' ');
                var args = inputArr.Skip(1).ToArray();
                string command = inputArr[0].ToLower();

                ExecuteCommand(new Command() { Type = command, Args = args });
            }
        }

        private void ExecuteCommand(Command command)
        {
            switch (command.Type)
            {
                case "def":
                    var variableName = command.Args[0];
                    int.TryParse(command.Args[1], out int variableValue);
                    SetVariable(variableName, variableValue);
                    break;
                case "calc":
                    var sol = CalculateEquation(command.Args);
                    Console.WriteLine($"{string.Join(" ", command.Args)} {sol}");
                    break;
                case "clear":
                    ValueStore.Clear();
                    break;
                default:
                    break;
            }
        }

        private void SetVariable(string name, int value)
        {
            if (ValueStore.ContainsKey(name))
            {
                ValueStore.Remove(name);
            }
            ValueStore.Add(name, value);
        }

        private string CalculateEquation(string[] equation)
        {
            if (!ValueStore.TryGetValue(equation[0], out int sum)) return "unknown";
            for (int i = 1; i < equation.Length - 1; i += 2)
            {
                if (!ValueStore.TryGetValue(equation[i + 1], out int variableValue)) return "unknown";
                if (equation[i] == "-")
                {
                    sum -= variableValue;
                }
                else
                {
                    sum += variableValue;
                }
            }
            var solution = ValueStore.FirstOrDefault(s => s.Value == sum).Key;
            return solution ?? "unknown";
        }
    }

    class Command
    {
        public string Type { get; set; }
        public string[] Args { get; set; }
    }
}
