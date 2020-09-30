using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [HideInInspector]
    public GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Players");
    }
    private void Update()
    {
        Invoke("Deletethis", 0.5f);
    }


    public void ToTeleport(/*string name*/)
    {
        player.transform.position = gameObject.transform.position + new Vector3(0,1.4f,0);
    }

    void Deletethis()
    {
        Destroy(GetComponent < TeleportPlayer >());
    }

}//class
