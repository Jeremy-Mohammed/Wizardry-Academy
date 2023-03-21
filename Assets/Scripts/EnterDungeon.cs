using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDungeon : MonoBehaviour
{
    private void OnMouseUpAsButton(){
        SceneManager.LoadScene(2);
        Debug.Log("Enter Dungeon");
    }
}
