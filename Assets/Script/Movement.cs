using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int moveSpeed = 5;
    int jumpForce = 5;
    public void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("Running", true);
            GetComponent<Animator>().SetBool("Idle", false);
            transform.Translate(Vector3.right*Time.deltaTime*moveSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("Running", true);
            GetComponent<Animator>().SetBool("Idle", false);
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        }
        if(Input.GetKey(KeyCode.Space)) 
        {
            GetComponent<Animator>().SetTrigger("Jump");
            GetComponent<Rigidbody>().AddForce(Vector2.up*jumpForce);
        }
        if(!Input.anyKey)
        {
            GetComponent<Animator>().SetBool("Running",false);
            GetComponent<Animator>().SetBool("Idle", true);
        }

    }
}
