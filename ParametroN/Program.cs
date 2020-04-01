using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ExerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime today = DateTime.Today;

            string dataAtual = today.ToString("dd/MM/yyyy");
            Console.WriteLine("Data atual: " + dataAtual);


            string ano = today.ToString("yy");

            if (ano == "01")
                ano = "1";
            else if (ano == "02")
                ano = "2";
            else if (ano == "03")
                ano = "3";
            else if (ano == "04")
                ano = "4";
            else if (ano == "05")
                ano = "5";
            else if (ano == "06")
                ano = "6";
            else if (ano == "07")
                ano = "7";
            else if (ano == "08")
                ano = "8";
            else if (ano == "09")
                ano = "9";
            else if (ano == "10")
                ano = "1";
            else if (ano == "20")
                ano = "2";
            else if (ano == "30")
                ano = "3";
            else if (ano == "40")
                ano = "4";
            else if (ano == "50")
                ano = "5";
            else if (ano == "60")
                ano = "6";
            else if (ano == "70")
                ano = "7";
            else if (ano == "80")
                ano = "8";
            else if (ano == "90")
                ano = "9";


            string mes = today.ToString("MM");

            if (mes == "01")
                mes = "1";
            else if (mes == "02")
                mes = "2";
            else if (mes == "03")
                mes = "3";
            else if (mes == "04")
                mes = "4";
            else if (mes == "05")
                mes = "5";
            else if (mes == "06")
                mes = "6";
            else if (mes == "07")
                mes = "7";
            else if (mes == "08")
                mes = "8";
            else if (mes == "09")
                mes = "9";
            else if (mes == "10")
                mes = "1";

            string dia = today.ToString("dd");


            if (dia == "01")
                dia = "1";
            else if (dia == "02")
                dia = "2";
            else if (dia == "03")
                dia = "3";
            else if (dia == "04")
                dia = "4";
            else if (dia == "05")
                dia = "5";
            else if (dia == "06")
                dia = "6";
            else if (dia == "07")
                dia = "7";
            else if (dia == "08")
                dia = "8";
            else if (dia == "09")
                dia = "9";
            else if (dia == "10")
                dia = "1";
            else if (dia == "20")
                dia = "2";
            else if (dia == "30")
                dia = "3";

            string total = today.ToString(dia + mes + ano);


            int resultadoTotal = Convert.ToInt32(total);


            resultadoTotal = resultadoTotal * 9;
            Console.WriteLine();
            Console.WriteLine("Parametro N: " + resultadoTotal);
            Console.WriteLine();

        }
    }
}
