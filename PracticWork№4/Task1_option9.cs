using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticWork_4
{
    internal class Task1_option9
    {
        static void Main(string[] args)
        {
            const double butter = 5, cheese1 = 7, cheese2 = 4.7, sausage1 = 7.5, sausage2 = 4.3;
            double kg1 = 1, kg2 = 1, kg3 = 1, kg4 = 1, kg5 = 1;
            string message;
            message = Interaction.InputBox($"Масло \"Вершкове\" ціна: {butter} грн. за 1 кг", "Введіть, скільки Ви хочете взяти дане масло (в кг)?", kg1.ToString());
            kg1 = Convert.ToDouble(message);
            double sumButter = butter * kg1;

            message = Interaction.InputBox($"Сир \"Костромський\" ціна: {cheese1} грн. за 1 кг", "Введіть, скільки Ви хочете взяти даний сир (в кг)?", kg2.ToString());
            kg2 = Convert.ToDouble(message);
            double sumCheese1 = cheese1 * kg2;
            
            message = Interaction.InputBox($"Сир \"Ковбасний\" ціна: {cheese2} грн. за 1 кг", "Введіть, скільки Ви хочете взяти даний сир (в кг)?", kg3.ToString());
            kg3 = Convert.ToDouble(message);
            double sumCheese2 = cheese2 * kg3;
            
            message = Interaction.InputBox($"Ковбаса  \"Черкаська\" ціна: {sausage1} грн. за 1 кг", "Введіть, скільки Ви хочете взяти дану ковбасу (в кг)?", kg4.ToString());
            kg4 = Convert.ToDouble(message);
            double sumSausage1 = sausage1 * kg4;
            
            message = Interaction.InputBox($"Сосиски \"Шкільні\" ціна: {sausage2} грн. за 1 кг", "Введіть, скільки Ви хочете взяти дану ковбасу (в кг)?", kg5.ToString());
            kg5 = Convert.ToDouble(message);
            double sumSausage2 = sausage2 * kg5;

            double allSum = sumButter + sumCheese1 + sumCheese2 + sumSausage1 + sumSausage2;
            MessageBox.Show($"Масло \"Вершкове\" ціна: {sumButter} грн. за {kg1} кг;\n Сир \"Костромський\" ціна: {sumCheese1} грн. за {kg2} кг;\n Сир \"Ковбасний\" ціна: {sumCheese2} грн. за {kg3} кг;\n Ковбаса  \"Черкаська\" ціна: {sumSausage1} грн. за {kg4} кг;\n Сосиски \"Шкільні\" ціна: {sumSausage2} грн. за {kg5} кг\n Вартість: {allSum} грн.", "Результат ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
