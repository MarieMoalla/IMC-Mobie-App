using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAfter : MonoBehaviour
{
    public GameObject obj;
    private float time = 0;
    public float onActiveTime;
    void Update()
    {
        time+= Time.deltaTime;
        //Debug.Log(time);
        if(time >= onActiveTime)
        {
            obj.SetActive(true); 
        }
    }
           
}
