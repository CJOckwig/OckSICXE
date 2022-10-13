using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OckSICXE
{
    internal class Opcodes
    {
        string Mnemonic { get; set; }
        string Format { get; set; }
        byte[] Opcode { get; set; }

        Opcodes(string inputLine)
        {
            if(string.IsNullOrEmpty(inputLine))
            {
                throw new ArgumentNullException("Input for opcode from opcodes file caused an error. " + inputLine);
            }
            inputLine = inputLine.Trim();
            string[] strings = inputLine.Split(' ');
            Mnemonic = strings[0];
            Format = strings[2];
            char[] ops= strings[1].ToCharArray();
            Opcode[0] = Byte.Parse("" + ops[0]);
            Opcode[1] = Byte.Parse("" + ops[1]);
        }
    }
}
