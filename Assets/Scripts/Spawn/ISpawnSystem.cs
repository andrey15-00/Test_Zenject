using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame
{
    public interface ISpawnSystem
    {
        public void Init(Dictionary<Type, GameObject> spawnables);

        public T Spawn<T>(Transform parent, Vector3 position, Quaternion rotation) where T : ISpawnable;
    }
}
