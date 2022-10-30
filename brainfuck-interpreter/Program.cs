using System;
using System.Linq;

namespace BrainfuckInterpreter
{
    class BrainfuckInterpreter
    {
        static void Main()
        {
            string commandBuffer = Console.ReadLine();
            
            int[] memory = Enumerable.Repeat(0, 30000).ToArray();
            int pointer = 0;

            foreach (var command in commandBuffer)
            {
                switch (command)
                {
                    case ',':
                    {
                        string input = Console.ReadLine();
                        memory[pointer] = Convert.ToInt32(pointer);
                        break;
                    }
                    case '.':
                    {
                        Console.WriteLine((char)memory[pointer]);
                        break;
                    }
                    case '>':
                    {
                        if (pointer == memory.Length - 1)
                        {
                            pointer = 0;
                            break;
                        }
                        
                        pointer++;
                        break;
                    }
                    case '<':
                    {
                        if (pointer == 0)
                        {
                            pointer = memory.Length - 1;
                            break;
                        }
                        
                        pointer--;
                        break;
                    }
                    case '+':
                    {
                        memory[pointer]++;
                        break;
                    }
                    case '-':
                    {
                        memory[pointer]--;
                        break;
                    }
                    case '[':
                    {
                        break;
                    }
                    case ']':
                    {
                        break;
                    }
                    default:
                        throw new InvalidOperationException();
                }
            }

        }
    }
}