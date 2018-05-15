using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class Nhibernate
    {
        public void Insert(object x)
        {
            Console.WriteLine("Insert envocado");
        }

        public void Get(long id)
        {
            Console.WriteLine("Get envocado");
        }

        public void BeginTransaction()
        {
            Console.WriteLine("BeginTransaction envocado");
        }

        public void CommitTransaction()
        {
            Console.WriteLine("CommitTransaction envocado");
        }

        public void RollbackTransaction()
        {
            Console.WriteLine("RollbackTransaction envocado");
        }
    }
}
