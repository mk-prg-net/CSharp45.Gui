using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpSelectionListBindingSource.DataSource = CalcController.OpSelectionList;
        }

        /// <summary>
        /// Operationen über Radiobuttons auswählen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExeRbtSelection_Click(object sender, EventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                if (rbtAdd.Checked)
                {
                    res = CalcController.CalcInstance.ADD(a, b);
                }
                else if (rbtSub.Checked)
                {
                    res = CalcController.CalcInstance.SUB(a, b);
                }
                else if (rbtMul.Checked)
                {
                    res = CalcController.CalcInstance.MUL(a, b);
                }
                else if (rbtDiv.Checked)
                {
                    res = CalcController.CalcInstance.DIV(a, b);
                }


            }

            WriteResult(ErrDescr, res);
        }

        private void WriteResult(string ErrDescr, decimal res)
        {
            ProtocolBindingSource.DataSource = CalcController.CalcInstance.Protocol;
            tbxRes.Text = res.ToString("N4");
            tbxMsg.Focus();
            tbxMsg.Text = ErrDescr;
        }

        private void ReadInput(ref bool inputValid, ref string ErrDescr, out decimal a, out decimal b)
        {
            tbxA.BackColor = SystemColors.Window;
            tbxB.BackColor = SystemColors.Window;

            if (!decimal.TryParse(tbxA.Text, out a))
            {
                inputValid = false;
                tbxA.BackColor = System.Drawing.Color.DeepPink;
                ErrDescr += "Operand A ist ungültig\n";
            }

            if (!decimal.TryParse(tbxB.Text, out b))
            {
                inputValid = false;
                tbxB.BackColor = System.Drawing.Color.DeepPink;
                ErrDescr += "Operand B ist ungültig\n";
            }
        }

        private void btnExeCbxSelection_Click(object sender, EventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                CS.Calculator.CalcBase.Operators Op = (CS.Calculator.CalcBase.Operators)cbxOps.SelectedValue;

                switch (Op)
                {
                    case CS.Calculator.CalcBase.Operators.Add:
                        res = CalcController.CalcInstance.ADD(a, b);
                        break;
                    case CS.Calculator.CalcBase.Operators.Subtract:
                        res = CalcController.CalcInstance.SUB(a, b);
                        break;
                    case CS.Calculator.CalcBase.Operators.Mul:
                        res = CalcController.CalcInstance.MUL(a, b);
                        break;
                    case CS.Calculator.CalcBase.Operators.Div:
                        res = CalcController.CalcInstance.DIV(a, b);
                        break;
                    default: throw new ArgumentException("Unbekannte Operation");
                }
            }

            WriteResult(ErrDescr, res);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                res = CalcController.CalcInstance.ADD(a, b);
            }

            WriteResult(ErrDescr, res);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                res = CalcController.CalcInstance.SUB(a, b);
            }

            WriteResult(ErrDescr, res);

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                res = CalcController.CalcInstance.MUL(a, b);
            }

            WriteResult(ErrDescr, res);

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                res = CalcController.CalcInstance.DIV(a, b);
            }

            WriteResult(ErrDescr, res);

        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine typische winForm- Anwendung");
        }

        private void dlgÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new Dlg1();
            dlg.tbxInput.Text = "Hallo";

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Sie haben eingegeben: " + dlg.tbxInput.Text);
            }
        }
    }
}
