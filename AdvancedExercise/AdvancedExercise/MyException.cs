using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedExercise
{
    public class MyException : Exception
    {
        public int _studenId { get; private set; }
        public string _userMessage { get; private set; }
    
        public MyException(int StudenId, string UserMessage)
        {
            _studenId = StudenId;
            _userMessage = UserMessage;
        }
    }
}