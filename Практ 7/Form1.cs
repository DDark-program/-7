using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_2;

namespace Практ_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка расчитывает оператор сложения, метод деления и метод вычитания 2ух пар чисел
        private void button1_Click(object sender, EventArgs e)
        {
            Money pair1 = new Money(Convert.ToInt32(txtFirstRub.Text), Convert.ToInt32(txtFirstKop.Text));
            Money pair2 = new Money(Convert.ToInt32(txtSecondRub.Text), Convert.ToInt32(txtSecondKop.Text));

            Money sumMoney = pair1 + pair2;
            Money subMoney = Money.MoneySub(pair1, pair2);
            Money divMoney = Money.MoneyDiv(pair1, pair2);
            MessageBox.Show("Значение сумма равно = " + "( " + sumMoney.First + " " + "рублей" + " " + sumMoney.Second + " " + "копеек" + " )");
            MessageBox.Show("Значение разница равно = " + "( " + subMoney.First + " " + "рублей" + " " + subMoney.Second + " " + "копеек" +  ")");
            MessageBox.Show("Значение деления равно = " + "( " + divMoney.First + " " + "рублей" + " " + divMoney.Second + " " + "копеек" + " )");
        }
        //Форма : О программе
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Подъяблонский Данила Владимирович \n" +
                "Использовать класс Pair (пара чисел). \n" +
                "Определить класс-наследник Money с полями: рубли и копейки. \n" +
                "Переопределить операцию сложения и \n" +
                "определить методы вычитания и деления денежных сумм");
        }

        //Форма : Выход
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Меню : О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Подъяблонский Данила Владимирович \n" +
                "Использовать класс Pair (пара чисел). \n" +
                "Определить класс-наследник Money с полями: рубли и копейки. \n" +
                "Переопределить операцию сложения и \n" +
                "определить методы вычитания и деления денежных сумм");
        }

        //Меню : Выход
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
