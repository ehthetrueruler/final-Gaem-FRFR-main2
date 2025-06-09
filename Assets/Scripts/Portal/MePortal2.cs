using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MePortal2 :MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    void OnTriggerEnter(Collider col)
    {
        Player.transform.position = new Vector3(600, 381, 494);
    }
}
