using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int speed = -5;
    public GameObject fireball;
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            fireball.SetActive(false);
        }    
    }


}