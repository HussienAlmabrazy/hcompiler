using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilerHUSSIN
{
    public class alphbet
    {
        static public string[] keyWords_DataType = new string[] { "int", "float", "string", "char", "short", "double", "long", "var", "bool" };
        static public string[] keyWords_StructureName = new string[] { "class", "struct", "list", "namespace", "enum", "interface" };
        
        static public string[] Condition = new string[] { "switch", "if",};

        static public string[] FunReservedWord = new string[] { "case ","break","default",};
        static public char[] symbolsAndOperators = new char[] {'*','/','+','-','=', '&','|',';',',','>','<','!','(',')','[',']',
        '{','}',':','\"','\'','.',
        };

        static public char[] operators = new char[]
        {'*','/','+','-','=', '&','|','>','<','!',};

        static public char[] symbols = new char[] { ';', ',', '(', ')', '[', ']', '{', '}', ':', '\"', '\'', '.', };

        static public char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
    }
}
