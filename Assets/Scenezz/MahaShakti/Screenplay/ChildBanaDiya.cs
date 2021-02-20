using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBanaDiya : MonoBehaviour
{
    public GameObject parentIseBanaDo;
    public bool defaultSetup;

    // Start is called before the first frame update
    void Start()
    {
        if (defaultSetup)
        {
            DefaultParent();
        }
        else {
            ParentKaun();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent == null)
        {
            if (defaultSetup)
            {
                DefaultParent();
            }
            else
            {
                ParentKaun();
            }
        }
    }

    void DefaultParent() {
        parentIseBanaDo = GameObject.Find("Khopra");
        gameObject.transform.SetParent(parentIseBanaDo.transform);
    }

    void ParentKaun() {        
        gameObject.transform.SetParent(parentIseBanaDo.transform);
    }
}
