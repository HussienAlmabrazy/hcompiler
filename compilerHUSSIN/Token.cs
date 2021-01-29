using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilerHUSSIN
{
    class Token
    {
        public string _text;

        public Token(string tokenText)
        {
            _text = tokenText;
        }

        public bool isStructureName
        {
            get
            {
                return alphbet.keyWords_StructureName.Contains(_text);
            }
        }
        public bool isfunction
        {
            get
            {
                return alphbet.function.Contains(_text);
            }
        }
        public bool isclass
        {
            get
            {
                return alphbet.Class.Contains(_text);
            }
        }

        public bool isReservedW
        {
            get
            {
                return alphbet.FunReservedWord.Contains(_text);
            }
        }
        public bool isCondition
        {
            get
            {
                return alphbet.Condition.Contains(_text);
            }
        }
        public bool isDataType
        {
            get
            {
                return alphbet.keyWords_DataType.Contains(_text);
            }
        }

       
        public bool operators
        {
            get
            {
                return _text.All((ss) => alphbet.operators.Contains(_text.First()));
            }
        }

        public bool isSymobl
        {
            get
            {
                return alphbet.symbols.Contains(_text.First());
            }
        }
        public bool isNumber
        {
            get
            {
                return _text.All((latter) => alphbet.numbers.Contains(latter));
            }
        }

        public bool isVar
        {
            get
            {
                var tempSymbols = new char[] { '$', '#', '@', };
                return
                    !isStructureName &&
                    !isDataType &&
                    !operators &&
                    !isSymobl &&
                    !isCondition &&
                    !isReservedW &&
                    !tempSymbols.Contains(_text.First()) &&
                    !alphbet.numbers.Contains(_text.First());
            }
        }
    }
}
//int e = 2;
//switch(e){case 2: int w = 3;
//break;
//defaultt : int q = 3;}
