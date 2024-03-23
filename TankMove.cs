using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{

    public float speed = 1.5f;
    private Vector3 target; //that's for moving 
    private Vector3 target_rot; // that's for rotating
    //i seperated rotation and movement because in line 33 i did some changes in the target.position and we shouldnt change the target.position for rotatin (we need to change it for moving)
    private bool tankclicked; //dont move the tank if isnt clicked (for my game)

    void Start()
    {
        target = transform.position; //gameobjects position before moving

    }
    void OnMouseDown()
    {
        tankclicked = true; //i clicked the tank so im going to move it (for my game)
    }
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            tankclicked = false;
        }
        if (Input.GetMouseButtonDown(0)) //if user clicked somewhere on the screen
        {
            if (tankclicked) // if tank is selected
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition); //target (click) position
                target.z = transform.position.z; //we dont want to move our gameobject in z axis since its a 2D game.
                target_rot = Camera.main.ScreenToWorldPoint(Input.mousePosition); //and simply we declare our target (click position)(without edited z axis)
            }
        }
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime); //moving its easy dont need explanation
            var angle = Mathf.Atan2(target_rot.y - transform.position.y, target_rot.x - transform.position.x) * Mathf.Rad2Deg; //we calculate tanjant of our gameobject and target and translate it to degress
            transform.rotation = Quaternion.Euler(0, 0, angle + 90); //you need to use Quaternions for editing transform.rotation since its a value in quaternion.
            //Read if you really dont know quaternions and beginner => Quaternion.Euler is like a vector3 , it gets 3 values (x,y,z).i set x and y to 0 cause we dont want to rotate our gameobject in x and y axis in 2D game.
            //and we will rotate in z axis with "angle" deggress but we need to add +90 deggres i dont know why :D
        
        }
    
}