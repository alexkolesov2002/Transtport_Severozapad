using System;
using System.Linq;

namespace TTask.Library
{
    public class Input
    {
        public Input(double[] nVec, double[] mVec, double[][] aMatr)
        {
            N = nVec.Length;
            M = mVec.Length;
            NVec = nVec;
            MVec = mVec;
            AMatr = aMatr;
        }

        public int N { get; }

        public int M { get; }

        public double[] NVec { get; }

        public double[] MVec { get; }

        public double[][] AMatr { get; }

        public static Result<Input, string> Create(double[] n, double[] m, double[][] a)
        {
            try
            {
                if (a.Length != n.Length)
                {
                    return new Result<Input, string>("Не соответствие размерностей матрица и вектора");
                }

                if (a[0].Length != m.Length)
                {
                    return new Result<Input, string>("Не соответствие размерностей матрица и вектора");
                }

                if (n.Sum() != m.Sum())
                {
                    return new Result<Input, string>("Несогласованность данных");
                }

                var input = new Input(n, m, a);
                return new Result<Input, string>(input);
            }
            catch (Exception exp)
            {
                return new Result<Input, string>(exp.ToString());
            }
        }
    }
}
