using UnityEngine;

public class RotationController : MonoBehaviour
{
   public Vector3 rotationVector;

   private void Update()
   {
       transform.Rotate(rotationVector * Time.deltaTime);
   }
}
