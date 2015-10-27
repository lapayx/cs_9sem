﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4_triangle
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public bool isExists()
        {

            if (A + B > C && A + C > B && B + C > A)
                return true;
            return false;

        }
        public double Perim() {
            if (!isExists()) {
                return -1;
            }

            return A + B + C;
        
        }

        public double Squere() {
            if (!isExists())
            {
                return -1;
            }
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        
        }
    }
}
