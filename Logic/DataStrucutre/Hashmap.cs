using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataStrucutre
{
    public class Hashmap<T>
    {
        private List<List<T>> data;
        public int Count => data.Count;

        public Hashmap(int depth) { 
            data = new List<List<T>>();
            for (int i = 0; i < depth; i++)
            {
                data.Add(new List<T>());
            }
        }

        public T Get(int vKey, int hKey)
        {
            return data[vKey][hKey];
        }

        public void AddRow() { 
            data.Add(new List<T>());
        }
        public void RemoveRow() { 
            data.Remove(data[data.Count]);
        }

        public void Set(T val, int vKey, int hKey)
        {
            data[vKey][hKey] = val;
        }

        public void Fill(T val)
        {
            for (int i = 0;i < data.Count;i++) { 
                for (int j = 0;j < data[i].Count; j++)
                {
                    data[i][j] = val;
                }
            }
        }
    }
}
