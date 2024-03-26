﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T Create(T item);

        T Delete(int code);

        T Update(int code, T item);
        
        


        
    }
}

