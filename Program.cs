// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

//declaring the variable starts with data type followed by variable
//name then giving the variable a value
string aFriend = "Davis";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
string bFriend = "Luke";
Console.WriteLine($"Hello {aFriend} and {bFriend}");

//.Length is a function that allows the length of a string to be
//counted and returned as an integer
int aLength = aFriend.Length;
int bLength = bFriend.Length;
Console.WriteLine($"The name {aFriend} has {aLength} letters");
Console.WriteLine($"The name {bFriend} has {bLength} letters.");
string greet = "Hello World!       ";
Console.WriteLine($"[{greet}]");

string trimgreet = greet.TrimStart();
Console.WriteLine($"[{trimgreet}]");

//value of a variable can be reassigned
//when reassigning value the data type is not specified.
trimgreet = greet.TrimEnd();
Console.WriteLine($"[{trimgreet}]");

//values can also be replaced similar whilst reassiging a value
//first value in the parathesis is the word you wish to replace
//second is what you which to replace it with
trimgreet = trimgreet.Replace("World", aFriend);
Console.WriteLine($"[{trimgreet}]");
if(trimgreet.Contains(aFriend)){
    Console.WriteLine($"{aFriend} is present");
}
else if (trimgreet.Contains(bFriend)){
    Console.WriteLine($"{bFriend} is present");
}
else{
    Console.WriteLine("No one is here");
}
if(greet.StartsWith("Hello")){
    Console.WriteLine("Starts with Hello");
}

// operands include == + - / % *
int a = 18;
int b = 6;
// "/" represents division, when using integers it will always return a whole number
int c = a / b;
Console.WriteLine(c);
// "%" represents modulus which returns the remainder when a int is divided
c = a % b;
Console.WriteLine(c);
// == is used to compare to integers or numerical data types (floats compared to floats etc...)
if(a == b){
    Console.WriteLine("a = b");
}
// order of operations is applied to mathmatical problems
c = a + b * c;
Console.WriteLine(c);
c = (a + b) * c;
Console.WriteLine(c);

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
//overflow is when the max value is exceeded
//the number wraps so once you hit the max value it will start at the other end and continue
int what = max + 100;
Console.WriteLine($"An Example of overflow... {what}");
//another numerical data type is the double
double doubleMax = double.MaxValue;
double doubleMin = double.MinValue;
Console.WriteLine($"the range of a double is {doubleMin} to {doubleMax}");

//another numbercal data type is the decimal which allows for more precise decimal points
double one = 1;
double third = 3;
Console.WriteLine(one/third);
decimal uno = 1;
decimal trace = 3;
//the double goes to fewer decimal points than the decimal
Console.WriteLine(uno/trace);
Console.WriteLine();
Console.WriteLine("Choose a radius of a cicle");
string radius = Console.ReadLine();
double r = Convert.ToDouble(radius);
double circleArea = (r*r) * Math.PI;
Console.WriteLine($"The area of a circle with radius {r} is {circleArea}");

//loops and conditional statements are the same format as Java
if (circleArea >= 15){
    Console.WriteLine($"The area of the circle {circleArea} is greater than 15");
}
else{
    Console.WriteLine($"The area of the circle {circleArea} is less than 15");
}
int counter = 6;
//++ or -- increments the value by one either up or down respectively
//do while will run the code of the while loop once and then if the the while statement
//is true then it will enter the while loop, if not then it won't
do{
    counter++;
    //conditional statements and loops can be nested within other loops
    if(counter > 1){
        Console.WriteLine($"This loop has run {counter} times");
    }
    else{
        Console.WriteLine($"This loop has run {counter} time");
    }
}
while (counter < 5);{
    counter++;
    //conditional statements and loops can be nested within other loops
    if(counter > 1){
        Console.WriteLine($"This loop has run {counter} times");
    }
    else{
        Console.WriteLine($"This loop has run {counter} time");
    }
}