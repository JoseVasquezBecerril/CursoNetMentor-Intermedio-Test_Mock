using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Generics
{
    public class OperationResult<T>
    {
        public bool success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public T Contenido { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }
        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
        public void SetSuccessResponse(T obj)
        {
            Contenido = obj;
        }
    }
}
