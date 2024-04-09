using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INTERACCION : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        PanelOff();
    }

    public void PanelOn()
    {
        panel.SetActive(true);
    }
    public void PanelOff()
    {
        panel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PanelOn();
        }
    }

    void OnTriggerExit(Collider other)
    {
        PanelOff();
    }

}
