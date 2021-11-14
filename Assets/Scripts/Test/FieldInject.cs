using Zenject;
using UnityEngine;
using System.Collections;


public class FieldInject : MonoBehaviour
{
    [Inject]
    public IBar _bar;

    private void Start()
    {
        Debug.Log("[FieldInject] Start called!");
        _bar.Print();
    }
}