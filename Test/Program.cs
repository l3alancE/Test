//вар 21
dynamic Komp = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите код:");
Komp.Kod = Console.ReadLine() ?? "Код не указан";
Console.WriteLine("Введите название дисциплины:");
Komp.Sod = Console.ReadLine() ?? "Содержание не указано";
Console.Write($"Код:{Komp.Kod} \n Название дисциплины:{Komp.Sod}\n");
//вар 22
dynamic Vneur = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите название:");
Vneur.Kod = Console.ReadLine() ?? "Название не указано";
Console.Write($"Название:{Vneur.Kod} \n");
//вар 24
dynamic Zhur = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите отметку:");
Zhur.Kod = Console.ReadLine() ?? "Отметка не указана";
Console.WriteLine("Введите дату:");
Zhur.Sod = Console.ReadLine() ?? "Дата не указана";
Console.Write($"Отметка:{Zhur.Kod} \n Дата:{Zhur.Sod}\n");