using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Calculator
{
    class CalcController
    {
        public class OpSelection
        {
            public CS.Calculator.CalcBase.Operators Op { get; set; }
            public string OpTxt { get; set; }
        }

        public static OpSelection[] OpSelectionList 
        {
            get
            {
                return new OpSelection[] {
                    new OpSelection() { Op = CS.Calculator.CalcBase.Operators.Add, OpTxt="+: ADD"},
                    new OpSelection() { Op= CS.Calculator.CalcBase.Operators.Subtract, OpTxt="-: Subtract"},
                    new OpSelection() { Op= CS.Calculator.CalcBase.Operators.Mul, OpTxt="*: Mul"},
                    new OpSelection() { Op= CS.Calculator.CalcBase.Operators.Div, OpTxt="/: Div"}
                };
            }
        }

        public static CS.Calculator.CalcBase CalcInstance = new CS.Calculator.CalcDerived_Protocol_as_ListCollection();
    }
}
