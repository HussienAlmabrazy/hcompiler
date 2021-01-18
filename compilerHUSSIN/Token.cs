﻿using System;
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

        public bool isDataType
        {
            get
            {
                return alphbet.keyWords_DataType.Contains(_text);
            }
        }

        public bool isFunction
        {
            get
            {
                return true;
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
                    !tempSymbols.Contains(_text.First()) &&
                    !alphbet.numbers.Contains(_text.First());
            }
        }
    }
}