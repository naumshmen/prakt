using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCheck : MonoBehaviour
{
    public float offset;
    public GameObject fireball;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if(timeBtwShots <= 0)
        {
        if(Input.GetMouseButton(0))
        {
            Instantiate(fireball,shotPoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
