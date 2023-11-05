using UnityEngine;

public class CinematicTrigger : MonoBehaviour
{
    
    [SerializeField] private GameObject cinematicCamera;
    [SerializeField] private GameObject cutscene;
    [SerializeField] private GameObject fpsController;
    
    private void OnTriggerEnter(Collider other)
    {
        fpsController.SetActive(false);
        cinematicCamera.SetActive(true);
        cutscene.SetActive(true);
    }
}
