

//Cambiar Foto
function cambiarImagen(contenedor) {
    let img = contenedor.querySelector('img');
    document.querySelector('.imagen-principal').src = img.src;
}











//Fotos invisibles NO ESTA FUNCIONANDO
function mostrarTodasLasFotos() {
    const datos = document.getElementById('datos-imagenes');
    if (!datos) return;

    const todasLasImagenes = JSON.parse(datos.getAttribute('data-imagenes'));
    const visibles = 5;
    const contenedorCarrusel = document.getElementById('contenedorCarrusel');
    if (!contenedorCarrusel) return;

    // Limpiar el carrusel
    contenedorCarrusel.innerHTML = '';

    // Añadir las imágenes restantes (desde índice 5)
    for (let i = visibles; i < todasLasImagenes.length; i++) {
        const ruta = todasLasImagenes[i];
        const claseItem = (i === visibles) ? 'carousel-item active' : 'carousel-item';

        const item = document.createElement('div');
        item.className = claseItem;

        const img = document.createElement('img');
        img.src = `/imagen/${ruta}`;
        img.className = 'd-block w-100';
        img.alt = `Foto ${i + 1}`;

        item.appendChild(img);
        contenedorCarrusel.appendChild(item);
    }

    // Abrir el modal
    const modal = new bootstrap.Modal(document.getElementById('modalFotos'));
    modal.show();
}