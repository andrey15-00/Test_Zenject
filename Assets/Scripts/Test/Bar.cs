using UnityEngine;


public class Bar :  IBar
{
    private int var = 5;

    public void Print()
    {
        Debug.Log("[Bar] Var: " + var);
    }
}