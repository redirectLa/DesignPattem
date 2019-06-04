using System;
using System.Collections.Generic;
using System.Text;

namespace LteratorPattern
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int current = 0;
        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            this._concreteAggregate = concreteAggregate;
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < _concreteAggregate.Count)
            {
                ret = _concreteAggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current >= _concreteAggregate.Count;
        }

        public override object CurrentItem()
        {
            return _concreteAggregate[current];
        }
    }

    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

}
