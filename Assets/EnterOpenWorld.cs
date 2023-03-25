using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterOpenWorld : MonoBehaviour
{
    private void OnMouseUpAsButton(){
        SceneManager.LoadScene(1);
        Debug.Log("Enter Open World");
    }
}