using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationCTRL : MonoBehaviour
{
    public Animator enemyAnimator;
    public bool Maara_left, Maara_right, Maara_aage, Maara_Peeche;
    public bool marGayaBool = false;

    [Header("Magic here")]
    public GameObject asuree;
    public AudioSource bajaa;
    public List<AudioClip> antarakshari;
    public EnemyMove_Translate enemyMove_Translate;
    public ColorCollisionNText colorCollisionNText;
    public bool isPlaying;
    public AudioSource kadamtaal;

    // Start is called before the first frame update
    void Start()
    {
        //bajaa = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Maara_right)
        {
            Right_Hook();
            marGayaBool = true;
        }
        if (Maara_aage)
        {
            Haymaker();
            marGayaBool = true;
        }
        if (Maara_left)
        {
            Left_Hook();
            marGayaBool = true;
        }
        if (Maara_Peeche)
        {
            Back_stab();
            marGayaBool = true;
        }

        if (bajaa == null)
        {
            bajaa = gameObject.GetComponent<AudioSource>();
        }
        if (marGayaBool)
        {
            KutteKiMaut();
            StartCoroutine(DeathHappened());

        }
    }

    public void Haymaker()
    {
        Maara_left = false;
        Maara_right = false;
        Maara_Peeche = false;

        enemyAnimator.SetTrigger("AageMara");
        marGayaBool = false;
    }
    public void Left_Hook()
    {

        Maara_right = false;
        Maara_Peeche = false;
        Maara_aage = false;
        //play animation
        //enemyAnimator.SetBool("LeftMara", Maara_left);
        enemyAnimator.SetTrigger("Lefty");
        marGayaBool = false;
    }
    public void Right_Hook()
    {
        Maara_left = false;

        Maara_Peeche = false;
        Maara_aage = false;
        //play animation
        //enemyAnimator.SetBool("RightMaara", Maara_right);
        enemyAnimator.SetTrigger("Righty");
        marGayaBool = false;

    }

    public void Back_stab()
    {
        Maara_left = false;
        Maara_right = false;

        Maara_aage = false;
        //enemyAnimator.SetBool("BackMaara", Maara_Peeche);
        enemyAnimator.SetTrigger("BackMaaraaa");
        marGayaBool = false;
    }

    public void Anim_RESET()
    {

        enemyAnimator.SetTrigger("RESET");
        //colorCollisionNText.maraTohGayabHo = true;
    }

    public void BigResetCall()
    {
        Maara_left = false;
        Maara_right = false;
        Maara_Peeche = false;
        Maara_aage = false;
        Anim_RESET();
        enemyMove_Translate.enabled = true;
        marGayaBool = false;
        gameObject.SetActive(true);
        asuree.SetActive(true);
        //gameObject.GetComponent<AudioSource>().clip = antarakshari[2];
        Debug.Log("BATAAAAAAAAAAA NAAAAAAAAAA TU" + asuree.activeSelf);

        isPlaying = false;
        kadamtaal.enabled = true;
    }


    IEnumerator DeathHappened()
    {
        enemyMove_Translate.enabled = false;
        kadamtaal.enabled = false;
        //colorCollisionNText.maraTohGayabHo = true;
        //KutteKiMaut();
        yield return new WaitForSeconds(2.1f); //(1.4f);

        gameObject.SetActive(false);


    }

    //void KutteKiMaut()
    //{
    //    //int index;
    //    //index = Random.Range(0,2);
    //    //bajaa = gameObject.GetComponent<AudioSource>();
    //    bajaa.clip = antarakshari[1];
    //    bajaa.Play();
    //    Debug.Log(antarakshari[1]);
    //}

    void KutteKiMaut()
    {
        
            
        if (!isPlaying)
        {
            // do something
            bajaa.clip = antarakshari[1];
            bajaa.Play();
            Debug.Log(antarakshari[1]);
            isPlaying = true;
        } 
        
    }

}
