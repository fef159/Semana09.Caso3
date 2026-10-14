using System.ComponentModel.DataAnnotations;

namespace Semana09.Caso3.Models;

public class Producto
{
    [Display(Name = "Código")]
    [Required(ErrorMessage = "El código es obligatorio.")]
    [StringLength(6, MinimumLength = 3, ErrorMessage = "El código debe tener entre 3 y 6 caracteres.")]
    [RegularExpression(@"^[A-Z0-9]+$", ErrorMessage = "Use solo mayúsculas y números.")]
    public string Codigo { get; set; } = string.Empty;

    [Display(Name = "Nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre acepta hasta 50 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Display(Name = "Precio")]
    [Range(0.01, 99999, ErrorMessage = "El precio debe ser mayor que 0.")]
    public decimal Precio { get; set; }

    [Display(Name = "Stock")]
    [Range(0, 1000, ErrorMessage = "El stock debe estar entre 0 y 1000.")]
    public int Stock { get; set; }

    [Display(Name = "Correo del proveedor")]
    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
    public string CorreoProveedor { get; set; } = string.Empty;
}
