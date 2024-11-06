using System.Text;

namespace ClassLibrary1
{
    public class Matrix
    {
        private double[,] data; // Закрытое поле - матрица вещественных чисел

        public int Rows { get; private set; } // Свойство для количества строк
        public int Cols { get; private set; } // Свойство для количества столбцов

        // Индексатор для доступа к элементам матрицы
        public double this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        // Конструктор с двумя параметрами - количество строк и столбцов
        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            data = new double[rows, cols];
        }

        // Конструктор с одним параметром - существующая матрица
        public Matrix(double[,] data)
        {
            this.data = data;
            Rows = data.GetLength(0);
            Cols = data.GetLength(1);
        }

        // Метод для вычисления суммы квадратов элементов, больших заданного числа
        public double SumSquaresGreaterThan(double threshold)
        {
            double sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (data[i, j] > threshold)
                    {
                        sum += data[i, j] * data[i, j];
                    }
                }
            }
            return sum;
        }

        // Метод для вычисления суммы квадратов элементов после заданного элемента
        public double SumSquaresAfterElement(int row, int col)
        {
            double sum = 0;
            for (int i = row; i < Rows; i++)
            {
                for (int j = (i == row ? col + 1 : 0); j < Cols; j++)
                {
                    sum += data[i, j] * data[i, j];
                }
            }
            return sum;
        }
    }

}
