using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PolynomGraph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Axes limits
        private void maxPositiveX_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Maximum = (double)(sender as NumericUpDown).Value;
        }

        private void maxNegativeX_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Minimum = (double)(sender as NumericUpDown).Value;
        }

        private void maxPositiveY_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Maximum = (double)(sender as NumericUpDown).Value;
        }

        private void maxNegativeY_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Minimum = (double)(sender as NumericUpDown).Value;
        }

        private void majorStepX_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Interval = (double)(sender as NumericUpDown).Value;  // на каждый условный промежуток
            chart.ChartAreas[0].AxisX.MinorTickMark.Interval =
                chart.ChartAreas[0].AxisX.Interval / (double)minorStepX.Value;
        }

        private void minorStepX_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.MinorTickMark.Interval =
                chart.ChartAreas[0].AxisX.Interval / (double)(sender as NumericUpDown).Value;
        }

        private void majorStepY_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Interval = (double)(sender as NumericUpDown).Value;
            chart.ChartAreas[0].AxisY.MinorTickMark.Interval =
                chart.ChartAreas[0].AxisY.Interval / (double)minorStepX.Value;
        }

        private void minorStepY_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.MinorTickMark.Interval =
                chart.ChartAreas[0].AxisY.Interval / (double)(sender as NumericUpDown).Value;
        }
        #endregion

        private void enableGrid_CheckedChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = (sender as CheckBox).Checked;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = (sender as CheckBox).Checked;
        }

        private void addGraph_Click(object sender, EventArgs e)
        {   // polynomPowerGrid вот это вот штучка над красной кнопкой
            polynomPowerGrid.Rows.Add();
        }

        private void removeGraph_Click(object sender, EventArgs e)
        {
            if (polynomPowerGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in polynomPowerGrid.SelectedRows)
                {
                    try
                    {
                        polynomPowerGrid.Rows.Remove(row);
                    }
                    catch
                    {
                        MessageBox.Show("You can't remove last row", "Error");
                    }
                }
            }
            else if (polynomPowerGrid.SelectedCells.Count > 0)
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>(); 
                foreach (DataGridViewCell cell in polynomPowerGrid.SelectedCells)
                {
                    if (!rows.Contains(cell.OwningRow)) rows.Add(cell.OwningRow);
                }

                foreach (DataGridViewRow row in rows)
                {
                    try
                    {
                        polynomPowerGrid.Rows.Remove(row);
                    }
                    catch
                    {
                        MessageBox.Show("You can't remove last row", "Error");
                    }
                }
            }
        }

        private void polynomPowerGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == polynomPowerGrid.Columns.Count - 1)
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    // Любой datagridview является object, но наоброт  
                    (sender as DataGridView).CurrentCell.Style.BackColor = cd.Color;  
                }
            }
        }

        private void BIG_RED_BUTTON_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            Series ser = new Series();
            ser.ChartArea = chart.ChartAreas[0].Name;
            ser.Points.AddXY(0, 0);
            chart.Series.Add(ser);

            foreach (DataGridViewRow row in polynomPowerGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    int[] indexes = new int[polynomPowerGrid.ColumnCount];
                    for (int j = 0; j < polynomPowerGrid.ColumnCount; j++)
                    {
                        int number = 0;
                        Int32.TryParse((string)row.Cells[j].Value, out number);
                        indexes[j] = number;
                    }

                    Series graph = new Series
                    {
                        Color = row.Cells[polynomPowerGrid.ColumnCount - 1].Style.BackColor,
                        ChartType = SeriesChartType.Line,
                        ChartArea = chart.ChartAreas[0].Name, // string имя куда отрисовывать
                        Name = "",
                        Legend = "mainLegend",
                        BorderWidth = (int)graphWidth.Value
                    };

                    for (int j = 0; j < polynomPowerGrid.ColumnCount - 1; j++)
                    {
                        if (indexes[j] != 0) //Имя графика
                        {
                            string str = "";
                            if (indexes[j] > 0) str += "+" + indexes[j].ToString();
                            else str += indexes[j].ToString();

                            if (j != 0) str += "x^" + j.ToString() + " ";

                            graph.Name = str + graph.Name;
                        }
                    }

                    for (double i = (double)minNegativeX.Value; i <= (double)maxPositiveX.Value; i += 0.1) // для плавности
                    {
                        double result = 0;

                        for (int j = 0; j < polynomPowerGrid.ColumnCount - 1; j++)
                        {
                            result += Math.Pow(i, j) * indexes[j];
                        }
                        graph.Points.AddXY(i, result);
                    }

                    try
                    {
                        chart.Series.Add(graph);  // Сравнивает по имени
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Одинаковые полиномы не отображены", "Error");
                    }
                }
            }
        }

        private void graphWidth_ValueChanged(object sender, EventArgs e)
        {
            foreach (Series graph in chart.Series)
            {
                graph.BorderWidth = (int)(sender as NumericUpDown).Value;
            }
        }
    }
}
