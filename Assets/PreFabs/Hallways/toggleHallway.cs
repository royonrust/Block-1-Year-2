using UnityEngine;

public class toggleHallway : MonoBehaviour
{
    public GameObject oldHallway;
    public GameObject newHallway;
    
    private void OnTriggerEnter(Collider other) 
    {
        oldHallway.SetActive(false);
        newHallway.SetActive(true);
    }
}
