using System;

namespace _27_Task
{
    class Program
    {


            private static int[,] matrix =
            { { 1, 3, 2, 2, 2, 4 },
              { 3, 3, 3, 2, 4, 4 },
              { 4, 3, 1, 2, 3, 3 },
              { 4, 3, 1, 3, 3, 1 },
              { 4, 3, 3, 3, 1, 1 } };
        private static List<Tuple<Coords, int>> allAreas =
            new List<Tuple<Coords, int>>();
        private static bool[,] visited;

        struct Coords
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Value { get; set; }
        }

        static void Main(string[] args)
        {
            ProcessInput();
            visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            int maxArea;
            int elementNumber;
            FindLargestArea(out maxArea, out elementNumber);

            Console.WriteLine("Largest area: element = {0}; area length = {1}", elementNumber, maxArea);
        }

        private static void FindLargestArea(out int maxArea, out int elementNumber)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!visited[row, col])
                    {
                        Coords element = new Coords();
                        element.Row = row;
                        element.Col = col;
                        element.Value = matrix[row, col];

                        DFS(element);
                    }
                }
            }

            maxArea = 0;
            elementNumber = int.MinValue;
            foreach (var tuple in allAreas)
            {
                int currentArea = tuple.Item2;
                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                    elementNumber = tuple.Item1.Value;
                }
            }
        }

        private static void DFS(Coords startingPoint)
        {
            Stack<Coords> stack = new Stack<Coords>();
            stack.Push(startingPoint);
            visited[startingPoint.Row, startingPoint.Col] = true;
            int areaLength = 0;
            while (stack.Count > 0)
            {
                Coords currentElement = stack.Pop();
                areaLength++;
                List<Coords> neighbours = GetNeighbours(currentElement.Row, currentElement.Col, currentElement.Value);
                foreach (Coords neighbour in neighbours)
                {
                    if (!visited[neighbour.Row, neighbour.Col])
                    {
                        stack.Push(neighbour);
                        visited[neighbour.Row, neighbour.Col] = true;
                    }
                }
            }
            allAreas.Add(new Tuple<Coords, int>(startingPoint, areaLength));
        }

        private static List<Coords> GetNeighbours(int row, int col, int value)
        {
            List<Coords> neighbours = new List<Coords>();

            if ((InRange(row - 1, col)) && (matrix[row - 1, col] == value))
            {
                Coords neighbour = new Coords();
                neighbour.Row = row - 1;
                neighbour.Col = col;
                neighbour.Value = value;
                neighbours.Add(neighbour);
            }

            if ((InRange(row, col - 1)) && (matrix[row, col - 1] == value))
            {
                Coords neighbour = new Coords();
                neighbour.Row = row;
                neighbour.Col = col - 1;
                neighbour.Value = value;
                neighbours.Add(neighbour);
            }

            if ((InRange(row, col + 1)) && (matrix[row, col + 1] == value))
            {
                Coords neighbour = new Coords();
                neighbour.Row = row;
                neighbour.Col = col + 1;
                neighbour.Value = value;
                neighbours.Add(neighbour);
            }

            if ((InRange(row + 1, col)) && (matrix[row + 1, col] == value))
            {
                Coords neighbour = new Coords();
                neighbour.Row = row + 1;
                neighbour.Col = col;
                neighbour.Value = value;
                neighbours.Add(neighbour);
            }

            return neighbours;
        }

        private static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLength(1);
            return rowInRange && colInRange;
        }

        private static void ProcessInput()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            matrix = new int[cols, rows];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowStr = Console.ReadLine();
                string[] rowElements = rowStr.Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(rowElements[col]);
                }
            }


        }
    }
}

    

