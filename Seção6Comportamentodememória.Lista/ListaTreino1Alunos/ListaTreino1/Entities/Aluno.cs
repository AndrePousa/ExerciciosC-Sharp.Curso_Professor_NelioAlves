using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ListaTreino1.Entities
{
    class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nivel { get; set; }


        public Aluno()
        {

        }

        public Aluno(int id, string nome, string nivel)
        {
            Id = Id;  
            Nome = nome;
            Nivel = nivel;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", " + "Nivel: " + Nivel;
        }

    }
}
