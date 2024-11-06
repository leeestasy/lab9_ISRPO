using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Matrix matTesting;

        // Конструктор программы
        public UnitTest1()
        {
            run();
        }
        // Метод запуска программы
        public void run()
        {
            RowsTest1();
            RowsTest2();
            ColsTest1();
            ColsTest2();
            SumSquaresGreaterThanTest1();
            SumSquaresGreaterThanTest2();
            SumSquaresAfterElementTest1();
            SumSquaresAfterElementTest2();
        }
        [TestMethod]
        // Тест проверки количества строк в матрице - первый случай
        public void RowsTest1()
        {
            double[,] rowTest1 = new double[,] { { 41, 8, 3, 15 }, { 16, 32, 2, 10 } }; //объявление матрицы
            int rezult = 0;
            matTesting = new Matrix(rowTest1); //инициализация переменной новым экземпляром Matrix с передачей матрицы
            rezult = matTesting.Rows;
            Assert.AreEqual(2, rezult);
        }
        [TestMethod]
        // Тест проверки количества строк в матрице - второй случай
        public void RowsTest2()
        {
            double[,] rowTest2 = new double[,] { { 5 } };
            double rezult = 0;
            matTesting = new Matrix(rowTest2);
            rezult = matTesting.Rows;
            Assert.AreEqual(1, rezult);
        }
        [TestMethod]
        // Тест проверки количества столбцов в матрице - первый случай
        public void ColsTest1()
        {
            double[,] colTest1 = new double[,] { { 41, 8, 3, 15 }, { 16, 32, 2, 10 } };
            double rezult = 0;
            matTesting = new Matrix(colTest1);
            rezult = matTesting.Cols;
            Assert.AreEqual(4, rezult);
        }
        [TestMethod]
        // Тест проверки количества столбцов в матрице - второй случай
        public void ColsTest2()
        {
            double[,] colTest2 = new double[,] { { 5 } };
            double rezult = 0;
            matTesting = new Matrix(colTest2);
            rezult = matTesting.Cols;
            Assert.AreEqual(1, rezult);
        }
        [TestMethod]
        // Тест вычисления суммы квадратов элементов, больших заданного числа - первый случай
        public void SumSquaresGreaterThanTest1()
        {
            double[,] sumSquaresGreaterThanTest1 = new double[,] { { 41, 8, 3, 15 } };
            double rezult = 0;
            matTesting = new Matrix(sumSquaresGreaterThanTest1);
            rezult = matTesting.SumSquaresGreaterThan(14);
            Assert.AreEqual(1906, rezult);
        }
        [TestMethod]
        // Тест вычисления суммы квадратов элементов, больших заданного числа - первый случай
        public void SumSquaresGreaterThanTest2()
        {
            double[,] sumSquaresGreaterThanTest2 = new double[,] { { 5 } };
            double rezult = 0;
            matTesting = new Matrix(sumSquaresGreaterThanTest2);
            rezult = matTesting.SumSquaresGreaterThan(7);
            Assert.AreEqual(0, rezult);
        }
        [TestMethod]
        // Тест вычисления суммы квадратов элементов после заданного элемента (параметры – номер строки и номер столбца) - первый случай
        public void SumSquaresAfterElementTest1()
        {
            double[,] sumSquaresAfterElementTest1 = new double[,] { { 41, 8, 3, 15 } };
            double rezult = 0;
            matTesting = new Matrix(sumSquaresAfterElementTest1);
            rezult = matTesting.SumSquaresAfterElement(1, 1);
            Assert.AreEqual(0, rezult);
        }
        [TestMethod]
        // Тест вычисления суммы квадратов элементов после заданного элемента (параметры – номер строки и номер столбца) - второй случай
        public void SumSquaresAfterElementTest2()
        {
            double[,] sumSquaresAfterElementTest2 = new double[,] { { 41, 8, 3, 15 } };
            double rezult = 0;
            matTesting = new Matrix(sumSquaresAfterElementTest2);
            rezult = matTesting.SumSquaresAfterElement(1, 2);
            Assert.AreEqual(0, rezult);
        }
        // Главный метод программы
        public static void Main()
        {
            UnitTest1 test = new UnitTest1();
        }
    }
}