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
