using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime inicio = new DateTime(2022, 5, 26, 8, 0, 0);
            //DateTime fin = new DateTime(2022, 5, 26, 18, 0, 0);
            //var result = salary(inicio, fin, 1, 2);

            //DateTime inicio = new DateTime(2022, 5, 26, 6, 0, 0);
            //DateTime fin = new DateTime(2022, 5, 26, 18, 0, 0);
            //var result = ConsoleApp2.Program.salary(inicio, fin, 1, 2);

            //DateTime inicio = new DateTime(2022, 5, 26, 6, 0, 0);
            //DateTime fin = new DateTime(2022, 5, 26, 20, 0, 0);
            //var result = ConsoleApp2.Program.salary(inicio, fin, 1, 2);

            //Este no
            //DateTime inicio = new DateTime(2022, 5, 26, 4, 0, 0);
            //DateTime fin = new DateTime(2022, 5, 26, 6, 0, 0);
            //var result = ConsoleApp2.Program.salary(inicio, fin, 1, 2);

            //DateTime inicio = new DateTime(2022, 5, 26, 19, 0, 0);
            //DateTime fin = new DateTime(2022, 5, 26, 21, 0, 0);
            //var result = ConsoleApp2.Program.salary(inicio, fin, 1, 2);

            //DateTime inicio = new DateTime(2022, 5, 26, 12, 0, 0);
            //DateTime fin = new DateTime(2022, 5, 26, 14, 0, 0);
            //var result = ConsoleApp2.Program.salary(inicio, fin, 1, 2);


            DateTime inicio = new DateTime(2022, 5, 26, 12, 0, 0);
            DateTime fin = new DateTime(2022, 5, 26, 20, 0, 0);
            var result = ConsoleApp2.Program.salary(inicio, fin, 1, 2);
            Console.WriteLine(result);
        }

        static float salary(DateTime hora_inicio, DateTime hora_fin, float salario_hora, float factor_multiplicador)
        {
            if (hora_inicio.Hour >= 8 && hora_fin.Hour <= 18)
            {
                float total_horas = hora_fin.Hour - hora_inicio.Hour;
                return total_horas * salario_hora;
            }
            else if ((hora_inicio.Hour < 8 && hora_fin.Hour < 8) || (hora_inicio.Hour > 18 && hora_fin.Hour > 18))
            {
                float total_horas = hora_fin.Hour - hora_inicio.Hour;
                return total_horas * factor_multiplicador;
            }
            else if(hora_inicio.Hour < 8 && hora_fin.Hour <= 18)
            {
                var normal = hora_fin.Hour - 8;
                var extra = 8 - hora_inicio.Hour;
                return normal * salario_hora + extra * factor_multiplicador;
            }
            else if(hora_inicio.Hour >= 8 && hora_fin.Hour > 18)
            {
                var normal = 18 - hora_inicio.Hour;
                var extra = hora_fin.Hour - 18;
                return normal* salario_hora + extra* factor_multiplicador;
            }
            else
            {
                var extra = (8 - hora_inicio.Hour) + (hora_fin.Hour - 18) ;
                return (18-8) * salario_hora + extra * factor_multiplicador;
            }
        }
    }
}
