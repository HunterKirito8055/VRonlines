using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myTeleport : MonoBehaviour
{
    public Image Reticle;
    bool isGazing;
    float times;

    [SerializeField]
    float timer = 2f;

    public List<GameObject> teleplace = new List<GameObject>();

    private void Update()
    {
        if(isGazing)
        {
        times += Time.deltaTime;
            Reticle.fillAmount = times / timer;
        }
        
        if(Reticle.fillAmount == 1)
        {
            foreach( GameObject obj in teleplace )
            {
                transform.position = obj.transform.position;
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
