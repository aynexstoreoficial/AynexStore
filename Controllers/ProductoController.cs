using Microsoft.AspNetCore.Mvc;
using AynexStore.Models;

namespace AynexStore.Controllers;

public class ProductoController : Controller
{
    public IActionResult Detalle(int id)
{
    Producto? producto = null;

    switch (id)
    {
        case 1:
            producto = new Producto
            {
                Id = 1,
                Nombre = "Pack Trapos de Cocina",
                Descripcion = "Trapos de cocina Break Coffee Break  Pack de 6, marca ROOMERS 100% algodon de alta absorción. Tamaño 50cm x 50cm. Procedencia de Portugal. ",
                Precio = "20,99 €",
                Imagen = "TrapoCoffeBreakTodosPaños-PresentacionDeTodo.jpeg",
                Imagenes = new List<string>
        {
            "TrapoCoffeBreakTodosPaños-PresentacionDeTodo.jpeg",
            "TrapoCoffeBreakAmarillo-Presentacion.jpeg",
            "TrapoCoffeBreakAzul-Presentacion.jpeg",
            "TrapoCoffeBreakVerde-Presentacion.jpeg",
            "TrapoCoffeBreakMarron-Presentacion.jpeg",
            "TrapoCoffeBreakAmarilloVerde-PresentacionColgado.jpeg",
        }.Take(6).ToList()
            };
            break;
        case 2:
            producto = new Producto
            {
                Id = 2,
                Nombre = "Paños Multiusos",
                Descripcion = "Paños de celulosa reutilizables. Ideales para limpieza general.",
                Precio = "5,99 €",
                Imagen = "Captura4.PNG",
                Imagenes = new List<string>
        {
            "Captura4.PNG",
            "Captura1.PNG",
            "Captura2.PNG",
            "Captura3.PNG",
            "Captura4.PNG",
        }.Take(6).ToList()
            };
            break;
        case 3:
            producto = new Producto
            {
                Id = 3,
                Nombre = "Esponjas de Limpieza",
                Descripcion = "Esponjas antirayas. No dañan superficies.",
                Precio = "3,99 €",
                Imagen = "Captura1.PNG",
                Imagenes = new List<string>
        {
            "Captura1.PNG",
            "Captura2.PNG",
            "Captura3.PNG",
        }.Take(6).ToList()
            };
            break;
        default:
            return NotFound();
    }

    return View(producto);
}
}