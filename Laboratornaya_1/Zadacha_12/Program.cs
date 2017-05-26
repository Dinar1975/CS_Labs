using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_12
{
    class Program
    {
        static void Main(string[] args)
        {
            String user;
            String pass;
            String host;
            String port;
            String db;
            user = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "user"
            pass = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "pass"
            host = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "host"
            port = Console.ReadLine();  // Получаем информацию от пользователя и записываем в переменную "port"
            db = Console.ReadLine();    // Получаем информацию от пользователя и записываем в переменную "db"
            Console.WriteLine("user ID = {0}; password = {1}; host = {2}; port = {3}; Database = {4}", user, pass, host, port, db);  // Выводим на экран значение
            
        }
    }
}
