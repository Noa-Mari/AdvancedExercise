using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedExercise
{
    public class MyCoolCalc
    {
        public  int _studentId { get; private set; }

        public MyCoolCalc(int studentId)
        {
            _studentId = studentId;
        }
        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
                throw new MyCoolCalcException(_studentId,$"cant divide a number by 0",new[] {num1,num2});

            else if (num1 == num2)
                throw new MyCoolCalcException(_studentId, $"{num1}=={num2} no point to divide a number by himself", new[] { num1, num2 });
            return num1 / num2;
        }

        public double Power(int num)
        {
            double numNew = Math.Pow(num, 2);
            if (numNew == 6 || num == 6)
                throw new MyCoolCalcException(_studentId, $"BOOM", new[] { num });
            return numNew;
            
        }
    }
}