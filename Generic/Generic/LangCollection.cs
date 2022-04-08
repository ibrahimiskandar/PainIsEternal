using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class LangCollection<T>where T:ProgrammingLanguage
    {
        public T[] Languages = new T[0];
        public void AddLang(T language)
        {
            Array.Resize(ref Languages, Languages.Length + 1);
            Languages[^1] = language;
        }
        public void SortByName()
        {
            for (int i = 0; i < Languages.Length; i++)
            {
                for (int j = i + 1; j < Languages.Length; j++)
                {
                    Array.Sort(Languages, (x, y) => String.Compare(x.Name, y.Name));
                }
            }
        }
        public void SortByDate()
        {

        }
    }
}
