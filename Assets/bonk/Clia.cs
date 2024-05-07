using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clia : MonoBehaviour
{
    public TMP_Text soma;
    public AudioSource clip;
    int a = 0;
    public float gira = 1f;   

    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            a++;
            print(a);
            soma.text = a.ToString();
            BouncingEffect();
            clip.Play();
        } 
    }

     void BouncingEffect()
     {
        gira+=10;
        //gameObject.transform.rotate(Vector3.foward, speedRotation *Time.deltaTime);

     }
}
