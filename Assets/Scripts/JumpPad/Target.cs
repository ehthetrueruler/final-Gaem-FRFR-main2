using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Target : MonoBehaviour
{
    public float climb = 2f;

    private void Start()
    {

    }

    private void Update()
    {

    }

    public void Commence(float amount)
    {
        climb -= amount;
        if (climb <= 0f)
        {
            Go();
        }
    }

    void Go()
    {
        Destroy(gameObject);
    }

}
