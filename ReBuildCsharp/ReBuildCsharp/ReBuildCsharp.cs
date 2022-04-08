using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace ReBuildCsharp
{
    class MyList<T> : IEnumerable
    {


        private T[] CustomList;
        private int count;
        private int capacity = 0;
        
       
        public int Count { get; set; }
        public int Capasity { get; set; }


        public MyList()
        {
            CustomList = new T[0];
        }
        public MyList(int capasity)
        {
            CustomList = new T[capasity];
        }

        public T this[int index]
        {
            get
            {
                if (index < capacity&& CustomList[index] != null)
                {
                    return CustomList[index];
                }
                throw new ArgumentOutOfRangeException("bu indexde element movcud deyil!!");
            }
            set
            {
                if (index < capacity && CustomList[index] == null)
                {
                    CustomList[index] = value;
                }
                throw new ArgumentOutOfRangeException("bu indexde element movcud deyil!!");
            }
        }
        public void Add(T item)
        {
            int cap = capacity;
            if (Capasity>0)
            {
                if (count<capacity)     //2 {1,2,3,0}
                {
                    CustomList[count] = item;
                    count++;
                }
                if (count == capacity)
                {
                    Array.Resize(ref CustomList, CustomList.Length + cap);
                    capacity += CustomList.Length;
                }
            }
            else if(capacity==0)
            {
                if (count == 0)
                {
                    Array.Resize(ref CustomList, CustomList.Length + 1);
                    CustomList[count] = item;
                    count++;
                }
                else if (count==1)
                {
                    Array.Resize(ref CustomList, (CustomList.Length +1)*2);
                    CustomList[count] = item;
                }
                else
                {
                    Array.Resize(ref CustomList, CustomList.Length * CustomList.Length);
                    CustomList[count] = item;
                }
            }
        }
        public void Clear()
        {
            CustomList = new T[0];
            
        }
        public bool Contains(T item)
        {
            bool isContains=false;
            for (int i = 0; i < CustomList.Length; i++)
            {
                if (CustomList[i].Equals(item))
                {
                    isContains = true;
                    return isContains;
                }
            }
            return isContains;
        }
        public void Sort()
        {
            Array.Sort(CustomList);
        }
        public void Remove(int index)
        {
            T[] newlist = new T[CustomList.Length - 1];
            bool isEqual = false;
            for (int i = 0; i < CustomList.Length; i++)
            {

                if (index == i)
                {
                    isEqual = true;
                    i++;
                    
                }
                if (isEqual)
                {
                    newlist[i-1] = CustomList[i];
                }
                else
                {
                    newlist[i] = CustomList[i];
                }

            }
            CustomList = newlist;
        }
        public void Remove(T value)
        {

            T[] newlist = new T[CustomList.Length - 1];
            bool isEqual = false;
            for (int i = 0; i < CustomList.Length; i++)
            {

                if (CustomList[i].Equals(value))
                {
                    isEqual = true;
                    i++;

                }
                if (isEqual)
                {
                    newlist[i - 1] = CustomList[i];
                }
                else
                {
                    newlist[i] = CustomList[i];
                }

            }
            CustomList = newlist;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (T CustomList in MyList<T>)
            {
                yield return CustomList;
            }
          
        }
    }
}
