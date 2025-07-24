//1 - vazifa.Aqlli robot(switch expressions + ternary operator)

Console.Write("Buyruq kiriting (yur, tushun, sakra, o'giril): ");
string buyruq = Console.ReadLine().ToLower();

string natija = buyruq switch
{
    "yur" => "Robot yurmoqda!",
    "tushun" => "Robot tushunmoqda!",
    "sakra" => "Robot sakrayapti!",
    "o'giril" => "Robot o'girilyapti!",
    _ => "Noma'lum buyruq"
};

Console.WriteLine(natija);


//2 - vazifa.Sehrli doʻkon(switch-case)

Console.Write("Mahsulot nomini kiriting (olma, banan, anor, gilos): ");
string mahsulot = Console.ReadLine().ToLower();

if (mahsulot == "olma" || mahsulot == "banan" || mahsulot == "anor" || mahsulot == "gilos")
{
    switch (mahsulot)
    {
        case "olma":
            Console.WriteLine("Narxi: 5000 so'm");
            break;

        case "banan":
            Console.WriteLine("Narxi: 22000 so'm");
            break;

        case "anor":
            Console.WriteLine("Narxi: 30000 so'm");
            break;

        case "gilos":
            Console.WriteLine("Narxi: 35000 so'm");
            break;
    }
}
else
{
    Console.WriteLine("Kechirasiz, bu mahsulot yo'q");
}


//3 - vazifa.Trafik yoritgich(ternary operator +logical AND(&&) / OR(||)

string? oldingiRang = null;

for (int i = 0; i < 2; i++)
{
    Console.Write("Rang kiriting (qizil, sariq, yashil): ");
    string rang = Console.ReadLine().ToLower();

    string xabar = (rang == "qizil") ? "To'xtang!"
                : (rang == "sariq") ? "Tayyorlaning!"
                : (rang == "yashil" && oldingiRang == "yashil") ? "Tez yurmayman!"
                : (rang == "yashil") ? "Yuring!"
                : "Noma'lum rang!";

    Console.WriteLine(xabar);

    oldingiRang = rang;
}
