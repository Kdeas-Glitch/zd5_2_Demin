using zd5_1_Demin;
using zd5_2_Demin;
namespace Test

{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Проверка_на_Сумму_Кредита()//Проверка на Правильно введённую сумму кредита
        {
            string sum = "100";
            double Pr_Sum= Validation.Check_Sum(sum);//Проверка на правильность ввода
            Assert.AreEqual(100, Pr_Sum);//Должны совпасть так как всё введено правильно
        }

        [TestMethod]
        public void Проверка_на_Неправильную_Сумму_Кредита()//Проверка на не Правильно введённую сумму кредита
        {
            string sum = "Сто";
            double Pr_Sum = Validation.Check_Sum(sum);//Проверка на правильность ввода
            Assert.AreEqual(0, Pr_Sum);//Должны совпасть так как введено не правильно
        }

        [TestMethod]
        public void Проверка_на_Правильное_Время_Кредита()//Проверка на Правильно введённое время кредита
        {
            string time = "12";
            int Pr_Time = Validation.Check_Time(time);//Проверка на правильность ввода
            Assert.AreEqual(12, Pr_Time);//Должны совпасть так как введено правильно
        }

        [TestMethod]
        public void Проверка_на_Не_Правильное_Время_Кредита()//Проверка на не Правильно введённое время кредита
        {
            string time = "121";
            int Pr_Time = Validation.Check_Time(time);//Проверка на правильность ввода
            Assert.AreEqual(0, Pr_Time);//Должны совпасть так как введено не правильно
        }

        [TestMethod]
        public void Проверка_на_Правильную_Процентную_Ставку()//Проверка на Правильно введённую Процентную ставку кредита
        {
            double slider = 12.5;
            double Pr_Scrol = Validation.Check_Scrol(slider);//Проверка на правильность ввода
            Assert.AreEqual(12,5, Pr_Scrol);//Должны совпасть так как введено правильно
        }

        [TestMethod]
        public void Проверка_на_Не_Правильную_Процентную_Ставку()//Проверка на не Правильно введённую Процентную ставку кредита
        {
            double slider = 125;
            double Pr_Scrol = Validation.Check_Scrol(slider);//Проверка на правильность ввода
            Assert.AreEqual(-1, Pr_Scrol);//Должны совпасть так как введено не правильно
        }
    }
}
