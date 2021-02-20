using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnCTRL : MonoBehaviour
{
    //public GameObject[] asurSaare;
    //public GameObject asurPrefab;
    public Transform[] spawnPoints;
    public float beat = 2f; //(60 / 130)*2f;
    private float timer;

    public ObjPooling objPooling;
    // Start is called before the first frame update
    void Start()
    {
        //GetAsursFromPool();
    }

    // Update is called once per frame
    void Update()
    {
        //if (timer>beat) {
        //    GameObject asurAaya = Instantiate(asurPrefab, spawnPoints[Random.Range(0,2)]);
        //    //asurAaya.transform.localPosition = Vector3.zero;
        //    timer -= beat;
        //}
        //timer += Time.deltaTime;

        if (timer > beat)
        {            
            GetAsursFromPool();
            timer -= beat;
        }
        timer += Time.deltaTime;
    }

    void GetAsursFromPool() {
        
        GameObject asurAaya = objPooling.GetAsur();
        if (asurAaya == null) {
            Debug.Log("Yeh KYA HE??");
            return;
        }
        asurAaya.transform.position = (spawnPoints[Random.Range(0, 2)].position);
        asurAaya.transform.rotation = (spawnPoints[Random.Range(0, 2)].rotation);
        
        //asurAaya.SetActive(true);
        asurAaya.GetComponent<EnemyAnimationCTRL>().BigResetCall();
    }
}
