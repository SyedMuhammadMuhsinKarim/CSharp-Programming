static void NomberOfNodeIsConnected(int[,] a)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int[] arr = new int[r];

            int i = 0;
            while (i < r)
            {
                int count = 0;
                for (int j = 0; j < c; j++)
                {
                    if (a[i, j] == 1)
                    {
                        count++;
                        arr[i] = count;
                    }
                }
                i++;
            }
            Console.WriteLine();
            for (int k = 0; k < r; k++)
            {
                Console.WriteLine("Node {0} connected to {1} nodes", k, arr[k]);
            }
        }
