﻿using System;
using System.Linq;

namespace BrainfuckInterpreter
{
    class BrainfuckInterpreter
    {
        static void Main()
        {
            Interpreter interpreter = new Interpreter(">+++++++++++++++[<+>>>>>>>>++++++++++<<<<<<<-]>+++++[<+++++++++>-]+>>>>>>+[<<+++[>>[-<]<[>]<-]>> [>+>]<[<]>]>[[->>>>+<<<<]>>>+++>-]<[<<<<]<<<<<<<<+[->>>>>>>>>>>>[<+[->>>>+<<<<]> >>>>]<<<<[>>>>>[<<<<+>>>>-]<<<<<-[<<++++++++++>>-]>>>[<<[<+<<+>>>-]<[>+<-]<++<<+ >>>>>>-]<<[-]<<-<[->>+<-[>>>]>[[<+>-]>+>>]<<<<<]>[-]>+<<<-[>>+<<-]<]<<<<+>>>>>>> >[-]>[<<<+>>>-]<<++++++++++<[->>+<-[>>>]>[[<+>-]>+>>]<<<<<]>[-]>+>[<<+<+>>>-]<<< <+<+>>[-[-[-[-[-[-[-[-[-<->[-<+<->>]]]]]]]]]]<[+++++[<<<++++++++<++++++++>>>>-]< <<<+<->>>>[>+<<<+++++++++<->>>-]<<<<<[>>+<<-]+<[->-<]>[>>.<<<<[+.[-]]>>-]>[>>.<< -]>[-]>[-]>>>[>>[<<<<<<<<+>>>>>>>>-]<<-]]>>[-]<<<[-]<<<<<<<<]++++++++++.");
            string res = interpreter.GetOutput();
            Console.WriteLine(res);
        }
    }
}