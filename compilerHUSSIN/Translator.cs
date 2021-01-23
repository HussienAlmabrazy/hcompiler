using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace compilerHUSSIN
{
    class Translator
    {
        Token _token;

        public Translator(Token thisToken)
        {
            _token = thisToken;
        }
        /// <summary>
        /// switch and if
        /// </summary>
        public bool start_s0
        {
            get
            {
                return _token.isStructureName;
            }
        }

        public bool start_s1
        {
            get
            {
                return _token.isFunction;
            }
        }
        public bool s1_S5
        {
            get
            {
                var tempOp = new string[] { "(", ")" };
                return tempOp.Contains(_token._text);
            }
        }
        public bool s5_s40
        {
            get
            {
                var tempOp = new string[] { "{", "}" };
                return tempOp.Contains(_token._text);
            }
        }
        //public bool s5_s3
        //{
        //    get
        //    {

        //    }
        //}
        /// <summary>
        ///  (W.H) ggggggggg 
        /// ///////  end H.w الواجب
        /// </summary>
        public bool s0_s3
        {
            get
            {
                return _token.isVar;
            }

        }

        public bool s3_s40
        {
            get
            {
                var tempOp = new string[] { "{","}" };
                return tempOp.Contains(_token._text);
            }
        }
        public bool s40_s2
        {
            get
            {
                return _token.isDataType;
            }
        }
        public bool f_s2
        {
            get
            {
                return _token.isDataType;
            }
        }
        public bool f_s40
        {
            get
            {
                return _token._text == "}";
            }
        }
        public bool s40_f
        {
            get
            {
                return _token._text == ";";
            }
        }
        /// <summary>
        /// ///////  end H.w الواجب 
        /// </summary>
        public bool start_s2
        {
            get
            {
                return _token.isDataType;
            }
        }

        public bool start_s3_or_s2_s3
        {
            get
            {
                return _token.isVar;
            }
        }
        //public bool s2_s3
        //{
        //    get
        //    {
        //        return _token.isVar;
        //    }
        //}

        public bool s3_s2
        {
            get
            {
                return _token._text == (',').ToString();
            }
        }

        public bool s3_s30
        {
            get
            {
                var tempOperators = new string[] { "+", "*", "/", "%", "-" };
                return tempOperators.Contains(_token._text);
            }
        }
        public bool s3_s31_or_s30_s31
        {
            get
            {
                return _token._text == "=";
            }
        }
        public bool s3_f
        {
            get
            {
                return _token._text == ";";
            }

        }

        //public bool s30_s31
        //{
        //    get {
        //        return _token._text == "=";

        //    }
        //}
        //public bool s31_s301
        //{
        //    get
        //    {
        //        return _token.isVar || _token.isNumber;
        //    }
        //}

        public bool s30_s301_or_s31_s301
        {
            get
            {
                return _token.isNumber || _token.isVar;
            }
        }
        public bool s301_s31
        {
            get
            {
                return _token.operators;
            }
        }
        //public bool s301_s30
        //{
        //    get { return _token.isOperator; }
        //}
        public bool s301_s2
        {
            get
            {
                return _token._text == ",";
            }
        }

        public bool s301_f
        {
            get
            {
                return _token._text == ";";
            }
        }
        /// <summary>
        /// switch case:
        /// </summary>
        //public bool s301_f
        //{
        //    get
        //    {
        //        return _token._text == ";";
        //    }
        //}
    }

}