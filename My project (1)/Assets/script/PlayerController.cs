using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerController : MonoBehaviour{
    private bool isTouchR;
    private bool isTouchL;
    public float speed;
    void Start(){
        Application.targetFrameRate = 60;
    }
    
    void Update(){
        Move();
    }

    public void Move(){
        if (Input.GetKey(KeyCode.LeftArrow) && isTouchL == false){
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && isTouchR == false){
            transform.Translate(speed, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "border"){
          switch(other.gameObject.name){  
            case "Right": 
            isTouchR = true;
            break;
            case "Left":
            isTouchL = true;
            break;
        }
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "border"){
          switch(other.gameObject.name){  
            case "Right": 
            isTouchR = false;
            break;
            case "Left":
            isTouchL = false;
            break;
        }
        }
    }
}
