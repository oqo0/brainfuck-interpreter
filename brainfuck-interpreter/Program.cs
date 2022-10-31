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
                        char output;

                        if (memory[pointer] <= 10)
                            output = (char)(memory[pointer] + 48);
                        else
                            output = (char)memory[pointer];
                        
                        Console.Write(output);
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
                            var brackets = 1;

                            while (brackets > 0)
                            {
                                command = commandBuffer[++i];

                                if (command == '[')
                                    brackets++;
                                else if (command == ']')
                                    brackets--;
                            }
                        }
                        break;
                    }
                    case ']':
                    {
                        var brackets = 1;

                        while (brackets > 0)
                        {
                            command = commandBuffer[--i];

                            if (command == '[')
                                brackets--;
                            else if (command == ']')
                                brackets++;
                        }
                        i--;
                        break;
                    }
                }
            }
            
        }
    }
}