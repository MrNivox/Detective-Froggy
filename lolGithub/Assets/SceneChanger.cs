using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
      public void SceneChange1()
        {
         SceneManager.LoadScene("SampleScene");
        }
      public void SceneChange2() 
      {
       SceneManager.LoadScene("");
      }
       public void SceneChange3() 
      {
       SceneManager.LoadScene("");
      }
}
