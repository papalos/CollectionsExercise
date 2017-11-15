using System;
using System.Collections;

namespace Array7
{
    class NotExistExcept : Exception
    {
        //Пользовательское исключение
        public NotExistExcept() : base("Такого ключа в данной таблице нет!") { }
        
    }

    /*Класс реализующий пользовательское исключение*/
    class CheckHash
    {
        Hashtable _hash;
        public CheckHash(Hashtable hash)
        {
            _hash = hash;
        }

        public double inspect(double key)
        {
            if (_hash.ContainsKey(key))
            {
                return (double)_hash[key];
            }
            else
            {
                throw new NotExistExcept();
            }
        }
    }
    
}
