﻿namespace DesignPattern.IteratorPattern.IteratorPattern
{
    public interface Iterator<T>
    {
        T CurrentItem { get; }
        bool NextLocation();

    }
}
