using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_lock : MonoBehaviour
{
    public bool cursorlock_bool;
    // Start is called before the first frame update
    private void Start()
    {
        mouselock(cursorlock_bool);
    }
    public void mouselock(bool cursorlocked)
    {
    
        if(cursorlocked) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            
        } else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
    }
   
}
