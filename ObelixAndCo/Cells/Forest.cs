namespace ObelixAndCo.Cells;

public class Forest : Cell
{
    public double Density { get; set; }

    public Forest()
    {
        
        Density = 1.0;
        _symbol = 'F';
    }

    public void DecreaseDensity()
    {
        if (Density - 0.01 >= 0 )
        {
            Density = Density - 0.01;
        }
    }

}
