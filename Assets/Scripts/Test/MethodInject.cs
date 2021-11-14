using Zenject;
using UnityEngine;
using System.Collections;

public class MethodInject : MonoBehaviour
{
    public IBar _bar;
    public IQux _qux;

    [Inject]
    public void Init(IBar bar, IQux qux)
    {
        _bar = bar;
        _qux = qux;
        Debug.Log("[MethodInject] Init called!");

        bar.Print();
        _qux.Print();
    }
}