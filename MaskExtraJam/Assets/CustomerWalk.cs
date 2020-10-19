using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float thisCustomerSpeed;
    public static bool hasMask = false;
    public Sprite spriteR;
    public GameObject face;
    private SpriteRenderer hasMaskImg;
 
    void Start()
    {
        thisCustomerSpeed = Random.Range(1,5);
        hasMaskImg = face.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -16 || transform.position.x > 16) {
			Destroy(gameObject);
            CustomerHead.gotMask = false;
            if ((transform.position.x < -16 || transform.position.x > 16) && spriteR != hasMaskImg.sprite){
                SceneManager.LoadScene("Over");
            }
		}
		else {
			transform.Translate(Vector3.left * -transform.localScale.x * 0.01f * speed * thisCustomerSpeed);
		}
    }
}
