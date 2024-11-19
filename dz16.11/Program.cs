//namespace dz16._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] A = new int[5];
//            double[,] B = new double[3, 4];
//            Console.WriteLine("Введіть 5 цілих чисел для масиву A:");
//            for (int i = 0; i < A.Length; i++)
//            {
//                Console.Write($"A[{i}] = ");
//                A[i] = int.Parse(Console.ReadLine());
//            }
//            Random rand = new Random();
//            Console.WriteLine("\nМасив B (випадкові числа):");
//            for (int i = 0; i < B.GetLength(0); i++)
//            {
//                for (int j = 0; j < B.GetLength(1); j++)
//                {
//                    B[i, j] = Math.Round(rand.NextDouble() * 100, 2); 
//                    Console.Write($"{B[i, j],6} ");
//                }
//                Console.WriteLine();
//            }
//            double maxElement = A[0];
//            double minElement = A[0];
//            double totalSum = 0;
//            double totalProduct = 1;
//            foreach (int num in A)
//            {
//                maxElement = Math.Max(maxElement, num);
//                minElement = Math.Min(minElement, num);
//                totalSum += num;
//                totalProduct *= num;
//            }
//            for (int i = 0; i < B.GetLength(0); i++)
//            {
//                for (int j = 0; j < B.GetLength(1); j++)
//                {
//                    maxElement = Math.Max(maxElement, B[i, j]);
//                    minElement = Math.Min(minElement, B[i, j]);
//                    totalSum += B[i, j];
//                    totalProduct *= B[i, j];
//                }
//            }
//            int evenSumA = 0;
//            foreach (int num in A)
//            {
//                if (num % 2 == 0)
//                    evenSumA += num;
//            }
//            double oddColumnSumB = 0;
//            for (int j = 1; j < B.GetLength(1); j += 2)
//            {
//                for (int i = 0; i < B.GetLength(0); i++)
//                {
//                    oddColumnSumB += B[i, j];
//                }
//            }
//            Console.WriteLine("\nМасив A:");
//            Console.WriteLine(string.Join(" ", A));
//            Console.WriteLine("\nРезультати обчислень:");
//            Console.WriteLine($"Загальний максимальний елемент: {maxElement}");
//            Console.WriteLine($"Загальний мінімальний елемент: {minElement}");
//            Console.WriteLine($"Загальна сума всіх елементів: {totalSum}");
//            Console.WriteLine($"Загальний добуток всіх елементів: {totalProduct}");
//            Console.WriteLine($"Сума парних елементів масиву A: {evenSumA}");
//            Console.WriteLine($"Сума елементів непарних стовпців масиву B: {oddColumnSumB}");

//        }
//    }
//}

//2
//namespace dz16._11
//{
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] array = new int[5, 5];
//        Random rand = new Random();
//        Console.WriteLine("Двовимірний масив 5×5:");
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//                array[i, j] = rand.Next(-100, 101);
//                Console.Write($"{array[i, j],4} ");
//            }
//            Console.WriteLine();
//        }
//        int minValue = array[0, 0], maxValue = array[0, 0];
//        (int minRow, int minCol) = (0, 0);
//        (int maxRow, int maxCol) = (0, 0);

//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//                if (array[i, j] < minValue)
//                {
//                    minValue = array[i, j];
//                    minRow = i;
//                    minCol = j;
//                }
//                if (array[i, j] > maxValue)
//                {
//                    maxValue = array[i, j];
//                    maxRow = i;
//                    maxCol = j;
//                }
//            }
//        }
//        Console.WriteLine($"\nМінімальний елемент: {minValue} (індекси: [{minRow}, {minCol}])");
//        Console.WriteLine($"Максимальний елемент: {maxValue} (індекси: [{maxRow}, {maxCol}])");
//        int sum = 0;
//        bool between = false;
//        if ((minRow < maxRow) || (minRow == maxRow && minCol < maxCol))
//        {
//            for (int i = 0; i < array.GetLength(0); i++)
//            {
//                for (int j = 0; j < array.GetLength(1); j++)
//                {
//                    if (i == minRow && j == minCol)
//                        between = true;

//                    if (between)
//                        sum += array[i, j];

