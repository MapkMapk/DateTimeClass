using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DateTimeLib;
namespace DateTimeLibTest
{
    [TestClass]
    public class DateTimeClassTest
    {
        /// <summary>
        /// Проверка, что дата корректна
        /// </summary>
        [TestMethod]
        public void PrevDate_CorrectDate_PrevDayReturn()
        {
            //Arrange
            DateTime date = new DateTime(2008, 6, 1, 7, 47, 0);
            DateTime expectedPrevDate = new DateTime(2008, 5, 31, 7, 47, 0);
            //Act
            DateTime actualPrevDate = DateTimeClass.PrevDate(date);

            //Assert
            Assert.AreEqual(expectedPrevDate, actualPrevDate);

            
        }
    }
}
