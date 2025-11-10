using UnityEngine;

public class DianaScript : MonoBehaviour
{
    // Private attributes
    private int count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method 
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Bala")
        {
            count++;
            switch (count)
            {
                case 1:
                    Material newMat = Resources.Load<Material>("Material/Yellow");
                    this.GetComponent<Renderer>().material = newMat;
                    break;
                case 2:
                    this.gameObject.SetActive(false);
                    break;
                default:
                    break;
            }
        }

    }
}
