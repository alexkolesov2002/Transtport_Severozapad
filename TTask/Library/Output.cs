using System.Linq;
using System.Text;

namespace TTask.Library
{
    public class Output
    {
        public Input Input { get; }
        public double[][] B { get; }
        public Cell[][] Result { get; }

        public Cell[][][] Iterations { get; }
        public double Sum { get; }
        public string Format { get; }

        public Output(Cell[][] cells, Input input, double[][] B, Cell[][][] iterations)
        {
            Result = cells;
            this.Input = input;
            this.B = B;
            Sum = cells.SelectMany(c => c).Sum(c => c.Amount * c.Price);
            Format = GetFormat();
            Iterations = iterations;
        }

        private string GetFormat()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Матрица A");

            for (int i = 0; i < Input.M; i++)
            {
                for (int j = 0; j < Input.N; j++)
                {
                    sb.Append($"{Input.AMatr[i][j],5}");
                    sb.Append("|");
                }

                sb.AppendLine();
            }

            sb.AppendLine();

            sb.AppendLine("Матрица B");

            for (int i = 0; i < Input.M; i++)
            {
                for (int j = 0; j < Input.N; j++)
                {
                    sb.Append($"{B[i][j],5}");
                    sb.Append("|");
                }

                sb.AppendLine();
            }

            sb.AppendLine();

            sb.AppendLine("Вектор N");
            sb.AppendLine($"({string.Join(";", Input.NVec)})");

            sb.AppendLine();

            sb.AppendLine("Вектор M");
            sb.AppendLine($"({string.Join(";", Input.MVec)})");

            sb.AppendLine();
            sb.AppendLine("Распределение:");
            sb.AppendLine();

            for (int i = -1; i < Input.N; i++)
            {
                var str = i < 0 ? "" : Input.NVec[i].ToString();
                sb.Append($"{str,-10}");
                sb.Append("|");
            }
            sb.AppendLine();

            for (int i = 0; i < Input.M; i++)
            {
                sb.Append($"{Input.MVec[i],-10}");
                sb.Append("|");
                for (int j = 0; j < Input.N; j++)
                {
                    sb.Append(Result[i][j]);
                    sb.Append("|");
                }

                sb.AppendLine();
            }

            sb.AppendLine();
            sb.Append("Суммарные затраты: ");
            sb.Append(Sum);
            sb.Append("у. д. е.");

            return sb.ToString();
        }

        public string GetIterFormat(int ind)
        {
            var sb = new StringBuilder();

            sb.AppendLine("Матрица A");

            for (int i = 0; i < Input.M; i++)
            {
                for (int j = 0; j < Input.N; j++)
                {
                    sb.Append($"{Input.AMatr[i][j],5}");
                    sb.Append("|");
                }

                sb.AppendLine();
            }

            sb.AppendLine();

            sb.AppendLine("Матрица B");

            for (int i = 0; i < Input.M; i++)
            {
                for (int j = 0; j < Input.N; j++)
                {
                    sb.Append($"{B[i][j],5}");
                    sb.Append("|");
                }

                sb.AppendLine();
            }

            sb.AppendLine();

            sb.AppendLine("Вектор N");
            sb.AppendLine($"({string.Join(";", Input.NVec)})");

            sb.AppendLine();

            sb.AppendLine("Вектор M");
            sb.AppendLine($"({string.Join(";", Input.MVec)})");

            sb.AppendLine();
            sb.AppendLine("Распределение:");
            sb.AppendLine();

            for (int i = -1; i < Input.N; i++)
            {
                var str = i < 0 ? "" : Input.NVec[i].ToString();
                sb.Append($"{str,-10}");
                sb.Append("|");
            }
            sb.AppendLine();

            for (int i = 0; i < Input.M; i++)
            {
                sb.Append($"{Input.MVec[i],-10}");
                sb.Append("|");
                for (int j = 0; j < Input.N; j++)
                {
                    sb.Append(Iterations[ind][i][j]);
                    sb.Append("|");
                }

                sb.AppendLine();
            }

            sb.AppendLine();
            if (ind == Iterations.Length - 1)
            {
                sb.Append("Суммарные затраты: ");
                sb.Append(Sum);
                sb.Append("у. д. е.");
            }

            return sb.ToString();
        }
    }
}
