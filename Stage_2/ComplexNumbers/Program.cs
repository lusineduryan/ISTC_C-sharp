﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public struct ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.RealPart = realPart;
            this.ImaginaryPart = imaginaryPart;
        }

        public string number(double realPart, double imaginaryPart)
        {
            return $"{realPart}+{imaginaryPart}*i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber number1 = new ComplexNumber(5, 6);
            ComplexNumber number2 = new ComplexNumber(10,23);

            OperationsClass operations = new OperationsClass();

            ComplexNumber sum = operations.Sum(number1, number2);
            ComplexNumber subtraction = operations.Subtraction(number1, number2);
            ComplexNumber product = operations.Product(number1, number2);
            ComplexNumber division = operations.Division(number1, number2);
            double module = operations.Module(number1);

        }
    }
}
