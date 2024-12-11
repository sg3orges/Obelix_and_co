using ObelixAndCo.Cells;

namespace ObelixAndCo.People;

public class Sculptor : Person
{
    public Sculptor(Cell cell) : base(cell)
    {
        Cell = cell;
        if (Cell is not Quarry)
        {
            throw new ArgumentException("The cell was not a quarry");
        }
        
    }

    public bool Sculpt()
    {
        if (Cell is Quarry quarry)
        {
            if (quarry.AmountLeft > 0)
            {
                quarry.Extract();
                return true;
            }
        }

        return false;
    }
}
