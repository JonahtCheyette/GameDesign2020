using UnityEngine;

public class CubeHandler : MonoBehaviour {
    [HideInInspector]
    public GameObject[] cubes;
    [HideInInspector]
    public Bounds[] cubeBounds;

    public int seed = 0;

    System.Random rand;

    void Start() {
        rand = new System.Random(seed);
        cubes = new GameObject[gameObject.transform.childCount];
        cubeBounds = new Bounds[gameObject.transform.childCount];
        for (int i = 0; i < gameObject.transform.childCount; i++) {
            cubes[i] = gameObject.transform.GetChild(i).gameObject;
            for(int j = 0; j < 3; j++) {
                if(j == 0) {
                    cubes[i].transform.GetChild(j).gameObject.SetActive(true);
                } else {
                    cubes[i].transform.GetChild(j).gameObject.SetActive(false);
                }
            }
            Vector3 boundSize = cubes[i].GetComponentInChildren<MeshFilter>().mesh.bounds.size;
            boundSize = Quaternion.AngleAxis(-90, Vector3.up) * boundSize;
            boundSize.x *= cubes[i].transform.localScale.x;
            boundSize.y *= cubes[i].transform.localScale.y;
            boundSize.z *= cubes[i].transform.localScale.z;
            cubeBounds[i] = new Bounds(cubes[i].transform.position, boundSize);
            if (rand.Next(0, 2) < 1) {
                for (int j = 0; j < 3; j++) {
                    if (j == 1) {
                        cubes[i].transform.GetChild(j).gameObject.SetActive(true);
                    } else {
                        cubes[i].transform.GetChild(j).gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < cubes.Length; i++) {
            cubeBounds[i].center = cubes[i].transform.position;
        }
    }
}
