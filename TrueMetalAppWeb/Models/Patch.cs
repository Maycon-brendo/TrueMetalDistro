using System.ComponentModel.DataAnnotations;

namespace TrueMetalAppWeb.Models;

public class Patch
{

    public int PatchId { get; set; }

    [Required(ErrorMessage ="Campo 'Nome' Obrigatorio")]
    [StringLength(50, MinimumLength = 10, ErrorMessage ="Campo Nome deve ter entre 10 e 50 caracteres")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Required(ErrorMessage = "Campo 'Descrição' Obrigatorio")]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Campo Descrição deve ter entre 10 e 100 caracteres")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Campo 'Imagem Url' Obrigatorio")]
    [Display(Name = "Imagem Url")]
    public string ImagemUri { get; set; }

    [Required(ErrorMessage = "Campo 'Preço' Obrigatorio")]
    [Display(Name ="Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }


    [Display(Name = "Entrega Expressa")]
    public bool EntregaExpressa { get; set; }
    public string EntragaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

    [Required(ErrorMessage = "Campo 'Disponível em' Obrigatorio")]
    [Display(Name = "Disponível em")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    [DataType("month")]
    public DateTime DataCadastro { get; set; }

    [Display(Name = "Genero")]
    public int? GeneroId { get; set; }
}
