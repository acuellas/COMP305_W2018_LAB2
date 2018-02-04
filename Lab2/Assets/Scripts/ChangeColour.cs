using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

    public GameObject Adriana1;

    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
    public int buttonNumber;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    
	// Use this for initialization
	void Start () {

        rBody = Adriana1.GetComponent<Rigidbody2D>();
        sRend = Adriana1.GetComponent<SpriteRenderer>();

        
	}
	
	void OnMouseDown () {
        if (buttonNumber == 1)
        {
            sRend.sprite = firstImage;
            
        } else if (buttonNumber == 2)
        {
            sRend.sprite = thirdImage;
           
        }
        else
        {
            sRend.sprite = secondImage;
            
        }
		
	}


}
