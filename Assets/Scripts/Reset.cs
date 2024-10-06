using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public List<GameObject> blocks;
    public GameObject player;
    public GameObject target;
    public GameObject pot;
    public Sprite potSprite;
    public GameObject inv;
    public GameObject key;
    private Vector3 playerStart;
    private List<Vector3> locations = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
      playerStart = player.GetComponent<Transform>().position;
      foreach(GameObject block in blocks){
        locations.Add(block.GetComponent<Transform>().position);
      }
    }
    void OnReset(){
      Debug.Log("Reset");
      int i = 0;
      foreach(Vector3 location in locations){
        blocks[i].GetComponent<Transform>().position = location;
        i++;
      }
      player.GetComponent<Transform>().position = playerStart;
      target.GetComponent<Transform>().position = playerStart;
      pot.GetComponent<SpriteRenderer>().sprite = potSprite;
      pot.SetActive(true);
      key.SetActive(false);
      inv.SetActive(false);
    }
}
