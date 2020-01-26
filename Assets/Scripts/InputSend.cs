using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSend : MonoBehaviour
{
    public InputField InputField;
    public GameObject controller;

    void Update()
    {
        if (InputField.isFocused && InputField.text != "" && Input.GetKey(KeyCode.Return))
        {
            SendMessage();
        }
    }

    public void SendMessage()
    {
        Input.location.Start();

        if (InputField.text != "")
        {
            Debug.Log(InputField.text + " " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude); //Send to firebase
            controller.GetComponent<Run>().CreateTextMessage(InputField.text);
            InputField.text = "";
        }

        Input.location.Stop();
    }
}
