using System;

// Constructors are the building blocks that enable you to create classes and struct-s. A class or struct can have multiple constructors.
// These constructors allow the developer to set default values, limit instantiation, and write applications/code that is easy to read/maintain/extend.
//
// You should use Constructors when your class for example needs to manipulate an object that it requires.
// If you do not provide any constructors for your class or struct, C# is going to create one by default.
// This, in turn, instantiates the object and sets member variables to the default values (often 0 or false) based on their datatypes.
//
// Constructors are special methods where the name is the same as its type.
// The method signature only consists of the method name and its parameter list,
// and it does not include a return type. This is an example of that, these constructors create a new object -
// INSTANCE CONSTRUCTORS:
public class ProgrammingLanguage
{
    private string name;
    private double version;

    public ProgrammingLanguage(string languageName, double languageVersion)
    {
        name = languageName;
        version = languageVersion;
    }
}
// Let's explore a "single like statement" a.k.a.
// "expression body definition". This expression definition assigns the argument to the languageName:
public class Language
{
    private string languageName;

    public Language(string name) => Name = name;

    public string Name
    {
        get => languageName;
        set => languageName = value;
    }
}
// These constructor types are used when you initialize any instance member variable,
// using the "new" expression to create an object of a class.
//  *************************************************************************************
//  
// The classes and structs can also have "static constructors" that initialize static members of a specific type.
// These are usually parameterless. If you do not provide a static constructor to initialize the static fields,
// the C# compiler recognizes it and these fields are initialized to their default values.
// 
// It's important, in order to initialize a static class or static variable in a non-static class, that you define a static constructor.
// The static constructors are used to initialize any static data or just to perform an action/calculation that needs to be performed once.
// It is called automagically before the first instance is created or any static members are referenced:
public class Python : Language
{
    private static double minimumVersion;

    public Python(string creator, string languageType) : base(creator, languageType)
    { }

    static Python()
    {
        minimumVersion = 3.8;
    }

}
// Let's explore a "single like statement" a.k.a.
// "expression body definition":
public class Ruby : Language
{
    private static double minimumVersion;

    public Ruby(string creator, string languageType) : base(creator, languageType)
    { }

    static Ruby() => minimumVersion = 18;
}
//  Use the Logger class when a class uses some file to write logs or data.
//  Use the Wrapper class for unmanaged code.
//  Enforce runtime checks of parameters which cannot be checked via compile - time constraints.
//  *************************************************************************************
//  
// Here is an example of an instance constructor that is called parameterless:
class VillageCoordinates
{
    public double lat, lng;

    // constructor
    public VillageCoordinates()
    {
        lat = 0;
        lng = 0;
    }
}

// If you are using public fields, you need to be aware that it is not really recommended.
// The public fields allow any method anywhere in the program - unrestricted and unverified access
// to the given objects’ internal workings. These members should generally be private and should be accessed
// only through class properties and methods.

// Let's add another constructor which takes two arguments:
public VillageCoordinates(double lat, double lng)
{
    this.lat = lat;
    this.lng = lng;
}
// The instance constructor is called whenever an object based on the VillageCoordinates class is created.
// It is often useful to provide different types of constructors as your application matures to ease the creation of new objects.
//
// Now you are able to create villages with default or specific initial values:
VillageCoordinates Village1 = new VillageCoordinates();
VillageCoordinates Village2 = new VillageCoordinates(10.4, 20.2);

//  *************************************************************************************
//  PRIVATE CONSTRUCTOR
//  Private constructors are very similar as to how the Math class works. It prevents the creation of instances
//  when there is no instance field or method, or when a method is called to obtain an instance of a class.
//  This is a special type of instance constructor. The main instance for usage is when your classes only have static members.
//  If a class has one or more private constructors and no public constructors, other classes are not able to create instances
//  of this class; except the nested classes inside this class. 
//  For example:
class Vehicle
{
    private Vehicle() { }
    public static int wheels = 4;
}
//  Constructors can be marked as public, private, protected, internal, protected internal or private protected.
//
//  If you declare an empty constructor, the C# compiler will not dynamically generate a parameter-less constructor.
//  If you do not use an access modifier with the constructor, it will also become a private constructor by default.
//  Using the private keywords makes it obvious for developers by explicitly stating the type.
//
//  Does constructor return any value?
//  There are no “return value” statements in the constructor, but the constructor returns the current class instance.
//  We can write 'return' inside a constructor.
//  the reason the constructor doesn't return a value is because it's not called directly by your code,
//  it's called by the memory allocation and object initialization code in the runtime.
//
//  A user can implement constructor overloading by defining two or more constructors in a class sharing the same name.
//  C# can distinguish the constructors with different signatures. i.e. the constructor must have the same name but with different parameters list.
//
//  Constructors that take parameters must be called through a new statement or a base statement.
//
//  .