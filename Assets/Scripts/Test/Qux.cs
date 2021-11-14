using Zenject;
using UnityEngine;
using System.Collections;


public class Qux :  IQux
{
    private int var = 5;

    public void Print()
    {
        Debug.Log("[Qux] Var: " + var);
    }
}