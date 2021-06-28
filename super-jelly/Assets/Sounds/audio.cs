using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource collect_key;
    // Start is called before the first frame update

    public void collect()
    {
        collect_key.Play();
    }

    // Update is called once per frame
  
}
