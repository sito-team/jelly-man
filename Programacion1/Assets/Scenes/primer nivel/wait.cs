using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait : MonoBehaviour
{
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1 * Time.deltaTime;

        if (Timer >= 3)
        {
            controller.instance.Advance(); // Llamas a la funcion que arranca los autos
        }
    }
}
