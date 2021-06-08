using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorchange : MonoBehaviour
{
    public static cursorchange instance;
    public Texture2D normal, onclick;
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
        Cursor.SetCursor(onclick, Vector2.zero, CursorMode.Auto);
    }
}
