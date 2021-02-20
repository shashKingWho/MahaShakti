using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPooling : MonoBehaviour
{
    public static ObjPooling asurInstance;

    [SerializeField]
    GameObject pooledObject;
    bool noMoreObjInPool = true;
    List<GameObject> asursPool;

    public int pooledObjAmount = 5;


    private void Awake()
    {
        asurInstance = this;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        asursPool = new List<GameObject>();
        for (int i = 0; i <pooledObjAmount; i++) {
            GameObject asurNew = Instantiate(pooledObject);
            asurNew.SetActive(false);
            asursPool.Add(asurNew);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetAsur() {
        if (asursPool.Count > 0) {
            for (int i = 0; i < asursPool.Count; i++) {
                if (!asursPool[i].activeInHierarchy) {
                    return asursPool[i];
                }
            }
        }

        if (noMoreObjInPool) {
            GameObject asurNew = Instantiate(pooledObject);
            asurNew.SetActive(false);
            asursPool.Add(asurNew);
            return asurNew;
        }

        return null;
    }
}
