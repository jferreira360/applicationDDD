using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Profundidade { get; set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSeMenorIgualMinimo(altura, 1, "O campo altura não pode ser menor que 1");
            Validacoes.ValidarSeMenorIgualMinimo(largura, 1, "O campo largura não pode ser menor que 1");
            Validacoes.ValidarSeMenorIgualMinimo(profundidade, 1, "O campo profundidade não pode ser menor que 1");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }
    }
}
