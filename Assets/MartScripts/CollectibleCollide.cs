using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CollectibleCollide : MonoBehaviour
{

    [SerializeField]
    TMP_Text Score;

    int score = 0;

    [SerializeField]
    private GameObject batteryObject;

    private bool collChecker = false;
    public GameObject sphereObj;
    public GameObject nextLevel;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collChecker == true)
        {
            sphereObj.SetActive(false);
            nextLevel.SetActive(true);
        }
        Score.text = score + "/5";

        if(batteryObject.transform.position.y >= 0.7)
        {
            Destroy(batteryObject);
            collChecker = true;
            score = score + 1;
        }
        else if(batteryObject.transform.position.z >= 4.15)
        {
            Destroy(batteryObject);
            collChecker = true;
            score = score + 1;
        }
        else if(batteryObject.transform.position.x >= 2.98)
        {
            Destroy(batteryObject);
            collChecker = true;
            score = score + 1;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            collChecker = true;
            score = score + 1;

        }

        else if (other.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(2);

        }
    }
}
