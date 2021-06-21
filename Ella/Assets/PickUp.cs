using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp  : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject Trigger;
    public GameObject E;

    private void OnTriggerStay(Collider other)
    {
        E.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            weapon1.SetActive(false);
            weapon2.SetActive(true);
            Trigger.SetActive(false);
            E.SetActive(false);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        E.SetActive(false);
    }
}
