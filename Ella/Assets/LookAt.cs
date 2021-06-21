using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        gameObject.transform.LookAt(Player.transform.position);
    }
}
