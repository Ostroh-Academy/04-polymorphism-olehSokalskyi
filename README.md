[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/5ZerStQK)

**Назва роботи: Використання механізму віртуальних методів
Мета роботи: Ознайомитися з особливостями використання віртуальних методів.** 

**Теоретичні відомості**
Мова С# включає таку властивість, як поліморфізм – можливість для об’єктів різних класів, зв’язаних з допомогою наслідування, реагувати різними способами при виклику однієї функції-елементу. До найважливіших форм поліморфізму можна віднести:
перевантаження методів та операцій;
віртуальні методи (функції);
Перевантаження методів та операцій називаються статичним поліморфізмом, тому що він підтримується на етапі компіляції (тобто до запуску програми). Віртуальні методи відносяться до динамічного поліморфізму, тому що він реалізується при виконанні програм.
При використанні віртуального методу запит здійснюється з допомогою вказівника базового класу (або посилання), тобто середовище виконання С# вибирає правильно перевизначений метод у відповідному похідному класі, який зв’язаний з цим об’єктом.
Іноді метод визначається в базовому класі як віртуальний, але просто перевизначений в похідному класі. Якщо такий метод викликається через вказівник похідного класу, то використовується версія похідного класу. Це не поліморфна поведінка.
Завдяки використанню поліморфних методів та поліморфізму виклик функції-елемента може привести до різних дій, які залежать від типу об’єкту, який викликається.
Завдання
Написати програму, описавши батьківський та похідний класи і використавши віртуальні методи. За основу візьміть попередню лабораторну і додайте віртуальні методи. Використайте динамічне створення об’єктів та показчики на екземпляр класу. 
Продемонструвати роботу віртуальних методів на практичному прикладі коли наперед невідомо який об’єкт буде створено (невідомо на етапі компіляції):
  

      //Вибрати режим роботи-запитати в користувача, змінна userChoose
        if (userChoose=='1'){
            //Працюємо з одним об'єктом
            //Створюємо, ініціалізуємо ітд
    
        }
            else{
            //Працюємо з іншим об'єктом
            //Створюємо, ініціалізуємо ітд
        }
           //Виклик віртуальної функції через вказівник/показчик на базовий клас

Змініть віртуальні методи на звичайні та перевірте роботу програми. Проаналізуйте зміни.


Приклад програми:


> using System; using System.Collections.Generic; using System.Linq;
> using System.Text;
> 
> namespace ConsoleApplication1 {
>     class Celipsoid
>     {
>         public int a1, a2, a3, b1, b2, b3;
>         public double v;
>         virtual public void inita()
>         {
>             System.Console.WriteLine("Введiть пiвосi елiпсоїда a1, a2, a3:");
>             a1 = Convert.ToInt32(Console.ReadLine());
>             a2 = Convert.ToInt32(Console.ReadLine());
>             a3 = Convert.ToInt32(Console.ReadLine());
>         }
>         virtual public void initb()
>         {
>             System.Console.WriteLine("Введiть координати змiщення центру b1, b2, b3:");
>             b1 = Convert.ToInt32(Console.ReadLine());
>             b2 = Convert.ToInt32(Console.ReadLine());
>             b3 = Convert.ToInt32(Console.ReadLine());
>         }
>         virtual public void show()
>         {
>             Console.WriteLine("a1= " + a1);
>             Console.WriteLine("a2= " + a2);
>             Console.WriteLine("a3= " + a3);
>             Console.WriteLine("b1= " + b1);
>             Console.WriteLine("b2= " + b2);
>             Console.WriteLine("b3= " + b3);
>         }
>         virtual public double size()
>         {
>             v = 4.0 * a1 * a2 * a3 / 3.0;
>             Console.Write("v елiпсоїда = ");
>             Console.WriteLine(v);
>             return (v);
>         }
> 
>     }
>     class Cball : Celipsoid
>     {
>         public int r;
>         public override void inita()
>         {
>             System.Console.Write("Введiть радiус кулi:");
>             r = Convert.ToInt32(Console.ReadLine());
>             base.initb();
>         }
>         public override void show()
>         {
>             Console.WriteLine("r= " + r);
>             Console.WriteLine("b1= " + b1);
>             Console.WriteLine("b2= " + b2);
>             Console.WriteLine("b3= " + b3);
>         }
>         public override double size()
>         {
>             v = 4.0 * r * r * r / 3.0;
>             Console.Write("v кулi = ");
>             Console.WriteLine(v);
>             return (v);
>         }
>     }
> 
>     class Program
>     {
>         static void Main(string[] args)
>         {
>             int userSelect;
>             Celipsoid baseobj = new Celipsoid();
>             do
>             {
>                 Console.WriteLine("Enter '0' if you want to work with elipsoid and '1' - with ball");
>                 userSelect = Convert.ToInt32(Console.ReadLine());
>                 if (userSelect == 0)
>                 {
>                     baseobj = new Celipsoid();
>                     baseobj.initb();
>                 }
>                 else if (userSelect == 1)
>                 {
>                     baseobj = new Cball();
>                 }
>                 else
>                 {
>                     return;
>                 }
>                 baseobj.inita();
>                 baseobj.show();
>                 baseobj.size();
>             } while (true);
>         }
>     } }



