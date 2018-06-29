using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastructure.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Infrastructure.Repository.Interfaces;
using FileServer.Common.Model;

namespace FileServer.Infrastructure.Repository.Repositories.Tests
{
	[TestClass()]
	public class AlumnoRepositoryTests
	{
		IAlumnoRepository alumnoRepository = new AlumnoRepository();
		Alumno alumno = new Alumno { IdAlumno = 8, Nombre = "Raquel", Apellidos = "Gil Ponz", Dni = "44993985M" };

		[TestMethod()]
		public void AddTest()
		{
			Assert.IsTrue(alumnoRepository.Add(alumno).Equals (alumno));
		}
	}
}