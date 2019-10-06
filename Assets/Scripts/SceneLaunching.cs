using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLaunching : MonoBehaviour
{
    public GameObject character;
    public string scenePath;

    private float characterOutOfColliderAt;

    void Start() {
        characterOutOfColliderAt = Time.time;
    }

    void Update()
    {
        if (!GetComponent<Collider2D>().OverlapPoint(character.transform.position)) {
            characterOutOfColliderAt = Time.time;
        }

        if (Time.time > characterOutOfColliderAt + 4) {
            SceneManager.LoadScene(scenePath, LoadSceneMode.Single);
        }
    }
}
