using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public class Pair
    {
        /// <summary>
        /// Поля данных
        /// </summary>
        private int _firstNumber;
        private int _secondNumber;

        /// <summary>
        /// Присваивание значения полям
        /// </summary>
        /// <param name="oneNumber">Первое число</param>
        /// <param name="twoNumber">Второе число</param>
        public Pair(int oneNumber, int twoNumber)
        {
            _firstNumber = oneNumber;
            _secondNumber = twoNumber;
        }

        /// <summary>
        /// Свойства первого числа
        /// </summary>
        public int First
        {
            get => _firstNumber;
            set => _firstNumber = value;
        }

        /// <summary>
        /// Свойства второго числа
        /// </summary>
        public int Second
        {
            get => _secondNumber;
            set => _secondNumber = value;
        }

        /// <summary>
        /// Операция инкремента 
        /// </summary>
        /// <returns></returns>
        public static Pair operator --(Pair firstpair)
        {
            return new Pair(--firstpair.First, --firstpair.Second);
        }

        /// <summary>
        /// Операция сложения пары чисел
        /// </summary>
        /// <param name="firstpair"></param>
        /// <param name="secondpair"></param>
        /// <returns></returns>
        public static Pair operator +(Pair firstpair, Pair secondpair)
        {
            return new Pair(firstpair.First + secondpair.First, firstpair.Second + secondpair.Second);
        }
    }
    public class Money:Pair
    {
        //Поля класса наследника Money
        private int rubles;
        private int kopecks;
        //Конструктор класса наследника Money
        public Money(int oneNumber, int twoNumber) : base(oneNumber, twoNumber)
        {
            rubles = oneNumber;
            kopecks = twoNumber;
        }
        //Оператор сложения пар чисел
        public static Money operator +(Money firstPair, Money secondPair)
        {
            return new Money(firstPair.First + secondPair.First, firstPair.Second + secondPair.Second);
        }
        //Метод вычитания денежных сумм
        public static Money MoneySub(Money firstPair, Money secondPair)
        {
            return new Money (firstPair.First - secondPair.First, firstPair.Second - secondPair.Second);
        }
        //Метод деления денежных сумм
        public static Money MoneyDiv(Money firstPair, Money secondPair)
        {
            return new Money (firstPair.First / secondPair.First, firstPair.Second / secondPair.Second);
        }
    }
}
