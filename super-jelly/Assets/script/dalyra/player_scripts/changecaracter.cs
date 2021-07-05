using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class changecaracter : MonoBehaviour
{
    #region Variables

    public              camara_rotation             camera;
    public              GameObject[]                form;
    private             bool[]                      comprobation                = new bool[10];
    [HideInInspector]
    public              int                         actualFormPosition;
    [HideInInspector]
    public              bool                        frized;

    #endregion

    #region change  system
    public void Start()
    {
        for (int i = 0; i < form.Length; i++)
        {

            comprobation[i] = form[i].gameObject.active;


            if (comprobation[i])
            {
                actualFormPosition = i;
            }
        }
    }

    // Update is called once per frame




    public void ChangeComand(GameObject newtranformation, Vector3 offset)
    {
        for (int i = 0; i < form.Length; i++)
        {

            comprobation[i] = form[i].gameObject.active;


            if (comprobation[i])
            {
                actualFormPosition = i;
            }
        }
        if (newtranformation.gameObject != form[actualFormPosition].gameObject)
        {
            newtranformation.transform.position = form[actualFormPosition].gameObject.transform.position + offset;
            newtranformation.SetActive(true);
            camera.funcionchangecharacter(newtranformation.transform);
            form[actualFormPosition].gameObject.SetActive(false);
        }
    }
    #endregion


    #region invunerability system
    public void InvunerabilityOn()
    {
        Physics.IgnoreLayerCollision(8, 12,true);
    }
    public void InvunerabilityOff()
    {
        Physics.IgnoreLayerCollision(8, 12, false);
    }
    #endregion
}
