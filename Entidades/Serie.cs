using DIO.Series.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Entidades
{
    class Serie : EntidadeBase
    {
        private String Titulo { get; set; }
        private String Descricao { get; set; }
        private int Ano { get; set; }
        private Genero Genero { get; set; }
        private bool Excluido { get; set; }
        public Serie() { }

        public Serie(int id,string titulo, string descricao, int ano, Genero genero)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Genero = genero;
            Excluido = false;
        }

        public override string ToString()
        {
            var retorno = "";
            Console.WriteLine();
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + Ano + Environment.NewLine;
            retorno += "Exluido: " + Excluido;
            return retorno;
        }

        public String retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }
        public bool retornaSerieExcluida()
        {
            return Excluido;
        }
    }
}
