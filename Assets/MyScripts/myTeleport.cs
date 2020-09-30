using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class myTeleport : MonoBehaviour
{
    public Image Reticle;
    bool isGazing;
    float times;

    [SerializeField]
    float timer = 2f;


    RaycastHit hit;
    Ray ray;



    private void Update()
    {
        if(isGazing)
        {
        times += Time.deltaTime;
            Reticle.fillAmount = times / timer;
        }

        ray = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));
        
        if(Physics.Raycast(ray,out hit,3243f))
        {
           // Debug.Log(hit.transform.gameObject.name);
            if(/*hit.transform.CompareTag("Tele1") && */Reticle.fillAmount == 1)
            {
                //  GameObject.Find("Portals").GetComponent<TeleportPlayer>().ToTeleport(hit.transform.gameObject.name);
                hit.transform.gameObject.AddComponent<TeleportPlayer>().ToTeleport();
            }
        }
    }

    public void OnPointerEnter()
    {
        isGazing = true;
       
        
    }
    public void OnPointerExit()
    {
        isGazing = false;
        Reticle.fillAmount = 0;
        times = 0f;
    }    
}
