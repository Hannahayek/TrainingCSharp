using System;

namespace Generics
{
//types
//where T :Icomparaple
    //where T: Product
    //where T:struct
    //where T:class
    //where T:new()
    public class Utilies<T> where T:IComparable,new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //below in generic way
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {//to make it compile with new T we add beside icomparaple,new
            var obj=new T();
        }
    }



}
