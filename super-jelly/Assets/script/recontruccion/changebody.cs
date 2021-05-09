using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changebody : MonoBehaviour
{
    public bool sus;
    public Transform prefab;
    public Transform prefab2;
    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)))
        { if (sus)
            {
                bola();
            }
            Destroy(gameObject);



        }
       
    }
    public void bola()
    {
        Instantiate(prefab, new Vector3(0.0F, 0, 0), Quaternion.identity);
        Instantiate(prefab2, new Vector3(0.0F, 0, 0), Quaternion.identity);
    }
}
