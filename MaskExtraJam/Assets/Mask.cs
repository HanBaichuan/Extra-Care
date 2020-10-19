using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public static bool justHit = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", lifeTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        Debug.Log(Vector2.up);
        
    }

    void DestroyBullet(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("THIS");
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            justHit = true;
        }
    }
}
