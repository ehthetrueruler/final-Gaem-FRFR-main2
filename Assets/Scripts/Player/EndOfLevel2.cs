using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class EndOfLevel2 : MonoBehaviour 
{
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LevelEnd") 
        {
            SceneManager.LoadScene(2);
        }
    }
}
