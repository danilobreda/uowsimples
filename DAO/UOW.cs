using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class UOW : IUOW
    {
        Dapper orm;

        public UOW(Dapper orminjetado)
        {
            orm = orminjetado;
        }

        public void Inseri(object obj)
        {
            orm.Add(obj);
        }

        public void Retorna(long id)
        {
            orm.PegaAi(id);
        }

        public void BeginTransacao()
        {
            orm.BeginEssaPorra();
        }

        public void CommitTransacao()
        {
            orm.CommitCaralho();
        }

        public void RollbackTransacao()
        {
            orm.RollbackDeuMerda();
        }

        public void AdicionaVarios(object[] objs)
        {
            foreach (var item in objs)
            {
                orm.Add(item);
            }
        }
    }
}
