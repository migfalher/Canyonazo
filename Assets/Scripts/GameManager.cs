using NUnit.Framework;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Shared objects
    public GameObject canyon;
    public Canvas canvas;

    // Attributes
    private TMP_Text tmp;
    private int ballCounter;
    private CanyonScript canyonScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballCounter = 0;
        if (canyon != null) {canyonScript = canyon.GetComponent<CanyonScript>();}
        if (canvas != null) {
            tmp = canvas.GetComponentInChildren<TextMeshProUGUI>();
            Debug.Log(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DetectClick();
        }
    }

    // Detect mouse click
    private void DetectClick()
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
            // activate event of clicked object
            GameObject coll = hit.transform.gameObject;
            string name = coll.transform.name;
            switch (name)
            {
                case "Boton_Green":
                    OnGreenClicked();
                    break;
                case "Boton_Yellow":
                    OnYellowClicked();
                    break;
                case "Boton_Red":
                    OnRedClicked();
                    break;
                default:
                    Debug.Log("No event implemented for clicked object");
                    break;
            }
        }
    }

    // Event on green button clicked
    private void OnGreenClicked()
    {
        // shoot bullet
        canyonScript.ShootAmmo();
        // count shot bullet
        ballCounter++;
        tmp.text = "Balas: " + ballCounter.ToString();
    }

    // Event on yellow button clicked
    private void OnYellowClicked()
    {
        // shoot bullet
        canyonScript.ShootRandomly();
        // count shot bullet
        ballCounter++;
        tmp.text = "Balas: " + ballCounter.ToString();
    }

    // Event on red clicked
    private void OnRedClicked()
    {
        // erase bullets
        GameObject[] shotBullets = GameObject.FindGameObjectsWithTag("Bala");
        foreach (GameObject item in shotBullets) {Destroy(item);}
        // reboot counter
        ballCounter = 0;
        tmp.text = "Balas: 0";
    }
}
