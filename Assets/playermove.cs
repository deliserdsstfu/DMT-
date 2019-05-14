using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class playermove : MonoBehaviour
{
    UduinoManager u;
    public GameObject player;
    private float speed = 0.1f;
    private int buttonState;
    public KeyCode test;
    private Animator myAnimator;
   
    // Start is called before the first frame update
    void Start()
    {
        u = UduinoManager.Instance;
        u.pinMode(3, PinMode.Input);

        myAnimator.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, player.transform.position.z);
        buttonState = (u.digitalRead(3) == 0 ? 0 : 1);
       //
       myAnimator.SetFloat("speed", 1);                
        
    }
    void OnCollisionStay(Collision collision)
    {
        if (buttonState == 1)
        {
            // animation wird aufgerufen
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 3);
            //player.GetComponent<Animation>().Play();
            Debug.Log("button wurde getätigt");
            //anim.SetTrigger("pen");

        }
    }
}
