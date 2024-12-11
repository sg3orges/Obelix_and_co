namespace ObelixAndCo.Cells;

public class Pond : Cell
{
    public int Seed { get; }

    public Pond(int x, int y)
    {
        Seed = 5 * x + 5000 * y;
        _symbol = 'P';
        
    }


    
}
