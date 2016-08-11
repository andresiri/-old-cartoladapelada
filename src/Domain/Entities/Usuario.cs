﻿namespace Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Apelido { get; set; }
        public byte Numero { get; set; }
        public string Posicao { get; set; }
    }
}