using UnityEngine;

public class SwitchDemo : MonoBehaviour
{

    public SwitchVR switchVR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 画面タッチで切り替え
        if (Input.GetMouseButtonDown(0)) {
            switchVR.ToggleXR();
        }
    }
}
