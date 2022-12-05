using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visit : MonoBehaviour
{
public void visitLink ( string link)
{
    Debug.Log("click");
    Application.OpenURL(link);
}
}
