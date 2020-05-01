
//using System;

using System;
using System.Collections;

namespace CSharpIntermediateToAdvance
{
    public class Stack
    { 
    private readonly ArrayList _list = new ArrayList();

    public void Push(object obj)
    {
        if (obj == null)
        {
            throw new InvalidOperationException("This is an Invalid Argument");
        }
        _list.Add(obj);
    }

    public object Pop()
    {
        var lastElementIndex = _list.Count - 1;
        if (lastElementIndex < 0)
        {
            throw new InvalidOperationException("The Stack is already empty.");
        }
        var obj = _list[lastElementIndex];
        _list.RemoveAt(lastElementIndex);
        return obj;
    }

    public void Clear()
    {
            _list.Clear();
    }

    public int Size()
    {
        return _list.Count;
    }
}
    public class Stack
    {
        private readonly ArrayList _list = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("This is an Invalid Argument");
            }
            _list.Add(obj);
        }

        public object Pop()
        {
            var lastElementIndex = _list.Count - 1;
            if (lastElementIndex < 0)
            {
                throw new InvalidOperationException("The Stack is already empty.");
            }
            var obj = _list[lastElementIndex];
            _list.RemoveAt(lastElementIndex);
            return obj;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public int Size()
        {
            return _list.Count;
        }
    }
}



