using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class JumpPadScript : MonoBehaviour
{
    public Rigidbody rb;
    public float range = 1f;
    public float jumpAmount = 9.8f;
    public bool grounded = false;
    public Camera cam;


    void Start()
    {
        
    }

    void Update()
    {
        ShootRaycast();

        if(Input.GetKeyDown(KeyCode.Space) & grounded == true)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
    }

    void ShootRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                StartCoroutine(JumpBool());
            }
        }
    }

    IEnumerator JumpBool()
    {
        grounded = true;
        yield return new WaitForSeconds(0.1f);
        grounded = false;
    }
}
