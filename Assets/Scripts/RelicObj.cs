using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RelicObj : MonoBehaviour, IPointerClickHandler
{
    public Text nameText;
    public Text descText;

    public Relic relic = null;

    public void SetRelic(Relic relic)
    {
        this.relic = relic;
        //Debug.Log("≤‚ ‘1£∫" + GameManager.Instance.RelicLib.ContainsRelic(this.relic));
        nameText.text = relic.relicInfo.Name;
        descText.text = relic.relicInfo.Description;
        //Debug.Log(nameText.text);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("≤‚ ‘2£∫" + GameManager.Instance.RelicLib.ContainsRelic(relic));
        SelectRelic selectRelic = GetComponentInParent<SelectRelic>();
        selectRelic.OnChooseRelic(relic);
    }
}