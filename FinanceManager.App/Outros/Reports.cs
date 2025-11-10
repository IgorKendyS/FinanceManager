// FinanceManager.App\Outros\Reports.cs

using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using ReaLTaiizor.Forms;
using ScottPlot;
using System.Data;
using System.Linq;

namespace FinanceManager.App.Outros
{
    public partial class Reports : MaterialForm
    {
        private readonly IBaseService<Transaction> _transactionService;

        public Reports(IBaseService<Transaction> transactionService)
        {
            InitializeComponent();
            _transactionService = transactionService;

            PlotDailyExpenses();
            PlotMonthlyExpenses();
            PlotCategoryExpenses();
        }

        private void PlotDailyExpenses()
        {
            formsPlot1.Plot.Clear();

            if (FormPrincipal.User == null) return;

            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var transactions = _transactionService.Get<Transaction>(
                t => t.UserId == FormPrincipal.User.Id && t.Date >= startDate && t.Date <= endDate,
                includes: new List<string> { "Category" }
            ).ToList();

            var dailyExpenses = transactions
                .Where(t => t.Category?.Type == "Saída")
                .GroupBy(t => t.Date.Day)
                .Select(g => new { Day = g.Key, Total = g.Sum(t => t.Amount) })
                .OrderBy(g => g.Day)
                .ToList();

            if (!dailyExpenses.Any())
            {
                formsPlot1.Plot.Title("Nenhuma despesa este mês");
                formsPlot1.Refresh();
                return;
            }

            var days = dailyExpenses.Select(g => (double)g.Day).ToArray();
            var totals = dailyExpenses.Select(g => (double)g.Total).ToArray();

            // Create bar plot with colors
            var barPlot = formsPlot1.Plot.Add.Bars(days, totals);
            
            // Set bar colors with gradient from Category10 palette
            var palette = new ScottPlot.Palettes.Category10();
            for (int i = 0; i < barPlot.Bars.Count; i++)
            {
                barPlot.Bars[i].FillColor = palette.GetColor(i % palette.Colors.Length);
                barPlot.Bars[i].LineWidth = 1;
            }

            // Add value labels on top of bars
            for (int i = 0; i < days.Length; i++)
            {
                var label = formsPlot1.Plot.Add.Text(totals[i].ToString("C2"), days[i], totals[i]);
                label.LabelAlignment = Alignment.LowerCenter;
                label.LabelFontSize = 10;
                label.LabelBold = true;
                label.LabelFontColor = Colors.Black;
            }

            formsPlot1.Plot.Title($"Despesas Diárias - {DateTime.Now:MMMM/yyyy}");
            formsPlot1.Plot.XLabel("Dia do Mês");
            formsPlot1.Plot.YLabel("Total Gasto (R$)");
            
            // Add semi-transparent grid for better readability
            formsPlot1.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#33000000");
            
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void PlotMonthlyExpenses()
        {
            formsPlot2.Plot.Clear();

            if (FormPrincipal.User == null) return;

            var startDate = new DateTime(DateTime.Now.Year, 1, 1);
            var endDate = new DateTime(DateTime.Now.Year, 12, 31);

            var transactions = _transactionService.Get<Transaction>(
                t => t.UserId == FormPrincipal.User.Id && t.Date >= startDate && t.Date <= endDate,
                includes: new List<string> { "Category" }
            ).ToList();

            var monthlyExpenses = transactions
                .Where(t => t.Category?.Type == "Saída")
                .GroupBy(t => t.Date.Month)
                .Select(g => new { Month = g.Key, Total = g.Sum(t => t.Amount) })
                .OrderBy(g => g.Month)
                .ToList();

            if (!monthlyExpenses.Any())
            {
                formsPlot2.Plot.Title($"Nenhuma despesa em {DateTime.Now.Year}");
                formsPlot2.Refresh();
                return;
            }

            var positions = monthlyExpenses.Select(m => (double)m.Month).ToArray();
            var totals = monthlyExpenses.Select(m => (double)m.Total).ToArray();
            var labels = monthlyExpenses.Select(m => new DateTime(1, m.Month, 1).ToString("MMM")).ToArray();

            // Create bar plot with colors
            var barPlot = formsPlot2.Plot.Add.Bars(positions, totals);
            
            // Set bar colors with gradient from Category10 palette
            var palette = new ScottPlot.Palettes.Category10();
            for (int i = 0; i < barPlot.Bars.Count; i++)
            {
                barPlot.Bars[i].FillColor = palette.GetColor(i % palette.Colors.Length);
                barPlot.Bars[i].LineWidth = 1;
            }

            // Add value labels on top of bars
            for (int i = 0; i < positions.Length; i++)
            {
                var label = formsPlot2.Plot.Add.Text(totals[i].ToString("C2"), positions[i], totals[i]);
                label.LabelAlignment = Alignment.LowerCenter;
                label.LabelFontSize = 10;
                label.LabelBold = true;
                label.LabelFontColor = Colors.Black;
            }

            formsPlot2.Plot.Title($"Despesas Mensais - {DateTime.Now.Year}");
            formsPlot2.Plot.YLabel("Total Gasto (R$)");
            
            // Set custom tick labels for months
            formsPlot2.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(positions, labels);
            formsPlot2.Plot.Axes.Bottom.MajorTickStyle.Length = 5;
            
            // Add semi-transparent grid for better readability
            formsPlot2.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#33000000");
            
            formsPlot2.Plot.Axes.AutoScale();
            formsPlot2.Refresh();
        }

        private void PlotCategoryExpenses()
        {
            formsPlot3.Plot.Clear();

            if (FormPrincipal.User == null) return;

            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var transactions = _transactionService.Get<Transaction>(
                t => t.UserId == FormPrincipal.User.Id && t.Date >= startDate && t.Date <= endDate,
                includes: new List<string> { "Category" }
            ).ToList();

            var categoryExpenses = transactions
                .Where(t => t.Category?.Type == "Saída" && t.Category != null)
                .GroupBy(t => t.Category!.Name)
                .Select(g => new { Category = g.Key, Total = g.Sum(t => t.Amount) })
                .OrderByDescending(g => g.Total)
                .ToList();

            if (!categoryExpenses.Any())
            {
                formsPlot3.Plot.Title("Nenhuma despesa por categoria este mês");
                formsPlot3.Refresh();
                return;
            }

            // Create pie chart with custom colors
            var palette = new ScottPlot.Palettes.Category10();
            var slices = new List<PieSlice>();
            
            for (int i = 0; i < categoryExpenses.Count; i++)
            {
                var expense = categoryExpenses[i];
                var slice = new PieSlice
                {
                    Value = (double)expense.Total,
                    Label = $"{expense.Category}\n{expense.Total:C2}",
                    FillColor = palette.GetColor(i % palette.Colors.Length),
                    LegendText = expense.Category
                };
                slices.Add(slice);
            }

            var pie = formsPlot3.Plot.Add.Pie(slices);
            pie.ExplodeFraction = 0.05; // Slightly separate slices for better visibility
            pie.SliceLabelDistance = 1.3; // Position labels outside the pie

            formsPlot3.Plot.Title($"Despesas por Categoria - {DateTime.Now:MMMM/yyyy}");
            
            // Hide axes for pie chart
            formsPlot3.Plot.Axes.Frameless();
            formsPlot3.Plot.HideGrid();
            
            formsPlot3.Plot.ShowLegend();
            formsPlot3.Plot.Axes.AutoScale();
            formsPlot3.Refresh();
        }
    }
}