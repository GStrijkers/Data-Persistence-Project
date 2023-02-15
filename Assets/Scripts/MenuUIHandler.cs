using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;

public class MenuUIHandler : MonoBehaviour
{
  public GameObject NameInput;
 

  public void StartNew()
  {
    TMP_InputField tmpInputField = NameInput.GetComponent<TMP_InputField>();
    MainManager.PlayerName = tmpInputField.text;
    SceneManager.LoadScene(1);
  }

  public void ClearHighScore()
  {
    MainManager.ClearHighScore();
  }

  public void Exit()
  {
 
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
    Application.Quit(); // original code to quit Unity player
#endif
  }

}
