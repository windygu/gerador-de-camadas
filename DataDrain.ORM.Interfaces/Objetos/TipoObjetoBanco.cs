﻿using System;
using System.Collections.Generic;

namespace DataDrain.ORM.Interfaces.Objetos
{
    public sealed class TipoObjetoBanco
    {
        public enum ETipoObjeto
        {
            Tabela,
            View,
            Procedure
        }

        public TipoObjetoBanco(string nome, string tipo, List<DadosStoredProceduresParameters> parametros = null)
        {
            NomeObjeto = nome;
            Parametros = parametros;

            switch (tipo.ToLower())
            {
                case "tabela":
                    TipoObjeto = ETipoObjeto.Tabela;
                    break;
                case "view":
                    TipoObjeto = ETipoObjeto.View;
                    break;
                case "procedure":
                    TipoObjeto = ETipoObjeto.Procedure;
                    break;

                default:

                    throw new ArgumentOutOfRangeException("tipo", "Tipo inválido");
            }
        }

        public string NomeObjeto { get; private set; }

        public ETipoObjeto TipoObjeto { get; private set; }

        /// <summary>
        /// Lista de dependencias e associacoes do objeto
        /// </summary>
        public List<DadosAssociation> Associacoes { get; set; }

        /// <summary>
        /// Lista de enumns usados no objeto
        /// </summary>
        public List<string> Enumns { get; set; }

        /// <summary>
        /// Lista de parametros
        /// </summary>
        public List<DadosStoredProceduresParameters> Parametros { get; set; }
    }
}