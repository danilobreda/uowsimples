using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class Dapper
    {
        public void Add(object x)
        {
            Console.WriteLine("Insert envocado");
        }

        public void PegaAi(long id)
        {
            Console.WriteLine("Get envocado");
        }

        public void BeginEssaPorra()
        {
            Console.WriteLine("BeginTransaction envocado");
        }

        public void CommitCaralho()
        {
            Console.WriteLine("CommitTransaction envocado");
        }

        public void RollbackDeuMerda()
        {
            Console.WriteLine("RollbackTransaction envocado");
        }
    }
}
