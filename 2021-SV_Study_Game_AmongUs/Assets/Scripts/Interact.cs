using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject Use;
    public GameObject Player;
    bool playerAlert; // 플레이어가 범위에 들어왔나 ox

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        playerAlert = true;
        GameObject Button = Instantiate(Use);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        playerAlert = false;
        Destroy(GameObject.Find("Canvas(Clone)"));
    }
}