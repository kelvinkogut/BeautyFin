﻿using System;
namespace Inicial.Models
{
    public class Horarios
    {
        public int ID { get; set; }
        public int idFuncionario { get; set; }
        public string horarioinicio { get; set; }
        public string nomeFuncionario { get; set; }
        public string nomeCliente { get; set; }
        public int IdServico { get; set; }
        public int tempo { get; set; }
    }
}