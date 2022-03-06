using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KYapp.Utility.KYAPPrefab
{
    /// <summary>
    /// このクラスを継承して使用する。
    /// 継承先のクラスは代表オブジェクト一つにアタッチする。
    /// 継承先クラスによって生成されたオブジェクトは全て、代表オブジェクトのパラメーター、代表オブジェクトの責任によって実行される。
    /// </summary>
    public class KYAPPrefabManager : MonoBehaviour
    {
        public GameObject Prefab;
        private List<GameObject> GameObjects = new List<GameObject>();

        private void Start()
        {

        }
        private void Update()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                KYAPPrefabUpdate(GameObjects[i], i);
            }
        }

        public void KYAPPInstantiate()
        {
            if (Prefab != null)
            {
                GameObjects.Add(Instantiate(Prefab));
                KYAPPrefabStart(GameObjects[GameObjects.Count - 1], GameObjects.Count - 1);
            }
        }


        protected virtual void KYAPPrefabStart(GameObject gameobject , int Index)
        {

        }
        protected virtual void KYAPPrefabUpdate(GameObject gameObject , int Index)
        {

        }
    }
}