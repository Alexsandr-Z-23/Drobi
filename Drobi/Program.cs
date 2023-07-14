using Drobi;



int Den1, Num1, Den2, Num2;
Console.WriteLine("Введите числитель первой дроби");
Num1= Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите знаменатель первой дроби");
Den1 = Convert.ToInt32(Console.ReadLine());
Tdrob d1 = new Tdrob { num = Num1, denum=Den1 };
Console.WriteLine($"**************************************");

Console.WriteLine("Введите числитель второй дроби");
Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знаменатель второй дроби");
Den2 = Convert.ToInt32(Console.ReadLine());
Tdrob d2 = new Tdrob { num = Num2, denum = Den2 };
Console.WriteLine($"\n**************************************");

d1.Print1();
d2.Print2();
Console.WriteLine($"\n**************************************");
Tdrob d3 =new Tdrob { num=5 };
d3.Print1();
Console.WriteLine($"\n**************************************");
Tdrob C1 = new Tdrob {  };
C1 = d1 + d2;

C1.Print();
Console.WriteLine($"**************************************");
(int num, int dnum) = C1;
Console.WriteLine($"Числитель => {num};\nЗнаменатель => {dnum};");