using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class Cotacao
    {
        [Display(Name = "Valor em Dólar $: ")]
        [Required(ErrorMessage = "Informe o Valor do Dólar")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double ValorDolar { get; set; }
        
        [Display(Name = "Quantidade em Reais R$: ")]
        [Required(ErrorMessage = "Informe a Quantidade em Reais")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double QuantidadeReal { get; set; }

        [Display(Name = "Valor em Reais R$: ")]
        [DisplayFormat(DataFormatString="{0:#.##}")]

        public double ValorReal { get => Calcular(); }

        private double Calcular(){
            return ValorDolar * QuantidadeReal;
        }

    }
}