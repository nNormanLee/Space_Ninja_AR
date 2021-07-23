using UnityEngine;
using System.Collections;

public class CamSwap : MonoBehaviour
{
    public GameObject closeCam;
    public GameObject sceneCam;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("JKey"))
      {
        closeCam.SetActive(true);
        sceneCam.SetActive(false);
      }
      else if (Input.GetButtonDown("KKey"))
      {
        closeCam.SetActive(false);
        sceneCam.SetActive(true);
      }
    }
}
