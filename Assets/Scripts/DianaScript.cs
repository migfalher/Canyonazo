using UnityEngine;

public class DianaScript : MonoBehaviour
{
    // Public components
    public Material newMaterial;

    // Private attributes
    private int count;
    private bool rotate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
        rotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate) { this.transform.Rotate(0, 0, 1); }
    }

    // Method detect collision
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Bala")
        {
            count++;
            switch (count)
            {
                case 1:
                    if (newMaterial != null)
                    {
                        this.GetComponent<Renderer>().material.color = newMaterial.color;
                    }
                    else
                    {
                        this.GetComponent<Renderer>().material.color = Color.indianRed;
                    }
                    break;
                case 2:
                    rotate = true;
                    break;
                case 3:
                    this.gameObject.SetActive(false);
                    break;
                default:
                    break;
            }
        }
    }


}
