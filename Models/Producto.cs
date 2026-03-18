namespace AynexStore.Models;

public class Producto
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
    public required string Precio { get; set; }
    public required string Imagen { get; set; }
    public List<string> Imagenes { get; set; } = new();  // imágenes adicionales

}