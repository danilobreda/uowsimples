using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class ServiceTeste
    {
        private readonly IUOW uow;

        public ServiceTeste(IUOW uowinjetado)
        {
            uow = uowinjetado;
        }

        public void Inserir(TesteModel teste)
        {
            try
            {
                uow.BeginTransacao();
                uow.Inseri(teste);
                uow.CommitTransacao();
            }
            catch (Exception ex)
            {
                uow.RollbackTransacao();
            }
        }
    }
}
