# AnyDataType
A datatype for strings, numerics, bool, and DateTime.

Any is a datatype capable of storing a number of different datatype values, and perform mathmatical and equality operations against other datatypes.

# Comparison Example #1:
```C#
Any variableA = "1";
if(variableA == 1)
{
  //true
}
```

# Comparison Example #2:
```C#
Any variableA = 1999L;
if(variableA == "1999")
{
  //true
}
```

# Comparison Example #3:
```C#
Any date = DateTime.Parse("2019/04/11");
if(date == "2019/04/11")
{
  //true
}
```

# Math Example #1
```C#
Any variableA = "45"
var result = variableA * 2; // 90
```

# Math Example #2
```C#
Any variableA = "45"
var result = variableA / 5; // 9
```

# String Addition 
```C#
Any variableA = "45"
var result = variableA + " trees"; // 45 trees
```

# String Multiplication
```C#
Any variableA = "taco"
var result = variableA * 3; // tacotacotaco
```
