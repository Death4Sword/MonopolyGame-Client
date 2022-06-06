using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public InputFiled usernameFiled;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance.tcp != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        startMenu.SetActive(false);
        usernameFiled.interactable(false);
        Client.instance.ConnectToServer();
    }

}
