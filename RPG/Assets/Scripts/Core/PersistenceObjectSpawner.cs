using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class PersistenceObjectSpawner : MonoBehaviour
    {
        [SerializeField] GameObject persistenceObjectPrefab;

        static bool hasSpawned=false;
        private void Awake()
        {
            if (hasSpawned) return;
            SpawnPersistentObjects();

            hasSpawned = true;
        }

        private void SpawnPersistentObjects()
        {
            GameObject persistentobject = Instantiate(persistenceObjectPrefab);
            DontDestroyOnLoad(persistentobject);
        }
    }
}
