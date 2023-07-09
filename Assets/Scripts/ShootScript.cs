using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera arCamera;
    public GameObject popSoundObject;
    public static int  score;
     public Text scoreText;
   public void Shoot(){
    RaycastHit hit;
    if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
        if(hit.transform.name == "balloon1(Clone)" ||hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)" ){
            Destroy(hit.transform.gameObject);
            Instantiate(popSoundObject);
            score=score+1;
            scoreText.text= score + "";
        }
    }
   }
}
