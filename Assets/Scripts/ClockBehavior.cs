using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockBehavior : MonoBehaviour
{
    [Header("Clock Interface")]
    [SerializeField] private GameObject thisCanvasGO;
    [SerializeField] private Text hourText;
    [SerializeField] private Text minuteText;
    [SerializeField] private Text amPMText;
    [SerializeField] private Text labelText;
    private bool isAM = true;
    private int hour = 0;
    private int minute = 0;

    [Header("Confirm Alarm Interface")]
    [SerializeField] private GameObject confirmPopup;
    [SerializeField] private Text popupHeader;
    [SerializeField] private Text popupClock;
    private bool wakeAlarmSet = false;
    private bool sleepAlarmSet = false;

    // Start is called before the first frame update
    void Start(){
        ResetClock();
        //thisCanvasGO.SetActive(false);
    }

    private void OnEnable() {
        ResetClock();
    }

    public void IncreaseHour() {
        if (hour >= 12) {
            hour = 1;
        }
        else {
            hour++;
        }
        hourText.text = PrintTime(hour);
    }

    public void DecreaseHour() {
        if (hour <= 1){
            hour = 12;
        }
        else{
            hour--;
        }
        hourText.text = PrintTime(hour);
    }

    public void IncreaseMinute() { 
        if (minute >= 59) {
            minute = 0;
        }
        else {
            minute++;
        }
        minuteText.text = PrintTime(minute);
    }

    public void DecreaseMinute() { 
        if (minute <= 0) {
            minute = 59;
        }
        else {
            minute--;
        }

        minuteText.text = PrintTime(minute);
    }

    public void ToggleAMPM() {
        isAM = !isAM;
        if (isAM)
            amPMText.text = "AM";
        else
            amPMText.text = "PM";
    }

    public void ConfirmTime() {
        if (!wakeAlarmSet) {
            popupHeader.text = "Wake up at";
        }
        else {
            popupHeader.text = "Sleep at";
        }
        popupClock.text = PrintTime(hour) + " : " + PrintTime(minute) + " " + amPMText.text;
        confirmPopup.SetActive(true);
    }

    public void ReconfirmTime(bool confirmed) {
        if (confirmed) {
            if (!wakeAlarmSet) {
                wakeAlarmSet = true;
                labelText.text = "Sleep At...";
            }
            else if (!sleepAlarmSet) {
                sleepAlarmSet = true;
            }
        }
        confirmPopup.SetActive(false);
        // IF BOTH WAKE UP AND SLEEP ALARMS HAVE BEEN SET, CLEAN UP AND CLOSE OUT OF THE CLOCK INTERFACE ENTIRELY
        if (sleepAlarmSet && wakeAlarmSet) {
            ResetClock();
            thisCanvasGO.SetActive(false);
        }
    }

    private void ResetClock() {
        hour = 12;
        minute = 0;
        isAM = true;
        wakeAlarmSet = false;
        sleepAlarmSet = false;
        hourText.text = "1 2";
        minuteText.text = "0 0";
        amPMText.text = "AM";
        labelText.text = "Wake Up At...";
        confirmPopup.SetActive(false);
    }

    private string PrintTime(int time) {
        string timeStr = "";
        if (time < 10) 
            timeStr = "0 " + time.ToString();
        else 
            timeStr = (time / 10).ToString() + " " + (time % 10).ToString();
        
        return timeStr;
    }
}
