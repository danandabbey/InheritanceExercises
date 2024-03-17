using System.Collections;

namespace InheritanceExercises;

public class Stack
{
    private ArrayList _list = new ArrayList();
    
    public void Push(object item)
    {
        if (item is null)
        {
            throw new InvalidOperationException("item is null");
        }
        
        _list.Add(item);
    }
    public object Pop()
    {
        if (_list is null || _list.Count == 0)
        {
            throw new InvalidOperationException("stack is empty");
        }
        
        var removed = _list[_list.Count -1];
        _list.RemoveAt(_list.Count -1);
        return removed;
    }
    public void Clear()
    {
        _list.RemoveRange(0,_list.Count -1);
    }
}