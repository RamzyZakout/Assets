using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int Lives = 3;

while (Lives > 0){

    if (Lives == 3){
    
        Debug.Log("many lives");
    }
    else if (Lives == 2) {
   
        Debug.Log("you have 2 lives");
    }
    else if (Lives == 1){
    
        Debug.Log("intebh");
    }

    Lives--; 
}

    Debug.Log("Game Over");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
