using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D()
    {
        BaseEventData eventData = new(EventSystem.current);
        scoreTrigger.Invoke(eventData);
    }
}