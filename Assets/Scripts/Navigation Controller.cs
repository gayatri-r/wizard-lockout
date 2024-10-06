using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationController : MonoBehaviour
{
  public void LoadLevel()
  {
    SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
  }

  void OnEnter() {
    SceneManager.LoadScene("Menu", LoadSceneMode.Single);
  }
}
