// See https://aka.ms/new-console-template for more information
using SingleTon;

DBClass dbc1 = DBClass.getInstance();
DBClass dbc2 = DBClass.getInstance();
Console.WriteLine(dbc1);
Console.WriteLine(dbc2);
