using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kidHead : MonoBehaviour
{
    private SpriteRenderer spriteR;
    public Sprite hasMaskImage;

    // Start is called before the first frame update
    void Start()
    {
        GameObject child = transform.GetChild(0).gameObject;
        spriteR = child.GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("THIS");
        if (collision.gameObject.tag == "clone")
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            spriteR.sprite = hasMaskImage;
            GetComponents<AudioSource>()[0].time = 0.3f;
            GetComponents<AudioSource>()[0].Play();
            CustomerHead.score += 1;
        }
    }
}
