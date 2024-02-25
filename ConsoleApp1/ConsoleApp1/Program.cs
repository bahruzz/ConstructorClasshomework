

//using ConsoleApp1;

////Person person = new()
////{
////    Id = 1,
////    fullName = "Fatime Qayxanova",
////    age = 22,
////    position = "student"
////};
////Console.WriteLine(person.fullName);

////Person person = new(1, "Hacixan Hacixanov", 19, "Studen");

////Console.WriteLine(person.fullName);

////Person person = new Person();   
////Person person1 = new Person("Kamran");

////Person person = new Person("Azerbaycan","Turkye");
//using ConsoleApp1;
//using System;

//Person person1 = new()
//{
//    id = 1,
//    fullName = "Ilqar Shiriyev",
//    age = 26
//};

//Person person2 = new()
//{
//    id = 2,
//    fullName = "Reshad Agayev",
//    age = 21
//};

//Person person3 = new()
//{
//    id = 3,
//    fullName = "Nurlan Umudov",
//    age = 22
//};

//Person person4 = new()
//{
//    id = 4,
//    fullName = "Elmir Qafarzade",
//    age = 21
//};

//Person[] people ={person1,person2,person3,person4 };
//Person FindPersonById(Person[] people,int id)
//{
//    return people.FirstOrDefault(m => m.id == id);

//}

////Person result = FindPersonById(people, 12);

////if (result != null)
////{
////    string response = $" id:{result.id} fullName:{result.fullName} age:{result.age}";

////    Console.WriteLine(response);

////}
////else
////{
////    Console.WriteLine("Data not Found");
////}

////var result1 = result != null ? $" id:{result.id} fullName:{result.fullName} age:{result.age}" : "Not found";
////Console.WriteLine(result1);

////Person result = FindStudentById(people, 2);
////void ShowPersonById(Person person)
////{
////    if (result != null)
////    {
////        string response = $" id:{person.id} fullName:{person.fullName} age:{person.age}";

////        Console.WriteLine(response);

////    }
////    else
////    {
////        Console.WriteLine("Data not Found");
////    }
////}

////ShowPersonById(result);

//Person[] GetAllPersons(Person[] datas)
//{
//    return datas;
//}

//var allPeople = GetAllPersons(people);

//void ShowAllPeopel(Person[] datas)
//{
//    foreach (var item in datas)
//    {
//        string response = $" id:{item.id} fullName:{item.fullName} age:{item.age}";
//        Console.WriteLine(response);
//    }
//}

//ShowAllPeopel(allPeople);


//Person[] GetPeopleByName(Person[] people,string name)
//{
//    return people.Where(m=>m.fullName == name).ToArray();
//} 

//void ShowPeopleByName(Person[] datas)
//{
//    foreach (var item in datas)
//    {
//        string response = $" id:{item.id} fullName:{item.fullName} age:{item.age}";
//        Console.WriteLine(response);
//    }
//}

//ShowPeopleByName(GetPeopleByName(GetAllPersons(),"Behruz Agayev"));






using ConsoleApp1;

//Animal animal = new();
//animal.id = 5;
//animal.name = "Qartal";

////Console.WriteLine(animal.name);


//Bird bird = new Bird()
//{
//    id = 5,
//    name = "Qaranqus",
//};

////Console.WriteLine(bird.name);

//bird.Sound();

//Fish fish = new();