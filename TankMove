using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{

    public float speed = 1.5f;
    private Vector3 target;
    private Vector3 target_rot;

    void Start()
    {
        target = transform.position;
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            target_rot = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        var angle = Mathf.Atan2(target_rot.y - transform.position.y, target_rot.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle + 90);
    }
}