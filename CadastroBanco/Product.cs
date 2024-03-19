using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O preço do produto é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço do produto deve ser maior que zero.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "A quantidade do produto é obrigatória.")]
    [Range(1, int.MaxValue, ErrorMessage = "A quantidade do produto deve ser maior que zero.")]
    public int Quantity { get; set; }
}
