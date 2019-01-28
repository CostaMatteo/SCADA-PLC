using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_impianto___Telecamera_WPF
{
    class clsVar
    {
        private string name;
        private string index;
        private varType type;
        private string desc;
        private object defaultValue;
        private object value;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Index
        {
            get
            {
                return index;
            }
        }
        public varType Type
        {
            get
            {
                return type;
            }
        }
        public string Desc
        {
            get
            {
                return desc;
            }
        }
        public object Value
        {
            get
            {
                value = PLController.Read(Index);
                return value;
            }
            set
            {
                this.value = value;
                PLController.Write(Index, value);
            }
        }

        public clsVar(string name, string index, varType type, object defaultValue, string desc="")
        {
            this.name = name;
            this.index = index;
            this.type = type;
            this.desc = desc;

            this.defaultValue = defaultValue;
            this.value = defaultValue;
        }

        public enum varType
        {
            BOOL,
            BYTE,
            WORD,
            INT,
            DWORD,
            Timer,
            Counter
        }
    }
}
