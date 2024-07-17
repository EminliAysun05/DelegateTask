using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    using System;
    using System.Collections.Generic;
    public class CustomList<T>
    {
        public T[] items;
        public int count;



        public CustomList()
        {
            items = new T[0];
            count = 0;
        }

        public void Resize()
        {
            int newSize = (items.Length == 0) ? 1 : items.Length * 2;
            Array.Resize(ref items, newSize);
        }
        public void Add(T item)
        {
            if (count == items.Length)
            {
                Resize();
            }
             items[count++] = item;
        }

        public T Find(Predicate<T> num)
        {
            for (int i = 0; i < count; i++)
            {
                if (num(items[i]))
                {
                    return items[i];
                }


            }
            return default(T);//0 qaytarir
        }
        public CustomList<T> FindAll(Predicate<T> num)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0;i < count;i++)
            {
                if (num(items[i]))
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public bool Remove (T item)
        {

            for(int i = 0;i<count; i++)
            {
                if (items[i].Equals(item))
                {
                    for(int j=i; j<count-1;j++)
                    {
                        items[j] = items[j+1];
                    }
                    count --;
                    items[count] = default(T);
                    return true;
                }
            }
            return false;
        }

        public int RemoveALL(Predicate<T> num)
        {
            int removedCount = 0;//silinenlerin sayi
            for (int i = 0; i < count; i++)
            {
                if (num(items[i]))
                {
                    Remove(items[i]);
                    i--;
                    removedCount++;
                }
            }
            return removedCount;//silinenlerin sayi
        }

        //public T this[int index]
        //{
        //    get
        //    {
        //        if(index < 0)
        //        {
        //            throw new ArgumentException("index sifirdan kicik ola bilmez");
        //        }
        //        return items[index];
        //    }

        //    set
        //    {
        //        if(index<0)
        //        {
        //            throw new ArgumentException("Index kicik ola bilmez");
        //        }
        //        items[index] = value;
        //    }
        //}
    }
}