//                    if (i == maxRow && j == maxCol)
//                        between = false;
//                }
//            }
//        }
//        else
//        {
//            for (int i = 0; i < array.GetLength(0); i++)
//            {
//                for (int j = 0; j < array.GetLength(1); j++)
//                {
//                    if (i == maxRow && j == maxCol)
//                        between = true;

//                    if (between)
//                        sum += array[i, j];

//                    if (i == minRow && j == minCol)
//                        between = false;
//                }
//            }
//        }
//        Console.WriteLine($"\nСума елементів між мінімальним і максимальним: {sum}");
//    }
//}

//3 
//namespace dz16._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть текст для шифрування:");
//            string input = Console.ReadLine();
//            Console.WriteLine("Введіть ключ (зсув):");
//            int key = int.Parse(Console.ReadLine());
//            string encryptedText = Encrypt(input, key);
//            Console.WriteLine($"Зашифрований текст: {encryptedText}");
//            string decryptedText = Decrypt(encryptedText, key);
//            Console.WriteLine($"Розшифрований текст: {decryptedText}");
//        }
//        static string Encrypt(string text, int shift)
//        {
//            return CaesarShift(text, shift);
//        }
//        static string Decrypt(string text, int shift)
//        {
//            return CaesarShift(text, -shift);
//        }
//        static string CaesarShift(string text, int shift)
//        {
//            char[] buffer = text.ToCharArray();

//            for (int i = 0; i < buffer.Length; i++)
//            {
//                char letter = buffer[i];
//                if (char.IsLetter(letter))
//                {
//                    char offset = char.IsUpper(letter) ? 'A' : 'a';
//                    letter = (char)(((letter + shift - offset + 26) % 26) + offset);
//                }
//                buffer[i] = letter; 
//            }
//            return new string(buffer);

//        }
//    }
//}

//4
//namespace dz16._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Операції над матрицями");
//            Console.WriteLine("Введіть розміри матриць (рядки і стовпці):");
//            int rows = int.Parse(Console.ReadLine());
//            int cols = int.Parse(Console.ReadLine());
//            Console.WriteLine("\nМатриця A:");
//            double[,] matrixA = InputMatrix(rows, cols);
//            Console.WriteLine("\nМатриця B:");
//            double[,] matrixB = InputMatrix(rows, cols);
//            Console.WriteLine("\nВведіть число для множення:");
//            double scalar = double.Parse(Console.ReadLine());
//            Console.WriteLine("\nРезультат множення матриці A на число:");
//            PrintMatrix(MultiplyMatrixByScalar(matrixA, scalar));
//            Console.WriteLine("\nРезультат додавання матриць A + B:");
//            double[,] sumMatrix = AddMatrices(matrixA, matrixB);
//            if (sumMatrix != null) PrintMatrix(sumMatrix);
//            Console.WriteLine("\nРезультат добутку матриць A * B:");
//            double[,] productMatrix = MultiplyMatrices(matrixA, matrixB);
//            if (productMatrix != null) PrintMatrix(productMatrix);
//        }
//        static double[,] InputMatrix(int rows, int cols)
//        {
//            double[,] matrix = new double[rows, cols];
//            for (int i = 0; i < rows; i++)
//            {
//                Console.WriteLine($"Введіть елементи {i + 1}-го рядка (через пробіл):");
//                string[] input = Console.ReadLine().Split(' ');
//                for (int j = 0; j < cols; j++)
//                {
//                    matrix[i, j] = double.Parse(input[j]);
//                }
//            }
//            return matrix;
//        }
//        static double[,] MultiplyMatrixByScalar(double[,] matrix, double scalar)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);
//            double[,] result = new double[rows, cols];

//            for (int i = 0; i < rows; i++)
//                for (int j = 0; j < cols; j++)
//                    result[i, j] = matrix[i, j] * scalar;

//            return result;
//        }
//        static double[,] AddMatrices(double[,] matrixA, double[,] matrixB)
//        {
//            if (matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1))
//            {
//                Console.WriteLine("Матриці повинні мати однакові розміри для додавання.");
//                return null;
//            }
//            int rows = matrixA.GetLength(0);
//            int cols = matrixA.GetLength(1);
//            double[,] result = new double[rows, cols];

