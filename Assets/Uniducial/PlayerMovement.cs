using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject playerController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 fiducialPos = new Vector2(playerController.transform.position.x, playerController.transform.position.y);
        rb.MovePosition(transform.position);
    }
}
