using System;

public class BreathingActivity : Activity {

  //Here's the constructor
  public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {
  }

public void RunBreathingActivity() {
  BeginActivity();
  while (DateTime.Now < _endTime) {
    Countdown();
  }
  EndActivity();
}

}