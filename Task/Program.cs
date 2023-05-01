Console.Write("Введите элементы массива через запятую: ");
string arrayString = Convert.ToString(Console.ReadLine());

string[] arrayOld = arrayString.Split(",");

string[] ArrayNew = arrayOld.Where(n => n.Length <= 3).ToArray();


Console.Write($"Элементы массива, длиной меньше или равной 3: ");
foreach (string i in ArrayNew)
    Console.Write($"{i} ");
