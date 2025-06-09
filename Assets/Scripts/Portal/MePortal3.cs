using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MePortal3 :MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    void OnTriggerEnter(Collider col)
    {
        Player.transform.position = new Vector3(775, 441, 514);
    }
}
