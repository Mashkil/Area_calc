using Jint;

namespace Area_calc
{
    public static class Areas
    {
        public static double Area_circle(double r)
        {
            return Math.Round(Math.Pow(r, 2)* Math.PI,3);
        }

        public static double Area_treug (double a, double b, double c)
        {
            double p = ((a * b * c) / 3);
            return Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)), 3);
        }
        
        /// <param name="c">Largest side</param>
        public static bool Check_treug (double a, double b, double c)
        {
            if ((Math.Pow(a, 2)+ (Math.Pow(b, 2)))== Math.Pow(c,2))
                return true;
            else
                return false;
        }


        /// <summary>
        /// Math.pow(A, 2)- возведение в квадрат.
        /// <para>
        /// Math.sqrt(N) - извлечение квадратного корня.
        /// </para>
        /// Math.round(N) - округление числа.
        /// <para>
        /// /// </para>
        /// Math.abs(N) - модуль числа.
        /// <para>
        /// * умножение
        /// </para>
        /// <para>
        /// / деление
        /// </para>
        /// <para>
        /// + сумма
        /// </para>
        /// <para>
        /// - разность
        /// </para>
        /// при введении значений параметров явно указать "A:5 H:10. Между буквами ставить пробел (Буквы заглавные!)"
        /// </summary>
        /// <param name="formula"> Введите формулу используя параметры из описания </param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="h"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static double Area(string formula, double? A=null , double? B=null, double? C= null, double? H= null, double? R=null, double? S = null, double? N = null)
        {       //Если добавить какие то конкретные фигуры , то функциональность будет ограничена. Поэтому я подумал , что лучше что бы вводили формулу и считалась площадь.
            formula= formula.Replace("A", A.ToString());
            formula = formula.Replace("B", B.ToString());
            formula = formula.Replace("C", C.ToString());
            formula = formula.Replace("H", H.ToString());
            formula = formula.Replace("R", R.ToString());
            formula = formula.Replace("S", S.ToString());
            formula = formula.Replace("N", N.ToString());

            Engine en = new();

            en.Execute($"var res = {formula};");       
            
            return en.GetValue("res").AsNumber();
        }
    }

}