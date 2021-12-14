using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    internal class MyDictionary<TKey,TValue>
    {
        TKey[] tKeys;
        TValue[] tValues;
        public MyDictionary()
        {
            tKeys = new TKey[0];
            tValues = new TValue[0];
        }
        
        public void Add(TKey keyT, TValue valueT)
        {
            TKey[] tempKeysArr = tKeys;
            TValue[] tempValuesArr = tValues;

            tKeys = new TKey[tKeys.Length+1];
            tValues = new TValue[tValues.Length+1];

            for (int i = 0; i < tempKeysArr.Length; i++)
            {
                tKeys[i] = tempKeysArr[i];
            }

            for (int i = 0; i < tempValuesArr.Length; i++)
            {
                tValues[i] = tempValuesArr[i];
            }

            tKeys[tKeys.Length - 1] = keyT;
            tValues[tKeys.Length -1] = valueT;
        }

        public int Length 
        { 
            get { return tKeys.Length; } 
        }
        public TValue[] Values 
        { 
            get { return tValues;  } 
        }
        public TKey[] Keys
        {
            get { return tKeys; }
        }
    }
}
