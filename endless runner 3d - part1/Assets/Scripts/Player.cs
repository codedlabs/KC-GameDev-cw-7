using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{   
    private Rigidbody RB;
    public float mov;
    public float min;
    public float max;
    private Vector3 targetPos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        targetPos = transform.position;
        if (Input.GetKeyDown(KeyCode.D))
        {
            targetPos = new Vector3(Mathf.Clamp(transform.position.x + mov , min, max), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            targetPos = new Vector3(Mathf.Clamp(transform.position.x - mov , min, max), transform.position.y, transform.position.z);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
    }
}
