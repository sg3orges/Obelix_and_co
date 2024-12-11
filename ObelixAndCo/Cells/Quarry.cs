namespace ObelixAndCo.Cells;

public class Quarry : Cell
{
    public int AmountLeft;

    public Quarry()
    {
        _symbol = 'Q';
        AmountLeft = 20;
        
    }

    public void Extract()
    {
        if (AmountLeft== 0)
        {
            throw new Exception();
        }
        else
        {
            AmountLeft = AmountLeft - 1;
        }
    }


}
