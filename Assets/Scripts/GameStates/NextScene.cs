using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour { 

    private int nextScene;
    public MusicControl musicSystem;

    // Start is called before the first frame update
    void Start()
    {     
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void Update()
    {
        //musicSystem.Stop();
    }


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            SceneManager.LoadScene(nextScene);
            musicSystem.NoNext();
            musicSystem.Stop();

        }
    }

    
}
