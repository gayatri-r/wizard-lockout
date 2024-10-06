using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public List<GameObject> dialogue;
    int i = 0;
    void Start()
    {
      dialogue[i].SetActive(true);
    }

    void OnEnter() {
      dialogue[i].SetActive(false);
      i++;
      if(i < dialogue.Count) {
        dialogue[i].SetActive(true);
      }
    }
}
