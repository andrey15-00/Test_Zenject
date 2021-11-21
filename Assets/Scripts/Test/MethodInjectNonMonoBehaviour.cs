using Zenject;
using UnityEngine;
using System.Collections;
using UnityGame;

public class MethodInjectNonMonoBehaviour
{
    public IBar _bar;
    public IQux _qux;

    [Inject]
    public void Init(IGameStateMachine machine)
    {
        Debug.Log("[MethodInjectNonMonoBehaviour] Init called!");
    }
}