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

            for (int i = 0; i < commandBuffer.Length; i++)
            {
                char command = commandBuffer[i];
                
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
                        Console.Write((char)memory[pointer]);
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
                        if (memory[pointer] == 0)
                        {
                            int brackets = 1;

                            while (brackets > 0)
                            {
                                i++;

                                if (commandBuffer[i] == '[')
                                    brackets++;
                                else if (commandBuffer[i] == ']')
                                    brackets--;
                            }
                        }
                        break;
                    }
                    case ']':
                    {
                        int brackets = 1;

                        while (brackets > 0)
                        {
                            i--;

                            if (commandBuffer[i] == '[')
                                brackets--;
                            else if (commandBuffer[i] == ']')
                                brackets++;
                        }
                        i--;
                        break;
                    }
                    default:
                        throw new InvalidOperationException();
                }
            }
            
        }
    }
}