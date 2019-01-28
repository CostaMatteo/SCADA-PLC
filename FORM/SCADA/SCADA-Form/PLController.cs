using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using S7.Net;
using Newtonsoft.Json;

namespace Gestione_impianto___Telecamera_WPF
{
    static class PLController
    {
        static Plc plc;
        /*
         * Premettendo che potrebbe risultare al quanto scomodo
         * Se per le variabili, anziche aggiungrle con TabVar.add(..)
         * le leggessimo da un file?
         * Così che non avremo una riga per ogni variabile del plc.
         * 
         * Tanto non posso instanziare variabili durante l'esecuzione del programma
         */
        static public IDictionary<string, clsVar>TabVar = new Dictionary<string, clsVar>();

        static public void Init(string variablePath, string ip = "192.168.2.104", CpuType cpu = CpuType.S71500)
        {
            plc = new Plc( cpu, ip, 0, 1);
            //-- Da nuova versione di S7.Net plc.Open() è VOID
            var result = plc.Open();

            if (result != ErrorCode.NoError)
                throw new Exception("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);

            //ReadVariable(variablePath);
        }
        static public result Close()
        {
            if (plc.IsConnected)
            {
                try
                {
                    plc.Close();
                    TabVar.Clear();
                }
                catch(Exception ex)
                {
                    ex = ex;
                    return result.InstructionError;
                }
                return result.Success;
            }
            else
                return result.ConnectionError;
        }

        static private void ReadVariable(string variablePath)
        {
            
            using (System.IO.StreamReader r = new System.IO.StreamReader(variablePath))
            {
                string json = r.ReadToEnd();
                foreach (clsVar v in JsonConvert.DeserializeObject<List<clsVar>>(json))
                    PLController.TabVar.Add(v.Name, v);
            }
        }
            
        static public result Write(string index, object value)
        {
            if (plc.IsConnected)
            {
                try
                {
                    bool boh = plc.IsAvailable;
                    plc.Write(index, value);
                    return result.Success;
                }
                catch(Exception ex)
                {
                    ex = ex;
                    return result.InstructionError;
                }
                
            }
            else
                return result.ConnectionError;
        }
        static public object Read(string index)
        {
            if (plc.IsConnected)
            {
                try
                {
                    return plc.Read(index);
                }
                catch
                {
                    return result.InstructionError;
                }
            }
            else
                return result.ConnectionError;
        }

        public enum result
        {
            Success,
            InstructionError,
            ConnectionError
        }
        public struct DB2
        {
            public bool nstMain;
        }
    }
}
