using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjectScript : MonoBehaviour {

    public float moveSpeed;
    public float rotationSpeed;
    public CallingPrefabs cp;

    // Use this for initialization
    void Start () {
        moveSpeed = 2f;
        rotationSpeed = 30f;
        cp = FindObjectOfType(typeof(CallingPrefabs)) as CallingPrefabs;
    }
	
	// Update is called once per frame
	void Update () {

        if (gameObject.name.Equals(cp.objectIndex)) {     // if the btn was clicked on

            // move
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);

            // rotation
            if (Input.GetKey(KeyCode.R))    // right
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.L))    // left
                transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);

            // changing coordinates in text fields
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;

            cp.textFieldX.text = x.ToString();
            cp.textFieldY.text = y.ToString();
            cp.textFieldZ.text = z.ToString();

            float rx = gameObject.transform.rotation.eulerAngles.x;
            float ry = gameObject.transform.rotation.eulerAngles.y;
            float rz = gameObject.transform.rotation.eulerAngles.z;

            cp.textFieldRX.text = rx.ToString();
            cp.textFieldRY.text = ry.ToString();
            cp.textFieldRZ.text = rz.ToString();

            if (Input.GetKey(KeyCode.Delete)) {

                int index = cp.ls.list.IndexOf(gameObject);     // get index of object i want to remove
                cp.ls.list.Remove(gameObject);                  // remove game object from list
                cp.ls.objects.RemoveAt(index);                  // remove prefab from objects
                Destroy(gameObject);                            // destroy game object

                for (int i = 0; i < cp.buttons.Count; i++) {
                    GameObject button = cp.buttons[i];
                    if (button.name.Equals(gameObject.name)) {
                        cp.buttons.Remove(cp.buttons[i]);
                        Destroy(button);
                    }
                }
                cp.gap -= 18;

            }


        }     
    }
}
