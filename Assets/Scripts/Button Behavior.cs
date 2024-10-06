using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    Animator buttonAnimator;
    public GameObject gate;
    Animator gateAnimator;
    BoxCollider2D gateColl;
    private int numDown;
    // Start is called before the first frame update
    void Start () {
      buttonAnimator = GetComponent<Animator>();
      gateColl = gate.GetComponent<BoxCollider2D>();
      gateAnimator = gate.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other) {
      buttonAnimator.SetBool("On", true);
      if(other.CompareTag("Box")) { Debug.Log("BOX!!!!!"); }
      //Debug.Log(numDown);
      gate.layer = LayerMask.NameToLayer("Trigger");
      gateColl.isTrigger = true;
      gateAnimator.SetBool("Locked", false);
    }

    void OnTriggerExit2D(Collider2D other) {
      //Debug.Log(numDown);
      buttonAnimator.SetBool("On", false);
      gate.layer = LayerMask.NameToLayer("Unwalkable");
      gateColl.isTrigger = false;
      gateAnimator.SetBool("Locked", true);
    }
}
