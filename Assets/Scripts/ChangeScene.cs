using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {
    public string scenename;
    public int seconds;

    void OnTriggerEnter (Collider ChangeScene) {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Wait());
            SceneManager.LoadScene(scenename);
        }
    }

    IEnumerator Wait()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(seconds);
        print(Time.time);
    }

}
