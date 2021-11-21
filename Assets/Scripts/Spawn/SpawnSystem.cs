using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame
{
    public class SpawnSystem : ISpawnSystem
    {
        private Dictionary<Type, GameObject> _spawnables = new Dictionary<Type, GameObject>();

        public void Init(Dictionary<Type, GameObject> spawnables)
        {
            _spawnables = spawnables;
        }

        public T Spawn<T>(Transform parent, Vector3 position, Quaternion rotation) where T : ISpawnable
        {
            GameObject prefab = GetPrefab<T>();
            GameObject instance = GameObject.Instantiate((GameObject)((object)prefab));
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            return instance.GetComponent<T>();
        }

        public GameObject GetPrefab<T>() where T: ISpawnable
        {
            Type type = typeof(T);
            foreach(var prefab in _spawnables)
            {
                if(prefab.Key == type)
                {
                    return (GameObject)(object)prefab.Value;
                }
            }

            throw new Exception($"Prefab of type {type} not found!");
        }
    }
}
