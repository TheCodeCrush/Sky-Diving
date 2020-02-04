using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class optselect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene(2);
        }  
        
        if(Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene(5);
        }    
    }
}
