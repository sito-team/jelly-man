using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision player_collision_verifict)
    {
        if (player_collision_verifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
            SceneManager.LoadScene("win - copia");



    }
}
