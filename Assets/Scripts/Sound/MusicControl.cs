using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public PlayerMovement player;
    FMOD.Studio.STOP_MODE IMMEDIATE;

    [FMODUnity.EventRef]
    public string music = "event:/Music"; 
    FMOD.Studio.EventInstance musicEvent;

    // Start is called before the first frame update
    void Start()
    {
        musicEvent = FMODUnity.RuntimeManager.CreateInstance(music);
        musicEvent.start();
    }
     
    public void Stop()
    {
        musicEvent.stop(IMMEDIATE);
    }  

    public void DistanceToSun()
    {
        musicEvent.setParameterByName("DistToSun", player.DistToSun);
    }

    public void Next()
    {
        musicEvent.setParameterByName("Next", 1f);
    }

    public void NoNext()
    {
        musicEvent.setParameterByName("Next", 0f);
    }

    public void End()
    {
        musicEvent.setParameterByName("Next", 0.5f);
    }




}
