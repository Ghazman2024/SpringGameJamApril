using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyTriggerAttack : MonoBehaviour
{
    public GameObject activateAttack;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            activateAttack.SetActive(true);
        }    
    }
}