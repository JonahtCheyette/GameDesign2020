using UnityEngine;

public class MouseCube : MonoBehaviour {
    public Camera _camera;
    public Transform cube;

    private void Update() {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        cube.position = ray.GetPoint(50);
    }
}
