using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseblock : MonoBehaviour
{
    public bool cursorlock_bool = true;
    // Start is called before the first frame update
    void Start()
    {
        mouselock(cursorlock_bool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mouselock(bool cursorlocked)
    {

        if (cursorlocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
}
