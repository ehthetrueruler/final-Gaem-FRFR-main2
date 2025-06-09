using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MePortal4 :MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    void OnTriggerEnter(Collider col)
    {
        Player.transform.position = new Vector3(722, 384, 325);
    }
}
