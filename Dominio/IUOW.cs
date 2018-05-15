using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public interface IUOW
    {
        void Inseri(object obj);

        void Retorna(long id);

        void BeginTransacao();

        void CommitTransacao();

        void RollbackTransacao();

        void AdicionaVarios(object[] objs);
    }
}