Варіанти завдань 
Згідно попередньої роботи.

**Хід виконання**
1.	Розробити алгоритми створення класів згідно варіантів завдань.
2.	Написати відповідну програму на мові програмування С#. 
3		Проаналізувати роботу програми з віртуальними методами та звичайними. Тобто потрібно дослідити механізм динамічного поліморфізму. Зверніть увагу на приклад коду, зокрема на механізм створення об'єкту одного з класів. На етапі компіляції програми невідомо який вибір зробить користувач під час виконання програми. 
4.	Порівняти результати виконання програми з віртуальними методами та без віртуальних методів.
5.	В README файл додати скріншоти роботи програми з віртуальними методами і без віртуальних. Описати різницю. 

##Результат виконання:
Порівнюючи результат виконання програми з віртуальними методами та без можна дійти висновку що коли ви хочете дотримуватись правил поліморфізму використаням віртуальних методів є ключовим аспектом. 
Наглядний приклад не віртуальних методів:
> public void PrintEquationSystem()
>    {
>        for (int i = 0; i < coefficients.GetLength(0); i++)
>        {
>            for (int j = 0; j < coefficients.GetLength(1); j++)
>            {
>                if (j != coefficients.GetLength(1) - 1)
>                {
>                    Console.Write($"{coefficients[i, j]} * x{j + 1} + ");
>                }
>                else
>                {
>                     Console.Write($"{coefficients[i, j]} * x{j + 1} ");
>               }
>            }
>            Console.WriteLine($"= {terms[i]}");
>        }
>        Console.WriteLine();
>    }
Тут метод PrintEquationSystem буде працювати однаково бо він не є virtual. При спробі його перевизначити в класах нащадках помилок виявлено не буде натомість від буде рахуватись як власний метод класу нащадка а не батька
> public virtual bool CheckVectorSatisfies(double[] data)
> {
>     if(data.Length != coefficients.GetLength(1))
>     {
>         return false;
>     }
>     for(int i = 0 ; i< coefficients.GetLength(0); i++)
>     {
>         double sum = 0;
>         for(int j = 0; j < coefficients.GetLength(1); j++)
>         {
>             sum += coefficients[i, j] * data[j];
>         }
>         if(Math.Abs(sum - terms[i]) > 1e-6)
>         {
>             return false;
>         }
>     }
>     return true;
> }
Метод CheckVectorSatisfies є віртуальним що дає змогу його перевизначити його в нащадках за комопогою ключового слова override
Приклад:
> public override bool CheckVectorSatisfies(double[] x)
> {
>     if (x.Length != 3)
>     {
>         return false;
>     }
> 
>     return base.CheckVectorSatisfies(x);
> }
Цей метод знаходиться в класі LinearEquation який є прямим нащадком SystemOfEquations тим самим отримавши всі методи батька та можливість перевизачити ці самі методи якщо вони віртуальні. В даному випадку метод CheckVectorSatisfies є віртуальним в батьківському класі та був перевизначений нащадку.
>     if (x.Length != 3)
>     {
>         return false;
>     }
Це нові нововведення в методі. Часом є потреба лише доповнити метод але зберегти весь функціонал батька тому ми можемо використати такий код
> return base.CheckVectorSatisfies(x); 
Цей рядок надає змову викликати базовий функціонал методу CheckVectorSatisfies щоб не переписувати його повністю тим самим скоротивши код
## Порівняння
З вітуальним 
![image](https://github.com/olehSokalskyi/04-polymorphism-olehSokalskyi/assets/162996249/040f81d7-cd04-452e-b866-fe9783cb438c)

Без
![image](https://github.com/olehSokalskyi/04-polymorphism-olehSokalskyi/assets/162996249/b4341d81-3cf3-4767-8c88-c91793b427bd)

Якщо не використовувати base.CheckVectorSatisfies(x) то потрібно перевизначити повністю весь метод щоб отримати бажаний результат.
Цей підхід є не бажаним бо тоді порушуються правила поліморфізму та наслідування
##Висновок
Результат використання віртульних методів є подібний до звичайних якщо другий був правильно описаний але це не є добрим рішенням тому потрібно використовувати virtual та override.

