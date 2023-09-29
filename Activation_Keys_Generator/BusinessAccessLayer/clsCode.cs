using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsCode
    {

        public enum Type { Itunes = 1 , GooglePlay = 2 , Steam = 3 , WindowsActivation = 4 , All = 99  };

        public int codeID { set; get; } 
        public int codeTypeID { set; get; }
        public string codeType { set; get; }
        public string code { set; get; }
        bool isValid { set; get; }


        public clsCode()
        {
            this.codeID = -1;
            this.codeTypeID = -1;
            this.codeType = "";
            this.code = "";
            this.isValid = false;
        }


        private clsCode(int codeID , int codeTypeID , string codeType , string code , bool isValid)
        {
            this.codeID = codeID;
            this.codeTypeID = codeTypeID;
            this.codeType = codeType;
            this.code = code;
            this.isValid = isValid;
        }


        static public DataTable getCodes(Type type)
        {
            return clsCodesDataAccess.getCodes(((int)type));
        }

        

    }
}
