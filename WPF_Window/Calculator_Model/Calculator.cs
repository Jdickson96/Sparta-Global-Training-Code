﻿using System;

namespace Calculator_Model
{
    public class Calculator
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public double Add()
        {
            return Num1 + Num2;
        }

        public double Subtract()
        {
            return Num1 - Num2;
        }

        public double Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            if (Num2 == 0) throw new DivideByZeroException("Can't Divide By Zero");
            return Num1 / Num2;
        }
    }
}