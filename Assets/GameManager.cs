using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> locations = new List<GameObject>();
    [SerializeField] Transform player;
    float levelLength = 106.3f;
    [SerializeField] GameObject shield;
    void Start()
    {
        Instantiate(locations[0], transform.forward, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if(player.position.z > levelLength - 106.3f)
        {
            CreateLocation();
        }
    }
    void CreateLocation()
    {
        Instantiate(locations[Random.Range(0, locations.Count)], transform.forward * levelLength, transform.rotation);
        levelLength += 106.3f;
    }
    public void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void GenerateObject()
    {
        float distance = Random.Range(100, 200);
        Instantiate(shield, player.position + new Vector3(0,2,distance), transform.rotation);
        Invoke("GenerateObject", Random.Range(20,30));
    }
}