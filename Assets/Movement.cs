using System;
using UnityEngine;

namespace Movement

{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
       
        
        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
           

            Vector3 direction = new Vector3(horizontal, 0f, 0f);


            transform.Translate(direction * (moveSpeed * Time.deltaTime), Space.World);
        }
    }
        
}