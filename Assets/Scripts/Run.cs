using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    public float tick;

    public GameObject textMessage;
    public GameObject canvas;

    public ArrayList messageList = new ArrayList();

    public void Start()
    {
        StartCoroutine(Pull());
    }

    public void CreateTextMessage(string message)
    {
        GameObject o = Instantiate(textMessage, new Vector3(0, 0, 0), Quaternion.identity);
        o.transform.SetParent(canvas.transform);
        o.transform.localScale = new Vector3(1, 1, 1);
        o.GetComponent<Text>().text = message;

        messageList.Add(o);
    }

    public void Update()
    {
        if (messageList.Count > 0)
        {
            GameObject o = (GameObject)messageList[messageList.Count - 1];
            o.transform.localPosition = new Vector3(0f, 300f, 0f);
        }

        if (messageList.Count > 1)
        {
            GameObject o = (GameObject)messageList[messageList.Count - 2];
            o.transform.localPosition = new Vector3(0f, 100f, 0f);
        }

        if (messageList.Count > 2)
        {
            GameObject o = (GameObject)messageList[messageList.Count - 3];
            o.transform.localPosition = new Vector3(0f, -100f, 0f);
        }

        if (messageList.Count > 3)
        {
            GameObject o = (GameObject)messageList[messageList.Count - 4];
            o.transform.localPosition = new Vector3(0f, -300f, 0f);
        }

        if (messageList.Count > 4)
        {
            GameObject o = (GameObject)messageList[messageList.Count - 5];
            Destroy(o);
        }
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

