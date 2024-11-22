using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;  

public class RayCast : MonoBehaviour
{
    public Text countdownText;

    bool raycastUsed = false; 

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && raycastUsed == false) 
        {
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition); 

            RaycastHit hit; 
            
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "1")
                {    
                    StartCoroutine(Countdown(0)); 
                    raycastUsed = true; 
                }
                else if(hit.transform.tag == "2") 
                {
                    StartCoroutine(Countdown(1)); 
                    raycastUsed = true; 
                }
                else if(hit.transform.tag == "3") 
                {
                    StartCoroutine(Countdown(2)); 
                    raycastUsed = true; 
                }

            }
        }
    }





    

     IEnumerator Countdown(int scene) 
    {
        while(countdownText.text != "Listo!") 
        {
            countdownText.text = "5";
            yield return new WaitForSeconds(1f);
            countdownText.text = "4";
            yield return new WaitForSeconds(1f);
            countdownText.text = "3";
            yield return new WaitForSeconds(1f);
            countdownText.text = "2";
            yield return new WaitForSeconds(1f);
            countdownText.text = "1";
            yield return new WaitForSeconds(1f);
            countdownText.text = "Listo!";
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(scene);
        }


    }
}










 













