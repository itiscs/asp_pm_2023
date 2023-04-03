
using LambdaApp;


ArOper ob = new ArOper();

//Func<Student,Student, bool>

Func<int,int,int> deleg = new Func<int,int,int>(ob.Sum);
//Func<int, int, bool> deleg = new Func<int, int, bool>(ob.Sum);

//MyDeleg deleg = new MyDeleg(ob.Sum);

Console.WriteLine(deleg(15, 6));

deleg = ob.Minus;

Console.WriteLine(deleg(15, 6));

deleg = ob.Mult;

Console.WriteLine(deleg(15, 6));

deleg = ob.Div;

Console.WriteLine(deleg(15, 6));


//deleg = delegate(int a,int b)
//{ return a > b ? a: b ; };

deleg = (a, b) => { int x = a; int y = b; return x + y; };


Console.WriteLine(deleg(45, 36));

deleg = ob.Mult;


//HelloDeleg h1 = new HelloDeleg(ob.Hello1);
Action h1 = new Action(ob.Hello1);

h1.Invoke();

//h1 -= ob.Hello1;
h1 += ob.Hello2;
//h1 += ob.Hello2;
//h1 += ob.Hello2;
//h1 += ob.Hello2;
//h1 += ob.Hello2;
h1 += () => { Console.WriteLine("Hello from lambda!"); };


h1?.Invoke(); /// if(h1!=null) h1();


Console.WriteLine("***************************************");

List<Student> studs = new List<Student>();
studs.Add(new Student()
{
    Id = 1,
    Name = "Ivan",
    Group = "01",
    Marks = { 4, 3, 5, 3, 4, 4, 4, 4, 4 }
});
studs.Add(new Student()
{
    Id = 2,
    Name = "Petr",
    Group = "01",
    Marks = { 4, 5, 5, 3, 5, 4, 4, 4, 4 }
}); 
studs.Add(new Student()
{
    Id = 3,
    Name = "Anna",
    Group = "01",
    Marks = { 4, 3, 5, 5, 5, 4, 5, 4, 4 }
});
studs.Add(new Student()
{
    Id = 4,
    Name = "Maria",
    Group = "02",
    Marks = { 4, 5,5,5,5,5,5, 4, 4, 4, 4, 3, 3, 3 }
});


//foreach(var st in studs)
//{
//    Console.WriteLine(st);  
//}


var st2 = studs.OrderBy(s => s.Group).ThenByDescending(s => s.Marks.Average());//.Where(s => s.Group == "01")
    //.Skip(1);

foreach (var st in st2)
{
    Console.WriteLine($"{st} {st.Marks.Average()}");
}

Console.WriteLine(studs.Max(s => s.Marks.Average()));

