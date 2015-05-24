namespace Task5To7_GenericClass
{
    using System;
    public class GenericList<T>//TASK 5-7
    {
        //FIELDS
        private T[] elements;
        private int counter = 0;
        private int capacity;


        //CONSTRUCTORS
        public GenericList(int capacity = 1000)
        {
            this.capacity = capacity;
            elements = new T[capacity];
        }


        //PROPERTIES
        public int Count
        {
            get
            {
                return this.counter;
            }
        }
        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The capacity can't be a negative number!");
                }
                this.capacity = value;
            }
        }


        //METHODS
        public void Add(T element)
        {
            if (counter == elements.Length)
            {
                AutoGrow();
            }
            if (counter >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capacity of {0} was exceeded.", elements.Length));
            }
            this.elements[counter] = element;
            counter++;
        }
        public T this[int index]
        {
            get
            {
                if (index >= counter)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
        public void RemoveAtIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("The index must be a positive number!");
            }
            if (index <= counter)
            {
                for (int i = index; i < counter - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                counter--;
            }
            else
            {
                throw new ArgumentException("This position is emty!");
            }
        }
        public void Clear()
        {
            elements = new T[elements.Length];
            counter = 0;
        }
        public void InsertAtPosition(int index, T element)
        {
            if (counter == elements.Length)
            {
                AutoGrow();
            }
            for (int i = counter; i >= index + 1; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[index] = element;
            counter++;
        }
        public int FindByValue(T element)
        {
            return Array.IndexOf(elements, element);
        }
        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < counter; i++)
            {
                str += elements[i];
                if (i < counter - 1)
                {
                    str += ", ";
                }
            }
            return str;
        }
        private void AutoGrow()// CREATING A NEW ARRAY OF DOUBLE SIZE AND MOVE ALL ELEMENTS TO IT
        {
            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, 0, tempArray, 0, elements.Length);
            elements = tempArray;
            Capacity *= 2; ;
        }

        public T Max()// FINDING THE MAXIMAL ELEMENT
        {
            if (this.counter == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            if (this.counter == 1)
            {
                return this.elements[0];
            }

            if (this.elements[0] is IComparable<T>)
            {
                T max = this.elements[0];

                for (int i = 1; i < this.counter; i++)
                {
                    if ((max as IComparable<T>).CompareTo(this.elements[i]) < 0)
                    {
                        max = this.elements[i];
                    }
                }

                return max;
            }
            else
            {
                throw new ArgumentException("At least one object must implement IComparable.");
            }
        }
        public T Min()//FINDING THE MINIMAL ELEMENT
        {
            if (this.counter == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            if (this.counter == 1)
            {
                return this.elements[0];
            }

            if (this.elements[0] is IComparable<T>)
            {
                T min = this.elements[0];

                for (int i = 1; i < this.counter; i++)
                {
                    if ((min as IComparable<T>).CompareTo(this.elements[i]) > 0)
                    {
                        min = this.elements[i];
                    }
                }

                return min;
            }
            else
            {
                throw new ArgumentException("At least one object must implement IComparable.");
            }
        }
    }
    }
}
