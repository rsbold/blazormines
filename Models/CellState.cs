namespace Models;
public class CellState
{
    public int Index{get;set;}
    public bool IsMine{get;set;}
    public bool IsShown{get;set;}
    public int NeighbourMines{get;set;}
}