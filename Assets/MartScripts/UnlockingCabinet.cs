using UnityEngine;

public class UnlockingCabinet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject Cabinet;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Keyhole"))
        {
            Cabinet.SetActive(false);
        }
    }



}
