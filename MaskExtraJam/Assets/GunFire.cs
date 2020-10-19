using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public float offset;

    public GameObject projectile;
    public Transform shotPoint;

    private float timeBetweenShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {   
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 difference = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotZ + offset);
        
        if (timeBetweenShots <= 0){
            if (Input.GetMouseButtonDown(0)){
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBetweenShots = startTimeBtwShots;
            }
        }else{
            timeBetweenShots -= Time.deltaTime;
        }
    }
}
