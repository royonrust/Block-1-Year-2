using UnityEngine;

public class invisibleLightScript : MonoBehaviour
{
    public Light limelight;

    void OnPreRender() {
        if (limelight != null)
            limelight.enabled = false;
        Debug.Log("OnPreRender");
    }

    void OnPostRender() {
        if (limelight != null)
            limelight.enabled = true;
    }
}
