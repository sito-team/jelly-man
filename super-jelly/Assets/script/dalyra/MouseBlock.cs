using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class MouseBlock : MonoBehaviour
{
    #region Variables
    public bool cursorlock_bool;
    #endregion
    
    private void Start()
    {
        mouselock(cursorlock_bool);
    }
    public void mouselock(bool cursorlocked)
    {

        if (cursorlocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            

        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
    public void Update()
    {
        
    }

}

