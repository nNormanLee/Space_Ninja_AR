using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThisScene : MonoBehaviour { 

    private int thisScene;
    public MusicControl musicSystem;

    // Start is called before the first frame update
    void Start()
    {
        thisScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(thisScene);
            
            musicSystem.Stop();
            
            
            
        }
    }
}
