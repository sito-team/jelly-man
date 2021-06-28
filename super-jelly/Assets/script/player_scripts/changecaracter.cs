using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecaracter : MonoBehaviour
{
    public GameObject positiontransform;

    public camara_rotation camara_;
    // Start is called before the first frame update
    public GameObject[] form;
    private bool[] comprobation = new bool[10];
    public int actualformposition;
    public bool frized;

    public void Update()
    {
        for (int i = 0; i < form.Length; i++)
        {

            comprobation[i] = form[i].gameObject.active;


            if (comprobation[i])
            {
                actualformposition = i;
            }
        }

    }
    // Update is called once per frame




    public void changecomand(GameObject newtranformation, Vector3 offset)
    {
        if (newtranformation.gameObject != form[actualformposition].gameObject)
        {
            newtranformation.transform.position = form[actualformposition].gameObject.transform.position + offset;
            newtranformation.SetActive(true);
            camara_.funcionchangecharacter(newtranformation.transform);
            form[actualformposition].gameObject.SetActive(false);
        }
    }

}
