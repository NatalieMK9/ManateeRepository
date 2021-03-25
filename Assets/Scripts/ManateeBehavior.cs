using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManateeBehavior : MonoBehaviour
{
    //create movement parameters
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    //create positional parameters
    private float vInput;
    private float hInput;

    //create rigid body
    private Rigidbody _rb;

    //create variables for text display
    public int foodCount;
    public Text countText;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        //initialize needed variables
        foodCount = 0;
        countText.text = "Count: " + foodCount.ToString();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //constantly update value of player position variables
        vInput = Input.GetAxis("Vertical") * moveSpeed;

        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

    }

    //moves the player
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }

    //changes UI text everytime the user picks up food
    public void changeText(int count)
    {
        this.foodCount += count;
        this.countText.text = "Count: " + foodCount.ToString();
    }
}
