using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS.Calculator
{
    /// <summary>
    /// Implementiert CalcBase,  indem das Protokoll durch eine Collection
    /// im Arbeitsspeicher verwaltet und gespeichert wird.
    /// </summary>
    
    [Serializable]
    public class CalcDerived_Protocol_as_ListCollection: CalcBase
    {
        /// <summary>
        /// List- Collection, die Protokoll speichert
        /// </summary>
        public List<ProtocolEntry> _ProtocolList = new List<ProtocolEntry>();

        /// <summary>
        /// Zugriff auf das Protokoll
        /// </summary>
        public override CalcBase.ProtocolEntry[] Protocol
        {
            get { return _ProtocolList.ToArray(); }
        }

        /// <summary>
        /// Protokolleintrag hinzufügen implementieren
        /// </summary>
        /// <param name="newEntry"></param>
        protected override void AddProtocolEntry(CalcBase.ProtocolEntry newEntry)
        {
            _ProtocolList.Add(newEntry);
        }
    }
}
