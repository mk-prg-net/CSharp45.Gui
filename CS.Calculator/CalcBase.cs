//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 1.6.2014
//
//  Projekt.......: CS.Calculator
//  Name..........: CalcBase
//  Aufgabe/Fkt...: Basisklasse für Instanzen von Taschenrechnern
//                  
//
//
//
//
//<unit_environment>
//------------------------------------------------------------------
//  Zielmaschine..: PC 
//  Betriebssystem: Windows 7 mit .NET 4.5
//  Werkzeuge.....: Visual Studio 2012
//  Autor.........: Martin Korneffel (mko)
//  Version 1.0...: 
//
// </unit_environment>
//
//<unit_history>
//------------------------------------------------------------------
//
//  Version.......: 1.1
//  Autor.........: Martin Korneffel (mko)
//  Datum.........: 
//  Änderungen....: 
//
//</unit_history>
//</unit_header>        
        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CS.Calculator
{
    /// <summary>
    /// Abstrakte Klasse, die Grundfunktionalität eines Taschenrechners mit 
    /// Protokollfunktion definiert und teilweise implementiert
    /// </summary>
    
    [Serializable]
    public abstract class CalcBase
    {
        /// <summary>
        /// 
        /// </summary>
        public enum Operators
        {
            Add,
            Subtract,
            Mul,
            Div,
            Pow,
        }

        public class ProtocolEntry
        {
            /// <summary>
            /// Defaultkonstruktor
            /// </summary>
            public ProtocolEntry() { }

            public ProtocolEntry(Operators Op, decimal OpA, decimal OpB, decimal Res)
            {
                LogDate = DateTime.Now;
                this.Op = Op;
                this.OpA = OpA;
                this.OpB = OpB;
                this.Res = Res;
            }

            public DateTime LogDate { get; set; }

            public Operators Op { get; set; }
            
            public decimal OpA { get; set; }
            public decimal OpB { get; set; }
            public decimal Res { get; set; }
        }

        /// <summary>
        /// Zugriff auf das Protokoll
        /// </summary>
        public abstract ProtocolEntry[] Protocol {get;}


        /// <summary>
        /// Hinzugügen eines neuen Eintrages zum Protokoll
        /// </summary>
        /// <param name="newEntry"></param>
        protected abstract void AddProtocolEntry(ProtocolEntry newEntry);

        /// <summary>
        /// Ausführen einer binären Operation des Taschenrechners. 
        /// </summary>
        /// <param name="op">ID der Operation</param>
        /// <param name="OpA">Operand A</param>
        /// <param name="OpB">Operand B</param>
        /// <returns></returns>
        public decimal EXE(Operators op, decimal OpA, decimal OpB)
        {
            switch (op)
            {
                case Operators.Add:
                    return ADD(OpA, OpB);
                case Operators.Subtract:
                    return SUB(OpA, OpB);
                case Operators.Mul:
                    return MUL(OpA, OpB);
                case Operators.Div:
                    return DIV(OpA, OpB);
                default:
                    throw new ArgumentException("Unbekannter Operator", "op");
            }
        }

        /// <summary>
        /// Ausführen einer Liste von Operationen
        /// </summary>
        /// <param name="taskList"></param>
        /// <returns></returns>
        public ProtocolEntry[] EXEList(IEnumerable<ProtocolEntry> taskList)
        {
            var results = new List<ProtocolEntry>(taskList.Count());
            foreach (var task in taskList)
            {
                var res = new ProtocolEntry(task.Op,
                                            task.OpA,
                                            task.OpB,
                                            EXE(task.Op, task.OpA, task.OpB));

                results.Add(res);
            }

            return results.ToArray();
        }

        /// <summary>
        /// Implementierung der Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal ADD(decimal a, decimal b)
        {
            var res = a + b;

            
            AddProtocolEntry(
                // Defaultkonstruktor + Objektinitialisierer
                new ProtocolEntry()
                {
                    LogDate = DateTime.Now,
                    Op = Operators.Add,
                    OpA = a,
                    OpB = b,
                    Res = res
                });

            return res;
        }

        /// <summary>
        /// Implementierung der Subtraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal SUB(decimal a, decimal b)
        {
            var res = a - b;
            
            AddProtocolEntry(

                // Konstruktor 2 mit benannten Parametern aufrufen
                new ProtocolEntry(
                    Op: Operators.Subtract,
                    OpA: a,
                    OpB: b,
                    Res: res
                ));

            return res;
        }

        /// <summary>
        /// Implementierung der Multiplikation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal MUL(decimal a, decimal b)
        {
            var res = a * b;

            AddProtocolEntry(

                // Konstruktor 2, gewöhnlicher Funktionsaufruf
                new ProtocolEntry(Operators.Mul, a, b, res));

            return res;
        }

        /// <summary>
        /// Implementierung der Division
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal DIV(decimal a, decimal b)
        {
            var res = a / b;

            AddProtocolEntry(

                // Konstruktor 2, gewöhnlicher Funktionsaufruf
                new ProtocolEntry(Operators.Div, a, b, res));

            return res;
        }

        public decimal POW(decimal Basis, decimal Exponent)
        {
            var res = Math.Pow((double)Basis, (double)Exponent);

            AddProtocolEntry(

            // Konstruktor 2, gewöhnlicher Funktionsaufruf
            new ProtocolEntry(Operators.Div, (decimal)Basis, (decimal)Exponent, (decimal)res));

            return (decimal)res;

        }





    }
}
