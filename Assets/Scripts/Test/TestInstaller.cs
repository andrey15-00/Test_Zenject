using Zenject;
using UnityEngine;
using System.Collections;
using UnityGame;

public class TestInstaller : MonoInstaller
{
    public MethodInject _methodInject;
    MethodInjectNonMonoBehaviour mongo = new MethodInjectNonMonoBehaviour();
    public GameStateMachine gameStateMachine;

    public override void InstallBindings()
    {
        // Constructor inject.
        Container.Bind<string>().FromInstance("Hello World ");
        Container.Bind<int>().FromInstance(6);
        Container.Bind<Greeter>().AsSingle().NonLazy();

        // Method inject.
        Container.Bind<IBar>().To<Bar>().AsSingle();
        Container.Bind<IQux>().To<Qux>().AsSingle();
        // Container.Bind<MethodInject>().AsSingle();
    }
}

public class Greeter
{
    public Greeter(string message, int number)
    {
        Debug.Log(message + number);
    }
}

public interface IQux
{
    public void Print();
}

public interface IBar
{
    public void Print();
}