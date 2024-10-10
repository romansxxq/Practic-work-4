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
    internal class Test
    {
        static void Main(string[] args)
        {
            double a, b, c, P, S;
            string s;
            c = 5;
            a = 3;
            s = Interaction.InputBox("Введіть гіпотенузу", "Введення", c.ToString());

            c = Convert.ToDouble(s);
            s = Interaction.InputBox("Введіть довжину катета", "Введення", a.ToString());
            a = Convert.ToDouble(s);
            b = Math.Sqrt(c*c-a*a);
            P = a + b + c;
            S = (a+b)/2;
            MessageBox.Show("Якщо гіпотенуза рівна " + c.ToString() +
                ", а один з катетів " + a.ToString() + ", то другий катет становитиме " + P.ToString() + ", а площа " + S.ToString(), "Результати обчислень", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
