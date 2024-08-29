using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //info about posotion, translation and scale
    public Transform player;

    //3 floats
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        //Modifies the transform attached to this object
        //this gives a first person view(you are the object)
        //transform.position = player.position;

        transform.position = player.position+offset;


    }
}
