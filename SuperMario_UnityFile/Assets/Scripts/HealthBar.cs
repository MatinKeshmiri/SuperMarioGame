using UnityEngine;
using System.Collections;
public class HealthBar : MonoBehaviour
{
    //Reference to this transform component
    private RectTransform ThisTransform = null;
    //Catch up speed
    public float MaxSpeed;
    void Awake()
    {
        //Get transform component
        ThisTransform = GetComponent<RectTransform>();
    }
    void Start()
    {
        //Set Start Health
        
        ThisTransform.sizeDelta = new Vector2(Mathf.Clamp(PlayerController.Health, 0, 100), ThisTransform.sizeDelta.y);
    }
    // Update is called once per frame
    void Update()
    {
        //Update health property
        float HealthUpdate = 0f;
        HealthUpdate = Mathf.MoveTowards(ThisTransform.rect.width,PlayerController.Health, MaxSpeed);
        ThisTransform.sizeDelta = new Vector2(Mathf.Clamp(HealthUpdate, 0, 100), ThisTransform.sizeDelta.y);
    }
}