//            for (int i = 0; i < rows; i++)
//                for (int j = 0; j < cols; j++)
//                    result[i, j] = matrixA[i, j] + matrixB[i, j];

//            return result;
//        }
//        static double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
//        {
//            if (matrixA.GetLength(1) != matrixB.GetLength(0))
//            {
//                Console.WriteLine("Кількість стовпців матриці A повинна дорівнювати кількості рядків матриці B.");
//                return null;
//            }
//            int rowsA = matrixA.GetLength(0);
//            int colsA = matrixA.GetLength(1);
//            int colsB = matrixB.GetLength(1);

//            double[,] result = new double[rowsA, colsB];

//            for (int i = 0; i < rowsA; i++)
//            {
//                for (int j = 0; j < colsB; j++)
//                {
//                    result[i, j] = 0;
//                    for (int k = 0; k < colsA; k++)
//                    {
//                        result[i, j] += matrixA[i, k] * matrixB[k, j];
//                    }
//                }
//            }

//            return result;
//        }
//        static void PrintMatrix(double[,] matrix)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);

//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write($"{matrix[i, j],6:F2} ");
//                }
//                Console.WriteLine();

//            }
//        }
//    }
//}

//5
//namespace dz16._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть арифметичний вираз (лише + та -):");
//            string input = Console.ReadLine();
//            try
//            {
//                double result = EvaluateExpression(input);
//                Console.WriteLine($"Результат: {result}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Помилка: {ex.Message}");
//            }
//        }
//        static double EvaluateExpression(string expression)
//        {
//            expression = expression.Replace(" ", "");
//            string[] numbers = expression.Split(new[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
//            char[] operators = GetOperators(expression);
//            if (numbers.Length == 0)
//                throw new Exception("Невірний формат виразу.");
//            double result = double.Parse(numbers[0]);
//            for (int i = 1; i < numbers.Length; i++)
//            {
//                double currentNumber = double.Parse(numbers[i]);
//                if (operators[i - 1] == '+')
//                    result += currentNumber;
//                else if (operators[i - 1] == '-')
//                    result -= currentNumber;
//            }
//            return result;
//        }
//        static char[] GetOperators(string expression)
//        {
//            return Array.FindAll(expression.ToCharArray(), c => c == '+' || c == '-');
//        }
//    }

//}
//6
//namespace dz16._11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть текст:");
//            string input = Console.ReadLine();
//            string result = CapitalizeFirstLetterOfSentences(input);
//            Console.WriteLine("\nРезультат:");
//            Console.WriteLine(result);
//        }
//        static string CapitalizeFirstLetterOfSentences(string text)
//        {
//            char[] sentenceEndings = { '.', '!', '?' };
//            char[] characters = text.ToCharArray();
//            bool capitalizeNext = true;
//            for (int i = 0; i < characters.Length; i++)
//            {
//                if (capitalizeNext && char.IsLetter(characters[i]))
//                {
//                    characters[i] = char.ToUpper(characters[i]);
//                    capitalizeNext = false;
//                }
//                if (Array.Exists(sentenceEndings, e => e == characters[i]))
//                {
//                    capitalizeNext = true;
//                }
//            }
//            return new string(characters);


//        }
//    }
//}
//7
namespace dz16._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть текст:");
            string inputText = Console.ReadLine();
            Console.WriteLine("Введіть неприпустиме слово:");
            string forbiddenWord = Console.ReadLine();
            string censoredText = CensorText(inputText, forbiddenWord, out int replacementCount);
            Console.WriteLine("\nРезультат:");
            Console.WriteLine(censoredText);
            Console.WriteLine($"\nСтатистика: {replacementCount} заміни слова \"{forbiddenWord}\"");
        }
        static string CensorText(string text, string forbiddenWord, out int replacementCount)
        {
            replacementCount = 0;
            string censoredWord = new string('*', forbiddenWord.Length);
            string[] words = text.Split(' ', '\n', '\r', '\t', ',', '.', ';', ':', '?', '!', '\'', '"', '(', ')');
            string resultText = text;
            foreach (string word in words)
            {
                if (string.Equals(word, forbiddenWord, StringComparison.OrdinalIgnoreCase))
                {
                    resultText = resultText.Replace(word, censoredWord);
                    replacementCount++;
                }
            }

            return resultText;
        }
    }

}
    

