namespace ObelixAndCo.Cells;

public class Cell
{
    public bool IsOccupied;
    protected char _symbol;

    public char Symbol
    {
        get
        {
            if (IsOccupied == false)
            {
                return Char.ToLower(_symbol);
            }
            else
            {
                return Char.ToUpper(_symbol);
            }
        }
    }

    public Cell()
    {
        IsOccupied = false;
        _symbol = ' ';
       
        
    
    }
    
    

}