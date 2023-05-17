using ConsoleApp2.Controller;
using ConsoleApp2.Model;
using ConsoleApp2.View;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2;
public class Program
{

    public static void Main()
    {
        MenuView menuView = new MenuView();
        menuView.MenuDisplay();
    }
}