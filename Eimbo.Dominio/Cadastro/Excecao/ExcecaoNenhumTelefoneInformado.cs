﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eimbo.Dominio.Comum.Excecao;

namespace Eimbo.Dominio.Cadastro.Excecao
{
    public class ExcecaoNenhumTelefoneInformado :ExcecaoCampoObrigatorioNaoInformado
    {
        public ExcecaoNenhumTelefoneInformado() : base("Telefone") { }
    }
}
