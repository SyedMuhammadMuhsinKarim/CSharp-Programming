/* FIND NUMBER OF EDGES BETWEEN VERTICES IN GRAPH (MATRIX ADGENCY)
 * Input: 2D Matrix (ARRAY);
 * Output: No of Edges Conected Between two vertices 
 */
static int GraphEdge(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[j, i] && (array[i, j] == 1 && array[j, i] == 1))
            {
                count = count + 1;
            }
        }
    }
    return count / 2;
}
