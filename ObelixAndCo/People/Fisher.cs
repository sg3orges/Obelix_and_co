using ObelixAndCo.Cells;

namespace ObelixAndCo.People;

public class Fisher: Person
{
    private Random _random;
    
    
    public Fisher(Cell cell) : base(cell)
    {
        if ( cell is Pond p )
        {
            _random = new Random(p.Seed);
            Cell = cell;
        }
        else
        {
            throw new ArgumentException("The cell was not a pond.");
        }
    }

    public int Fish()
    {
        int a =_random.Next(0,3) ;
        return a;
    }
    
}