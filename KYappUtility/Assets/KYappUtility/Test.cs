using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KYapp.Utility.KYAPPrefab;

public class Test : KYAPPrefabManager
{
    // Start is called before the first frame update
    void Start()
    {
        Prefab = new GameObject();
        for (int i = 0; i < 100; i++)
        {
            KYAPPInstantiate();
        }
    }

    protected override void KYAPPrefabStart()
    {
        GameObjects[Index].transform.position += new Vector3(0.1f, 0.1f, 0.1f);
    }
    protected override void KYAPPrefabUpdate()
    {
        GameObjects[Index].transform.position += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
