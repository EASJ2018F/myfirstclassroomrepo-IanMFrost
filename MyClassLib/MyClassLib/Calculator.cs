using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace MyClassLib
{
    public class Calculator
    {
       
        /// <summary>
        /// Lægger 2 tal sammen 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Addition (double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Trækker to tal fra hinanden
        /// </summary>
        public double Substraction(double x, double y)
        {
            return x - y; 
        }

        /// <summary>
        /// Ganger to tal med hinanden
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// dividerer to tal med hinanden
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Division(double x, double y)
        {
            return x / y;
        }
    }
}
