using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefab;
    private GameObject newCustomer;
    private int SpawnSide;
    private SpriteRenderer spriteR;
    private Color customerColor;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCustomers());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCustomers() {
		while (true) {
            if (Random.value < 0.5){
                SpawnSide = -1;
            }else{
                SpawnSide = 1;
            }

            int j;
            if (Random.Range(0,5) == 1){
                j = 1;
            }else{
                j = 0;
            }

            newCustomer = Instantiate(prefab[j], new Vector2(SpawnSide * 15, Random.Range(-4, 3)), Quaternion.Euler(0,0,0));
            customerColor = Color.HSVToRGB(7f/100f, Random.Range(20, 60)/100f, Random.Range(60, 100)/100f);//(m_Hue, m_Saturation, m_Value);

            GameObject child = newCustomer.transform.GetChild(0).gameObject; //head color
            spriteR = child.GetComponent<SpriteRenderer>();
            spriteR.color = customerColor;

            child = newCustomer.transform.GetChild(4).gameObject; //hands color
            spriteR = child.GetComponent<SpriteRenderer>();
            spriteR.color = customerColor;

            child = newCustomer.transform.GetChild(5).gameObject;
            spriteR = child.GetComponent<SpriteRenderer>();
            spriteR.color = customerColor;

            Vector3 theScale = newCustomer.transform.localScale;
            theScale.x *= -SpawnSide;
            newCustomer.transform.localScale = theScale;
			yield return new WaitForSeconds(Random.Range(1f - CustomerHead.score * 0.005f, 3f - CustomerHead.score * 0.03f));
		}
	}
}
