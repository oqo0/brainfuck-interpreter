namespace BrainfuckInterpreter;

public class Interpreter
{
    private int[] _memory;
    private int _pointer;

    private string CommandBuffer { get; }

    public Interpreter(string commandBuffer, int memorySize = 3000, int defaultValue = 0)
    {
        CommandBuffer = commandBuffer;
        _memory = Enumerable.Repeat(defaultValue, memorySize).ToArray();
        _pointer = 0;
    }

    public string GetOutput()
    {
        string output = String.Empty;

        for (int i = 0; i < CommandBuffer.Length; i++)
        {
            char command = CommandBuffer[i];
            
            switch (command)
            {
                case ',':
                {
                    string? input = Console.ReadLine();
                    _memory[_pointer] = Convert.ToInt32(input);
                    break;
                }
                case '.':
                {
                    if (_memory[_pointer] <= 10)
                        output += (char)(_memory[_pointer] + 48);
                    else
                        output += (char)_memory[_pointer];
                    
                    break;
                }
                case '>':
                {
                    _pointer++;
                    break;
                }
                case '<':
                {
                    _pointer--;
                    break;
                }
                case '+':
                {
                    _memory[_pointer]++;
                    break;
                }
                case '-':
                {
                    _memory[_pointer]--;
                    break;
                }
                case '[':
                {
                    if (_memory[_pointer] == 0)
                    {
                        var brackets = 1;

                        while (brackets > 0)
                        {
                            command = CommandBuffer[++i];

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
                        command = CommandBuffer[--i];

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

        return output;
    }
}