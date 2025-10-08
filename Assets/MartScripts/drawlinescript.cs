using UnityEngine;

public class drawlinescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Vector3.zero,Vector3.up, color: Color.cyan);
    }




}
