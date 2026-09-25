Console.Write("Введите своё имя: ");
string name = Console.ReadLine();
string myName = "Васильев Юрий";
string myGroup = "ИСП-241";
int myAge = 18;
DateTime time = DateTime.Now;
Console.WriteLine();
Console.WriteLine($"Здравствуйте, {name}! Вас приветствует {myName} из группы {myGroup}, на вашем компьютере сейчас {time}");
Console.WriteLine();
Console.WriteLine("Что вы хотите обо мне узнать? Пожалуйста, выберите из этого: *Имя*, *Группа*, *Возраст*");
Console.WriteLine();
Console.Write("Напишите свой выбор из этого списка без **, можно выбрать только одно: ");
string choice = Console.ReadLine();
if (choice == "Имя") 
{
    Console.WriteLine($"Привет! Меня зовут {myName}");
} 
else if (choice == "Группа")
{
    Console.WriteLine($"Я студент группы {myGroup} ВФ ВолГУ");
} 
else if (choice == "Возраст")
{
    Console.WriteLine($"Мне {myAge} лет");
}
else
{
    Console.WriteLine("Ошибка, четко напишите слово из списка");
}

Console.Write("Нажмите любую клавишу, чтобы выйти: ");
Console.ReadKey();
