using EjercicioAPI_1.Modelos;
using EjercicioAPI_1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioAPI_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase {
        [Route("InformacionEstudiante")]
        [HttpGet]
        public ActionResult DevuelveInformacionEstudiante(int id)
        {
            try
            {
                EstudiantesRepository repositorio = new EstudiantesRepository();
                if (id==0)
                {
                    return NotFound();
                }
                var estudiante = repositorio.DevuelveInformacionEstudiante();
                return Ok(estudiante);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Route("ListadoEstudiantes")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            EstudiantesRepository repository = new EstudiantesRepository();
            return repository.DevuelveListadoEstudiante();
        }

        [Route("ListadoEstudiantesPorNombre/{Nombre}")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantesPorNombre(string Nombre)
        {
            EstudiantesRepository repository = new EstudiantesRepository();
            return repository.DevuelveListadoEstudiante().Where(x => x.Nombre == Nombre).ToList(); 
        }
    }
}
