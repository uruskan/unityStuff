using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAI : MonoBehaviour{
    public float speed = 2;
    public float directionChangeInterval = 4;
    float heading;
    public float min_Donme = 9f;
    public float maks_Donme = 89f;
    void Awake()
    {
        heading = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, heading, 0);
        StartCoroutine(NewHeading());
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    IEnumerator NewHeading()
    {
        while (true)
        {
            NewHeadingRoutine();
            yield return new WaitForSeconds(directionChangeInterval);
        }
    }
    void NewHeadingRoutine()
    {
        var rotHolder = this.transform.eulerAngles;
        transform.eulerAngles = new Vector3(rotHolder.x,rotHolder.y + Random.Range(min_Donme,maks_Donme),rotHolder.z);
    }
}