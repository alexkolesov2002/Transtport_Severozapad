using System;
using System.Windows.Forms;
using TTask.Library;
using TTask.Nav;
using TTask.Styles;

namespace TTask.Pages
{
    public partial class AlgorithmPage : UserControl, INav
    {
        private int n, m;
        public AlgorithmPage()
        {
            InitializeComponent();

            mVecDGV.SetMatrixStyle();
            nVecDGV.SetMatrixStyle();
            aMatrDGV.SetMatrixStyle();

            mVecDGV.ScrollBars = ScrollBars.None;
            nVecDGV.ScrollBars = ScrollBars.None;
        }

        public event Action<NavMsg> NewMsg;

        private Result<double[][], CellError> GetMatrixFromDGV(DataGridView dataGridView)
        {
            var n = dataGridView.RowCount;
            var m = dataGridView.ColumnCount;

            var matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var ov = dataGridView[j, i].Value;
                    if (ov == null)
                    {
                        var err = new CellError(i, j, "Элемент не заполнен");
                        return new Result<double[][], CellError>(err);
                    }

                    var str = ov.ToString();
                    if (string.IsNullOrWhiteSpace(str))
                    {
                        var err = new CellError(i, j, "Элемент не заполнен");
                        return new Result<double[][], CellError>(err);
                    }

                    if (!double.TryParse(ov.ToString(), out double v))
                    {
                        var err = new CellError(i, j, "Невозможно преобразовать в число с плавающей запятой");
                        return new Result<double[][], CellError>(err);
                    }

                    if (v < 0)
                    {
                        var err = new CellError(i, j, "Значения не должны быть отрицательными");
                        return new Result<double[][], CellError>(err);
                    }

                    matrix[i][j] = v;
                }
            }

            return new Result<double[][], CellError>(matrix);
        }

        private Result<double[], CellError> GetRowVectorFromDGV(DataGridView dataGridView)
        {
            var m = dataGridView.ColumnCount;

            var vector = new double[m];

            for (int j = 0; j < m; j++)
            {
                var ov = dataGridView[j, 0].Value;
                if (ov == null)
                {
                    var err = new CellError(0, j, "Элемент не заполнен");
                    return new Result<double[], CellError>(err);
                }

                var str = ov.ToString();
                if (string.IsNullOrWhiteSpace(str))
                {
                    var err = new CellError(0, j, "Элемент не заполнен");
                    return new Result<double[], CellError>(err);
                }

                if (!double.TryParse(ov.ToString(), out double v))
                {
                    var err = new CellError(0, j, "Невозможно преобразовать в число с плавающей запятой");
                    return new Result<double[], CellError>(err);
                }

                if (v < 0)
                {
                    var err = new CellError(0, j, "Значения не должны быть отрицательными");
                    return new Result<double[], CellError>(err);
                }

                vector[j] = v;
            }

            return new Result<double[], CellError>(vector);
        }

        private Result<double[], CellError> GetColumnVectorFromDGV(DataGridView dataGridView)
        {
            var n = dataGridView.RowCount;

            var vector = new double[n];

            for (int j = 0; j < n; j++)
            {
                var ov = dataGridView[0, j].Value;
                if (ov == null)
                {
                    var err = new CellError(j, 0, "Элемент не заполнен");
                    return new Result<double[], CellError>(err);
                }

                var str = ov.ToString();
                if (string.IsNullOrWhiteSpace(str))
                {
                    var err = new CellError(j, 0, "Элемент не заполнен");
                    return new Result<double[], CellError>(err);
                }

                if (!double.TryParse(ov.ToString(), out double v))
                {
                    var err = new CellError(j, 0, "Невозможно преобразовать в число с плавающей запятой");
                    return new Result<double[], CellError>(err);
                }

                if (v < 0)
                {
                    var err = new CellError(j, 0, "Значения не должны быть отрицательными");
                    return new Result<double[], CellError>(err);
                }

                vector[j] = v;
            }

            return new Result<double[], CellError>(vector);
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            if (n == 0 || m == 0)
            {
                MessageBox.Show("Введите размерность", "Ошибка");
                return;
            }

            var a = GetMatrixFromDGV(aMatrDGV);
            if (a.IsError)
            {
                MessageBox.Show(a.Error.FormatError(), "Ошибка! Матрица A");
                return;
            }

            var vecM = GetColumnVectorFromDGV(mVecDGV);
            if (vecM.IsError)
            {
                MessageBox.Show(vecM.Error.FormatError(), "Ошибка! Вектор N");
                return;
            }

            var vecN = GetRowVectorFromDGV(nVecDGV);
            if (vecN.IsError)
            {
                MessageBox.Show(vecN.Error.FormatError(), "Ошибка! Вектор M");
                return;
            }

            var input = Input.Create(vecN.Ok, vecM.Ok, a.Ok);
            if (input.IsError)
            {
                MessageBox.Show(input.Error, "Ошибка в данных");
                return;
            }

            var res = Algorithm.Calculate(input.Ok);

            NewMsg?.Invoke(new ToResultPage(res));
        }

        private void MTxb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(mTxb.Text, out m))
            {
                return;
            }

            mVecDGV.ColumnCount = 1;
            mVecDGV.RowCount = m;
            aMatrDGV.RowCount = m;
        }

        private void NTxb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(nTxb.Text, out n))
            {
                return;
            }

            nVecDGV.RowCount = 1;
            nVecDGV.ColumnCount = n;
            aMatrDGV.ColumnCount = n;
        }
    }

    public class CellError
    {
        public CellError(int row, int column, string error)
        {
            Row = row;
            Column = column;
            Error = error;
        }

        public int Row { get; }

        public int Column { get; }

        public string Error { get; }

        public string FormatError()
        {
            return $"[{Row + 1}, {Column + 1}]: {Error}";
        }
    }
}
