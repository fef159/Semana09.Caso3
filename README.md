# Semana 09 Caso 3

Proyecto MVC sencillo para demostrar validación con Data Annotations.

## Ejecutar

```powershell
dotnet run
```

Abrir la dirección que muestra la consola. La aplicación inicia en `Productos/Create`.

## Guion corto para explicar

1. `Producto.cs`: los atributos sobre cada propiedad definen las reglas y mensajes.
2. `Create.cshtml`: `asp-validation-for` muestra el error de cada campo y `asp-validation-summary` muestra errores generales.
3. Al enviar, ASP.NET llena `Producto` y guarda los errores en `ModelState`.
4. El controlador revisa si el código ya existe con `ModelState.AddModelError`.
5. Si `ModelState.IsValid` es falso, vuelve a la misma vista sin borrar lo escrito.
6. `_ValidationScriptsPartial` valida antes de enviar; aunque se quite, el servidor igual valida.

## Pruebas rápidas

- Código: `ab` (falla por longitud y minúsculas).
- Precio: `0` (falla por rango).
- Correo: `hola` (falla por formato).
- Registra `ABC1` y luego intenta registrar otra vez `ABC1` (falla por duplicado).
