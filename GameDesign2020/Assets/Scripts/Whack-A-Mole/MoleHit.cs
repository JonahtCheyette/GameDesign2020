using UnityEngine;

public class MoleHit : MonoBehaviour {
    public CubeHandler handler;
    public Camera _camera;
    public ManageHealth healthManager;

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            bool hitSomething = false;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            for (int i = 0; i < handler.cubeBounds.Length; i++) {
                if(handler.cubeBounds[i].IntersectRay(ray) && !hitSomething) {
                    for (int j = 0; j < 3; j++) {
                        if (j == 2) {
                            handler.cubes[i].transform.GetChild(j).gameObject.SetActive(true);
                        } else {
                            handler.cubes[i].transform.GetChild(j).gameObject.SetActive(false);
                        }
                    }
                    hitSomething = true;
                }
            }

            if (!hitSomething) {
                healthManager.LoseHealth();
            }
        }
    }
}
