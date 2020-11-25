using UnityEngine;

public class MoveForward : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        transform.position -= transform.right * 0.1f;
    }
}
