using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolDirector;
using System;

namespace SchoolDirector
{
    [TestClass()]
    public class SchoolDirectorRepoTests
    {
        [TestMethod()]
        public void GetMostExperiencedDirectorName_NoDirectors()
        {
            // Arrange
            SchoolDirectorRepo repo = new SchoolDirectorRepo();

            // Act
            string actual = repo.GetMostExperiencedDirectorName();

            // Assert
            string expected = "Nincs vezető az adatbázisban.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMostExperiencedDirectorName_OneDirector()
        {
            // Arrange
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            repo.Add(new SchoolDirector("Vezető Vilmos", new DateTime(2010, 10, 10), 22, 500000));

            // Act
            string actual = repo.GetMostExperiencedDirectorName();

            // Assert
            string expected = "Vezető Vilmos";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMostExperiencedDirectorName_MultipleDirectors()
        {
            // Arrange
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            repo.Add(new SchoolDirector("Vezető Vilmos", new DateTime(2010, 10, 10), 22, 500000));
            repo.Add(new SchoolDirector("Irányító Ida", new DateTime(2011, 11, 11), 11, 450000));

            // Act
            string actual = repo.GetMostExperiencedDirectorName();

            // Assert
            string expected = "Vezető Vilmos";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMostExperiencedDirectorName_SameExperience()
        {
            // Arrange
            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            repo.Add(new SchoolDirector("Vezető Vilmos", new DateTime(2010, 10, 10), 22, 500000));
            repo.Add(new SchoolDirector("Irányító Ida", new DateTime(2010, 10, 10), 22, 450000));

            // Act
            string actual = repo.GetMostExperiencedDirectorName();

            // Assert
            string expected = "Vezető Vilmos";
            Assert.AreEqual(expected, actual);
        }
    }
}