using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        public TKey[] _keyArray;
        public TValue[] _valueArray;
       
        public MyDictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }

        
        public void Add(TKey key,TValue value)
        {
            TKey[] _temArray1= _keyArray;
            TValue[] _temArray2=_valueArray;
            _keyArray = new TKey[_keyArray.Length+1];
            _valueArray = new TValue[_temArray2.Length + 1];

            for (int i = 0; i < _temArray1.Length; i++)
            {
                _keyArray[i] = _temArray1[i];
                
            }
            _keyArray[_keyArray.Length - 1] = key;

            for (int j = 0; j < _temArray2.Length; j++)
            {
                
                _valueArray[j] = _temArray2[j];
            }
            _valueArray[_valueArray.Length - 1] = value;


        }
        public int Count()
        {
             return _valueArray.Length; 
        }
        public void List()
        {
            for (int i = 0; i < _keyArray.Length; i++)
            {
                Console.WriteLine("MyDictionary Key: " + _keyArray[i] + "  MyDictionary Value: " + _valueArray[i]);
            }
        }
    }
}
