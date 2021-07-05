using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class cursorchange : MonoBehaviour
{
    #region Variables
    public static cursorchange instance;
    public Texture2D normal, onclick;
    #endregion
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Cursor.SetCursor(normal, Vector2.zero, CursorMode.Auto);
    }


    // Update is called once per frame
    public void deactivate()
    {
        Cursor.SetCursor(normal, Vector2.zero, CursorMode.Auto);
    }
    public void onpoint()
    {
        
        StartCoroutine(wait(0.5f));
    }
    IEnumerator wait(float regeneration)
    {

       
        Cursor.SetCursor(onclick, Vector2.zero, CursorMode.Auto);

        yield return new WaitForSeconds(regeneration);
       
        Cursor.SetCursor(normal, Vector2.zero, CursorMode.Auto);



    }
}
