

//Employee adinda class yaradin,
//    Class -in id, name, surname, address, email, age fieldleri olacaq.
//    Proqram.cs - de ashagidaki methodlari      yazin. 
//    1)  Yashi methoda parametr kimi gelen yashdan boyuk olan 
//employee -lerin  siyahisini qaytaran method.
//    2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.
//    3)  Butun Emloyeelerin yashlarinin cemini qaytaran method.
//    4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.

using Homeworktasks;
using System;
using System.Numerics;
using System.Xml.Linq;

Employee employee1 = new()
{
    id = 1,
    name = "Qabil",
    surName = "Memmedov",
    adress = "Surakhani",
    email="memmedov26@gmail.com",
    age = 26
  
};


Employee employee2 = new()
{
    id = 2,
    name = "Famil",
    surName = "Axundov",
    adress = "ehmedli",
    email = "axundov@gmail.com",
    age = 30

};



Employee employee3 = new()
{
    id = 3,
    name = "Samir",
    surName = "Sariyev",
    adress = "Xetai",
    email = "Samir@gmail.com",
    age = 28

};



Employee employee4 = new()
{
    id = 4,
    name = "Aqil",
    surName = "Dadasov",
    adress = "Ecemi",
    email = "dadasov@gmail.com",
    age = 24

};





//1)  Yashi methoda parametr kimi gelen yashdan boyuk olan 
//employee -lerin  siyahisini qaytaran method.

Employee[] employee = { employee1, employee2, employee3, employee4 };

void GetByAge(Employee[] employees, int age)
{

    foreach (var item in employees)
    {
        if (item.age > age)
        {
            Console.WriteLine($" id:{item.id} name:{item.name} surName:{item.surName} adress:{item.adress}" +
                $" email:{item.email} age:{item.age}");

        }
    }
}

GetByAge(employee, 25);

//2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.

//void GetCountByAge(Employee[] employees)
//{
//    int count = 0;

//    foreach (var item in employees)
//    {
//        if (item.age >= 20 && item.age <= 30)
//        {
//            count++;

//        }

//    }
//    Console.WriteLine(count);
//}
//GetCountByAge(employee);


//3)  Butun Emloyeelerin yashlarinin cemini qaytaran method.

//void GetSumOffAge(Employee[] employees)
//{
//    int sum = 0;

//    foreach (var item in employees)
//    {

//        sum += item.age;

//    }
//    Console.WriteLine(sum);
//}
//GetSumOffAge(employee);



//1)  Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin



CustomMash customMash = new();
//int[] arr = { 2, 3, 4, 5, 6, 7, 9 };
//Console.WriteLine(customMash.SumOffOddNumbers(arr));


//2.Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.

//customMash.GetOddNums(5);

//3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq

//int[] arr = { 2, 3, 4, 5, 6, 7, 9 };

//Console.WriteLine(customMash.GetOddArrays(arr));


//4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };


//Console.WriteLine(customMash.ArraysResult(arr,5));