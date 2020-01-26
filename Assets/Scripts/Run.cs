using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float tick;

    public GameObject textMessage;

    public GameObject canvas;

    public void Start()
    {
        StartCoroutine(Pull());

        GameObject o = Instantiate(textMessage, new Vector3(0,0,0),Quaternion.identity);
        canvas.transform.SetParent(canvas);
    }

    IEnumerator Pull()
    {
        while (true)
        {
            Debug.Log("OnCoroutine");
            yield return new WaitForSeconds(tick); //runs once a second
        }
    }
}

