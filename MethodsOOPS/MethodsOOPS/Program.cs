// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


School school = new School();
school.getSchoolName();

Student student = new Student();
student.getSchoolName();

AvoidIneritance avoidIneritance = new AvoidIneritance();
MystaticClass.StaticMethod();

//MyAbstractClass myAbstract=new MyAbstractClass();


class School:MyAbstractClass
{
   

    public void getSchoolName()
    {
        Console.WriteLine("it will return school name");
    }


}

class Student: School
{
    public void GetDetails()
    {
        Console.WriteLine("It will return Name, Age, Gender");
    }

    public void GetDetails(string Name)
    {
        Console.WriteLine("It will return Name");
    }

    public void GetDetails(int Age)
    {
        Console.WriteLine("It will return Age");
    }

    public new void getSchoolName()
    {
        Console.WriteLine("School name will come from class student");
    }
}

sealed class AvoidIneritance
{
    public void secureMethod()
    {
        Console.WriteLine("This is ssecure");
    }
}

static class MystaticClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("This is static Method");
    }
}

abstract class MyAbstractClass
{
    public void AbstractMethod()
    {
        Console.WriteLine("abstract Method");
    }
}

