using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class Movement : MonoBehaviour  
{  
     
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
        // Slow movement
        if (Input.GetKey(KeyCode.Tab))  {  
            if (Input.GetKey(KeyCode.W))  
            {  
               this.transform.Translate(Vector3.forward * Time.deltaTime);  
            }
         
            if (Input.GetKey(KeyCode.S))  
            {  
                this.transform.Translate(Vector3.back * Time.deltaTime);  
            } 

            if (Input.GetKey(KeyCode.A))  
            {  
               this.transform.Translate(Vector3.left * Time.deltaTime);  
            }
         
            if (Input.GetKey(KeyCode.D))  
            {  
                this.transform.Translate(Vector3.right * Time.deltaTime);  
            }   

            if (Input.GetKey(KeyCode.UpArrow))  
            {  
               this.transform.Translate(Vector3.up * Time.deltaTime);  
            }
         
            if (Input.GetKey(KeyCode.DownArrow))  
            {  
                this.transform.Translate(Vector3.down * Time.deltaTime);  
            }   
         
            if (Input.GetKey(KeyCode.LeftArrow))  
            {  
                this.transform.Rotate(Vector3.up, -2);  
            }  
        
            if (Input.GetKey(KeyCode.RightArrow))  
            {  
                this.transform.Rotate(Vector3.up, 2);  
            }  
        }

        // Fast movement
        if (Input.GetKey(KeyCode.LeftShift))  {  
            if (Input.GetKey(KeyCode.W))  
            {  
               this.transform.Translate(Vector3.forward * 5*Time.deltaTime);  
            }
         
            if (Input.GetKey(KeyCode.S))  
            {  
                this.transform.Translate(Vector3.back * 5*Time.deltaTime);  
            } 

            if (Input.GetKey(KeyCode.A))  
            {  
               this.transform.Translate(Vector3.left * 5*Time.deltaTime);  
            }
         
            if (Input.GetKey(KeyCode.D))  
            {  
                this.transform.Translate(Vector3.right * 5*Time.deltaTime);  
            }   

            if (Input.GetKey(KeyCode.UpArrow))  
            {  
               this.transform.Translate(Vector3.up * 5*Time.deltaTime);  
            }
         
            if (Input.GetKey(KeyCode.DownArrow))  
            {  
                this.transform.Translate(Vector3.down * 5*Time.deltaTime);  
            }   
         
            if (Input.GetKey(KeyCode.LeftArrow))  
            {  
                this.transform.Rotate(Vector3.up, -10);  
            }  
        
            if (Input.GetKey(KeyCode.RightArrow))  
            {  
                this.transform.Rotate(Vector3.up, 10);  
            }  
        }
    }  
} 