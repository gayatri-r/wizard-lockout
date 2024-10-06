using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonParentBehavior : MonoBehaviour
{
  private int total = 0;
    public GameObject gate;
    Animator gateAnimator;
    BoxCollider2D gateColl;

    void Start() {
      gateColl = gate.GetComponent<BoxCollider2D>();
      gateAnimator = gate.GetComponent<Animator>();
    }

    void FixedUpdate() {
      if(total == 3) {
        GateUp();
      }
      else{
        GateDown();
      }
    }

    public void ButtonDepressed(bool pressed) {
      if(pressed) {
        total++;
        Debug.Log(total);
      }
      else{
        total--;
        Debug.Log(total);
      }
    }

    private void GateUp() {
      Debug.Log("UP!");
      gate.layer = LayerMask.NameToLayer("Trigger");
      gateColl.isTrigger = true;
      gateAnimator.SetBool("Locked", false);
    }
    private void GateDown() {
      Debug.Log("DOWN!");
      gate.layer = LayerMask.NameToLayer("Unwalkable");
      gateColl.isTrigger = false;
      gateAnimator.SetBool("Locked", true);
    }
}
