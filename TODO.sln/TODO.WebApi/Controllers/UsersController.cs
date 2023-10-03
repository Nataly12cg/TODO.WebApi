using Microsoft.AspNetCore.Mvc;
using TODO.WebApi.Models;
using TODO.WebApi.Data;

/// <summary>
/// Controlador para gestionar usuarios.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Constructor del controlador de usuarios.
    /// </summary>
    /// <param name="context">Contexto de la base de datos.</param>
    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Obtiene la lista de todos los usuarios.
    /// </summary>
    /// <returns>Una lista de objetos User.</returns>
    [HttpGet]
    public IActionResult GetUsers()
    {
        // Implementa la lógica para listar usuarios aquí.
        return Ok();
    }

    /// <summary>
    /// Crea un nuevo usuario.
    /// </summary>
    /// <param name="user">Datos del nuevo usuario.</param>
    /// <returns>El usuario creado.</returns>
    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        // Implementa la lógica para crear un usuario aquí.
        return Ok();
    }

    /// <summary>
    /// Actualiza un usuario existente.
    /// </summary>
    /// <param name="id">ID del usuario a actualizar.</param>
    /// <param name="user">Nuevos datos del usuario.</param>
    /// <returns>El usuario actualizado.</returns>
    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, User user)
    {
        // Implementa la lógica para actualizar un usuario aquí.
        return Ok();
    }

    /// <summary>
    /// Elimina un usuario.
    /// </summary>
    /// <param name="id">ID del usuario a eliminar.</param>
    /// <returns>Resultado de la operación.</returns>
    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        // Implementa la lógica para eliminar un usuario aquí.
        return Ok();
    }
}


