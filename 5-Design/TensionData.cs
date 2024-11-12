using System;
using System.Collections.Generic;

public class TensionData
{
    private List<ITensionObserver> observers;
    private int tension;

    public TensionData()
    {
        observers = new List<ITensionObserver>();
    }

    public void AddObserver(ITensionObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(ITensionObserver observer)
    {
        observers.Remove(observer);
    }

    public void SetTension(int value)
    {
        tension = value;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(tension);
        }
    }
}
