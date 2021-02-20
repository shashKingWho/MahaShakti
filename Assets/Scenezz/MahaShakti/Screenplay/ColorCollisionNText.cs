using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ColorCollisionNText : MonoBehaviour
{
    public List<Material> colorList;
    //public Material specialMat;
    //public GameObject sphere;
    public List<GameObject> hotBody;
    //public TMP_Text texty;
    public int indexNo;

    //[Header("CoolShaderDissolve")]
    //public bool maraTohGayabHo = false;
    //public float dissolveSpeed = .08f;
    //Material[] mats;
    //public Material MATDissolve;

    // Start is called before the first frame update
    void Start()
    {
        indexNo = 0;
        ColorChangerrr();
    }

    // Update is called once per frame
    void Update()
    {
        //if (maraTohGayabHo)
        //{
        //    ColorOfDeath();
        //}
       


    }


    public void ColorChangerrr() {
        indexNo = Random.Range(0, colorList.Count);        
        foreach (GameObject colora in hotBody) {
            colora.GetComponent<SkinnedMeshRenderer>().material = colorList[indexNo];
            //carBody.GetComponent<MeshRenderer>().material = colorList[indexNo];

        }
        //texty.text = colorNames[indexNo].ToString();

        //Incrementorrr();

    }

    //IEnumerator Timer() {
    //    sphere.GetComponent<SphereCollider>().enabled = false;        
    //    yield return new WaitForSeconds(.3f);
    //    sphere.GetComponent<SphereCollider>().enabled = true;
    //}

    //IEnumerator Timer() { 
    //yield return new WaitForSeconds(.7f);
    //    dissolveSpeed = .04f;
    //    yield return new WaitForSeconds(.5f);
    //    dissolveSpeed = .08f;

    //}



    public void Incrementorrr() {
        if (indexNo >= colorList.Count)
        {
            indexNo = 0;
        }

        indexNo++;
        //Debug.Log(indexNo);
    }

    //public void ColorOfDeath()
    //{
    //    foreach (GameObject colora in hotBody)
    //    {
    //        colora.GetComponent<SkinnedMeshRenderer>().material = MATDissolve;
    //    }
    //    float t = 0.0f;
    //    foreach (GameObject colora in hotBody)
    //    {
    //        mats = colora.GetComponent<SkinnedMeshRenderer>().materials;
    //    }

    //    mats[0].SetFloat("_Cutoff", Mathf.Sin(t * dissolveSpeed));
    //    t += Time.deltaTime;

    //    foreach (GameObject colora in hotBody)
    //    {
    //        colora.GetComponent<SkinnedMeshRenderer>().materials = mats;
    //    }
    //}
}
