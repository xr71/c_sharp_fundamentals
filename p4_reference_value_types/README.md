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
