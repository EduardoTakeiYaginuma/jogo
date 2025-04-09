using UnityEngine;

public static class GameController 
{
    private static int colletableCount = 0;

    public static bool gameOver 
    {
        get { return colletableCount <= 0; }
    }

    public static void Init()
    {
        colletableCount = 4;
    }

    public static void Collect()
    {
        colletableCount--;
    }

    public static int VidasRestantes
    {
        get { return colletableCount; }
    }

}
