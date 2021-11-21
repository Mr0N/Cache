## Code sample
```csharp
using BufferEnumerable;

int count = 0;
var res = Enumerable.Range(0, 5).Select(a =>
{
    if (count == 3)
        Console.WriteLine("|3|");
    count++;
    return count;
}).ToBuffer();

foreach (var item in res)
{
    Console.WriteLine(item);
}

foreach (var item in res)
{
    Console.WriteLine(item);
}

Console.ReadLine();
```

## Execution results
```     
1
2
3
|3|
4
5
1
2
3
4
5
```
