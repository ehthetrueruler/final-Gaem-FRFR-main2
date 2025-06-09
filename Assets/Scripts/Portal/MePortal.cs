using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MePortal :MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    void OnTriggerEnter(Collider col)
    {
        Player.transform.position = new Vector3(641, 549, 545);
    }
}
