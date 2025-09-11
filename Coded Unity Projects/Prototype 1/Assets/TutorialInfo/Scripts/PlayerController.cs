using UnityEngine;
//Coder: Adi Sutton
//Date: 9/11/2025
//Description: This script will control the player vehicle

public class PlayerControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
