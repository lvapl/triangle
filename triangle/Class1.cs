using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    public enum TriangleType
    {
        impossible,
        rectangular,
        acute,
        obtuse
    }

    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public TriangleType GetTriangleType()
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                return TriangleType.impossible;
            }

            double squareA = sideA * sideA;
            double squareB = sideB * sideB;
            double squareC = sideC * sideC;

            if (squareA == squareB + squareC || squareB == squareA + squareC || squareC == squareA + squareB)
            {
                return TriangleType.rectangular;
            }
            else if (squareA < squareB + squareC && squareB < squareA + squareC && squareC < squareA + squareB)
            {
                return TriangleType.acute;
            }
            else
            {
                return TriangleType.obtuse;
            }
        }
    }
}
