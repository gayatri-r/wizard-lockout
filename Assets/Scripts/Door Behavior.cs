using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public GameObject inv;
    private bool open;
    void Start () {
        anim = GetComponent<Animator>();
    }
    public void FinishedOpening() {
      int sceneID = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneID+1);
    }
    void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Player")) {
        if(inv.activeSelf) {
          Debug.Log("opening");
          anim.SetTrigger("Unlocked");
        }
      }
    }
}
