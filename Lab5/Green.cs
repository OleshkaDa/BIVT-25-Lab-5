using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Green
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here             ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int minIndex = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }
                }
                answer[i] = minIndex;
            }
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {
            // code here
            int stroka = matrix.GetLength(0);
            int stolbec = matrix.GetLength(1);

            for (int i = 0; i < stroka; i++)
            {
                int maxIndex = 0;
                int maxValue = matrix[i, 0];

                for (int j = 1; j < stolbec; j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxIndex = j;
                    }
                }
                for (int j = 0; j < maxIndex; j++)
                {
                    if (matrix[i, j] < 0) 
                    {
                        matrix[i, j] = (int)Math.Floor((double)matrix[i, j] / maxValue);
                    }
                }
            }
            // end
        }
        public void Task3(int[,] matrix, int k)
        {
            // code here
            int n = matrix.GetLength(0);

            if (n != matrix.GetLength(1) || k < 0 || k >= n)
            {
                return;
            }

            int maxDiagonalValue = matrix[0, 0];
            int maxDiagonalColumn = 0;

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > maxDiagonalValue)
                {
                    maxDiagonalValue = matrix[i, i];
                    maxDiagonalColumn = i;
                }
            }
            if (maxDiagonalColumn != k)
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, maxDiagonalColumn];
                    matrix[i, maxDiagonalColumn] = temp;
                }
            }
            // end
        }
        public void Task4(int[,] matrix)
        {
            // code here
            int n = matrix.GetLength(0);

            if (n != matrix.GetLength(1))
            {
                return;
            }

            int maxDiagonalValue = matrix[0, 0];
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > maxDiagonalValue)
                {
                    maxDiagonalValue = matrix[i, i];
                    maxIndex = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i != maxIndex)
                {
                    int temp = matrix[maxIndex, i];
                    matrix[maxIndex, i] = matrix[i, maxIndex];
                    matrix[i, maxIndex] = temp;
                }
            }
            // end
        }
        public int[,] Task5(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int stroka = matrix.GetLength(0);
            int stolbec = matrix.GetLength(1);

            if (stroka == 0 || stolbec == 0)
            {
                answer = new int[0, 0];
                return answer;
            }


            int maxSum = -1;
            int maxSumIndex = 0;

            for (int i = 0; i < stroka; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < stolbec; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        currentSum += matrix[i, j];
                    }
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumIndex = i;
                }
            }


            answer = new int[stroka - 1, stolbec];

            for (int i = 0, newI = 0; i < stroka; i++)
            {
                if (i != maxSumIndex)
                {
                    for (int j = 0; j < stolbec; j++)
                    {
                        answer[newI, j] = matrix[i, j];
                    }
                    newI++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[,] matrix)
        {
            // code here
            int stroka = matrix.GetLength(0);
            int stolbec = matrix.GetLength(1);

            if (stroka == 0) return;

            int[] negativeCounts = new int[stroka];

            for (int i = 0; i < stroka; i++)
            {
                int count = 0;
                for (int j = 0; j < stolbec; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
                negativeCounts[i] = count;
            }

            
            int minIndex = 0;
            int maxIndex = 0;
            int minCount = negativeCounts[0];
            int maxCount = negativeCounts[0];

            for (int i = 1; i < stroka; i++)
            {
                if (negativeCounts[i] < minCount)
                {
                    minCount = negativeCounts[i];
                    minIndex = i;
                }
                if (negativeCounts[i] > maxCount)
                {
                    maxCount = negativeCounts[i];
                    maxIndex = i;
                }
            }

            if (minCount != maxCount)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    int temp = matrix[minIndex, j];
                    matrix[minIndex, j] = matrix[maxIndex, j];
                    matrix[maxIndex, j] = temp;
                }
            }
            // end
        }
        public int[,] Task7(int[,] matrix, int[] array)
        {
            int[,] answer = null;

            // code here             ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА ОШИБКА 
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Находим минимальный элемент и его столбец
            int minValue = matrix[0, 0];
            int minCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                        minCol = j;
                    }
                }
            }

            // Если минимальный элемент в последнем столбце, вставляем после него
            // Если в другом столбце, тоже вставляем после него
            // Размер всегда: rows × (cols + 1)

            answer = new int[rows, cols + 1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols + 1; j++)
                {
                    if (j <= minCol)
                    {
                        answer[i, j] = matrix[i, j];
                    }
                    else if (j == minCol + 1)
                    {
                        answer[i, j] = (i < array.Length) ? array[i] : 0;
                    }
                    else
                    {
                        answer[i, j] = matrix[i, j - 1];
                    }
                }
            }
            // end

            return answer;
        }
        public void Task8(int[,] matrix)
        {
            // code here
            int stroka = matrix.GetLength(0);
            int stolbec = matrix.GetLength(1);

            for (int j = 0; j < stolbec; j++)
            {
                int positiveCount = 0;
                int negativeCount = 0;
                int maxValue = matrix[0, j];
                int maxIndex = 0;

                for (int i = 0; i < stroka; i++)
                {
                    if (matrix[i, j] > 0) positiveCount++;
                    else if (matrix[i, j] < 0) negativeCount++;

                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxIndex = i;
                    }
                }

                if (positiveCount > negativeCount)
                {
                    matrix[maxIndex, j] = 0;
                }
                else if (negativeCount > positiveCount)
                {
                    matrix[maxIndex, j] = maxIndex;
                }
            }
            // end
        }
        public void Task9(int[,] matrix)
        {
            // code here
            int n = matrix.GetLength(0);

            if (n != matrix.GetLength(1)) return;

            for (int i = 0; i < n * n; i++)
            {
                int row = i / n;
                int col = i % n;

                if (row == 0 || row == n - 1 || col == 0 || col == n - 1)
                {
                    matrix[row, col] = 0;
                }
            }
            // end
        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            // code here
            int n = matrix.GetLength(0);

            if (n != matrix.GetLength(1))
            {
                return (A, B); // возвращаем null для неквадратной матрицы
            }

            // Вычисляем размеры массивов
            int sizeA = n * (n + 1) / 2;  // сумма арифметической прогрессии
            int sizeB = n * (n - 1) / 2;

            A = new int[sizeA];
            B = new int[sizeB];

            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i) // Верхний треугольник (включая диагональ)
                    {
                        A[indexA++] = matrix[i, j];
                    }
                    else // Нижний треугольник
                    {
                        B[indexB++] = matrix[i, j];
                    }
                }
            }
            // end

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {
            // code here
            int stroka = matrix.GetLength(0);
            int stolbec = matrix.GetLength(1);

            for (int j = 0; j < stolbec; j++)
            {
                // Собираем элементы столбца в массив
                int[] column = new int[stroka];
                for (int i = 0; i < stroka; i++)
                {
                    column[i] = matrix[i, j];
                }

                // Сортируем по условию
                if (j % 2 == 0) // Четные столбцы - по убыванию
                {
                    Array.Sort(column);
                    Array.Reverse(column);
                }
                else // Нечетные столбцы - по возрастанию
                {
                    Array.Sort(column);
                }

                // Возвращаем отсортированные элементы обратно в столбец
                for (int i = 0; i < stroka; i++)
                {
                    matrix[i, j] = column[i];
                }
            }
            // end
        }
        public void Task12(int[][] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            // Создаем массив для хранения информации о строках
            var rowInfo = new (int length, int sum, int index)[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    int sum = 0;
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        sum += array[i][j];
                    }
                    rowInfo[i] = (array[i].Length, sum, i);
                }
                else
                {
                    rowInfo[i] = (0, 0, i);
                }
            }

            // Сортируем по убыванию количества элементов, затем по убыванию суммы
            Array.Sort(rowInfo, (a, b) =>
            {
                if (a.length != b.length)
                    return b.length.CompareTo(a.length); // по убыванию длины
                else
                    return b.sum.CompareTo(a.sum); // по убыванию суммы
            });

            // Создаем новый отсортированный массив
            int[][] sortedArray = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                sortedArray[i] = array[rowInfo[i].index];
            }

            // Копируем отсортированный массив обратно в исходный
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sortedArray[i];
            }
            // end
        }
    }
}
