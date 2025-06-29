using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedExercise
{
    public class MyCoolCalcException : MyException
    {
        public List<int> list{ get; private set; }

        public MyCoolCalcException(int studentId, string userMessage, IEnumerable<int> numbers)
            : base(studentId, userMessage)
        {
            list = new List<int>(numbers);
        }

        public IList<int> GetCoolCalcNumbers()
        {
            return list;
        }

    }
}