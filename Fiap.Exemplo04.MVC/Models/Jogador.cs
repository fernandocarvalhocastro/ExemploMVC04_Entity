using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        //Relacionamentos
        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}