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
        for (int i = 0; i < 10000; i++)
        {
            KYAPPInstantiate();
        }
    }
    public override void KYAPPrefabStart()
    {

    }
    public override void KYAPPrefabUpdate()
    {
        MyGameObject.transform.position += new Vector3(0.1f, 0.1f, 0.1f);
    }
}