using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public NewComponent movement;
//PAY ATTENTION TO THE SPELLING - unity doesn't give errors or warnings for bad spelling
        void OnCollisionEnter(Collision collisionInfo)
        {
            //Debug.Log(collisionInfo.collider.name);  
            if(collisionInfo.collider.tag == "Obstacle")  
            {
            movement.enabled=false;
            }
        }

}
