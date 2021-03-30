using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicFunctions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        public int playerHealth = 2;

    public class ItemBehavior : MonoBehaviour
    {
        // 1
        void OnCollisionEnter(Collision collision)
        {
            // 2
            if (collision.gameObject.name == "single boat")
            {
                // 3
                Destroy(this.transform.parent.gameObject);
                // 4
                Debug.Log("You lost health");
                playerHealth = 1;
            }
        }
    }
}