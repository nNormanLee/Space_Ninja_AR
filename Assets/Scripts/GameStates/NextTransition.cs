using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTransition : MonoBehaviour { 

    private int nextTransition;
    public MusicControl musicSystem;
    public float transitionTime = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
        nextTransition = SceneManager.GetActiveScene().buildIndex + 1;
        

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            StartCoroutine(LoadLevel(nextTransition));
        }
    }

    IEnumerator LoadLevel(int sceneIndex)
    {
        
        musicSystem.Next();
        

        //wait
        yield return new WaitForSeconds(transitionTime);


        musicSystem.End();
        

        //Load Scene
        SceneManager.LoadScene(sceneIndex);


    }

}
