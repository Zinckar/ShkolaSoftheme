﻿namespace Iterator
{
    interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}