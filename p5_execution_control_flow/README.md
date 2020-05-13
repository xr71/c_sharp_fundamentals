# Control Flow

we can use:

- foreach
- for loops
- while loops
- do...while loops

we can use jumps:

- break
- continue
- goto

using switch statement:

```csharp
switch(letter)
{
    case 'A' : AddGrade(90); break;
    case 'B' : AddGrade(80); break;

    default : AddGrade(0); break;
}
```

pattern matching switch statement:

```csharp
case var d when d >= 90.0 :
    result.Letter = 'A';
    break;

case var d when d >= 80.0 :
    result.Letter = 'B';
    break;

default:
    result.Letter = 'F';
    break;

```

## Building Types

- we can use multiple types in method overloading 
- we can use getters and setters to avoid making a property public
    - we can do this using `get` and `set`
- better yet, we can use a shorthand for properties
    ```csharp
    public string Name
    {
        get; set;
    }
    ```
- this is an auto property
- use readonly to define a variable that can only be set during init `readonly string name`
- const is even more strict, can only be assigned during variaable declaration `const string NAME = "FIELD"`
    - const is not a state in each instance, so it is accessed from the Class definition, not the instance

### Events and Delegates
- the delegate type
- delegates in csharp are multi-cast delegates, they can be assigned with multiple methods




