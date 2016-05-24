using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long entrNum, dividend, divider, result = 1;
            long var1 = 0, var2 = 0, var3 = 0;
            int count = 0;

            string resultString = "";

            entrNum = long.Parse(textBox1.Text);
            dividend = entrNum;
            // произведение введённых чисел и dividend равно entrNum (введенное число)
            while (dividend > 1)
            {
                divider = 2;
                // dividend не имеет делителей в интервале (1, divider)
                while ((dividend % divider) > 0)
                {
                    divider = divider + 1;
                 }
                // divider - наименьший делитель dividend больший 1, значит - простой
                resultString = resultString + divider.ToString() + " * ";
                dividend = dividend / divider;
      //         
                count = count + 1; // считаем до трех простых чисел для проверки их произведения

                switch (count)
                {   
                // В зависимости от значения локальной переменной count запоминаем простые сомножители для определения их последовательности;
                    case 1:
                        var1 = divider; 
                        break;

                    case 2:
                        var2 = divider;  
                        break;

                    case 3:
                        var3 = divider;
                        break;
                }

                result = result * divider;   // result - произведение простых чисел
               
            }
            // проверяем полученную тройку простых чисел, 
            // равно ли полученное после разложения на простые сомножители их произведение введенному числу,
            // а также, для условия их последовательности, отличаются ли они не более, чем  на 4 или 6 единиц
            if ((count == 3 && result == entrNum) && (var2 > var1 && var3 > var2) && (var2 - var1 <= 4 || var3 - var2 <= 4 || var2 - var1 <= 6 || var3 - var2 <= 6) && (var3 - var1 <= 4 || var3 - var1 <= 6))   
                {
                    resultString = "Да, " + resultString.Substring(0, resultString.Length - 2) + " = " + textBox1.Text;
                }
           else  
                {
                    resultString = "Нет";   
                   
           }
            textBox2.Text = resultString;
           
        }
    }
}
