using Microsoft.AspNetCore.Mvc;
using Semana09.Caso3.Models;

namespace Semana09.Caso3.Controllers;

public class ProductosController : Controller
{
    // Lista en memoria: se borra al reiniciar la aplicación.
    private static readonly List<Producto> productos = new();

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Producto producto)
    {
        // Regla de negocio adicional: no repetir códigos.
        if (productos.Any(p => p.Codigo == producto.Codigo))
        {
            ModelState.AddModelError("Codigo", "Este código ya está registrado.");
        }

        // Si algo falla, se vuelve a mostrar el formulario con sus datos y errores.
        if (!ModelState.IsValid)
        {
            return View(producto);
        }

        productos.Add(producto);
        return RedirectToAction(nameof(Lista));
    }

    public IActionResult Lista()
    {
        return View(productos);
    }
}
