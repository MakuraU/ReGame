using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
　
public class SceneManagerOnPlayer : MonoBehaviour
{
    private GameObject player;
    private int SceneNum = 0;

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
            SceneNum = 1;
            Invoke("ChangeScene", 0.5f);
        }
        if (other.gameObject.tag == "ToTown2")
        {
            SceneNum = 2;
            Invoke("ChangeScene", 0.5f);
        }
        if (other.gameObject.tag == "ToDungeon")
        {
            SceneNum = 3;
            Invoke("ChangeScene", 0.5f);
        }
        if (other.gameObject.tag == "ToKasino")
        {
            SceneNum = 4;
            Invoke("ChangeScene", 0.5f);
        }
        if (other.gameObject.tag == "GoHome")
        {
            SceneNum = 0;
            Invoke("ChangeScene", 0.5f);
        }
    }

        void ChangeScene()
    {
        if (SceneNum == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (SceneNum == 1)
        {
            SceneManager.LoadScene("Town_1");
        } if (SceneNum == 2)
        {
            SceneManager.LoadScene("Town_2");
        }
        if (SceneNum == 3)
        {
            SceneManager.LoadScene("Dungeon");
        }if (SceneNum == 4)
        {
            SceneManager.LoadScene("Kasino");
        }
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
