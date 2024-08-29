using UnityEngine;

public class NewComponent : MonoBehaviour
{
    public Rigidbody rb;

//f is for float
    public float forwardForce=200f;
    public float sidewayForce=500f;

    // Start is called before the first frame update
    // void Start()
    // {
    //    rb.AddForce(0, 200, 500); 
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     rb.AddForce(0, 0, 200 * Time.deltaTime);
    // }

//Marked as FixidUpdate instead of Update because it messed with physics
    void FixedUpdate()
    {
        //Forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime,ForceMode.VelocityChange);

        //TODO: make this work with left and right arrows

        //Right movement
        if(Input.GetKey("d") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
          //ForceMode.VelocityChange is optonal, here it is used to signal that I don't want the objects to build momentum constantly, hence moving faster
          rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }

        //Left movement
        if(Input.GetKey("a") || Input.GetKeyDown(KeyCode.RightArrow))
        {
          rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }
}
