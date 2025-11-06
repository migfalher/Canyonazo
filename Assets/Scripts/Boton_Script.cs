using UnityEngine;

public class Boton_Script : MonoBehaviour
{
    // Attributes
    private GameObject cannon;
    string btnColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        btnColor = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get click variables
            // -> 'hit' is a sentinel to detect if the ray has touched a collider
            // -> 'ray' is thrown from the camera core to the place where the mouse "would be" in the world
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // has the ray even touched any collider?
            if (Physics.Raycast(ray, out hit))
            {
                // if so:
                // get clicked object, and its parent's name and tag
                GameObject coll = hit.transform.gameObject;
                string parentName = coll.transform.parent.name;
                string parentTag = coll.transform.parent.tag;
                // has it a 'Boton' tag?
                if (parentTag == "Boton")
                {
                    // if so:
                    // push
                    coll.transform.Translate(0, -0.1f, 0);
                    // compare 'parentName'
                    switch (parentName)
                    {
                        case "Boton_Yellow":
                            btnColor = "Yellow";
                            break;
                        case "Boton_Red":
                            btnColor = "Red";
                            break;
                        case "Boton_Green":
                            btnColor = "Green";
                            Debug.Log("Green");
                            break;
                        default:
                            Debug.Log("No action intended for this button");
                            break;
                    }
                    // push back
                    coll.transform.Translate(0, 0.1f, 0);
                }
            }
        }
    }

    /**
    // Method to detect if screen mouse clicked over an object of game world
    void DetectWorldClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get click variables
            // -> 'hit' is a sentinel to detect if the ray has touched a collider
            // -> 'ray' is thrown from the camera core to the place where the mouse "would be" in the world
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // has the ray even touched any collider?
            if (Physics.Raycast(ray, out hit))
            {
                // if so:
                // get clicked object, and its parent's name and tag
                GameObject coll = hit.transform.gameObject;
                string parentName = coll.transform.parent.name;
                string parentTag = coll.transform.parent.tag;
                // has it a 'Boton' tag?
                if (parentTag == "Boton")
                {
                    // if so:
                    // push
                    coll.transform.Translate(0, -0.1f, 0);
                    // compare 'parentName'
                    switch (parentName)
                    {
                        case "Boton_White":
                            btnColor = "White";
                            break;
                        case "Boton_Red":
                            btnColor = "Red";
                            break;
                        case "Boton_Green":
                            btnColor = "Green";
                            break;
                        default:
                            Debug.Log("No action intended for this button");
                            break;
                    }
                    // push back
                    coll.transform.Translate(0, 0.1f, 0);
                }
            }
        }
    }
    */

    // Method


    // Method


    // Method

}
