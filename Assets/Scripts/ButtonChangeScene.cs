using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChangeScene : MonoBehaviour {
    //public string scenename;
	// Use this for initialization
	public void LoadScene (string scenename) {
        SceneManager.LoadScene(scenename);
    }

}
