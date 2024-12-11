namespace ObelixAndCo.Cells;

public class Hut : Cell
{
    private int _nbWorkers;

    public Hut()
    {
        _nbWorkers = 0;
        _symbol = 'H';
    }


    public void AddWorker()
    {
       
        if (_nbWorkers < 5)
        {
            _nbWorkers = _nbWorkers + 1;
            if (_nbWorkers == 5)
            {
                IsOccupied = true;
            }
            
        }

        
        else
        {
            throw new Exception();
        }
    }

}
