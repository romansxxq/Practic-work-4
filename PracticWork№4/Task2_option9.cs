using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticWork_4
{
    internal class Task2_option9
    {
        static void Main(string[] args)
        {
            double nominal, realIncome, cpi;
            string message;
            message = Interaction.InputBox($"Введіть реальний дохід: ", "Task 2. Option 9. OP AM", $"Наприклад: {12000} грн.");
            realIncome = Convert.ToDouble(message);
            message = Interaction.InputBox($"Введіть індекс споживчих цін: ", "Task 2. Option 9. OP AM", $"Наприклад: {120}");
            cpi = Convert.ToDouble(message);
            nominal = realIncome * (cpi/100);
            MessageBox.Show($"При реальному доході: {realIncome} та при індексі споживчої цінах: {cpi}\n Ваш номінальний дохід становить: {nominal} грн.");




        }
    }
}
