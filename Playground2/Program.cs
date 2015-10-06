namespace Playground2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "foo", "bar", "baz", "pqr", "ABC" };
            StringProblems.Quicksort(strings);
            //Random r = new Random();

            //int data = r.Next(1, 10);
            //Console.WriteLine(data);
            //TreeNode2<int> root = new TreeNode2<int>(data);
            //for(int i = 1; i < 10; i++)
            //{
            //    data = r.Next(1, 10);
            //    Console.WriteLine(data);
            //    root.Insert(data);
            //}

            //root.PrintTree();
            //root.PrintAllPaths();
            //int[] array = { 1, 2, 3, 4 };

            //List<List<int>> subsets = FindAllSubsets(array);
            //foreach (var subset in subsets)
            //{
            //    Console.WriteLine("[{0}]", string.Join(",", subset));
            //}

            //List<List<int>> permutation = FindAllPermutations(array);
            //Console.WriteLine(permutation.Count);

            // var res = IsBinaryRepresentationPalindrome(9);

            //            string matrixStr = @"
            //1 1 1 1 1 
            //S 1 X 1 1 
            //1 1 1 1 1 
            //X 1 1 1 1 
            //1 1 1 1 E 
            //";

            //            var res = FindSmallestPath(matrixStr);

            //            string matrixStr = @"
            //S N B S N 
            //B A K E A 
            //B K B B K 
            //S E B S E 
            //";
            //            string testString = "SNAKES";
            //            int res = FindNumOccurrences(matrixStr, testString);

            //int[] array = new int[8];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = -1;
            //}

            //int res = 0;
            //SolveEightQueenProblem(array, 0, ref res);

            //TreeNode root = new TreeNode(1);
            //TreeNode v2 = new TreeNode(2);
            //TreeNode v3 = new TreeNode(3);
            //TreeNode v4 = new TreeNode(4);

            //TreeNode v5 = new TreeNode(5);
            //TreeNode v6 = new TreeNode(6);
            //TreeNode v7 = new TreeNode(7);

            //root.Left = v2;
            //root.Right = v3;
            //v3.Left = v4;
            //v3.Right = v5;
            //v4.Left = v6;
            //v4.Right = v7;

            //v2.Left = new TreeNode(8);

            //TreeNode.PrintVertically(root);

            //HashSet<string> dictionary = new HashSet<string>
            //    {
            //        "mobile", "samsung", "sam", "sung", "man", "mango", "icecream", "and", "i",
            //        "like", "ice", "cream"
            //    };

            //// WordBreakUsingBackTracking("samsungandmango", dictionary);
            //WordBreakUsingDynamicProgramming("samsungandmango", dictionary);
            // bool res = TreeNode.DoesPathWithHeightKExist(root, 3);

            // var result = TreeNode.GetTreeNodesAtKthLevel(root, 2);

            //string ipAddress = "25525511135";

            //RestoreIpAddresses(ipAddress);

            // Console.WriteLine(result.Count);
            // Console.WriteLine(res);

            //while (true)
            //{
            //    int columnNumber = Convert.ToInt32(Console.ReadLine());
            //    if (columnNumber == 0)
            //    {
            //        break;
            //    }

            //    string result = NumberToExcelColumn(columnNumber);
            //    Console.WriteLine(result);
            //}

            //int[] input = { 22, 4, 6, 0, 9, 12, 156, 86, 99 };

            //MergeSort(input, 0, input.Length - 1);

            //Console.WriteLine(string.Join(" ", input));


            //string encodedStr = "101";

            //Dictionary<string, char> codeToCharMap = new Dictionary<string, char>();

            //for (int i = 0; i < 26; i++)
            //{
            //    char value = (char)('A' + i);
            //    codeToCharMap.Add((i + 1).ToString(CultureInfo.InvariantCulture), value);
            //}

            //Queue<char> result = new Queue<char>();
            //PrintAllDecodings(encodedStr, codeToCharMap, result);

            //using (StreamReader sr = new StreamReader(@"C:\Users\mukundsh\Downloads\D-small-practice.in"))
            //{
            //    string text = sr.ReadLine();
            //    int testCases = int.Parse(text);
            //    for (int i = 0; i < testCases; i++)
            //    {
            //        text = sr.ReadLine();
            //        string[] parts = text.Split(' ');
            //        int n = int.Parse(parts[0]);
            //        int k = int.Parse(parts[1]);
            //        Console.Write("Case #{0}: ", i + 1);
            //        PrintKthBalancedParatheses(n, k);
            //    }
            //}

            //int n = 2;
            //double precision = Math.Pow(10, -4);
            //double sqrtN = Sqrt(n, precision);

            //Console.WriteLine(sqrtN);

            //int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            //List<int> result = ArrayProblems.FindUniqueElementsFromSortedArray(arr);

            //Console.WriteLine(string.Join(",", result));

            int[] arr = new int[15];

            for (int i = 0; i < 15; i++)
            {
                arr[i] = i + 1;
            }

            //TreeNode root = TreeNode.BuildBalancedTreeFromSortedArray(arr);
            //TreeNode root =new TreeNode(1);
            //root.Left = new TreeNode(2);
            //root.Right = new TreeNode(3);
            //root.Left.Left = new TreeNode(4);
            //root.Right.Left = new TreeNode(5);
            //root.Right.Left.Right = new TreeNode(6);
            //TreeNode.PrintRightViewOfTree(root);
            Console.ReadLine();
        }

        private static double Sqrt(int n, double precision)
        {
            double start = 1;
            double end = n;
            double candidate;
            double previousAnswer = 0;
            double candidateSq;
            while (true)
            {
                candidate = (start + end) / 2;
                candidateSq = candidate * candidate;
                if (Math.Abs(previousAnswer - candidateSq) < precision)
                {
                    break;
                }

                previousAnswer = candidateSq;
                if (candidateSq < n)
                {
                    start = candidate;
                }
                else
                {
                    end = candidate;
                }
            }

            return candidate;
        }

        private static void PrintKthBalancedParatheses(int n, int k)
        {
            int totalPossibleSolutions = nCr(2 * n, n) / (n + 1);

            if (k > totalPossibleSolutions)
            {
                Console.WriteLine("Doesn't exist!");
            }

            int current = 0;
            string solution = "";
            PrintKthBalancedParatheses(n, k, solution, ref current);
        }

        private static int nCr(int n, int r)
        {
            if (r == 0)
            {
                return 1;
            }

            if (n == r)
            {
                return 1;
            }

            return nCr(n - 1, r) + nCr(n - 1, r - 1);
        }

        private static void PrintKthBalancedParatheses(int n, int k, string solution, ref int current)
        {
            if (current == k)
            {
                return;
            }

            if (solution.Length == 2 * n)
            {
                current++;
                //Console.WriteLine(solution);  
                if (current == k)
                {
                    Console.WriteLine(solution);  
                }

                return;
            }

            int openCount = solution.Count(s => s == '(');
            int closedCount = solution.Length - openCount;

            if (openCount == closedCount)
            {
                PrintKthBalancedParatheses(n, k, solution + '(', ref current);
            }
            else if (openCount > closedCount)
            {
                if (openCount < n)
                {
                    PrintKthBalancedParatheses(n, k, solution + '(', ref current);
                }

                PrintKthBalancedParatheses(n, k, solution + ')', ref current);
            }
        }

        private static void PrintAllDecodings(string encodedStr, Dictionary<string, char> codeToCharMap, Queue<char> result)
        {
            if (string.IsNullOrEmpty(encodedStr))
            {
                PrintDecoding(result);
                return;
            }

            foreach (string possibleStart in PossibleStarts(encodedStr))
            {
                result.Enqueue(codeToCharMap[possibleStart]);
                
                PrintAllDecodings(encodedStr.Substring(possibleStart.Length), codeToCharMap, result);

                result.Dequeue();
            }
        }

        private static IEnumerable<string> PossibleStarts(string encodedStr)
        {
            if (encodedStr.Length == 1)
            {
                yield return encodedStr;
                yield break;
            }

            if (encodedStr[1] == '0')
            {
                yield return encodedStr.Substring(0, 2);
            }
            else
            {
                if (encodedStr[1] <= '6' && encodedStr[1] >= '1' && encodedStr[0] >= '1' && encodedStr[0] <= '2')
                {
                    yield return encodedStr.Substring(0, 1);
                    yield return encodedStr.Substring(0, 2);
                }
                else
                {
                    yield return encodedStr.Substring(0, 1);
                }
            }
        }

        private static void PrintDecoding(Queue<char> result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in result)
            {
                sb.Append(c);
            }

            Console.WriteLine(sb);
        }

        private static void WordBreakUsingDynamicProgramming(string testString, HashSet<string> dictionary)
        {
            bool[] dpAnswer = new bool[testString.Length + 1];

            dpAnswer[0] = false;

            for (int i = 1; i <= testString.Length; i++)
            {
                string substr = testString.Substring(0, i);

                if (dictionary.Contains(substr))
                {
                    dpAnswer[i] = true;
                }

                for (int j = 0; j < i; j++)
                {
                    string substring = testString.Substring(j, i - j);
                    dpAnswer[i] |= dpAnswer[j] && dictionary.Contains(substring);
                }
            }

            for (int i = 1; i < dpAnswer.Length; i++)
            {
                Console.WriteLine("{0} {1}", dpAnswer[i], testString.Substring(0, i));
            }
        }

        private static void WordBreakUsingBackTracking(string testString, HashSet<string> dictionary)
        {
            List<string> brokenWords = new List<string>();

            bool isPossible = WordBreakUsingBackTracking(brokenWords, testString, dictionary);

            if (isPossible)
            {
                Console.WriteLine(string.Join(" ", brokenWords));
            }
        }

        private static bool WordBreakUsingBackTracking(List<string> brokenWords, string testString, HashSet<string> dictionary)
        {
            if (testString.Length == 0)
            {
                return true;
            }

            for (int i = 0; i < testString.Length; i++)
            {
                string substring = testString.Substring(0, i + 1);
                if (dictionary.Contains(substring))
                {
                    brokenWords.Add(substring);
                    bool res = WordBreakUsingBackTracking(brokenWords, testString.Substring(i + 1), dictionary);

                    if (res)
                    {
                        return res;
                    }
                    
                    brokenWords.Remove(substring);
                }
            }

            return false;
        }

        private static string NumberToExcelColumn(int columnNumber)
        {
            // A - 1, Z - 26, AA - 27 = (26*1 + 1)
            Stack<char> values = new Stack<char>();
            while (columnNumber != 0)
            {
                int mod = columnNumber % 26;
                if (mod == 0)
                {
                    values.Push('Z');
                    columnNumber = columnNumber / 26  -1;
                }
                else
                {
                    values.Push((char)('A' + mod - 1));
                    columnNumber = columnNumber / 26;
                }
            }

            string result = "";
            while (values.Count != 0)
            {
                result = result + values.Pop();
            }

            return result;
        }

        private static void RestoreIpAddresses(string ipAddress)
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = i + 1; j < i + 4; j++)
                {
                    for (int k = j + 1; k < j + 4; k++)
                    {
                        string s0 = ipAddress.Substring(0, i);
                        string s1 = ipAddress.Substring(i, j - i);
                        string s2 = ipAddress.Substring(j, k - j);
                        string s3 = ipAddress.Substring(k);
                        if (IsIpAddressValid(new string[] { s0, s1, s2, s3 }))
                        {
                            Console.WriteLine("{0}.{1}.{2}.{3}", s0, s1, s2, s3);
                        }
                    }
                }
            }
        }

        private static bool IsIpAddressValid(string[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length >= 4)
                {
                    return false;
                }

                int value = Convert.ToInt32(parts[i]);

                if (value < 0 || value > 255)
                {
                    return false;
                }
            }

            return true;
        }

        private static void SolveEightQueenProblem(int[] array, int index, ref int res)
        {
            foreach (int nextMove in NextValidQueenMove(array, index))
            {
                if (IsFinalState(array))
                {
                    array[index] = nextMove;
                    res++;
                    PrintEightQueenAnswer(array);
                    array[index] = -1;
                    continue;
                }

                array[index] = nextMove;
                SolveEightQueenProblem(array, index + 1, ref res);
                array[index] = -1;
            }
        }

        private static void PrintEightQueenAnswer(int[] array)
        {
            Console.WriteLine("8 queen solution:");
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine();
        }

        private static bool IsFinalState(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        private static IEnumerable<int> NextValidQueenMove(int[] array, int proposedRow)
        {
            if (proposedRow == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    yield return i; 
                }
            }
            else
            {
                for (int proposedColumn = 0; proposedColumn < 8; proposedColumn++)
                {
                    bool isSafe = true;
                    for (int occupiedRow = 0; occupiedRow < proposedRow; occupiedRow++)
                    {
                        if (!IsSafeQueenPosition(array, occupiedRow, proposedRow, proposedColumn))
                        {
                            isSafe = false;
                            break;
                        }
                    }

                    if (isSafe)
                    {
                        yield return proposedColumn;
                    }
                }
            }
        }

        private static bool IsSafeQueenPosition(int[] array, int occupiedRow, int proposedRow, int proposedColumn)
        {
            if (proposedColumn == array[occupiedRow])
            {
                return false;
            }

            if (Math.Abs(occupiedRow - proposedRow) == Math.Abs(array[occupiedRow] - proposedColumn))
            {
                return false;
            }

            return true;
        }

        private static int FindNumOccurrences(string matrixStr, string testString)
        {
            int columnCount;
            char[,] matrix;
            var rowCount = PopulateMatrix(matrixStr, out columnCount, out matrix);

            char startingChar = testString[0];
            List<Tuple<int, int>> possibleStartIndices = GetPossibleStartIndices(
                matrix, rowCount, columnCount, startingChar);

            int total = 0;
            foreach (var possibleStartIndex in possibleStartIndices)
            {
                total += CountOccurrences(matrix, testString.Substring(1), possibleStartIndex, rowCount, columnCount);
            }

            return total;
        }

        private static int CountOccurrences(
            char[,] matrix, string testString, Tuple<int, int> startIndex, int rowCount, int columnCount)
        {
            bool [,] visited = new bool[rowCount, columnCount];

            SetVisited(visited, startIndex.Item1, startIndex.Item2);

            int res = 0;
            CountOccurrences(matrix, testString, startIndex, rowCount, columnCount, visited, ref res);

            visited[startIndex.Item1, startIndex.Item2] = false;

            return res;
        }

        private static void CountOccurrences(
            char[,] matrix,
            string testString,
            Tuple<int, int> possibleStartIndex,
            int rowCount,
            int columnCount,
            bool[,] visited,
            ref int res)
        {
            foreach (var validNextMove in ValidNextMoves(possibleStartIndex, matrix, rowCount, columnCount, testString[0], visited))
            {
                if (IsFinal(matrix, validNextMove, testString))
                {
                    SetVisited(visited, validNextMove.Item1, validNextMove.Item2);
                    PrintAnswer(matrix, visited, rowCount, columnCount);
                    res++;
                    visited[validNextMove.Item1, validNextMove.Item2] = false;
                    continue;
                }

                SetVisited(visited, validNextMove.Item1, validNextMove.Item2);
                CountOccurrences(matrix, testString.Substring(1), validNextMove, rowCount, columnCount, visited, ref res);

                visited[validNextMove.Item1, validNextMove.Item2] = false;
            }
        }

        private static void SetVisited(bool[,] visited, int x, int y)
        {
            visited[x, y] = true;
        }

        private static void PrintAnswer(char[,] matrix, bool[,] visited, int rowCount, int columnCount)
        {
            Console.WriteLine("ANSWER:");
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (visited[i, j])
                    {
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static bool IsFinal(char[,] matrix, Tuple<int, int> nextIndex, string testString)
        {
            if (testString.Length == 1 && matrix[nextIndex.Item1, nextIndex.Item2] == testString[0])
            {
                return true;
            }

            return false;
        }

        private static IEnumerable<Tuple<int, int>> ValidNextMoves(
            Tuple<int, int> startIndex, char[,] matrix, int rowCount, int columnCount, char nextChar, bool[,] visited)
        {
            List<Tuple<int, int>> possibleNextMoves = 
                new List<Tuple<int, int>>()
                {
                    new Tuple<int, int>(1, 0),
                    new Tuple<int, int>(-1, 0),
                    new Tuple<int, int>(0, 1),
                    new Tuple<int, int>(0, -1)
                };

            foreach (var possibleNextMove in possibleNextMoves)
            {
                Tuple<int, int> nextIndex = new Tuple<int, int>(
                    startIndex.Item1 + possibleNextMove.Item1, startIndex.Item2 + possibleNextMove.Item2);

                if (nextIndex.Item1 >= 0 && nextIndex.Item1 < rowCount && nextIndex.Item2 >= 0
                    && nextIndex.Item2 < columnCount)
                {
                    if (matrix[nextIndex.Item1, nextIndex.Item2] == nextChar
                        && !visited[nextIndex.Item1, nextIndex.Item2])
                    {
                        yield return nextIndex;
                    }
                }
            }
        }

        private static List<Tuple<int, int>> GetPossibleStartIndices(char[,] matrix, int rowCount, int columnCount, char startingChar)
        {
            List<Tuple<int, int>> possibleStartIndices = new List<Tuple<int, int>>();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (matrix[i, j] == startingChar)
                    {
                        possibleStartIndices.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return possibleStartIndices;
        }

        private static int FindSmallestPath(string matrixStr)
        {
            int columnCount;
            char[,] matrix;
            var rowCount = PopulateMatrix(matrixStr, out columnCount, out matrix);

            int startX = -1, startY = -1;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (matrix[i, j] == 'S')
                    {
                        startX = i;
                        startY = j;
                        break;
                    }
                }
            }

            int [,] minDistances = new int[rowCount, columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    minDistances[i, j] = int.MaxValue;
                }
            }

            minDistances[startX, startY] = 0;

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

            return BFS(matrix, rowCount, columnCount, minDistances, startX, startY, queue);
        }

        private static int PopulateMatrix(string matrixStr, out int columnCount, out char[,] matrix)
        {
            string[] lines = matrixStr.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] parts = lines[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = lines.Length;
            columnCount = parts.Length;
            matrix = new char[rowCount, columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                parts = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = parts[j].First();
                }
            }

            return rowCount;
        }

        private static int BFS(
            char[,] matrix,
            int rowCount,
            int columnCount,
            int[,] minDistances,
            int startX,
            int startY,
            Queue<Tuple<int, int>> queue)
        {
            if ((startX + 1) < columnCount && matrix[startX + 1, startY] != 'X')
            {
                minDistances[startX + 1, startY] = 1 + minDistances[startX, startY];
                queue.Enqueue(new Tuple<int, int>(startX + 1, startY));
            }

            if ((startX - 1) > 0 && matrix[startX - 1, startY] != 'X')
            {
                minDistances[startX - 1, startY] = 1 + minDistances[startX, startY];
                queue.Enqueue(new Tuple<int, int>(startX - 1, startY));
            }

            if ((startY + 1) < rowCount && matrix[startX, startY + 1] != 'X')
            {
                minDistances[startX, startY + 1] = 1 + minDistances[startX, startY];
                queue.Enqueue(new Tuple<int, int>(startX, startY + 1));
            }

            if ((startY - 1) > 0 && matrix[startX, startY - 1] != 'X')
            {
                minDistances[startX, startY - 1] = 1 + minDistances[startX, startY];
                queue.Enqueue(new Tuple<int, int>(startX, startY - 1));
            }

            while (true)
            {
                if (queue.Count == 0)
                {
                    return int.MaxValue;
                }

                var t = queue.Dequeue();

                if (matrix[t.Item1, t.Item2] == 'E')
                {
                    return minDistances[t.Item1, t.Item2];
                }

                if (minDistances[t.Item1, t.Item2] != int.MaxValue)
                {
                    return BFS(matrix, rowCount, columnCount, minDistances, t.Item1, t.Item2, queue);
                }
            }
        }

        private static List<List<int>> FindAllPermutations(int[] array)
        {
            List<List<int>> currentPermutations = new List<List<int>>();
            List<List<int>> newPermutations = new List<List<int>>();

            if (array.Length == 0)
            {
                return currentPermutations;
            }

            currentPermutations.Add(new List<int>(){ array[0] });

            for (int k = 1; k < array.Length; k++)
            {
                int item = array[k];

                foreach (var currentPermutation in currentPermutations)
                {
                    for (int i = 0; i <= currentPermutation.Count; i++)
                    {
                        List<int> newPerm = new List<int>(currentPermutation);
                        newPerm.Insert(i, item);

                        newPermutations.Add(newPerm);
                    }
                }

                currentPermutations.Clear();
                currentPermutations.AddRange(newPermutations);
                newPermutations.Clear();
            }

            return currentPermutations;
        }

        private static List<List<int>> FindAllSubsets(int[] array)
        {
            List<List<int>> subsets = new List<List<int>>();
            long numSubsets = (long)Math.Pow(2, array.Length);

            for (int i = 0; i < numSubsets; i++)
            {
                List<int> aSubset = new List<int>();
                for (int j = 0; j < array.Length; j++)
                {
                    // check if jth bit of i is 1
                    if ((1 << j & i) != 0)
                    {
                        aSubset.Add(array[j]);
                    }
                }

                subsets.Add(aSubset);
            }

            return subsets;
        }

        public static bool IsBinaryRepresentationPalindrome(int number)
        {
            int digits = 0;

            if (number == 0)
            {
                digits = 1;
            }

            int originalNumber = number;

            while (number != 0)
            {
                number = number >> 1;
                digits++;
            }

            bool[] binaryRepresentationArray = new bool[digits];
            for (int i = 0; i < digits; i++)
            {
                if (originalNumber % 2 == 1)
                {
                    binaryRepresentationArray[i] = true;
                }

                originalNumber = originalNumber / 2;
            }

            int start = 0;
            int end = digits - 1;

            for (; start <= end; start++, end--)
            {
                if (binaryRepresentationArray[start] != binaryRepresentationArray[end])
                {
                    return false;
                }
            }

            return true;
        }

        public static void MergeSort(int[] input, int startIndex, int endIndex)
        {
            int mid;

            if (endIndex > startIndex)
            {
                mid = (endIndex + startIndex) / 2;
                MergeSort(input, startIndex, mid);
                MergeSort(input, mid + 1, endIndex);
                Merge(input, startIndex, mid + 1, endIndex);
            }
        }

        private static void Merge(int[] input, int left, int mid, int right)
        {
            int lengthOfInput = right - left + 1;
            int[] temp = new int[lengthOfInput];
            int i, leftEnd, currentPosition;
            leftEnd = mid - 1;
            currentPosition = left;
            
            while ((left <= leftEnd) && (mid <= right))
            {
                if (input[left] <= input[mid])
                {
                    temp[currentPosition++] = input[left++];
                }
                else
                {
                    temp[currentPosition++] = input[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[currentPosition++] = input[left++];
            }

            while (mid <= right)
            {
                temp[currentPosition++] = input[mid++];
            }

            for (i = 0; i < lengthOfInput; i++)
            {
                input[right] = temp[right];
                right--;
            }
        }
    }
}
