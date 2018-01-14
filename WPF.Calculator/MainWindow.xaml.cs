using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExeRadioButtonSelection_Click(object sender, RoutedEventArgs e)
        {
            bool inputValid = true;
            string ErrDescr = "";
            decimal a, b, res = 0;

            ReadInput(ref inputValid, ref ErrDescr, out a, out b);

            if (inputValid)
            {
                if (rbtAdd.IsChecked.GetValueOrDefault(false))
                {
                    res = CalcController.CalcInstance.ADD(a, b);
                }
                else if (rbtSub.IsChecked.GetValueOrDefault(false))
                {
                    res = CalcController.CalcInstance.SUB(a, b);
                }
                else if (rbtMul.IsChecked.GetValueOrDefault(false))
                {
                    res = CalcController.CalcInstance.MUL(a, b);
                }
                else if (rbtDiv.IsChecked.GetValueOrDefault(false))
                {
                    res = CalcController.CalcInstance.DIV(a, b);
                }


            }

            WriteResult(ErrDescr, res);

        }

        private void ReadInput(ref bool inputValid, ref string ErrDescr, out decimal a, out decimal b)
        {
            tbxA.Background = SystemColors.WindowBrush;
            tbxB.Background = SystemColors.WindowBrush;

            if (!decimal.TryParse(tbxA.Text, out a))
            {
                inputValid = false;
                tbxA.Background = new SolidColorBrush(System.Windows.Media.Colors.DeepPink);
                ErrDescr += "Operand A ist ungültig\n";
            }

            if (!decimal.TryParse(tbxB.Text, out b))
            {
                inputValid = false;
                tbxB.Background = new SolidColorBrush(System.Windows.Media.Colors.DeepPink);
                ErrDescr += "Operand B ist ungültig\n";
            }
        }

        private void WriteResult(string ErrDescr, decimal res)
        {
            LbxProtokoll.ItemsSource = CalcController.CalcInstance.Protocol;
            tbxRes.Text = res.ToString("N4");
            tblockMsg.Focus();
            tblockMsg.Text = ErrDescr;
        }


    }
}
