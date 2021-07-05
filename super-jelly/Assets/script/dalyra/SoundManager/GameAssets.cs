using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    //facundo olmedo
    // Start is called before the first frame update
    private static           GameAssets        objecttointanciate;
   
    
    
    
    
    
    public static GameAssets Instanciate{
        get
        {
            if (objecttointanciate == null) objecttointanciate = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return objecttointanciate;
        }
    }
    public SoundAudioClip[] SoundAudioClipArray;
    [System.Serializable]
   
    
    
    
    
    
    public class SoundAudioClip
    {
        public SoundmanagerM.Sound sound;
        public AudioClip audioclip;
    }
}
