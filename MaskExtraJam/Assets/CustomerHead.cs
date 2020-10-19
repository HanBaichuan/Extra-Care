using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CustomerHead : MonoBehaviour
{
    private SpriteRenderer spriteR;
    private SpriteRenderer frontHairR;
    private SpriteRenderer backHairR;
    public Sprite hasMaskImage;
    public Sprite[] ListofWear;

    public static int score;
    public static bool gotMask = false;
    public GameObject frontHair;
    public GameObject backHair;

    // Start is called before the first frame update
    void Start()
    {
        GameObject child = transform.GetChild(0).gameObject;
        GameObject frontHair = transform.GetChild(1).gameObject;
        GameObject backHair = transform.GetChild(2).gameObject;
        spriteR = child.GetComponent<SpriteRenderer>(); 
        frontHairR = frontHair.GetComponent<SpriteRenderer>();
        backHairR = backHair.GetComponent<SpriteRenderer>();

        int j = Random.Range(0,10);
        if (j == 1){
            backHairR.sprite = ListofWear[0];
        }
        else if (j == 2){
            backHairR.sprite = ListofWear[1];
        }
        else if (j == 3){
            frontHairR.sprite = ListofWear[2];
            backHairR.sprite = ListofWear[3];
        }
        else if (j == 4){
            frontHairR.sprite = ListofWear[4];
            backHairR.sprite = ListofWear[5];
        }
        else if (j == 5){
            frontHairR.sprite = ListofWear[6];
            backHairR.sprite = ListofWear[7];
        }
        else{

        }
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
            if (spriteR.sprite != hasMaskImage){
                score += 1;
            }
            spriteR.sprite = hasMaskImage;
            GetComponents<AudioSource>()[0].time = 0.3f;
            GetComponents<AudioSource>()[0].Play();
            gotMask = true;
            //CustomerWalk.hasMask = true;
        }
/*         if (collision.gameObject.tag == "Player"){
            Swipe.damage = true;
            //Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            accelaration = 0;
        } */
    }
}
