using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheat : MonoBehaviour
{
    // Start is called before the first frame update

    public string Bug;
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            SceneManager.LoadScene("GameClear");
        }
          
          

    }


}
