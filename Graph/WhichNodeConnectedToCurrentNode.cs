static void NodeConnection(int[,] a)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);

            int i = 0;
            while (i < r)
            {
                int count = 0;
                for (int j = 0; j < c; j++)
                {
                    if (a[i, j] == 1)
                    {
                        count++;
                        Console.WriteLine("Node " + i + " Connected to Node " + j);
                    }
                }
                i++;
            }
        }
