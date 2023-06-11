using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class ChildForm1 : SimpleCalculator.CalcUI
    {
        public ChildForm1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSquareRoot);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eReverseValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eNumberSquare);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
