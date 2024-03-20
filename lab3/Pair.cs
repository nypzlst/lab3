﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    abstract class Pair
    {
        public virtual float Sum(float x = 0, float y = 0)
        {
            return (x + y);
        }

        public virtual float Mul(float x = 0, float y = 0)
        {
            return (x * y);
        }

        public virtual float Sub(float x = 0 , float y = 0)
        {
            return (x - y);
        }

        public virtual float Div(float x = 0, float y = 0)
        {
            return (x / y);
        }
    }

    class Money : Pair
    {
        public float HrnsFirst;

        public float HrnsSecond;

        public void SumHrns1(float x = 0 , float y = 0)
        {
            HrnsFirst = (x + (y/100));
        }
        public void SumHrns2(float x =0 , float y = 0)
        {
            HrnsSecond = (x + (y/100));
        }
    }
    class Fraction : Pair
    {
        public float FirstNum;

        public float SecondNum;

        public void SumFirst(float x, string y)
        {
            string[] nums = y.Split('/');
            string up = nums[0];
            string down = nums[1];
            float z = (float)Convert.ToDouble(up) / (float)Convert.ToDouble(down);
            FirstNum = x + z;
        }
        public void SumSecond(float x, string y)
        {
            string[] nums = y.Split('/');
            string up = nums[0];
            string down = nums[1];
            float z = (float)Convert.ToDouble(up) / (float)Convert.ToDouble(down);
            SecondNum = x + z;
        }
    }
}
    