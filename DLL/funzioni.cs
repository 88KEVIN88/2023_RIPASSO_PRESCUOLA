using System;
namespace DLL
{
   
    public class funzioni
    {
       public string  filecsv = @"D:\Programmi\Ripasso_2023\Ripasso_2023\bin\Debug\ciao.csv";
        public int cont;
        public char delimiter = ';';
        public  void Add() //Aggiunta di un campo alla fine di ogni record
        {
            Random random = new Random();
            string[] csvline = File.ReadAllLines(filecsv);

            for(int i = 0; i < csvline.Length; i++)
            {
                csvline[i] += $";Mio valore:{random.Next(10, 21)};0";
            }
            File.WriteAllLines(filecsv, csvline);
        }
        public  int  Cont()
        {
            using (StreamReader rd = new StreamReader(filecsv))
            {
                string hdline= rd.ReadLine();
                if(!String.IsNullOrEmpty(hdline))
                {
                    cont = hdline.Split(delimiter).Length;
                }
                
            }
            return cont;
        }
    }
}