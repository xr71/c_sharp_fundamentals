# References vs Values

### Reference Type

```csharp
var b = new Book("example");
```

- create space in memory to store b
- there will be a pointer address that references to the BOOK OBJECT
- b does not actually contain the book
  - states are references themselves
  - properties and methods are associated with the book object

### Value Type

```csharp
int x = 3;
```

- memory is created to store just the value 3
- x does not hold a pointer address, it contains the memsize of the int 3

### Using a Solution File to Simplify Build Tasks

- goto the dir that contains the `src` and `test` dirs
- run `dotnet new sln` to create a new solution
- use `dotnet sln add` to add project dirs to the solution file

Note: by convention, `public` members usually use a capital letter start to variable while a `private` member usually starts with a lowercase letter

### Differentiating Value vs Reference

When we initialize something from a class definition, we are working with a reference type  
When we define something as a struct, it is a value type (as are primitive types)  
Remember that `string` is reference type but it often behaves like a value type

### Garbage Collection

- dotnet runtime can do this automatically
- ther is no need to manually free up unused objects in memory
