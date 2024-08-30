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

//for loops run a specific number of iterations
for(int i = 1; i < 6; i++){
    Console.WriteLine($"Hello {aFriend} the counter is {i}");
}
Console.WriteLine("The program will now make a rectangle of * based on the dimensions you give it");
Console.WriteLine("Choose a number of rows");
string row = Console.ReadLine();
Console.WriteLine("Choose a number of columsn");
string column = Console.ReadLine();
int rowNum = Convert.ToInt16(row);
int columnNum = Convert.ToInt16(column);
//for loops can be nested
for(int i = 0; i < rowNum; i++){
    for(int j = 0; j < columnNum; j++){
        Console.Write("* ");
    }
    Console.WriteLine();
}
//using conditional statements within a for loop
int divisThree = 0;
for(int i = 0; i < 20; i++){
    if( i % 3 == 0){
        divisThree += i;
    }
}
Console.WriteLine(divisThree);

//lists and collections
var names = new List<string> { "caleb", "davis", "Felipe" };
//var frank is just a representation of the of each items held in a list
//in names is giving varr frank a location of the items choosing which list
foreach (var frank in names){
    Console.WriteLine($"Hello {frank.ToUpper()}!");
}

//.Add & .Remove allows items in a list to be inserted or removed
Console.WriteLine();
names.Add("Luke");
names.Add("Kaelie");
names.Remove("Filipe");
foreach (var frank in names){
    Console.WriteLine($"Hello {frank.ToUpper()}!");
}
//you can select an individual number using []
Console.WriteLine($"My name is {names[0]}");
//.Count is similar to .Length it returns the number of items in the list
Console.WriteLine($"This list has {names.Count} names");

var index = names.IndexOf("Felipe");
if (index != -1){
    Console.WriteLine($"The name {names[index]} is at index {index}");
}
var fibonacciNumbers = new List<int> {1, 1};

while (fibonacciNumbers.Count < 20){
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers){
    Console.WriteLine(item);
}