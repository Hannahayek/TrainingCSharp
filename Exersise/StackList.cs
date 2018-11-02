using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Exersise_4
{
    public class StackList
    {
        readonly ArrayList _arrayList=new ArrayList();
        public void Push(object obj)
        {

            if (obj is null)
            {
                throw  new InvalidOperationException("object is null");
            }
            else
            {
                
                _arrayList.Add(obj);
            }
           


 
        }

       

        public object Pop()
        {

        
            if (_arrayList.Count == 0)
            {

                throw new InvalidOperationException("list is empty");
            }
            else
            {
                int arrayCount = _arrayList.Count;
                object arraytoRemove = _arrayList[arrayCount - 1];
                _arrayList.RemoveAt(arrayCount-1);
                return arraytoRemove;
            }

           
        }
    }
}