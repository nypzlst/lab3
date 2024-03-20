using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        public void CheckNumberInBox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 43 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }
        private float ConvertToFloatWithDefault(string text)
        {
            if (float.TryParse(text, out float result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        public (float,float,float,float) ConvertStrToFloat()
        {
            try
            {
                float X = ConvertToFloatWithDefault(tbHrn1.Text);
                float Y = ConvertToFloatWithDefault(tbHrn2.Text);
                float I = ConvertToFloatWithDefault(tbCop1.Text);
                float O = ConvertToFloatWithDefault(tbCop2.Text);
                return (X, Y, I, O);
            }
            catch(Exception ex) 
            {
                resHrn.Text = ex.Message;
                return (0, 0, 0, 0);
            }
        }

        public (float,float) ConvertStrToFloat2task()
        {
            try
            {
                float x = (float)Convert.ToDouble(tbFull1.Text);
                float y = (float)Convert.ToDouble(tbFull2.Text);
                return (x, y);
            }
            catch(Exception ex)
            {
                resHrn.Text = ex.Message;
                return (0, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbHrn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void tbHrn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void tbCop1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void tbCop2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            Money Sum = new Money();
            (float x, float y, float i, float o) = ConvertStrToFloat();
            Sum.SumHrns1(x, y);
            Sum.SumHrns2(i, o);   
            this.resHrn.Text = Convert.ToString(Sum.Sum(Sum.HrnsFirst,Sum.HrnsSecond));
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Money Sub = new Money();
            (float x, float y, float i, float o) = ConvertStrToFloat();
            Sub.SumHrns1(x, y);
            Sub.SumHrns2(i, o);
            this.resHrn.Text = Convert.ToString(Sub.Sub(Sub.HrnsFirst, Sub.HrnsSecond));
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Money Mul = new Money();
            (float x, float y, float i, float o) = ConvertStrToFloat();
            Mul.SumHrns1(x, y);
            Mul.SumHrns2(i, o);
            this.resHrn.Text = Convert.ToString(Mul.Mul(Mul.HrnsFirst, Mul.HrnsSecond));
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Money Div = new Money();
            (float x, float y, float i, float o) = ConvertStrToFloat();
            Div.SumHrns1(x, y);
            Div.SumHrns2(i, o);
            this.resHrn.Text = Convert.ToString(Div.Div(Div.HrnsFirst, Div.HrnsSecond));
        }

        private void btnSum2_Click(object sender, EventArgs e)
        {
             Fraction Sum = new Fraction();
             (float x, float y) = ConvertStrToFloat2task();
             string I = tbFrac1.Text;
             string O = tbFrac2.Text;
             Sum.SumFirst(x, I);
             Sum.SumSecond(y, O);
             this.lblRes.Text = Convert.ToString(Sum.Sum(Sum.FirstNum, Sum.SecondNum));
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            Fraction Sub = new Fraction();
            (float X, float Y) = ConvertStrToFloat2task();
            string I = tbFrac1.Text;
            string O = tbFrac2.Text;
            Sub.SumFirst(X, I);
            Sub.SumSecond(Y, O);
            this.lblRes.Text = Convert.ToString(Sub.Sub(Sub.FirstNum, Sub.SecondNum));
        }

        private void btnMul2_Click(object sender, EventArgs e)
        {
            Fraction Mul = new Fraction();
            (float X, float Y) = ConvertStrToFloat2task();
            string I = tbFrac1.Text;
            string O = tbFrac2.Text;
            Mul.SumFirst(X, I);
            Mul.SumSecond(Y, O);
            this.lblRes.Text = Convert.ToString(Mul.Mul(Mul.FirstNum, Mul.SecondNum));
        }

        private void btnDiv2_Click(object sender, EventArgs e)
        {
            Fraction Div = new Fraction();
            (float X, float Y) = ConvertStrToFloat2task();
            string I = tbFrac1.Text;
            string O = tbFrac2.Text;
            Div.SumFirst(X, I);
            Div.SumSecond(Y, O);
            this.lblRes.Text = Convert.ToString(Div.Div(Div.FirstNum, Div.SecondNum));
        }

        private void tbFull1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void tbFull2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void tbFrac1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }

        private void tbFrac2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNumberInBox(sender, e);
        }
    }
}
