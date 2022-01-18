using System;
using System.Collections.Generic;
using System.Linq;

namespace TTask.Library
{//
    public static class Algorithm
    {
        public static Output Calculate(Input input)
        {
            var max = input.AMatr.SelectMany(x => x).Max();

            var B = input.AMatr.Select(row => row.Select(x => max + 1 - x).ToArray()).ToArray();

            var iterations = new List<Cell[][]>();
            var cells = new Cell[input.M][];
            int i = 0, j = 0;
            for (i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[input.N];
            }

            for (i = 0; i < input.M; i++)
            {
                for (j = 0; j < input.N; j++)
                {
                    cells[i][j] = new Cell(B[i][j]);
                }
            }

            var a = input.NVec.ToArray();
            var b = input.MVec.ToArray();
            
            i = 0;
            j = 0;

            while (i < input.N && j < input.M)
            {
                if (b[j] == 0)
                {
                    j++;
                    continue;
                }

                if (a[i] == 0)
                {
                    i++;
                    continue;
                }
                var min = Math.Min(a[i], b[j]);
                cells[j][i] = new Cell(B[j][i], min);
                a[i] -= cells[j][i].Amount;
                b[j] -= cells[j][i].Amount;
                if (cells[j][i].Amount != 0)
                {
                    iterations.Add(cells.Select(arr => arr.ToArray()).ToArray());
                }
            }

            return new Output(cells, input, B, iterations.ToArray());
        }
    }
}
