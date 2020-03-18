using System;
using System.Collections.Generic;
using System.Text;

namespace counter
{
    class Counter
    {
        public int Count { get; set; }

        public Counter()
        {
            this.Count = 0;
        }
        public Counter(int initialValue)
        {
            this.Count = initialValue;
        }
        public void Add()
        {
            this.Count++;
        }
        public void Add(int number)
        {
            this.Count += number;
        }
        public string Get()
        {
            return this.Count.ToString();
        }
        public void Reset()
        {
            this.Count = 0;
        }
    }
}

/*    which has an integer property
    when creating it should have a default value 0 or we can specify it when creating
    we can Add(number) to this counter another whole number
    or we can Add() without parameters just increasing the counter's value by one
    and we can Get() the current value as string
    also we can Reset() the value to the initial value
*/