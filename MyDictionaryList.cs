﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryList
{
    class MyDictionaryList<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        TKey[] tempKeyArray = new TKey[0];
        TValue[] tempValueArray = new TValue[0];
        public MyDictionaryList()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKeyArray = _keys;
            _keys = new TKey[_keys.Length + 1];

            tempValueArray = _values;
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _keys[i] = tempKeyArray[i];
                _values[i] = tempValueArray[i];

            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }

        public void GetAll()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(" Key :  {0}  | Value :   {1}", _keys[i], _values[i]);
            }
        }

    }
}
