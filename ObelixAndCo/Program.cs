// See https://aka.ms/new-console-template for more information

using ObelixAndCo.Cells;
using ObelixAndCo.People;

Console.WriteLine("Hello, World!");


Console.WriteLine(new Cell().IsOccupied); // False
Console.WriteLine(new Cell().Symbol); // ' '


var forest = new Forest();
Console.WriteLine(forest.Density); // 1
Console.WriteLine(forest.Symbol); // f
forest.IsOccupied = true;
Console.WriteLine(forest.Symbol); // F


var f = new Forest();
f.DecreaseDensity();
Console.WriteLine(f.Density); // 0.95
f.Density = 0.01;    // if we manually set the Density to 0.01
f.DecreaseDensity(); // this should not go below 0
Console.WriteLine(f.Density); // 0

Console.WriteLine(new Quarry().Symbol); // q

Console.WriteLine(new Pond(1, 2).Symbol); // p
Console.WriteLine(new Pond(1, 2).Seed); // 10005




Console.WriteLine(new Hut().Symbol); // h
Console.WriteLine(new Hut().IsOccupied); // False




var hut = new Hut();
Console.WriteLine(hut.IsOccupied); // False
for (int i = 0; i < 5; i++)
    hut.AddWorker(); // we can add 5 workers
Console.WriteLine(hut.IsOccupied); // True







Fisher fisher = new Fisher(new Pond(0, 0));
Console.WriteLine(fisher.Fish()); // 2
Console.WriteLine(fisher.Fish()); // 2
Console.WriteLine(fisher.Fish()); // 2
Console.WriteLine(fisher.Fish()); // 1
Console.WriteLine(fisher.Fish()); // 0
Console.WriteLine(fisher.Fish()); // 1

Cell cell = new Pond(1, 1);
Fisher fisher2 = new Fisher(cell);


