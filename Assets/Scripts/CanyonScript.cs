using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CanyonScript : MonoBehaviour
{
    // Public Attributes
    public GameObject ammo;
    public float force;
    public List<Material> matList;

    // Private Components
    private GameObject spawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = GameObject.Find("Canyon_Spawn");
        Debug.Log(spawn.name);
    }

    // Method shoot ammo
    public void ShootAmmo()
    {
        // Instantiate prefab
        GameObject bullet = Instantiate(
            ammo,
            spawn.transform.position,
            spawn.transform.rotation
        );

        // Get Rigidbody
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Apply force to Rigidbody
            Vector3 bulletForce = spawn.transform.up * force;
            rb.AddForce(bulletForce, ForceMode.Impulse);
        }
    }

    // Method shoot ammo randomly
    public void ShootRandomly()
    {
        // Instantiate prefab
        GameObject bullet = Instantiate(
            ammo,
            spawn.transform.position,
            spawn.transform.rotation
        );

        // Apply random scale
        bullet.transform.localScale = new Vector3(
            UnityEngine.Random.Range(0.5f, 5.0f),
            UnityEngine.Random.Range(0.5f, 5.0f),
            UnityEngine.Random.Range(0.5f, 5.0f)
        );

        // If more than one available, apply random material
        if (matList.Count > 1)
        {
            int index = UnityEngine.Random.Range(0, matList.Count);
            bullet.GetComponent<Renderer>().material = matList[index];
        }
        else if (matList.Count > 0)
        {
            bullet.GetComponent<Renderer>().material = matList[0];
        }

        // Get Rigidbody
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Apply random force to Rigidbody
            Vector3 bulletForce = spawn.transform.up * UnityEngine.Random.Range(5.0f, 50.0f);
            rb.AddForce(bulletForce, ForceMode.Impulse);
        }
    }

}
