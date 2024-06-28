using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerOnPlayer : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        SceneManager.sceneLoaded += OnSceneLoaded;

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ToTown1")
        {
            Invoke("ChangeScene", 1.5f);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Town_1");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Reset the player's position to (0, 0, 0)
        player.transform.position = new Vector3(0, 0, 0);
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
