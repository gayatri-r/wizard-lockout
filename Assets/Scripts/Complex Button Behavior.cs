using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexButtonBehavior : MonoBehaviour
{
    Animator buttonAnimator;
    // Start is called before the first frame update
    void Start () {
      buttonAnimator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other) {
      buttonAnimator.SetBool("On", true);
      //Debug.Log(numDown);
      SendMessageUpwards("ButtonDepressed", true);
    }

    void OnTriggerExit2D(Collider2D other) {
      //Debug.Log(numDown);
      buttonAnimator.SetBool("On", false);
      SendMessageUpwards("ButtonDepressed", false);
    }
}
