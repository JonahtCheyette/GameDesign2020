using UnityEngine;

public class ManageHealth : MonoBehaviour {
    public static int numHealth = 3;

    public void LoseHealth() {
        numHealth--;

        for (int i = 0; i < numHealth; i++) {
            gameObject.transform.GetChild(i).GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
        }

        for (int i = numHealth; i < 3; i++) {
            gameObject.transform.GetChild(i).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }

        if(numHealth == 0) {
            //do something
        }
    }
}
