using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Calculator.Test
{
    [TestClass]
    public class Tests
    {
        [TestInitialize]
        public void InitTest()
        {
            Calc = new CS.Calculator.CalcDerived_Protocol_as_ListCollection();
        }

        CS.Calculator.CalcBase Calc;

        [TestMethod]
        public void CS_Calculator_Ops_Test()
        {
            Assert.AreEqual(2M + 3M, Calc.ADD(2M, 3M));
            Assert.AreEqual(2.7M + 3.3M, Calc.ADD(2.7M, 3.3M));

            Assert.AreEqual(2M - 3M, Calc.SUB(2M, 3M));
            Assert.AreEqual(2.7M - 3.3M, Calc.SUB(2.7M, 3.3M));

            Assert.AreEqual(2M * 3M, Calc.MUL(2, 3));
            Assert.AreEqual(2.7M * 3.3M, Calc.MUL(2.7M, 3.3M));

            Assert.AreEqual(2M/3M, Calc.DIV(2, 3));
            Assert.AreEqual(2.7M/3.3M, Calc.DIV(2.7M, 3.3M));

        }

        [TestMethod]
        public void CS_Calculator_EXE_Test()
        {
            Assert.AreEqual(2M + 3M, Calc.EXE(CalcBase.Operators.Add, 2M, 3M));
            Assert.AreEqual(2.7M + 3.3M, Calc.EXE(CalcBase.Operators.Add, 2.7M, 3.3M));

            Assert.AreEqual(2M - 3M, Calc.EXE(CalcBase.Operators.Subtract, 2M, 3M));
            Assert.AreEqual(2.7M - 3.3M, Calc.EXE(CalcBase.Operators.Subtract, 2.7M, 3.3M));

            Assert.AreEqual(2M * 3M, Calc.EXE(CalcBase.Operators.Mul, 2M, 3M));
            Assert.AreEqual(2.7M * 3.3M, Calc.EXE(CalcBase.Operators.Mul, 2.7M, 3.3M));

            Assert.AreEqual(2M / 3M, Calc.EXE(CalcBase.Operators.Div, 2M, 3M));
            Assert.AreEqual(2.7M / 3.3M, Calc.EXE(CalcBase.Operators.Div, 2.7M, 3.3M));

            int Offset = Calc.Protocol.Length;

            var res = Calc.EXEList(Calc.Protocol);

            Assert.AreEqual(res.Length + Offset, Calc.Protocol.Length);

            for (int i = 0; i < Calc.Protocol.Length - Offset; i++)
            {
                Assert.AreEqual(res[i].Op, Calc.Protocol[i + Offset].Op);
                Assert.AreEqual(res[i].OpA, Calc.Protocol[i + Offset].OpA);
                Assert.AreEqual(res[i].OpB, Calc.Protocol[i + Offset].OpB);
                Assert.AreEqual(res[i].Res, Calc.Protocol[i + Offset].Res);
            }

        }

    }
}
