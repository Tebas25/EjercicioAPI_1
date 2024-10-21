using EjercicioAPI_1.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioAPI_1.Repositories
{
    public class EstudiantesRepository{
        public Estudiante DevuelveInformacionEstudiante()
        {
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Sebastian",
                Edad = 19,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true
            };
            return estudiante;
        }

        public List<Estudiante> DevuelveListadoEstudiante()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(new Estudiante
            {
                Id = 2,
                Nombre = "Juaquin",
                Edad = 20,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true
            });

            estudiantes.Add(new Estudiante
            {
                Id = 3,
                Nombre = "Maria",
                Edad = 22,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = false
            });
            return estudiantes;
        }
    }
}
