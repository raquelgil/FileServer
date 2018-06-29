using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastructure.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FileServer.Common.Model;
using FileServer.Infrastructure.Repository.Interfaces;

namespace FileServer.Infrastructure.Repository.Repositories.Tests
{
	[TestClass()]
	public class AlumnoRepositoryTests
	{
		private IAlumnoRepository mockObject;


		Alumno vAlumno = new Alumno { IdAlumno = 8, Nombre = "Raquel", Apellidos = "Gil Ponz", Dni = "44993985M" };
		[TestInitialize]
		public void Setup()
		{
			var mock = new Mock<IAlumnoRepository>();
			mock.Setup(X => X.Add(vAlumno)).Returns(vAlumno);
			mockObject = mock.Object;
		}

		[TestMethod()]
		public void AddTest()
		{
			var result = mockObject.Add(vAlumno);
			Assert.AreEqual(vAlumno, result);
		}
	}




	
	}