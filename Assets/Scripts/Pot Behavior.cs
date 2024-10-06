using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PotBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public GameObject key;
    void Start () {
        anim = GetComponent<Animator>();
    }

    public void FinishedBreaking() {
      Debug.Log("finished");
      gameObject.SetActive(false);
      key.SetActive(true);
      Debug.Log("COMPLETE");
    }

    void OnBreak(){
      Debug.Log("breaking");
      anim.SetTrigger("PlayerBreaks");
    }
}
