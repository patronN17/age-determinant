using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace пр1
{
    class Program
    {
        static void Main(string[] args)
        {
            string res, txt;
            int year = 2023, age, born;
            res = Interaction.InputBox("В каком году вы родились?", "Год рождения");
            born = Int32.Parse(res);
            age = year - born;
            txt = " Тогда вам " + age + " лет ";
            MessageBox.Show(txt, " Возраст ");
        }
    }
}
