using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public int index;
    [SerializeField] bool KeyDown;
    [SerializeField] int maxIndex;
    public AudioSource Audio;
    


    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Index" + index);
        if (Input.GetAxis("Vertical") < 0)
        {
            if (!KeyDown)
            {
                if (index < maxIndex)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }

            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                if (index > 0)
                {
                    index--;
                }
                else
                {
                    index = maxIndex;
                }

            }
            KeyDown = true;
        }
        else
        {
            KeyDown = false;
        }


    }

}
