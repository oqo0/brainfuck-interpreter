namespace BrainfuckInterpreter
{
    class BrainfuckInterpreter
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
                
            try
            {
                string code = File.ReadAllText(args[0]);

                var interpreter = new Interpreter(code);
                Console.WriteLine(interpreter.GetOutput());
            }
            catch
            {
                Console.WriteLine("Invalid file name \\ path.");
            }
            finally
            {
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            }
        }
    }
}